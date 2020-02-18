using Dental.Core;
using JetBrains.Annotations;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace Dental.Win
{
    public partial class DoctorForm : Form
    {
        Doctor _doctor;

        public DoctorForm([CanBeNull] Doctor doctor)
        {
            _doctor = doctor;
            InitializeComponent();
             using (var context = new DentalContext())
            {
                _objectListViewDoctore.SetObjects(context.Doctors);

            }
            InitDoctor();
        }

        public void InitDoctor()
        {

            _btnSaveDoctor.Click += (sender, args) =>
            {
                if (string.IsNullOrEmpty(_txtFirstName.Text)
                    || string.IsNullOrEmpty(_txtSecondName.Text)
                    || string.IsNullOrEmpty(_txtThirdName.Text)
                    || string.IsNullOrEmpty(_txtPhone.Text))
                {
                    MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (_dtpBirthDay.Value > new DateTime(2008, 1, 1))
                {
                    MessageBox.Show("Неправильно указан день рождения", "Внимание", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    using (var context = new DentalContext())
                    {
                        var selectDoctore = new Doctor(_txtFirstName.Text, _txtSecondName.Text, _txtThirdName.Text, _txtPhone.Text, _dtpBirthDay.Value);
                        context.Doctors.AddOrUpdate(selectDoctore);
                        context.SaveChanges();
                        _objectListViewDoctore.SetObjects(context.Doctors);
                        ResetDoctorControls();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка", ex.Message);
                }
            };
            _btnUpdateDoctore.Click += (sender, args) =>
            {
                try
                {
                    using (var contex = new DentalContext())
                    {
                        var updateDoctore = _objectListViewDoctore.SelectedObject as Doctor;
                        if (updateDoctore == null)
                        {
                            MessageBox.Show("Укажите доктора для редактирования", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        updateDoctore.FirstName = _txtFirstName.Text;
                        updateDoctore.SecondName = _txtSecondName.Text;
                        updateDoctore.ThirdName = _txtThirdName.Text;
                        updateDoctore.PhoneNumber = _txtPhone.Text;
                        updateDoctore.BirthDay = _dtpBirthDay.Value;
                        contex.Doctors.AddOrUpdate(updateDoctore);
                        contex.SaveChanges();
                        _objectListViewDoctore.SetObjects(contex.Doctors);
                        ResetDoctorControls();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка", ex.Message);
                }
            };

            _btnDeleteDoctore.Click += (sender, args) =>
            {
                

                using (var dentalContext = new DentalContext())
                {
                    var selectDoctore = _objectListViewDoctore.SelectedObject as Doctor;
                    var deletedDoctore = dentalContext.Patients.Include("MedicationHistories").First(d => d.Id == selectDoctore.Id);
                    if (selectDoctore == null)
                    {
                        MessageBox.Show("Укажите доктора", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    dentalContext.Doctors.Remove(selectDoctore);

                    dentalContext.SaveChanges();

                    _objectListViewDoctore.SetObjects(dentalContext.Doctors);

                    ResetDoctorControls();
                }

                Close();
            };

            _objectListViewDoctore.SelectedIndexChanged += (sender, args) =>
            {
                var selectedPatient = _objectListViewDoctore.SelectedObject as Doctor;
                if (selectedPatient == null) return;
                _txtFirstName.Text = selectedPatient.FirstName;
                _txtSecondName.Text = selectedPatient.SecondName;
                _txtThirdName.Text = selectedPatient.ThirdName;
                _txtPhone.Text = selectedPatient.PhoneNumber;
                _dtpBirthDay.Value = selectedPatient.BirthDay;

            };

        }
        private void ResetDoctorControls()
        {
            _txtFirstName.Text = "";
            _txtSecondName.Text = "";
            _txtThirdName.Text = "";
            _txtPhone.Text = "";
            _dtpBirthDay.Value = DateTime.Now;
        }
    }
}
