namespace QuanLiXe
{
    partial class frmDeleteVehicles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteVehicles));
            this.btnSearchVehiclesToUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.tbVehiclesId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nudVehiclesAcceleration = new System.Windows.Forms.NumericUpDown();
            this.nudVehicleTopSpeed = new System.Windows.Forms.NumericUpDown();
            this.nudVehiclesWeigth = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteVehiclesConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.label12 = new System.Windows.Forms.Label();
            this.cboVehiclesManufactures = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboVehiclesOwner = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbVehiclesEngineDisplacement = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbVehiclesFuelType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVehiclesColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbVehiclesEngineType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVehiclesLiscensePlate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVehiclesName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehiclesAcceleration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleTopSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehiclesWeigth)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchVehiclesToUpdate
            // 
            this.btnSearchVehiclesToUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchVehiclesToUpdate.Appearance.Options.UseFont = true;
            this.btnSearchVehiclesToUpdate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearchVehiclesToUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSearchVehiclesToUpdate.ImageOptions.SvgImage")));
            this.btnSearchVehiclesToUpdate.Location = new System.Drawing.Point(948, 29);
            this.btnSearchVehiclesToUpdate.Name = "btnSearchVehiclesToUpdate";
            this.btnSearchVehiclesToUpdate.Size = new System.Drawing.Size(140, 71);
            this.btnSearchVehiclesToUpdate.TabIndex = 14;
            this.btnSearchVehiclesToUpdate.Text = "Tìm xe";
            this.btnSearchVehiclesToUpdate.Click += new System.EventHandler(this.btnSearchVehiclesToUpdate_Click);
            // 
            // tbVehiclesId
            // 
            this.tbVehiclesId.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiclesId.Location = new System.Drawing.Point(595, 51);
            this.tbVehiclesId.Name = "tbVehiclesId";
            this.tbVehiclesId.Size = new System.Drawing.Size(318, 35);
            this.tbVehiclesId.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(486, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 28);
            this.label13.TabIndex = 82;
            this.label13.Text = "Mã số";
            // 
            // nudVehiclesAcceleration
            // 
            this.nudVehiclesAcceleration.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudVehiclesAcceleration.Location = new System.Drawing.Point(819, 264);
            this.nudVehiclesAcceleration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudVehiclesAcceleration.Name = "nudVehiclesAcceleration";
            this.nudVehiclesAcceleration.ReadOnly = true;
            this.nudVehiclesAcceleration.Size = new System.Drawing.Size(319, 35);
            this.nudVehiclesAcceleration.TabIndex = 10;
            this.nudVehiclesAcceleration.TabStop = false;
            // 
            // nudVehicleTopSpeed
            // 
            this.nudVehicleTopSpeed.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudVehicleTopSpeed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudVehicleTopSpeed.Location = new System.Drawing.Point(819, 156);
            this.nudVehicleTopSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudVehicleTopSpeed.Name = "nudVehicleTopSpeed";
            this.nudVehicleTopSpeed.ReadOnly = true;
            this.nudVehicleTopSpeed.Size = new System.Drawing.Size(319, 35);
            this.nudVehicleTopSpeed.TabIndex = 9;
            this.nudVehicleTopSpeed.TabStop = false;
            // 
            // nudVehiclesWeigth
            // 
            this.nudVehiclesWeigth.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudVehiclesWeigth.Location = new System.Drawing.Point(430, 479);
            this.nudVehiclesWeigth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudVehiclesWeigth.Name = "nudVehiclesWeigth";
            this.nudVehiclesWeigth.ReadOnly = true;
            this.nudVehiclesWeigth.Size = new System.Drawing.Size(319, 35);
            this.nudVehiclesWeigth.TabIndex = 8;
            this.nudVehiclesWeigth.TabStop = false;
            // 
            // btnDeleteVehiclesConfirm
            // 
            this.btnDeleteVehiclesConfirm.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteVehiclesConfirm.Appearance.ForeColor = System.Drawing.Color.Tomato;
            this.btnDeleteVehiclesConfirm.Appearance.Options.UseFont = true;
            this.btnDeleteVehiclesConfirm.Appearance.Options.UseForeColor = true;
            this.btnDeleteVehiclesConfirm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDeleteVehiclesConfirm.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteVehiclesConfirm.ImageOptions.SvgImage")));
            this.btnDeleteVehiclesConfirm.Location = new System.Drawing.Point(820, 458);
            this.btnDeleteVehiclesConfirm.Name = "btnDeleteVehiclesConfirm";
            this.btnDeleteVehiclesConfirm.Size = new System.Drawing.Size(230, 71);
            this.btnDeleteVehiclesConfirm.TabIndex = 1;
            this.btnDeleteVehiclesConfirm.Text = "Xóa xe";
            this.btnDeleteVehiclesConfirm.Click += new System.EventHandler(this.btnDeleteVehiclesConfirm_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(424, 447);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 28);
            this.label12.TabIndex = 77;
            this.label12.Text = "Cân nặng";
            // 
            // cboVehiclesManufactures
            // 
            this.cboVehiclesManufactures.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVehiclesManufactures.FormattingEnabled = true;
            this.cboVehiclesManufactures.Location = new System.Drawing.Point(46, 478);
            this.cboVehiclesManufactures.Name = "cboVehiclesManufactures";
            this.cboVehiclesManufactures.Size = new System.Drawing.Size(317, 36);
            this.cboVehiclesManufactures.TabIndex = 4;
            this.cboVehiclesManufactures.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 447);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 28);
            this.label11.TabIndex = 75;
            this.label11.Text = "Hãng xe";
            // 
            // cboVehiclesOwner
            // 
            this.cboVehiclesOwner.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVehiclesOwner.FormattingEnabled = true;
            this.cboVehiclesOwner.Location = new System.Drawing.Point(430, 156);
            this.cboVehiclesOwner.Name = "cboVehiclesOwner";
            this.cboVehiclesOwner.Size = new System.Drawing.Size(317, 36);
            this.cboVehiclesOwner.TabIndex = 5;
            this.cboVehiclesOwner.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Tomato;
            this.label10.Location = new System.Drawing.Point(38, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 48);
            this.label10.TabIndex = 73;
            this.label10.Text = "Xóa xe ";
            // 
            // tbVehiclesEngineDisplacement
            // 
            this.tbVehiclesEngineDisplacement.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiclesEngineDisplacement.Location = new System.Drawing.Point(820, 370);
            this.tbVehiclesEngineDisplacement.Name = "tbVehiclesEngineDisplacement";
            this.tbVehiclesEngineDisplacement.ReadOnly = true;
            this.tbVehiclesEngineDisplacement.Size = new System.Drawing.Size(318, 35);
            this.tbVehiclesEngineDisplacement.TabIndex = 11;
            this.tbVehiclesEngineDisplacement.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(815, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 28);
            this.label7.TabIndex = 71;
            this.label7.Text = "Dung tích động cơ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(815, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 28);
            this.label8.TabIndex = 70;
            this.label8.Text = "Tốc độ tăng tốc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(815, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 28);
            this.label9.TabIndex = 69;
            this.label9.Text = "Tốc độ tối đa";
            // 
            // tbVehiclesFuelType
            // 
            this.tbVehiclesFuelType.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiclesFuelType.Location = new System.Drawing.Point(430, 370);
            this.tbVehiclesFuelType.Name = "tbVehiclesFuelType";
            this.tbVehiclesFuelType.ReadOnly = true;
            this.tbVehiclesFuelType.Size = new System.Drawing.Size(318, 35);
            this.tbVehiclesFuelType.TabIndex = 7;
            this.tbVehiclesFuelType.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(425, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 28);
            this.label6.TabIndex = 67;
            this.label6.Text = "Loại nhiên liệu";
            // 
            // tbVehiclesColor
            // 
            this.tbVehiclesColor.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiclesColor.Location = new System.Drawing.Point(46, 370);
            this.tbVehiclesColor.Name = "tbVehiclesColor";
            this.tbVehiclesColor.ReadOnly = true;
            this.tbVehiclesColor.Size = new System.Drawing.Size(318, 35);
            this.tbVehiclesColor.TabIndex = 3;
            this.tbVehiclesColor.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 28);
            this.label5.TabIndex = 65;
            this.label5.Text = "Màu sắc";
            // 
            // tbVehiclesEngineType
            // 
            this.tbVehiclesEngineType.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiclesEngineType.Location = new System.Drawing.Point(430, 263);
            this.tbVehiclesEngineType.Name = "tbVehiclesEngineType";
            this.tbVehiclesEngineType.ReadOnly = true;
            this.tbVehiclesEngineType.Size = new System.Drawing.Size(318, 35);
            this.tbVehiclesEngineType.TabIndex = 6;
            this.tbVehiclesEngineType.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 28);
            this.label4.TabIndex = 63;
            this.label4.Text = "Loại động cơ";
            // 
            // tbVehiclesLiscensePlate
            // 
            this.tbVehiclesLiscensePlate.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiclesLiscensePlate.Location = new System.Drawing.Point(46, 263);
            this.tbVehiclesLiscensePlate.Name = "tbVehiclesLiscensePlate";
            this.tbVehiclesLiscensePlate.ReadOnly = true;
            this.tbVehiclesLiscensePlate.Size = new System.Drawing.Size(318, 35);
            this.tbVehiclesLiscensePlate.TabIndex = 2;
            this.tbVehiclesLiscensePlate.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 61;
            this.label3.Text = "Biển số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 28);
            this.label2.TabIndex = 60;
            this.label2.Text = "Chủ sở hữu";
            // 
            // tbVehiclesName
            // 
            this.tbVehiclesName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiclesName.Location = new System.Drawing.Point(46, 156);
            this.tbVehiclesName.Name = "tbVehiclesName";
            this.tbVehiclesName.ReadOnly = true;
            this.tbVehiclesName.Size = new System.Drawing.Size(318, 35);
            this.tbVehiclesName.TabIndex = 1;
            this.tbVehiclesName.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 28);
            this.label1.TabIndex = 58;
            this.label1.Text = "Tên xe";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.IndianRed;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(572, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 33);
            this.labelControl1.TabIndex = 94;
            this.labelControl1.Text = "*";
            // 
            // frmDeleteVehicles
            // 
            this.AcceptButton = this.btnDeleteVehiclesConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 562);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnSearchVehiclesToUpdate);
            this.Controls.Add(this.tbVehiclesId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.nudVehiclesAcceleration);
            this.Controls.Add(this.nudVehicleTopSpeed);
            this.Controls.Add(this.nudVehiclesWeigth);
            this.Controls.Add(this.btnDeleteVehiclesConfirm);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboVehiclesManufactures);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboVehiclesOwner);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbVehiclesEngineDisplacement);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbVehiclesFuelType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbVehiclesColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbVehiclesEngineType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbVehiclesLiscensePlate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVehiclesName);
            this.Controls.Add(this.label1);
            this.Name = "frmDeleteVehicles";
            this.Text = "Xóa xe";
            ((System.ComponentModel.ISupportInitialize)(this.nudVehiclesAcceleration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleTopSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehiclesWeigth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSearchVehiclesToUpdate;
        private System.Windows.Forms.TextBox tbVehiclesId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudVehiclesAcceleration;
        private System.Windows.Forms.NumericUpDown nudVehicleTopSpeed;
        private System.Windows.Forms.NumericUpDown nudVehiclesWeigth;
        private DevExpress.XtraEditors.SimpleButton btnDeleteVehiclesConfirm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboVehiclesManufactures;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboVehiclesOwner;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbVehiclesEngineDisplacement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbVehiclesFuelType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVehiclesColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbVehiclesEngineType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVehiclesLiscensePlate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVehiclesName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}