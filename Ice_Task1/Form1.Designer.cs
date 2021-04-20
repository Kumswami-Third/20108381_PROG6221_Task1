
namespace Ice_Task1
{
    partial class BudgetForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGrossIncAlert = new System.Windows.Forms.Label();
            this.txbGrossMonInc = new System.Windows.Forms.TextBox();
            this.lblGrossInc = new System.Windows.Forms.Label();
            this.lblMonthlyDeduct = new System.Windows.Forms.Label();
            this.lblGroceries = new System.Windows.Forms.Label();
            this.lblWaterLights = new System.Windows.Forms.Label();
            this.lblTravelCost = new System.Windows.Forms.Label();
            this.lblCellTell = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.rbRent = new System.Windows.Forms.RadioButton();
            this.rbBuy = new System.Windows.Forms.RadioButton();
            this.pnlProperty = new System.Windows.Forms.Panel();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.txbTaxDed = new System.Windows.Forms.TextBox();
            this.txbGroc = new System.Windows.Forms.TextBox();
            this.txbWaterLights = new System.Windows.Forms.TextBox();
            this.txbTravel = new System.Windows.Forms.TextBox();
            this.txbCellTell = new System.Windows.Forms.TextBox();
            this.txbOther = new System.Windows.Forms.TextBox();
            this.lblMonthlyDeductAlert = new System.Windows.Forms.Label();
            this.lblGroceriesAlert = new System.Windows.Forms.Label();
            this.lblWaterLightsAlert = new System.Windows.Forms.Label();
            this.lblTravelCostAlert = new System.Windows.Forms.Label();
            this.lblCellTellAlert = new System.Windows.Forms.Label();
            this.lblOtherAlert = new System.Windows.Forms.Label();
            this.pnlBuyProperty = new System.Windows.Forms.Panel();
            this.numericUpDownMonRepay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownInterestRate = new System.Windows.Forms.NumericUpDown();
            this.lblTotDepositAlert = new System.Windows.Forms.Label();
            this.lblMonRepayAlert = new System.Windows.Forms.Label();
            this.lblInterestRateAlert = new System.Windows.Forms.Label();
            this.lblPropertyPriceAlert = new System.Windows.Forms.Label();
            this.txbTotDeposit = new System.Windows.Forms.TextBox();
            this.txbPropPrice = new System.Windows.Forms.TextBox();
            this.lblMonRepay = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblTotDeposit = new System.Windows.Forms.Label();
            this.lblPropertyPrice = new System.Windows.Forms.Label();
            this.pnlRentProperty = new System.Windows.Forms.Panel();
            this.lblMonRentAlert = new System.Windows.Forms.Label();
            this.txbMonRent = new System.Windows.Forms.TextBox();
            this.lblMonRent = new System.Windows.Forms.Label();
            this.btnCheckBud = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txbFullName = new System.Windows.Forms.TextBox();
            this.txbReport = new System.Windows.Forms.Button();
            this.lblFullNameAlert = new System.Windows.Forms.Label();
            this.txbOutput = new System.Windows.Forms.RichTextBox();
            this.pnlProperty.SuspendLayout();
            this.pnlBuyProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonRepay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterestRate)).BeginInit();
            this.pnlRentProperty.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGrossIncAlert
            // 
            this.lblGrossIncAlert.AutoSize = true;
            this.lblGrossIncAlert.Location = new System.Drawing.Point(300, 117);
            this.lblGrossIncAlert.Name = "lblGrossIncAlert";
            this.lblGrossIncAlert.Size = new System.Drawing.Size(0, 15);
            this.lblGrossIncAlert.TabIndex = 0;
            // 
            // txbGrossMonInc
            // 
            this.txbGrossMonInc.Location = new System.Drawing.Point(164, 111);
            this.txbGrossMonInc.Name = "txbGrossMonInc";
            this.txbGrossMonInc.Size = new System.Drawing.Size(123, 23);
            this.txbGrossMonInc.TabIndex = 1;
            this.txbGrossMonInc.TextChanged += new System.EventHandler(this.txbInput_TextChanged);
            // 
            // lblGrossInc
            // 
            this.lblGrossInc.AutoSize = true;
            this.lblGrossInc.Location = new System.Drawing.Point(4, 114);
            this.lblGrossInc.Name = "lblGrossInc";
            this.lblGrossInc.Size = new System.Drawing.Size(145, 15);
            this.lblGrossInc.TabIndex = 2;
            this.lblGrossInc.Text = "Gross Monthly Income(R):";
            // 
            // lblMonthlyDeduct
            // 
            this.lblMonthlyDeduct.AutoSize = true;
            this.lblMonthlyDeduct.Location = new System.Drawing.Point(17, 146);
            this.lblMonthlyDeduct.Name = "lblMonthlyDeduct";
            this.lblMonthlyDeduct.Size = new System.Drawing.Size(132, 15);
            this.lblMonthlyDeduct.TabIndex = 3;
            this.lblMonthlyDeduct.Text = "Est. Mon Tax Deduct(R):";
            // 
            // lblGroceries
            // 
            this.lblGroceries.AutoSize = true;
            this.lblGroceries.Location = new System.Drawing.Point(90, 180);
            this.lblGroceries.Name = "lblGroceries";
            this.lblGroceries.Size = new System.Drawing.Size(59, 15);
            this.lblGroceries.TabIndex = 4;
            this.lblGroceries.Text = "Groceries:";
            // 
            // lblWaterLights
            // 
            this.lblWaterLights.AutoSize = true;
            this.lblWaterLights.Location = new System.Drawing.Point(53, 215);
            this.lblWaterLights.Name = "lblWaterLights";
            this.lblWaterLights.Size = new System.Drawing.Size(96, 15);
            this.lblWaterLights.TabIndex = 5;
            this.lblWaterLights.Text = "Water and lights:";
            // 
            // lblTravelCost
            // 
            this.lblTravelCost.AutoSize = true;
            this.lblTravelCost.Location = new System.Drawing.Point(15, 251);
            this.lblTravelCost.Name = "lblTravelCost";
            this.lblTravelCost.Size = new System.Drawing.Size(134, 15);
            this.lblTravelCost.TabIndex = 6;
            this.lblTravelCost.Text = "Travel costs (inc. petrol):";
            // 
            // lblCellTell
            // 
            this.lblCellTell.AutoSize = true;
            this.lblCellTell.Location = new System.Drawing.Point(3, 283);
            this.lblCellTell.Name = "lblCellTell";
            this.lblCellTell.Size = new System.Drawing.Size(146, 15);
            this.lblCellTell.TabIndex = 7;
            this.lblCellTell.Text = "Cell phone and telephone:";
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(58, 322);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(91, 15);
            this.lblOther.TabIndex = 8;
            this.lblOther.Text = "Other expenses:";
            // 
            // rbRent
            // 
            this.rbRent.AutoSize = true;
            this.rbRent.Location = new System.Drawing.Point(12, 20);
            this.rbRent.Name = "rbRent";
            this.rbRent.Size = new System.Drawing.Size(97, 19);
            this.rbRent.TabIndex = 9;
            this.rbRent.TabStop = true;
            this.rbRent.Text = "Rent Property";
            this.rbRent.UseVisualStyleBackColor = true;
            this.rbRent.CheckedChanged += new System.EventHandler(this.rbRent_CheckedChanged);
            // 
            // rbBuy
            // 
            this.rbBuy.AutoSize = true;
            this.rbBuy.Location = new System.Drawing.Point(264, 20);
            this.rbBuy.Name = "rbBuy";
            this.rbBuy.Size = new System.Drawing.Size(93, 19);
            this.rbBuy.TabIndex = 10;
            this.rbBuy.TabStop = true;
            this.rbBuy.Text = "Buy Property";
            this.rbBuy.UseVisualStyleBackColor = true;
            this.rbBuy.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // pnlProperty
            // 
            this.pnlProperty.Controls.Add(this.rbRent);
            this.pnlProperty.Controls.Add(this.rbBuy);
            this.pnlProperty.Location = new System.Drawing.Point(35, 353);
            this.pnlProperty.Name = "pnlProperty";
            this.pnlProperty.Size = new System.Drawing.Size(384, 45);
            this.pnlProperty.TabIndex = 11;
            this.pnlProperty.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlProperty_Paint);
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormHeader.Location = new System.Drawing.Point(265, 9);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(375, 45);
            this.lblFormHeader.TabIndex = 12;
            this.lblFormHeader.Text = "Personal Budget Planner ";
            // 
            // txbTaxDed
            // 
            this.txbTaxDed.Location = new System.Drawing.Point(165, 143);
            this.txbTaxDed.Name = "txbTaxDed";
            this.txbTaxDed.Size = new System.Drawing.Size(123, 23);
            this.txbTaxDed.TabIndex = 13;
            this.txbTaxDed.TextChanged += new System.EventHandler(this.txbTaxDed_TextChanged);
            // 
            // txbGroc
            // 
            this.txbGroc.Location = new System.Drawing.Point(165, 177);
            this.txbGroc.Name = "txbGroc";
            this.txbGroc.Size = new System.Drawing.Size(123, 23);
            this.txbGroc.TabIndex = 14;
            this.txbGroc.TextChanged += new System.EventHandler(this.txbGroc_TextChanged);
            // 
            // txbWaterLights
            // 
            this.txbWaterLights.Location = new System.Drawing.Point(165, 212);
            this.txbWaterLights.Name = "txbWaterLights";
            this.txbWaterLights.Size = new System.Drawing.Size(123, 23);
            this.txbWaterLights.TabIndex = 15;
            this.txbWaterLights.TextChanged += new System.EventHandler(this.txbWaterLights_TextChanged);
            // 
            // txbTravel
            // 
            this.txbTravel.Location = new System.Drawing.Point(165, 248);
            this.txbTravel.Name = "txbTravel";
            this.txbTravel.Size = new System.Drawing.Size(123, 23);
            this.txbTravel.TabIndex = 16;
            this.txbTravel.TextChanged += new System.EventHandler(this.txbTravel_TextChanged);
            // 
            // txbCellTell
            // 
            this.txbCellTell.Location = new System.Drawing.Point(165, 283);
            this.txbCellTell.Name = "txbCellTell";
            this.txbCellTell.Size = new System.Drawing.Size(123, 23);
            this.txbCellTell.TabIndex = 17;
            this.txbCellTell.TextChanged += new System.EventHandler(this.txbCellTell_TextChanged);
            // 
            // txbOther
            // 
            this.txbOther.Location = new System.Drawing.Point(165, 319);
            this.txbOther.Name = "txbOther";
            this.txbOther.Size = new System.Drawing.Size(123, 23);
            this.txbOther.TabIndex = 18;
            this.txbOther.TextChanged += new System.EventHandler(this.txbOther_TextChanged);
            // 
            // lblMonthlyDeductAlert
            // 
            this.lblMonthlyDeductAlert.AutoSize = true;
            this.lblMonthlyDeductAlert.Location = new System.Drawing.Point(300, 146);
            this.lblMonthlyDeductAlert.Name = "lblMonthlyDeductAlert";
            this.lblMonthlyDeductAlert.Size = new System.Drawing.Size(0, 15);
            this.lblMonthlyDeductAlert.TabIndex = 20;
            // 
            // lblGroceriesAlert
            // 
            this.lblGroceriesAlert.AutoSize = true;
            this.lblGroceriesAlert.Location = new System.Drawing.Point(300, 180);
            this.lblGroceriesAlert.Name = "lblGroceriesAlert";
            this.lblGroceriesAlert.Size = new System.Drawing.Size(0, 15);
            this.lblGroceriesAlert.TabIndex = 21;
            // 
            // lblWaterLightsAlert
            // 
            this.lblWaterLightsAlert.AutoSize = true;
            this.lblWaterLightsAlert.Location = new System.Drawing.Point(300, 215);
            this.lblWaterLightsAlert.Name = "lblWaterLightsAlert";
            this.lblWaterLightsAlert.Size = new System.Drawing.Size(0, 15);
            this.lblWaterLightsAlert.TabIndex = 22;
            // 
            // lblTravelCostAlert
            // 
            this.lblTravelCostAlert.AutoSize = true;
            this.lblTravelCostAlert.Location = new System.Drawing.Point(300, 251);
            this.lblTravelCostAlert.Name = "lblTravelCostAlert";
            this.lblTravelCostAlert.Size = new System.Drawing.Size(0, 15);
            this.lblTravelCostAlert.TabIndex = 23;
            // 
            // lblCellTellAlert
            // 
            this.lblCellTellAlert.AutoSize = true;
            this.lblCellTellAlert.Location = new System.Drawing.Point(300, 286);
            this.lblCellTellAlert.Name = "lblCellTellAlert";
            this.lblCellTellAlert.Size = new System.Drawing.Size(0, 15);
            this.lblCellTellAlert.TabIndex = 24;
            // 
            // lblOtherAlert
            // 
            this.lblOtherAlert.AutoSize = true;
            this.lblOtherAlert.Location = new System.Drawing.Point(300, 322);
            this.lblOtherAlert.Name = "lblOtherAlert";
            this.lblOtherAlert.Size = new System.Drawing.Size(0, 15);
            this.lblOtherAlert.TabIndex = 25;
            this.lblOtherAlert.Click += new System.EventHandler(this.lblOtherAlert_Click);
            // 
            // pnlBuyProperty
            // 
            this.pnlBuyProperty.Controls.Add(this.numericUpDownMonRepay);
            this.pnlBuyProperty.Controls.Add(this.numericUpDownInterestRate);
            this.pnlBuyProperty.Controls.Add(this.lblTotDepositAlert);
            this.pnlBuyProperty.Controls.Add(this.lblMonRepayAlert);
            this.pnlBuyProperty.Controls.Add(this.lblInterestRateAlert);
            this.pnlBuyProperty.Controls.Add(this.lblPropertyPriceAlert);
            this.pnlBuyProperty.Controls.Add(this.txbTotDeposit);
            this.pnlBuyProperty.Controls.Add(this.txbPropPrice);
            this.pnlBuyProperty.Controls.Add(this.lblMonRepay);
            this.pnlBuyProperty.Controls.Add(this.lblInterestRate);
            this.pnlBuyProperty.Controls.Add(this.lblTotDeposit);
            this.pnlBuyProperty.Controls.Add(this.lblPropertyPrice);
            this.pnlBuyProperty.Location = new System.Drawing.Point(35, 457);
            this.pnlBuyProperty.Name = "pnlBuyProperty";
            this.pnlBuyProperty.Size = new System.Drawing.Size(414, 147);
            this.pnlBuyProperty.TabIndex = 26;
            this.pnlBuyProperty.Visible = false;
            this.pnlBuyProperty.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBuyProperty_Paint);
            // 
            // numericUpDownMonRepay
            // 
            this.numericUpDownMonRepay.Location = new System.Drawing.Point(129, 111);
            this.numericUpDownMonRepay.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownMonRepay.Minimum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.numericUpDownMonRepay.Name = "numericUpDownMonRepay";
            this.numericUpDownMonRepay.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownMonRepay.TabIndex = 14;
            this.numericUpDownMonRepay.Value = new decimal(new int[] {
            240,
            0,
            0,
            0});
            // 
            // numericUpDownInterestRate
            // 
            this.numericUpDownInterestRate.DecimalPlaces = 2;
            this.numericUpDownInterestRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownInterestRate.Location = new System.Drawing.Point(129, 75);
            this.numericUpDownInterestRate.Name = "numericUpDownInterestRate";
            this.numericUpDownInterestRate.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownInterestRate.TabIndex = 13;
            this.numericUpDownInterestRate.ValueChanged += new System.EventHandler(this.numericUpDownInterestRate_ValueChanged);
            // 
            // lblTotDepositAlert
            // 
            this.lblTotDepositAlert.AutoSize = true;
            this.lblTotDepositAlert.Location = new System.Drawing.Point(265, 46);
            this.lblTotDepositAlert.Name = "lblTotDepositAlert";
            this.lblTotDepositAlert.Size = new System.Drawing.Size(0, 15);
            this.lblTotDepositAlert.TabIndex = 12;
            // 
            // lblMonRepayAlert
            // 
            this.lblMonRepayAlert.AutoSize = true;
            this.lblMonRepayAlert.Location = new System.Drawing.Point(265, 101);
            this.lblMonRepayAlert.Name = "lblMonRepayAlert";
            this.lblMonRepayAlert.Size = new System.Drawing.Size(0, 15);
            this.lblMonRepayAlert.TabIndex = 11;
            // 
            // lblInterestRateAlert
            // 
            this.lblInterestRateAlert.AutoSize = true;
            this.lblInterestRateAlert.Location = new System.Drawing.Point(265, 75);
            this.lblInterestRateAlert.Name = "lblInterestRateAlert";
            this.lblInterestRateAlert.Size = new System.Drawing.Size(0, 15);
            this.lblInterestRateAlert.TabIndex = 10;
            // 
            // lblPropertyPriceAlert
            // 
            this.lblPropertyPriceAlert.AutoSize = true;
            this.lblPropertyPriceAlert.Location = new System.Drawing.Point(265, 16);
            this.lblPropertyPriceAlert.Name = "lblPropertyPriceAlert";
            this.lblPropertyPriceAlert.Size = new System.Drawing.Size(0, 15);
            this.lblPropertyPriceAlert.TabIndex = 8;
            this.lblPropertyPriceAlert.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txbTotDeposit
            // 
            this.txbTotDeposit.Location = new System.Drawing.Point(129, 43);
            this.txbTotDeposit.Name = "txbTotDeposit";
            this.txbTotDeposit.Size = new System.Drawing.Size(122, 23);
            this.txbTotDeposit.TabIndex = 5;
            this.txbTotDeposit.TextChanged += new System.EventHandler(this.txbTotDeposit_TextChanged);
            // 
            // txbPropPrice
            // 
            this.txbPropPrice.Location = new System.Drawing.Point(129, 13);
            this.txbPropPrice.Name = "txbPropPrice";
            this.txbPropPrice.Size = new System.Drawing.Size(122, 23);
            this.txbPropPrice.TabIndex = 4;
            this.txbPropPrice.TextChanged += new System.EventHandler(this.txbPropPrice_TextChanged);
            // 
            // lblMonRepay
            // 
            this.lblMonRepay.AutoSize = true;
            this.lblMonRepay.Location = new System.Drawing.Point(12, 113);
            this.lblMonRepay.Name = "lblMonRepay";
            this.lblMonRepay.Size = new System.Drawing.Size(97, 15);
            this.lblMonRepay.TabIndex = 3;
            this.lblMonRepay.Text = "Months to repay:";
            this.lblMonRepay.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(19, 75);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(90, 15);
            this.lblInterestRate.TabIndex = 2;
            this.lblInterestRate.Text = "InterestRate(%):";
            this.lblInterestRate.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTotDeposit
            // 
            this.lblTotDeposit.AutoSize = true;
            this.lblTotDeposit.Location = new System.Drawing.Point(33, 46);
            this.lblTotDeposit.Name = "lblTotDeposit";
            this.lblTotDeposit.Size = new System.Drawing.Size(78, 15);
            this.lblTotDeposit.TabIndex = 1;
            this.lblTotDeposit.Text = "Total Deposit:";
            // 
            // lblPropertyPrice
            // 
            this.lblPropertyPrice.AutoSize = true;
            this.lblPropertyPrice.Location = new System.Drawing.Point(30, 16);
            this.lblPropertyPrice.Name = "lblPropertyPrice";
            this.lblPropertyPrice.Size = new System.Drawing.Size(81, 15);
            this.lblPropertyPrice.TabIndex = 0;
            this.lblPropertyPrice.Text = "PropertyPrice:";
            // 
            // pnlRentProperty
            // 
            this.pnlRentProperty.Controls.Add(this.lblMonRentAlert);
            this.pnlRentProperty.Controls.Add(this.txbMonRent);
            this.pnlRentProperty.Controls.Add(this.lblMonRent);
            this.pnlRentProperty.Location = new System.Drawing.Point(3, 404);
            this.pnlRentProperty.Name = "pnlRentProperty";
            this.pnlRentProperty.Size = new System.Drawing.Size(446, 47);
            this.pnlRentProperty.TabIndex = 27;
            this.pnlRentProperty.Visible = false;
            // 
            // lblMonRentAlert
            // 
            this.lblMonRentAlert.AutoSize = true;
            this.lblMonRentAlert.Location = new System.Drawing.Point(297, 15);
            this.lblMonRentAlert.Name = "lblMonRentAlert";
            this.lblMonRentAlert.Size = new System.Drawing.Size(0, 15);
            this.lblMonRentAlert.TabIndex = 2;
            // 
            // txbMonRent
            // 
            this.txbMonRent.Location = new System.Drawing.Point(162, 12);
            this.txbMonRent.Name = "txbMonRent";
            this.txbMonRent.Size = new System.Drawing.Size(121, 23);
            this.txbMonRent.TabIndex = 1;
            this.txbMonRent.TextChanged += new System.EventHandler(this.txbMonRent_TextChanged);
            // 
            // lblMonRent
            // 
            this.lblMonRent.AutoSize = true;
            this.lblMonRent.Location = new System.Drawing.Point(8, 15);
            this.lblMonRent.Name = "lblMonRent";
            this.lblMonRent.Size = new System.Drawing.Size(133, 15);
            this.lblMonRent.TabIndex = 0;
            this.lblMonRent.Text = "Monthly rental amount:";
            // 
            // btnCheckBud
            // 
            this.btnCheckBud.Location = new System.Drawing.Point(549, 551);
            this.btnCheckBud.Name = "btnCheckBud";
            this.btnCheckBud.Size = new System.Drawing.Size(120, 34);
            this.btnCheckBud.TabIndex = 28;
            this.btnCheckBud.Text = "Check Budget";
            this.btnCheckBud.UseVisualStyleBackColor = true;
            this.btnCheckBud.Click += new System.EventHandler(this.btnCheckBud_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(85, 77);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(64, 15);
            this.lblFullName.TabIndex = 29;
            this.lblFullName.Text = "Full Name:";
            this.lblFullName.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txbFullName
            // 
            this.txbFullName.Location = new System.Drawing.Point(164, 74);
            this.txbFullName.Name = "txbFullName";
            this.txbFullName.Size = new System.Drawing.Size(124, 23);
            this.txbFullName.TabIndex = 30;
            this.txbFullName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbReport
            // 
            this.txbReport.Location = new System.Drawing.Point(713, 552);
            this.txbReport.Name = "txbReport";
            this.txbReport.Size = new System.Drawing.Size(120, 33);
            this.txbReport.TabIndex = 31;
            this.txbReport.Text = "Report";
            this.txbReport.UseVisualStyleBackColor = true;
            this.txbReport.Click += new System.EventHandler(this.txbReport_Click);
            // 
            // lblFullNameAlert
            // 
            this.lblFullNameAlert.AutoSize = true;
            this.lblFullNameAlert.Location = new System.Drawing.Point(294, 77);
            this.lblFullNameAlert.Name = "lblFullNameAlert";
            this.lblFullNameAlert.Size = new System.Drawing.Size(0, 15);
            this.lblFullNameAlert.TabIndex = 32;
            // 
            // txbOutput
            // 
            this.txbOutput.Location = new System.Drawing.Point(455, 74);
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.Size = new System.Drawing.Size(452, 449);
            this.txbOutput.TabIndex = 33;
            this.txbOutput.Text = "";
            // 
            // BudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 616);
            this.Controls.Add(this.txbOutput);
            this.Controls.Add(this.lblFullNameAlert);
            this.Controls.Add(this.txbReport);
            this.Controls.Add(this.txbFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnCheckBud);
            this.Controls.Add(this.pnlRentProperty);
            this.Controls.Add(this.pnlBuyProperty);
            this.Controls.Add(this.lblOtherAlert);
            this.Controls.Add(this.lblCellTellAlert);
            this.Controls.Add(this.lblTravelCostAlert);
            this.Controls.Add(this.lblWaterLightsAlert);
            this.Controls.Add(this.lblGroceriesAlert);
            this.Controls.Add(this.lblMonthlyDeductAlert);
            this.Controls.Add(this.txbOther);
            this.Controls.Add(this.txbCellTell);
            this.Controls.Add(this.txbTravel);
            this.Controls.Add(this.txbWaterLights);
            this.Controls.Add(this.txbGroc);
            this.Controls.Add(this.txbTaxDed);
            this.Controls.Add(this.lblFormHeader);
            this.Controls.Add(this.pnlProperty);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.lblCellTell);
            this.Controls.Add(this.lblTravelCost);
            this.Controls.Add(this.lblWaterLights);
            this.Controls.Add(this.lblGroceries);
            this.Controls.Add(this.lblMonthlyDeduct);
            this.Controls.Add(this.lblGrossInc);
            this.Controls.Add(this.txbGrossMonInc);
            this.Controls.Add(this.lblGrossIncAlert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BudgetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlProperty.ResumeLayout(false);
            this.pnlProperty.PerformLayout();
            this.pnlBuyProperty.ResumeLayout(false);
            this.pnlBuyProperty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonRepay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterestRate)).EndInit();
            this.pnlRentProperty.ResumeLayout(false);
            this.pnlRentProperty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrossIncAlert;
        private System.Windows.Forms.TextBox txbGrossMonInc;
        private System.Windows.Forms.Label lblGrossInc;
        private System.Windows.Forms.Label lblMonthlyDeduct;
        private System.Windows.Forms.Label lblGroceries;
        private System.Windows.Forms.Label lblWaterLights;
        private System.Windows.Forms.Label lblTravelCost;
        private System.Windows.Forms.Label lblCellTell;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.RadioButton rbRent;
        private System.Windows.Forms.RadioButton rbBuy;
        private System.Windows.Forms.Panel pnlProperty;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.TextBox txbTaxDed;
        private System.Windows.Forms.TextBox txbGroc;
        private System.Windows.Forms.TextBox txbWaterLights;
        private System.Windows.Forms.TextBox txbTravel;
        private System.Windows.Forms.TextBox txbCellTell;
        private System.Windows.Forms.TextBox txbOther;
        private System.Windows.Forms.Label lblMonthlyDeductAlert;
        private System.Windows.Forms.Label lblGroceriesAlert;
        private System.Windows.Forms.Label lblWaterLightsAlert;
        private System.Windows.Forms.Label lblTravelCostAlert;
        private System.Windows.Forms.Label lblCellTellAlert;
        private System.Windows.Forms.Label lblOtherAlert;
        private System.Windows.Forms.Panel pnlBuyProperty;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblTotDeposit;
        private System.Windows.Forms.Label lblPropertyPrice;
        private System.Windows.Forms.TextBox txbTotDeposit;
        private System.Windows.Forms.TextBox txbPropPrice;
        private System.Windows.Forms.Label lblMonRepay;
        private System.Windows.Forms.Label lblPropertyPriceAlert;
        private System.Windows.Forms.Label lblMonRepayAlert;
        private System.Windows.Forms.Label lblInterestRateAlert;
        private System.Windows.Forms.Label lblTotDepositAlert;
        private System.Windows.Forms.Panel pnlRentProperty;
        private System.Windows.Forms.Label lblMonRentAlert;
        private System.Windows.Forms.TextBox txbMonRent;
        private System.Windows.Forms.Label lblMonRent;
        private System.Windows.Forms.Button btnCheckBud;
        private System.Windows.Forms.NumericUpDown numericUpDownInterestRate;
        private System.Windows.Forms.NumericUpDown numericUpDownMonRepay;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txbFullName;
        private System.Windows.Forms.Button txbReport;
        private System.Windows.Forms.Label lblFullNameAlert;
        private System.Windows.Forms.RichTextBox txbOutput;
    }
}

