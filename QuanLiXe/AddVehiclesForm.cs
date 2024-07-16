using DevExpress.XtraEditors;
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
    public partial class frmAddVehicles : DevExpress.XtraEditors.XtraForm
    {
        private frmVehicles _vehiclesForm;
        public frmAddVehicles(frmVehicles vehiclesForm)
        {
            InitializeComponent();
            
            _vehiclesForm = vehiclesForm;
            LoadData();
        }

        void LoadData()
        {
            //Load manufactures
            string msgError = "";
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
        }

        private void btnAddVehiclesConfirm_Click(object sender, EventArgs e)
        {
            string msgError = "";
            var list = new List<TextBox>
            {
                tbVehiclesColor,tbVehiclesEngineDisplacement,tbVehiclesEngineType,tbVehiclesFuelType,tbVehiclesLiscensePlate,tbVehiclesName

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
            else if (!ValidateHelper.Instance.IsValidMinMax(nudVehiclesWeigth.Value,0,1000000))
            {
                //Check max length
                MessageBox.Show("Cân nặng cần nằm trong khoảng 0 đến 1000000 kg", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidateHelper.Instance.IsValidMinMax(nudVehicleTopSpeed.Value, 0, 1000))
            {
                //Check max length
                MessageBox.Show("Tốc độ tối đa cần nằm trong khoảng 0 đến 1000 km/h", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidateHelper.Instance.IsValidMinMax(nudVehiclesAcceleration.Value, 0, 1000))
            {
                //Check max length
                MessageBox.Show("Tăng tốc cần nằm trong khoảng 0 đến 1000 km/h", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (VehiclesServices.Instance.IsPlateExisted(out msgError, tbVehiclesLiscensePlate.Text))
            {
                //Check name exist
                MessageBox.Show("Biển số xe đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Create
                
                if (VehiclesServices.Instance.CreateVehicles( out msgError,tbVehiclesColor, tbVehiclesEngineDisplacement, tbVehiclesEngineType, tbVehiclesFuelType, tbVehiclesLiscensePlate, tbVehiclesName, nudVehiclesAcceleration,nudVehiclesWeigth,nudVehicleTopSpeed,cboVehiclesManufactures,cboVehiclesOwner,RecentUser.ID))
                {
                    MessageBox.Show("Thêm mới xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    _vehiclesForm.LoadData(0,DateTime.Now,DateTime.Now);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm mới xe thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}