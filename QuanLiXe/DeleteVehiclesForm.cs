using DevExpress.XtraEditors;
using QuanLiXe.DTO;
using QuanLiXe.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiXe
{
    public partial class DeleteVehiclesForm : DevExpress.XtraEditors.XtraForm
    {
        private VehiclesForm _vehiclesForm;
        public DeleteVehiclesForm (VehiclesForm vehiclesForm)
        {
            InitializeComponent();
            LoadData();
            _vehiclesForm = vehiclesForm;
        }
        void LoadData()
        {
            //Load manufactures
            var dataManufactures = VehiclesServices.Instance.LoadManufactures();

            if (tbVehiclesManufactures.Items.Count == 0)
            {
                foreach (var item in dataManufactures)
                {
                    tbVehiclesManufactures.Items.Add(item);

                }
                tbVehiclesManufactures.SelectedIndex = 0;
                tbVehiclesManufactures.DisplayMember = "Name";
            }

            //Load Owner
            var dataOwner = VehiclesServices.Instance.LoadOwners();
            if (tbVehiclesOwner.Items.Count == 0)
            {
                foreach (var item in dataOwner)
                {
                    tbVehiclesOwner.Items.Add(item);
                }
                tbVehiclesOwner.SelectedIndex = 0;
                tbVehiclesOwner.DisplayMember = "FullName";
            }
        }
        private void btnSearchVehiclesToUpdate_Click(object sender, EventArgs e)
        {
            if (tbVehiclesId.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var data = VehiclesServices.Instance.SearchById(tbVehiclesId.Text);
                if (data != null)
                {
                    tbVehiclesName.Text = data.Name;
                    tbVehiclesColor.Text = data.Color;
                    tbVehiclesId.Text = data.ID.ToString();
                    tbVehiclesEngineDisplacement.Text = data.EngineDisplacement;
                    tbVehiclesEngineType.Text = data.EngineType;
                    tbVehiclesFuelType.Text = data.FuelType;
                    tbVehiclesLiscensePlate.Text = data.LiscensePlate;
                    tbVehiclesManufactures.SelectedItem = tbVehiclesManufactures.Items
                                                            .Cast<ManufacturesDTO>()
                                                            .FirstOrDefault(item => item.ID == data.Manufacture.ID); ;
                    tbVehiclesOwner.SelectedItem = tbVehiclesOwner.Items
                                                            .Cast<OwnerDTO>()
                                                            .FirstOrDefault(item => item.ID == data.Owner.ID);
                    tbVehicleTopSpeed.Value = (decimal)data.TopSpeed;
                    tbVehiclesWeigth.Value = (decimal)data.Weigth;
                    tbVehiclesAcceleration.Value = (decimal)data.Acceleration;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDeleteVehiclesConfirm_Click(object sender, EventArgs e)
        {
            if (tbVehiclesId.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ID xe cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (VehiclesServices.Instance.DeleteVehicles(tbVehiclesId.Text))
                {
                    MessageBox.Show("Xóa xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _vehiclesForm.LoadData();
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Xóa xe thất bại hoặc không tìm thấy xe có ID = {tbVehiclesId.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}