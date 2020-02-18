using Dental.Core;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Dental.Win
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            using (var context = new DentalContext())
            {
                _listOfPations.SetObjects(context.Patients);

                _txtPatientSearch.TextChanged += (sender, args) =>
                {
                    try
                    {
                        using (var contextPatientSearch = new DentalContext())
                        {
                            if (string.IsNullOrEmpty(_txtPatientSearch.Text))
                            {
                                _listOfPations.SetObjects(contextPatientSearch.Patients);

                                return;
                            }
                            var patients = contextPatientSearch.Patients.Where(d => d.FirstName.ToLower().StartsWith(_txtPatientSearch.Text.ToLower())
                                                || d.SecondName.ToLower().StartsWith(_txtPatientSearch.Text.ToLower()))
                                    .Take(100);
                            _listOfPations.SetObjects(patients);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                };

                _btnAddPatient.Click += (sender, args) =>
                {
                    var formPatients = new PatientForm(null);

                    formPatients.ShowDialog();

                    try
                    {
                        using (var context1 = new DentalContext())
                        {
                            _listOfPations.SetObjects(context1.Patients.OrderByDescending(d => d.Id).Take(100));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                };
            }

            _listOfPations.DoubleClick += (sender, args) =>
            {
                var selectedPatient = _listOfPations.SelectedObject as Patient;

                try
                {
                    using (var context = new DentalContext())
                    {
                        selectedPatient = context.Patients.Include("MedicationHistories").First(f => f.Id == selectedPatient.Id);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }

                var formPatient = new PatientForm(selectedPatient);

                formPatient.ShowDialog();

                using (var context = new DentalContext())
                {
                    _listOfPations.SetObjects(context.Patients.OrderByDescending(d => d.Id).Take(100));
                }
            };
        }

        private void добавитьToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var formPatients = new PatientForm(null);

            formPatients.ShowDialog();

            try
            {
                using (var context = new DentalContext())
                {
                    _listOfPations.SetObjects(context.Patients.OrderByDescending(d => d.Id).Take(100));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void добавитьToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            var doctorForm = new DoctorForm(null);
            doctorForm.Show();

        }

        private void добавитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var serviceForm = new ServiceForm(null);
            serviceForm.Show();
        }
    }
}