using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QuanLiXe.DTO;
using QuanLiXe.Helper;
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
    public partial class frmUpdateVehicles : DevExpress.XtraEditors.XtraForm
    {
        private frmVehicles _vehiclesForm;
        private GridView _dataGridView;
        public frmUpdateVehicles(frmVehicles vehiclesForm, GridView dataGridView)
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
            if(tbVehiclesId.Text == "")
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

        private void btnUpdateVehiclesConfirm_Click(object sender, EventArgs e)
        {
            string msgError = "";
            var list = new List<TextBox>
            {
                tbVehiclesColor,tbVehiclesEngineDisplacement,tbVehiclesEngineType,tbVehiclesFuelType,tbVehiclesLiscensePlate,tbVehiclesName,
                tbVehiclesId
            };
            if (ValidateHelper.Instance.IsEmptyTextBox(list))
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidateHelper.Instance.IsValidMaxLengthTextBox(list, 100))
            {
                //Check max length
                MessageBox.Show("Các trường nhập tối đa 100 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidateHelper.Instance.IsValidMinMax(nudVehiclesWeigth.Value, 0, 1000000))
            {
                //Check max length
                MessageBox.Show("Cân nặng cần lớn hơn 0 và bé hơn 1000000 kg", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidateHelper.Instance.IsValidMinMax(nudVehicleTopSpeed.Value, 0, 1000))
            {
                //Check max length
                MessageBox.Show("Tốc độ tối đa cần lớn hơn 0 và bé hơn 1000 km/h", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidateHelper.Instance.IsValidMinMax(nudVehiclesAcceleration.Value, 0, 1000))
            {
                //Check max length
                MessageBox.Show("Tăng tốc cần lớn hơn 0 và bé hơn 1000 km/h", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!VehiclesServices.Instance.IsVehiclesExistedCheckById(out msgError, tbVehiclesId.Text))
            {
                //Check plate exist
                MessageBox.Show($"Không tìm thấy xe có ID = {tbVehiclesId.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (VehiclesServices.Instance.IsOtherPlateExisted(out msgError, tbVehiclesLiscensePlate.Text, tbVehiclesId.Text))
            {
                //Check plate exist
                MessageBox.Show("Biển số xe đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Create

                if (VehiclesServices.Instance.UpdateVehicles(out msgError, tbVehiclesColor, tbVehiclesEngineDisplacement, tbVehiclesEngineType, tbVehiclesFuelType, tbVehiclesLiscensePlate, tbVehiclesName, nudVehiclesAcceleration, nudVehiclesWeigth, nudVehicleTopSpeed, cboVehiclesManufactures, cboVehiclesOwner, tbVehiclesId, RecentUser.ID))
                {
                    MessageBox.Show("Cập nhật xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    _vehiclesForm.LoadData(0, DateTime.Now, DateTime.Now);
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Cập nhật xe thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}