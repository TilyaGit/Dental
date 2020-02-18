using Dental.Core;
using JetBrains.Annotations;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace Dental.Win
{
    public partial class ServiceForm : Form
    {
        ServiceCategory _sc;
        
        public ServiceForm([CanBeNull]ServiceCategory sc)
        {
             _sc = sc;
            InitializeComponent();

            using (var context = new DentalContext())
            {
                //_objectListViewService.SetObjects(context.ServiceCategories);

            }
            InitService();
        }
        public void InitService()
        {
            _btnSaveService.Click += (sender, args) =>
            {
                if (string.IsNullOrEmpty(_txtNameService.Text) || string.IsNullOrEmpty(_txtDesscribe.Text))
                {
                    MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                try
                {
                    using (var context = new DentalContext())
                    {
                        var selectService = new ServiceCategory(_txtNameService.Text, _txtDesscribe.Text);
                        context.ServiceCategories.Add(selectService);
                        context.SaveChanges();
                        _objectListViewService.SetObjects(context.ServiceCategories);
                        ResetServiceControls();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка", ex.Message);
                }
            };

            _btnUpdateService.Click += (sender, args) =>
            {
                try
                {
                    using (var contex = new DentalContext())
                    {
                        var updateService = _objectListViewService.SelectedObject as ServiceCategory;
                        if (updateService == null)
                        {
                            MessageBox.Show("Укажите услугу для редактирования", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        updateService.Name = _txtNameService.Text;
                        updateService.Desscribe = _txtDesscribe.Text;
                        contex.ServiceCategories.AddOrUpdate(updateService);
                        contex.SaveChanges();
                        _objectListViewService.SetObjects(contex.ServiceCategories);
                        ResetServiceControls();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка", ex.Message);
                }
            };

            _btnDeleteService.Click += (sender, args) =>
            {


                using (var context = new DentalContext())
                {
                    var selectService = _objectListViewService.SelectedObject as ServiceCategory;
                    var deletedDoctore = context.Patients.First(d => d.Id == selectService.Id);
                    if (selectService == null)
                    {
                        MessageBox.Show("Укажите услугу", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    context.ServiceCategories.Remove(selectService);

                    context.SaveChanges();

                    _objectListViewService.SetObjects(context.ServiceCategories);

                    ResetServiceControls();
                }

                Close();
            };

            _objectListViewService.SelectedIndexChanged += (sender, args) =>
            {
                var selectedService = _objectListViewService.SelectedObject as ServiceCategory;
                if (selectedService == null) return;
                _txtNameService.Text = selectedService.Name;
                _txtDesscribe.Text = selectedService.Desscribe;

            };

        }
        private void ResetServiceControls()
        {
            _txtNameService.Text = "";
            _txtDesscribe.Text = "";
        }
    }
}
