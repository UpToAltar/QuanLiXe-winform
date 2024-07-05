using DevExpress.XtraEditors;
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
    public partial class AddVehiclesForm : DevExpress.XtraEditors.XtraForm
    {
        private VehiclesForm _vehiclesForm;
        public AddVehiclesForm(VehiclesForm vehiclesForm)
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

        private void btnAddVehiclesConfirm_Click(object sender, EventArgs e)
        {
            var list = new List<TextBox>
            {
                tbVehiclesColor,tbVehiclesEngineDisplacement,tbVehiclesEngineType,tbVehiclesFuelType,tbVehiclesLiscensePlate,tbVehiclesName

            };
            if (!ValidateHelper.Instance.ValidateEmptyTextBox(list))
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
            else if (VehiclesServices.Instance.CheckPlate(tbVehiclesLiscensePlate.Text))
            {
                //Check name exist
                MessageBox.Show("Biển số xe đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Create
                
                if (VehiclesServices.Instance.CreateVehicles(tbVehiclesColor, tbVehiclesEngineDisplacement, tbVehiclesEngineType, tbVehiclesFuelType, tbVehiclesLiscensePlate, tbVehiclesName, tbVehiclesAcceleration,tbVehiclesWeigth,tbVehicleTopSpeed,tbVehiclesManufactures,tbVehiclesOwner))
                {
                    MessageBox.Show("Thêm mới xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    _vehiclesForm.LoadData();
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