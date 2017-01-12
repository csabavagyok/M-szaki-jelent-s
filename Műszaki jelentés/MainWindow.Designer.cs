namespace Műszaki_jelentés
{
    partial class MainWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.actualMonth = new System.Windows.Forms.DateTimePicker();
            this.stationName = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addVehicle = new System.Windows.Forms.Button();
            this.vehicleList = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.vehicleLicenseDateModifierButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicleLicenseValidDate = new System.Windows.Forms.DateTimePicker();
            this.vehicleMakeModel = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.vehicleLicenseValidDateWarning = new System.Windows.Forms.Label();
            this.actualDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.actualMonth);
            this.groupBox1.Controls.Add(this.stationName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Állomás, hónap adatok";
            // 
            // actualMonth
            // 
            this.actualMonth.CustomFormat = "yyyy. MMMM";
            this.actualMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.actualMonth.Location = new System.Drawing.Point(6, 58);
            this.actualMonth.Name = "actualMonth";
            this.actualMonth.Size = new System.Drawing.Size(182, 22);
            this.actualMonth.TabIndex = 1;
            // 
            // stationName
            // 
            this.stationName.FormattingEnabled = true;
            this.stationName.Items.AddRange(new object[] {
            "Központ",
            "Buda II",
            "Újpest",
            "Rákospalota",
            "Kispest",
            "Pestlőrinc",
            "Pesterzsébet",
            "Csepel",
            "Budafok",
            "Csillaghegy",
            "Rákoskeresztúr",
            "Bázis",
            "Mátyásföld",
            "Pesthidegkút"});
            this.stationName.Location = new System.Drawing.Point(6, 21);
            this.stationName.Name = "stationName";
            this.stationName.Size = new System.Drawing.Size(182, 24);
            this.stationName.TabIndex = 0;
            this.stationName.Text = "Mentőállomás";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addVehicle);
            this.groupBox2.Controls.Add(this.vehicleList);
            this.groupBox2.Location = new System.Drawing.Point(212, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OSTOR Nyilvántartás";
            // 
            // addVehicle
            // 
            this.addVehicle.Location = new System.Drawing.Point(132, 53);
            this.addVehicle.Name = "addVehicle";
            this.addVehicle.Size = new System.Drawing.Size(75, 37);
            this.addVehicle.TabIndex = 1;
            this.addVehicle.Text = "Új jármű";
            this.addVehicle.UseVisualStyleBackColor = true;
            // 
            // vehicleList
            // 
            this.vehicleList.FormattingEnabled = true;
            this.vehicleList.ItemHeight = 16;
            this.vehicleList.Location = new System.Drawing.Point(6, 21);
            this.vehicleList.Name = "vehicleList";
            this.vehicleList.Size = new System.Drawing.Size(120, 100);
            this.vehicleList.Sorted = true;
            this.vehicleList.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.vehicleLicenseValidDateWarning);
            this.groupBox3.Controls.Add(this.vehicleLicenseDateModifierButton);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.vehicleLicenseValidDate);
            this.groupBox3.Controls.Add(this.vehicleMakeModel);
            this.groupBox3.Location = new System.Drawing.Point(12, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 222);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kiválasztott jármű adatai";
            // 
            // vehicleLicenseDateModifierButton
            // 
            this.vehicleLicenseDateModifierButton.Location = new System.Drawing.Point(6, 117);
            this.vehicleLicenseDateModifierButton.Name = "vehicleLicenseDateModifierButton";
            this.vehicleLicenseDateModifierButton.Size = new System.Drawing.Size(196, 43);
            this.vehicleLicenseDateModifierButton.TabIndex = 3;
            this.vehicleLicenseDateModifierButton.Text = "Műszaki érvényesség módosítása";
            this.vehicleLicenseDateModifierButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Műszaki vizsga érvényessége";
            // 
            // vehicleLicenseValidDate
            // 
            this.vehicleLicenseValidDate.CustomFormat = "yyyy. MMMM dd.";
            this.vehicleLicenseValidDate.Enabled = false;
            this.vehicleLicenseValidDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.vehicleLicenseValidDate.Location = new System.Drawing.Point(6, 89);
            this.vehicleLicenseValidDate.Name = "vehicleLicenseValidDate";
            this.vehicleLicenseValidDate.Size = new System.Drawing.Size(196, 22);
            this.vehicleLicenseValidDate.TabIndex = 1;
            // 
            // vehicleMakeModel
            // 
            this.vehicleMakeModel.Enabled = false;
            this.vehicleMakeModel.FormattingEnabled = true;
            this.vehicleMakeModel.Location = new System.Drawing.Point(6, 30);
            this.vehicleMakeModel.Name = "vehicleMakeModel";
            this.vehicleMakeModel.Size = new System.Drawing.Size(196, 24);
            this.vehicleMakeModel.TabIndex = 0;
            this.vehicleMakeModel.Text = "Gyártmány, típus";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDown2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.actualDatePicker);
            this.groupBox4.Location = new System.Drawing.Point(244, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(186, 222);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Motorolaj, üzemanyag";
            // 
            // vehicleLicenseValidDateWarning
            // 
            this.vehicleLicenseValidDateWarning.AutoEllipsis = true;
            this.vehicleLicenseValidDateWarning.AutoSize = true;
            this.vehicleLicenseValidDateWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vehicleLicenseValidDateWarning.ForeColor = System.Drawing.Color.Red;
            this.vehicleLicenseValidDateWarning.Location = new System.Drawing.Point(6, 163);
            this.vehicleLicenseValidDateWarning.MaximumSize = new System.Drawing.Size(200, 0);
            this.vehicleLicenseValidDateWarning.Name = "vehicleLicenseValidDateWarning";
            this.vehicleLicenseValidDateWarning.Size = new System.Drawing.Size(187, 51);
            this.vehicleLicenseValidDateWarning.TabIndex = 4;
            this.vehicleLicenseValidDateWarning.Text = "A mentőjármű műszaki érvényessége 40 napon belül lejár!";
            this.vehicleLicenseValidDateWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actualDatePicker
            // 
            this.actualDatePicker.CustomFormat = "yyyy. MM. dd.";
            this.actualDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.actualDatePicker.Location = new System.Drawing.Point(6, 21);
            this.actualDatePicker.Name = "actualDatePicker";
            this.actualDatePicker.Size = new System.Drawing.Size(160, 22);
            this.actualDatePicker.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Betöltött üzemanyag";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(6, 66);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(88, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Betöltött motorolaj";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 1;
            this.numericUpDown2.Location = new System.Drawing.Point(9, 114);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(85, 22);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 409);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainWindow";
            this.Text = "OSTOR - Műszaki jelentés app";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox stationName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addVehicle;
        private System.Windows.Forms.ListBox vehicleList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker vehicleLicenseValidDate;
        private System.Windows.Forms.ComboBox vehicleMakeModel;
        private System.Windows.Forms.DateTimePicker actualMonth;
        private System.Windows.Forms.Button vehicleLicenseDateModifierButton;
        private System.Windows.Forms.Label vehicleLicenseValidDateWarning;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker actualDatePicker;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
    }
}

