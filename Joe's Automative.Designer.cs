namespace Assignment_4_2_
{
    partial class mainFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCarBrand = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkExpeditedService = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkNonRoutine = new System.Windows.Forms.CheckBox();
            this.txtPartsCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkOilChange = new System.Windows.Forms.CheckBox();
            this.chkLubeJob = new System.Windows.Forms.CheckBox();
            this.chkInspection = new System.Windows.Forms.CheckBox();
            this.chkMufflerReplacement = new System.Windows.Forms.CheckBox();
            this.chkRadiatorFlush = new System.Windows.Forms.CheckBox();
            this.chkTireRotation = new System.Windows.Forms.CheckBox();
            this.chkTranFlush = new System.Windows.Forms.CheckBox();
            this.hsbHours = new System.Windows.Forms.HScrollBar();
            this.lblHourAmount = new System.Windows.Forms.Label();
            this.rdb10 = new System.Windows.Forms.RadioButton();
            this.rdb20 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Price Calculator";
            // 
            // cmbCarBrand
            // 
            this.cmbCarBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarBrand.FormattingEnabled = true;
            this.cmbCarBrand.Location = new System.Drawing.Point(24, 53);
            this.cmbCarBrand.Name = "cmbCarBrand";
            this.cmbCarBrand.Size = new System.Drawing.Size(121, 21);
            this.cmbCarBrand.TabIndex = 1;
            this.cmbCarBrand.SelectedIndexChanged += new System.EventHandler(this.cmbCarBrand_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Car Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Services";
            // 
            // chkExpeditedService
            // 
            this.chkExpeditedService.AutoSize = true;
            this.chkExpeditedService.Location = new System.Drawing.Point(24, 222);
            this.chkExpeditedService.Name = "chkExpeditedService";
            this.chkExpeditedService.Size = new System.Drawing.Size(112, 17);
            this.chkExpeditedService.TabIndex = 5;
            this.chkExpeditedService.Text = "Expedited Service";
            this.chkExpeditedService.UseVisualStyleBackColor = true;
            this.chkExpeditedService.CheckStateChanged += new System.EventHandler(this.cmbCarBrand_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Discount";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(290, 323);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(290, 367);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(290, 396);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(24, 323);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(260, 320);
            this.lblResult.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cost of Parts";
            // 
            // chkNonRoutine
            // 
            this.chkNonRoutine.AutoSize = true;
            this.chkNonRoutine.Location = new System.Drawing.Point(24, 197);
            this.chkNonRoutine.Name = "chkNonRoutine";
            this.chkNonRoutine.Size = new System.Drawing.Size(125, 17);
            this.chkNonRoutine.TabIndex = 14;
            this.chkNonRoutine.Text = "Non Routine Service";
            this.chkNonRoutine.UseVisualStyleBackColor = true;
            this.chkNonRoutine.CheckStateChanged += new System.EventHandler(this.cmbCarBrand_SelectedIndexChanged);
            // 
            // txtPartsCost
            // 
            this.txtPartsCost.Location = new System.Drawing.Point(228, 201);
            this.txtPartsCost.Name = "txtPartsCost";
            this.txtPartsCost.Size = new System.Drawing.Size(100, 20);
            this.txtPartsCost.TabIndex = 15;
            this.txtPartsCost.TextChanged += new System.EventHandler(this.cmbCarBrand_SelectedIndexChanged);
            this.txtPartsCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPartsCost_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hours";
            // 
            // chkOilChange
            // 
            this.chkOilChange.AutoSize = true;
            this.chkOilChange.Location = new System.Drawing.Point(24, 108);
            this.chkOilChange.Name = "chkOilChange";
            this.chkOilChange.Size = new System.Drawing.Size(78, 17);
            this.chkOilChange.TabIndex = 18;
            this.chkOilChange.Text = "Oil Change";
            this.chkOilChange.UseVisualStyleBackColor = true;
            this.chkOilChange.CheckStateChanged += new System.EventHandler(this.cmbCarBrand_SelectedIndexChanged);
            // 
            // chkLubeJob
            // 
            this.chkLubeJob.AutoSize = true;
            this.chkLubeJob.Location = new System.Drawing.Point(24, 132);
            this.chkLubeJob.Name = "chkLubeJob";
            this.chkLubeJob.Size = new System.Drawing.Size(70, 17);
            this.chkLubeJob.TabIndex = 19;
            this.chkLubeJob.Text = "Lube Job";
            this.chkLubeJob.UseVisualStyleBackColor = true;
            this.chkLubeJob.CheckStateChanged += new System.EventHandler(this.cmbCarBrand_SelectedIndexChanged);
            // 
            // chkInspection
            // 
            this.chkInspection.AutoSize = true;
            this.chkInspection.Location = new System.Drawing.Point(127, 109);
            this.chkInspection.Name = "chkInspection";
            this.chkInspection.Size = new System.Drawing.Size(75, 17);
            this.chkInspection.TabIndex = 20;
            this.chkInspection.Text = "Inspection";
            this.chkInspection.UseVisualStyleBackColor = true;
            this.chkInspection.CheckStateChanged += new System.EventHandler(this.cmbCarBrand_SelectedIndexChanged);
            // 
            // chkMufflerReplacement
            // 
            this.chkMufflerReplacement.AutoSize = true;
            this.chkMufflerReplacement.Location = new System.Drawing.Point(127, 132);
            this.chkMufflerReplacement.Name = "chkMufflerReplacement";
            this.chkMufflerReplacement.Size = new System.Drawing.Size(124, 17);
            this.chkMufflerReplacement.TabIndex = 21;
            this.chkMufflerReplacement.Text = "Muffler Replacement";
            this.chkMufflerReplacement.UseVisualStyleBackColor = true;
            this.chkMufflerReplacement.CheckStateChanged += new System.EventHandler(this.cmbCarBrand_SelectedIndexChanged);
            // 
            // chkRadiatorFlush
            // 
            this.chkRadiatorFlush.AutoSize = true;
            this.chkRadiatorFlush.Location = new System.Drawing.Point(24, 155);
            this.chkRadiatorFlush.Name = "chkRadiatorFlush";
            this.chkRadiatorFlush.Size = new System.Drawing.Size(94, 17);
            this.chkRadiatorFlush.TabIndex = 22;
            this.chkRadiatorFlush.Text = "Radiator Flush";
            this.chkRadiatorFlush.UseVisualStyleBackColor = true;
            this.chkRadiatorFlush.CheckStateChanged += new System.EventHandler(this.cmbCarBrand_SelectedIndexChanged);
            // 
            // chkTireRotation
            // 
            this.chkTireRotation.AutoSize = true;
            this.chkTireRotation.Location = new System.Drawing.Point(127, 156);
            this.chkTireRotation.Name = "chkTireRotation";
            this.chkTireRotation.Size = new System.Drawing.Size(87, 17);
            this.chkTireRotation.TabIndex = 23;
            this.chkTireRotation.Text = "Tire Rotation";
            this.chkTireRotation.UseVisualStyleBackColor = true;
            this.chkTireRotation.CheckStateChanged += new System.EventHandler(this.cmbCarBrand_SelectedIndexChanged);
            // 
            // chkTranFlush
            // 
            this.chkTranFlush.AutoSize = true;
            this.chkTranFlush.Location = new System.Drawing.Point(24, 174);
            this.chkTranFlush.Name = "chkTranFlush";
            this.chkTranFlush.Size = new System.Drawing.Size(115, 17);
            this.chkTranFlush.TabIndex = 24;
            this.chkTranFlush.Text = "Transmission Flush";
            this.chkTranFlush.UseVisualStyleBackColor = true;
            this.chkTranFlush.CheckStateChanged += new System.EventHandler(this.cmbCarBrand_SelectedIndexChanged);
            // 
            // hsbHours
            // 
            this.hsbHours.LargeChange = 1;
            this.hsbHours.Location = new System.Drawing.Point(228, 235);
            this.hsbHours.Name = "hsbHours";
            this.hsbHours.Size = new System.Drawing.Size(110, 13);
            this.hsbHours.TabIndex = 25;
            this.hsbHours.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbHours_Scroll);
            // 
            // lblHourAmount
            // 
            this.lblHourAmount.AutoSize = true;
            this.lblHourAmount.Location = new System.Drawing.Point(287, 248);
            this.lblHourAmount.Name = "lblHourAmount";
            this.lblHourAmount.Size = new System.Drawing.Size(13, 13);
            this.lblHourAmount.TabIndex = 26;
            this.lblHourAmount.Text = "0";
            // 
            // rdb10
            // 
            this.rdb10.AutoSize = true;
            this.rdb10.Location = new System.Drawing.Point(28, 265);
            this.rdb10.Name = "rdb10";
            this.rdb10.Size = new System.Drawing.Size(90, 17);
            this.rdb10.TabIndex = 27;
            this.rdb10.TabStop = true;
            this.rdb10.Text = "10% Discount";
            this.rdb10.UseVisualStyleBackColor = true;
            // 
            // rdb20
            // 
            this.rdb20.AutoSize = true;
            this.rdb20.Location = new System.Drawing.Point(27, 289);
            this.rdb20.Name = "rdb20";
            this.rdb20.Size = new System.Drawing.Size(90, 17);
            this.rdb20.TabIndex = 28;
            this.rdb20.TabStop = true;
            this.rdb20.Text = "20% Discount";
            this.rdb20.UseVisualStyleBackColor = true;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 694);
            this.Controls.Add(this.rdb20);
            this.Controls.Add(this.rdb10);
            this.Controls.Add(this.lblHourAmount);
            this.Controls.Add(this.hsbHours);
            this.Controls.Add(this.chkTranFlush);
            this.Controls.Add(this.chkTireRotation);
            this.Controls.Add(this.chkRadiatorFlush);
            this.Controls.Add(this.chkMufflerReplacement);
            this.Controls.Add(this.chkInspection);
            this.Controls.Add(this.chkLubeJob);
            this.Controls.Add(this.chkOilChange);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPartsCost);
            this.Controls.Add(this.chkNonRoutine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkExpeditedService);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCarBrand);
            this.Controls.Add(this.label1);
            this.Name = "mainFrm";
            this.Text = "Joe\'s Automative";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCarBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkExpeditedService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkNonRoutine;
        private System.Windows.Forms.TextBox txtPartsCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkOilChange;
        private System.Windows.Forms.CheckBox chkLubeJob;
        private System.Windows.Forms.CheckBox chkInspection;
        private System.Windows.Forms.CheckBox chkMufflerReplacement;
        private System.Windows.Forms.CheckBox chkRadiatorFlush;
        private System.Windows.Forms.CheckBox chkTireRotation;
        private System.Windows.Forms.CheckBox chkTranFlush;
        private System.Windows.Forms.HScrollBar hsbHours;
        private System.Windows.Forms.Label lblHourAmount;
        private System.Windows.Forms.RadioButton rdb10;
        private System.Windows.Forms.RadioButton rdb20;
    }
}

