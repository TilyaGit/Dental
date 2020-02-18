using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Dental.Core;
using JetBrains.Annotations;
using System.IO;
using System.Drawing;
using System.Collections.Generic;

namespace Dental.Win
{
    public partial class PatientForm : Form
    {
        Patient _selectedPatient = null;

        public PatientForm([CanBeNull] Patient selectedPatient)
        {
            InitializeComponent();

            _selectedPatient = selectedPatient;
            using (var context = new DentalContext())
            {
                _listOfPations.SetObjects(context.Patients);

            }

            InitPatientPage();
            InitMedicationPage();
        }

        private void InitPatientPage()
        {
            if (_selectedPatient != null)
            {
                _txtFirstName.Text = _selectedPatient.FirstName;
                _txtSecondName.Text = _selectedPatient.SecondName;
                _txtThirdName.Text = _selectedPatient.ThirdName;
                _txtPhone.Text = _selectedPatient.PhoneNumber;
                _dtpBirthDay.Value = _selectedPatient.BirthDay;
            }

            _btnSave.Click += (sender, args) =>
            {
                if (string.IsNullOrEmpty(_txtFirstName.Text)
                    || string.IsNullOrEmpty(_txtSecondName.Text) 
                    || string.IsNullOrEmpty(_txtThirdName.Text)
                    || string.IsNullOrEmpty(_txtPhone.Text))
                {
                    MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (_dtpBirthDay.Value > new DateTime(2020, 1, 1))
                {
                    MessageBox.Show("Неправильно указан день рождения", "Внимание", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                using (var context = new DentalContext())
                {
                    _selectedPatient?.With(_txtFirstName.Text, _txtSecondName.Text, _txtThirdName.Text, _txtPhone.Text, _dtpBirthDay.Value);

                    _selectedPatient = _selectedPatient ?? new Patient(_txtFirstName.Text, _txtSecondName.Text,_txtThirdName.Text,
                                           _txtPhone.Text, _dtpBirthDay.Value);

                    context.Patients.Add(_selectedPatient);

                    context.SaveChanges();

                    _listOfPations.SetObjects(context.Patients);

                    ResetPatientControls();
                }
            };
            _btnUpdate.Click += (sender, args) =>
            {
                try
                {
                    using (var contex = new DentalContext())
                    {
                        var updatePatien = _listOfPations.SelectedObject as Patient;
                        if (updatePatien == null)
                        {
                            MessageBox.Show("Укажите пациента для редактирования", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        updatePatien.FirstName = _txtFirstName.Text;
                        updatePatien.SecondName = _txtSecondName.Text;
                        updatePatien.ThirdName = _txtThirdName.Text;
                        updatePatien.PhoneNumber = _txtPhone.Text;
                        updatePatien.BirthDay = _dtpBirthDay.Value;
                        contex.Patients.AddOrUpdate(updatePatien);
                        contex.SaveChanges();
                        _listOfPations.SetObjects(contex.Patients);
                        ResetPatientControls();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка", ex.Message);
                }
            };

            _btnDelete.Click += (sender, args) =>
            {
                if (_selectedPatient == null)
                {
                    MessageBox.Show("Укажите пациента", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (var dentalContext = new DentalContext())
                {
                    var deletedPatient = dentalContext.Patients.Include("MedicationHistories").First(d => d.Id == _selectedPatient.Id);

                    if (deletedPatient.MedicationHistories.Count != 0)
                        MessageBox.Show(" У пациента есть лечение", "Перейдите в лечение пациента",
                            MessageBoxButtons.OK,MessageBoxIcon.Information);

                    if (deletedPatient.MedicationHistories.Any()
                        || MessageBox.Show(
                            $"Удалить пациента '{_selectedPatient.FirstName} {_selectedPatient.SecondName}' ?",
                            "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes
                    )
                    {
                        return;
                    }                    

                    dentalContext.Patients.Remove(deletedPatient);

                    dentalContext.SaveChanges();

                    ResetPatientControls();
                }

                Close();
            };

            _listOfPations.SelectedIndexChanged += (sender, args) =>
            {
                var selectedPatient = _listOfPations.SelectedObject as Patient;
                if (selectedPatient == null) return;
                _txtFirstName.Text = selectedPatient.FirstName;
                _txtSecondName.Text = selectedPatient.SecondName;
                _txtThirdName.Text = selectedPatient.ThirdName;
                _txtPhone.Text = selectedPatient.PhoneNumber;
                _dtpBirthDay.Value = selectedPatient.BirthDay;

            };
        }
        private void InitMedicationPage()
        {
            _olvColumnDiagnosis.AspectToStringConverter = (ob) =>
            {
                var diagnosis = (Diagnosis)ob;
                return diagnosis.GetDesc();
            };

            if (_selectedPatient != null)
                _listOfMedications.SetObjects(_selectedPatient.MedicationHistories);

            _comboDiagnostics.DataSource = typeof(Diagnosis).ToList();
            _comboDiagnostics.DisplayMember = "value";
            _comboDiagnostics.ValueMember = "key";

            using (var db = new DentalContext())
            {
                _comboBoxDoctor.DataSource = db.Doctors.ToList();
                _comboDiagnostics.DisplayMember = "value";
                _comboDiagnostics.ValueMember = "key";

                _comboServce.DataSource = db.ServiceCategories.ToList();
                _comboDiagnostics.DisplayMember = "value";
                _comboDiagnostics.ValueMember = "key";
            }

            _btnSaveMedication.Click += (sender, args) =>
            {
                if (_selectedPatient == null) return;

                if (string.IsNullOrEmpty(_txtPlan.Text))
                {
                    MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var plan = _txtPlan.Text;
                var diagnosis = (Diagnosis) ((KeyValuePair<int, string>) (_comboDiagnostics.SelectedItem)).Key;
                var medication = new Medication(plan, diagnosis);
                
                if (_pictureboxImage.Image != null)
                {
                    var imageName = Path.GetFileName(_pictureboxImage.ImageLocation);

                    var image = ImageToByteArray(_pictureboxImage.Image);

                    medication.AddImage(imageName, image);
                }

                using (var context = new DentalContext())
                {
                    context.Patients.AddOrUpdate(_selectedPatient);
                    var patient = context.Patients.Include("MedicationHistories").First(f => f.Id == _selectedPatient.Id);
                    patient.AddSick(medication);
                    context.SaveChanges();
                    _listOfMedications.SetObjects(patient.MedicationHistories);
                }

                ResetMedicationControls();
            };

           _btnDeleteMedication.Click += (sender, args) =>
            {
                using (var context = new DentalContext())
                {
                    var deletedMedication = _listOfMedications.SelectedObject as Medication;
                    if (deletedMedication == null) return;
                    if (MessageBox.Show($"Удалить лечения '{deletedMedication.Diagnosis.GetDesc()}' ?",
                            "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }

                    _selectedPatient = context.Patients.Include("MedicationHistories")
                        .First(q => q.Id == _selectedPatient.Id); 

                    _selectedPatient.DeleteSick(deletedMedication.Id);
                    context.SaveChanges();
                    _listOfMedications.SetObjects(_selectedPatient.MedicationHistories);
                }
            };

            _btnUpdateMedication.Click += (sender, args) =>
            {
                try
                {
                    using (var context = new DentalContext())
                    {
                        var updateMedication = _listOfMedications.SelectedObject as Medication;
                        if (updateMedication == null)
                        {
                            MessageBox.Show("Укажите лечения для редактирования", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        updateMedication.Plan = _txtPlan.Text;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка", ex.Message);
                }
            };

            _listOfMedications.SelectedIndexChanged += (sender, args) =>
            {
                Medication selectedMedication = _listOfMedications.SelectedObject as Medication;
                if (selectedMedication == null) return;

                _comboDiagnostics.SelectedIndex = (int)selectedMedication.Diagnosis - 1;
                _txtPlan.Text = selectedMedication.Plan;

                var image = selectedMedication.Images.FirstOrDefault()?.Image;
                _pictureboxImage.Image = ConvertToImage(image);

            };

            _btnLoadSnapshot.Click += (sender, args) =>
            {
                using (var dialog = new OpenFileDialog())
                {
                    dialog.Title = "Open Image";
                    dialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        _pictureboxImage.Load(dialog.FileName);
                    }
                }
            };
            //_listOfMedications.SmallImageList = new ImageList();
            //_listOfMedications.LargeImageList = new ImageList();
            ////_olvColumnImage.ImageGetter += rowObject =>
            ////{
            ////    var item = rowObject as Medication;
            ////    var image = item?.Fir
            ////};
        }
        
        private void ResetPatientControls()
        {
            _txtFirstName.Text = "";
            _txtSecondName.Text = "";
            _txtThirdName.Text = "";
            _txtPhone.Text = "";
            _dtpBirthDay.Value = DateTime.Now;
        }
        private void ResetMedicationControls()
        {
            _comboDiagnostics.SelectedIndex = 0;
            _txtPlan.Text = "";
            _pictureboxImage.Image = null;
           // _comboBoxDoctor.SelectedIndex = 0;
        }

        public byte[] ImageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private Image ConvertToImage(byte[] bytesImage)
        {
            if (bytesImage == null) return null;
            using (var ms = new MemoryStream(bytesImage))
            {
                return Image.FromStream(ms);
            }
        }
        
    }
}