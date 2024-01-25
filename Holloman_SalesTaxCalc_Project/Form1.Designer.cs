namespace Holloman_SalesTaxCalc_Project
{
    partial class frmMain
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblWarranty = new System.Windows.Forms.Label();
            this.cmbVehicle = new System.Windows.Forms.ComboBox();
            this.lstbState = new System.Windows.Forms.ListBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnTotalCheck = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(110, 87);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(191, 27);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price of choice vehicle: ";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(18, 69);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(60, 27);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "State: ";
            // 
            // lblWarranty
            // 
            this.lblWarranty.AutoSize = true;
            this.lblWarranty.Location = new System.Drawing.Point(110, 142);
            this.lblWarranty.Name = "lblWarranty";
            this.lblWarranty.Size = new System.Drawing.Size(153, 27);
            this.lblWarranty.TabIndex = 10;
            this.lblWarranty.Text = "Type of Warranty: ";
            // 
            // cmbVehicle
            // 
            this.cmbVehicle.FormattingEnabled = true;
            this.cmbVehicle.Items.AddRange(new object[] {
            "None",
            "One Year",
            "Two Year",
            "Three Year"});
            this.cmbVehicle.Location = new System.Drawing.Point(298, 134);
            this.cmbVehicle.Name = "cmbVehicle";
            this.cmbVehicle.Size = new System.Drawing.Size(139, 35);
            this.cmbVehicle.TabIndex = 2;
            // 
            // lstbState
            // 
            this.lstbState.FormattingEnabled = true;
            this.lstbState.ItemHeight = 27;
            this.lstbState.Items.AddRange(new object[] {
            "CA",
            "OR",
            "UT",
            "WA",
            "WY"});
            this.lstbState.Location = new System.Drawing.Point(23, 99);
            this.lstbState.Name = "lstbState";
            this.lstbState.Size = new System.Drawing.Size(43, 139);
            this.lstbState.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(298, 79);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(139, 35);
            this.txtPrice.TabIndex = 0;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Location = new System.Drawing.Point(110, 202);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(121, 27);
            this.lblVehicle.TabIndex = 11;
            this.lblVehicle.Text = "Vehicle Type: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Convertible",
            "Coupe",
            "Hatchback",
            "Sedan",
            "SUV",
            "Truck",
            "Truck - Sedan",
            "Van"});
            this.comboBox1.Location = new System.Drawing.Point(300, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 35);
            this.comboBox1.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(30, 293);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(15, 27);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = " ";
            // 
            // btnTotalCheck
            // 
            this.btnTotalCheck.Location = new System.Drawing.Point(168, 251);
            this.btnTotalCheck.Name = "btnTotalCheck";
            this.btnTotalCheck.Size = new System.Drawing.Size(112, 28);
            this.btnTotalCheck.TabIndex = 4;
            this.btnTotalCheck.Text = "Calculate";
            this.btnTotalCheck.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(62, 349);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 30);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(359, 349);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 44);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Sans Serif Collection", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(428, 37);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Lost But Found Car Sales Calculator";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 404);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTotalCheck);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lstbState);
            this.Controls.Add(this.cmbVehicle);
            this.Controls.Add(this.lblWarranty);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblPrice);
            this.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmMain";
            this.Text = "LBF Car Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblWarranty;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private System.Windows.Forms.ListBox lstbState;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnTotalCheck;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
    }
}

