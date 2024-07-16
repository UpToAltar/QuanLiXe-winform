using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmDeleteVehicles : DevExpress.XtraEditors.XtraForm
    {
        private frmVehicles _vehiclesForm;
        private GridView _dataGridView;
        public frmDeleteVehicles (frmVehicles vehiclesForm, GridView dataGridView)
        {
            InitializeComponent();
            
            _vehiclesForm = vehiclesForm;
            _dataGridView = dataGridView;
            LoadData();
        }
        void LoadData()
        {
            string msgError = "";
            //Load manufactures
            var dataManufactures = VehiclesServices.Instance.LoadManufactures(out msgError);

            if (cboVehiclesManufactures.Items.Count == 0)
            {
                foreach (var item in dataManufactures)
                {
                    cboVehiclesManufactures.Items.Add(item);

                }
                cboVehiclesManufactures.SelectedIndex = 0;
                cboVehiclesManufactures.DisplayMember = "Name";
            }

            //Load Owner
            var dataOwner = VehiclesServices.Instance.LoadOwners(out msgError);
            if (cboVehiclesOwner.Items.Count == 0)
            {
                foreach (var item in dataOwner)
                {
                    cboVehiclesOwner.Items.Add(item);
                }
                cboVehiclesOwner.SelectedIndex = 0;
                cboVehiclesOwner.DisplayMember = "FullName";
            }

            //Load data
            tbVehiclesId.Text = _dataGridView.GetFocusedRowCellValue("ID").ToString();
            tbVehiclesName.Text = _dataGridView.GetFocusedRowCellValue("Name").ToString();
            tbVehiclesColor.Text = _dataGridView.GetFocusedRowCellValue("Color").ToString();
            tbVehiclesLiscensePlate.Text = _dataGridView.GetFocusedRowCellValue("LiscensePlate").ToString();
            tbVehiclesEngineDisplacement.Text = _dataGridView.GetFocusedRowCellValue("EngineDisplacement").ToString();
            tbVehiclesEngineType.Text = _dataGridView.GetFocusedRowCellValue("EngineType").ToString();
            tbVehiclesFuelType.Text = _dataGridView.GetFocusedRowCellValue("FuelType").ToString();
            cboVehiclesManufactures.SelectedItem = cboVehiclesManufactures.Items
                                                    .Cast<ManufacturesDTO>()
                                                    .FirstOrDefault(item => item.Name == _dataGridView.GetFocusedRowCellValue("Manufacture").ToString());
            cboVehiclesOwner.SelectedItem = cboVehiclesOwner.Items
                .Cast<OwnerDTO>()
                .FirstOrDefault(item => item.FullName == _dataGridView.GetFocusedRowCellValue("OwnerName").ToString());
            nudVehicleTopSpeed.Value = (decimal)float.Parse(_dataGridView.GetFocusedRowCellValue("TopSpeed").ToString());
            nudVehiclesWeigth.Value = (decimal)float.Parse(_dataGridView.GetFocusedRowCellValue("Weigth").ToString());
            nudVehiclesAcceleration.Value = (decimal)float.Parse(_dataGridView.GetFocusedRowCellValue("Acceleration").ToString());
        }
        private void btnSearchVehiclesToUpdate_Click(object sender, EventArgs e)
        {
            string msgError = "";
            if (tbVehiclesId.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var data = VehiclesServices.Instance.SearchById(out msgError, tbVehiclesId.Text);
                if (data != null)
                {
                    tbVehiclesName.Text = data.Name;
                    tbVehiclesColor.Text = data.Color;
                    tbVehiclesId.Text = data.ID.ToString();
                    tbVehiclesEngineDisplacement.Text = data.EngineDisplacement;
                    tbVehiclesEngineType.Text = data.EngineType;
                    tbVehiclesFuelType.Text = data.FuelType;
                    tbVehiclesLiscensePlate.Text = data.LiscensePlate;
                    cboVehiclesManufactures.SelectedItem = cboVehiclesManufactures.Items
                                                            .Cast<ManufacturesDTO>()
                                                            .FirstOrDefault(item => item.ID == data.Manufacture.ID); ;
                    cboVehiclesOwner.SelectedItem = cboVehiclesOwner.Items
                                                            .Cast<OwnerDTO>()
                                                            .FirstOrDefault(item => item.ID == data.Owner.ID);
                    nudVehicleTopSpeed.Value = (decimal)data.TopSpeed;
                    nudVehiclesWeigth.Value = (decimal)data.Weigth;
                    nudVehiclesAcceleration.Value = (decimal)data.Acceleration;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDeleteVehiclesConfirm_Click(object sender, EventArgs e)
        {
            string msgError = "";
            if (tbVehiclesId.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ID xe cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Show dialog
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa xe này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Delete
                    if (VehiclesServices.Instance.DeleteVehicles(out msgError, tbVehiclesId.Text, RecentUser.ID))
                    {
                        MessageBox.Show("Xóa xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _vehiclesForm.LoadData(0, DateTime.Now, DateTime.Now);
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
}