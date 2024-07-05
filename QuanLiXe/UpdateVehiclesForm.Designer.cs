namespace QuanLiXe
{
    partial class UpdateVehiclesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateVehiclesForm));
            this.tbVehiclesAcceleration = new System.Windows.Forms.NumericUpDown();
            this.tbVehicleTopSpeed = new System.Windows.Forms.NumericUpDown();
            this.tbVehiclesWeigth = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateVehiclesConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.label12 = new System.Windows.Forms.Label();
            this.tbVehiclesManufactures = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbVehiclesOwner = new System.Windows.Forms.ComboBox();
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
            this.tbVehiclesId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSearchVehiclesToUpdate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbVehiclesAcceleration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVehicleTopSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVehiclesWeigth)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVehiclesAcceleration
            // 
            this.tbVehiclesAcceleration.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiclesAcceleration.Location = new System.Drawing.Point(803, 259);
            this.tbVehiclesAcceleration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbVehiclesAcceleration.Name = "tbVehiclesAcceleration";
            this.tbVehiclesAcceleration.Size = new System.Drawing.Size(319, 35);
            this.tbVehiclesAcceleration.TabIndex = 54;
            // 
            // tbVehicleTopSpeed
            // 
            this.tbVehicleTopSpeed.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehicleTopSpeed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbVehicleTopSpeed.Location = new System.Drawing.Point(803, 151);
            this.tbVehicleTopSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbVehicleTopSpeed.Name = "tbVehicleTopSpeed";
            this.tbVehicleTopSpeed.Size = new System.Drawing.Size(319, 35);
            this.tbVehicleTopSpeed.TabIndex = 53;
            // 
            // tbVehiclesWeigth
            // 
            this.tbVehiclesWeigth.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiclesWeigth.Location = new System.Drawing.Point(414, 474);
            this.tbVehiclesWeigth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbVehiclesWeigth.Name = "tbVehiclesWeigth";
            this.tbVehiclesWeigth.Size = new System.Drawing.Size(319, 35);
            this.tbVehiclesWeigth.TabIndex = 52;
            // 
            // btnUpdateVehiclesConfirm
            // 
            this.btnUpdateVehiclesConfirm.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateVehiclesConfirm.Appearance.Options.UseFont = true;
            this.btnUpdateVehiclesConfirm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnUpdateVehiclesConfirm.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdateVehiclesConfirm.ImageOptions.SvgImage")));
            this.btnUpdateVehiclesConfirm.Location = new System.Drawing.Point(804, 453);
            this.btnUpdateVehiclesConfirm.Name = "btnUpdateVehiclesConfirm";
            this.btnUpdateVehiclesConfirm.Size = new System.Drawing.Size(230, 71);
            this.btnUpdateVehiclesConfirm.TabIndex = 51;
            this.btnUpdateVehiclesConfirm.Text = "Cập nhật xe";
            this.btnUpdateVehiclesConfirm.Click += new System.EventHandler(this.btnUpdateVehiclesConfirm_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(408, 442);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 28);
            this.label12.TabIndex = 50;
            this.label12.Text = "Cân nặng";
            // 
            // tbVehiclesManufactures
            // 
            this.tbVehiclesManufactures.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiclesManufactures.FormattingEnabled = true;
            this.tbVehiclesManufactures.Location = new System.Drawing.Point(30, 473);
            this.tbVehiclesManufactures.Name = "tbVehiclesManufactures";
            this.tbVehiclesManufactures.Size = new System.Drawing.Size(317, 36);
            this.tbVehiclesManufactures.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 442);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 28);
            this.label11.TabIndex = 48;
            this.label11.Text = "Hãng xe";
            // 
            // tbVehiclesOwner
            // 
            this.tbVehiclesOwner.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiclesOwner.FormattingEnabled = true;
            this.tbVehiclesOwner.Location = new System.Drawing.Point(414, 151);
            this.tbVehiclesOwner.Name = "tbVehiclesOwner";
            this.tbVehiclesOwner.Size = new System.Drawing.Size(317, 36);
            this.tbVehiclesOwner.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(22, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(426, 48);
            this.label10.TabIndex = 46;
            this.label10.Text = "Cập nhật xe theo ID";
            // 
            // tbVehiclesEngineDisplacement
            // 
            this.tbVehiclesEngineDisplacement.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiclesEngineDisplacement.Location = new System.Drawing.Point(804, 365);
            this.tbVehiclesEngineDisplacement.Name = "tbVehiclesEngineDisplacement";
            this.tbVehiclesEngineDisplacement.Size = new System.Drawing.Size(318, 35);
            this.tbVehiclesEngineDisplacement.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(799, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 28);
            this.label7.TabIndex = 44;
            this.label7.Text = "Dung tích động cơ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(799, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 28);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tốc độ tăng tốc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(799, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 28);
            this.label9.TabIndex = 42;
            this.label9.Text = "Tốc độ tối đa";
            // 
            // tbVehiclesFuelType
            // 
            this.tbVehiclesFuelType.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiclesFuelType.Location = new System.Drawing.Point(414, 365);
            this.tbVehiclesFuelType.Name = "tbVehiclesFuelType";
            this.tbVehiclesFuelType.Size = new System.Drawing.Size(318, 35);
            this.tbVehiclesFuelType.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(409, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 28);
            this.label6.TabIndex = 40;
            this.label6.Text = "Loại nhiên liệu";
            // 
            // tbVehiclesColor
            // 
            this.tbVehiclesColor.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiclesColor.Location = new System.Drawing.Point(30, 365);
            this.tbVehiclesColor.Name = "tbVehiclesColor";
            this.tbVehiclesColor.Size = new System.Drawing.Size(318, 35);
            this.tbVehiclesColor.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 28);
            this.label5.TabIndex = 38;
            this.label5.Text = "Màu sắc";
            // 
            // tbVehiclesEngineType
            // 
            this.tbVehiclesEngineType.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiclesEngineType.Location = new System.Drawing.Point(414, 258);
            this.tbVehiclesEngineType.Name = "tbVehiclesEngineType";
            this.tbVehiclesEngineType.Size = new System.Drawing.Size(318, 35);
            this.tbVehiclesEngineType.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(409, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 28);
            this.label4.TabIndex = 36;
            this.label4.Text = "Loại động cơ";
            // 
            // tbVehiclesLiscensePlate
            // 
            this.tbVehiclesLiscensePlate.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiclesLiscensePlate.Location = new System.Drawing.Point(30, 258);
            this.tbVehiclesLiscensePlate.Name = "tbVehiclesLiscensePlate";
            this.tbVehiclesLiscensePlate.Size = new System.Drawing.Size(318, 35);
            this.tbVehiclesLiscensePlate.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "Biển số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "Chủ sở hữu";
            // 
            // tbVehiclesName
            // 
            this.tbVehiclesName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiclesName.Location = new System.Drawing.Point(30, 151);
            this.tbVehiclesName.Name = "tbVehiclesName";
            this.tbVehiclesName.Size = new System.Drawing.Size(318, 35);
            this.tbVehiclesName.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tên xe";
            // 
            // tbVehiclesId
            // 
            this.tbVehiclesId.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiclesId.Location = new System.Drawing.Point(579, 46);
            this.tbVehiclesId.Name = "tbVehiclesId";
            this.tbVehiclesId.Size = new System.Drawing.Size(318, 35);
            this.tbVehiclesId.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(526, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 28);
            this.label13.TabIndex = 55;
            this.label13.Text = "ID";
            // 
            // btnSearchVehiclesToUpdate
            // 
            this.btnSearchVehiclesToUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchVehiclesToUpdate.Appearance.Options.UseFont = true;
            this.btnSearchVehiclesToUpdate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearchVehiclesToUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSearchVehiclesToUpdate.ImageOptions.SvgImage")));
            this.btnSearchVehiclesToUpdate.Location = new System.Drawing.Point(932, 24);
            this.btnSearchVehiclesToUpdate.Name = "btnSearchVehiclesToUpdate";
            this.btnSearchVehiclesToUpdate.Size = new System.Drawing.Size(140, 71);
            this.btnSearchVehiclesToUpdate.TabIndex = 57;
            this.btnSearchVehiclesToUpdate.Text = "Tìm xe";
            this.btnSearchVehiclesToUpdate.Click += new System.EventHandler(this.btnSearchVehiclesToUpdate_Click);
            // 
            // UpdateVehiclesForm
            // 
            this.AcceptButton = this.btnUpdateVehiclesConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 555);
            this.Controls.Add(this.btnSearchVehiclesToUpdate);
            this.Controls.Add(this.tbVehiclesId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbVehiclesAcceleration);
            this.Controls.Add(this.tbVehicleTopSpeed);
            this.Controls.Add(this.tbVehiclesWeigth);
            this.Controls.Add(this.btnUpdateVehiclesConfirm);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbVehiclesManufactures);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbVehiclesOwner);
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
            this.Name = "UpdateVehiclesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật xe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateVehiclesForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tbVehiclesAcceleration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVehicleTopSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVehiclesWeigth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown tbVehiclesAcceleration;
        private System.Windows.Forms.NumericUpDown tbVehicleTopSpeed;
        private System.Windows.Forms.NumericUpDown tbVehiclesWeigth;
        private DevExpress.XtraEditors.SimpleButton btnUpdateVehiclesConfirm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox tbVehiclesManufactures;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox tbVehiclesOwner;
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
        private System.Windows.Forms.TextBox tbVehiclesId;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.SimpleButton btnSearchVehiclesToUpdate;
    }
}