/*Programmer: Luis Moller
 * Program: Joe's Automative Receipt
 * Purpose: To calculate a receipt based on different inputs
 * Date: 11/1/2018
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4_2_
{
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            // Declare area for Car brands to display in cmbCarBrands
            string[] carBrand =
                {"Acura", "Alfa Romeo", "Aston Martin", "Audi", "Bentley", "BMW",
                "Bugatti", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Citroen",
                "Dodge", "Ferrari", "Fiat", "Ford", "GMC", "Honda", "Infiniti", "Jaguar", "Jeep", "Lamborghini",
                "Land Rover", "Lexus", "Maserati", "Mazda", "McLaren", "Mercedes-Benz", "Mini", "Mitsubishi", "Nissan",
                "Peugeot", "Porsche", "Ram", "Renault", "Rolls Royce", "Saab", "Subaru", "Suzuki",
                "Tesla", "Toyota", "Volkswagen", "Volvo"};
            //add an item to cmbCarBrand combo box for every brand in carBrand Array
            foreach (string brand in carBrand)
                cmbCarBrand.Items.Add(brand);

           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //change SelectedItems in combo boxes to null, checked boxes to false, and text to null
            cmbCarBrand.SelectedItem = null;
            rdb10.Checked = false;
            rdb20.Checked = false;
            chkExpeditedService.Checked = false;
            chkInspection.Checked = false;
            chkLubeJob.Checked = false;
            chkMufflerReplacement.Checked = false;
            chkOilChange.Checked = false;
            chkRadiatorFlush.Checked = false;
            chkTireRotation.Checked = false;
            chkTranFlush.Checked = false;
            chkNonRoutine.Checked = false;
            txtPartsCost.Text = "";
            lblResult.Text = "";
            hsbHours.Value = 0;
            lblHourAmount.Text = "0";
                    
        }
        private double GetDiscountAmount(string selectedBrand) //method to return whether selected brand is a discount brand or not
        {
            //array of brands with discounts
            string[] contractBrands =
                {"Acura", "Honda", "Infiniti", "Lexus", "Mazda", "Mitsubishi", "Nissan", "Subaru", "Suzuki", "Toyota"};
            //check for each brand in contractBrands array whether any are equal to selected brand, if any are return bool as true else return bool as false
            double loopResult = 0;
            foreach (string discountBrand in contractBrands)
                if (selectedBrand == discountBrand)
                {
                    loopResult += .05;
                }
                else
                        loopResult += 0;
            return loopResult;
                     
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit the application
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare constants for value of services and fees
            const double LABORRATE = 20;
            const double EXPEDITEDFEE = 200;
            const double CONTRACTDISCOUNT = .05;
            const double OILCHANGE = 26;
            const double LUBEJOB = 18;
            const double RADIATORFLUSH = 30;
            const double TRANSMISSIONFLUSH = 80;
            const double INSPECTION = 15;
            const double MUFFLERREPLACEMENT = 100;
            const double TIREROTATION = 20;
            //check for selectedBrand;
            if (cmbCarBrand.SelectedItem != null)
            { 
                //declare variables for calculations
                //Variable to check if the car would get discount on non routine services
                string selectedBrand = cmbCarBrand.SelectedItem.ToString().Trim();
           
            
                double contractDiscount = GetDiscountAmount(selectedBrand);
                //other variables
                double totalAmount = 0;
                double contractDiscountAmount;
                double otherDiscountRate = 0;
                double otherDiscountAmount;
                double nonRoutineLaborCost;
                double partsCost;
                double partDiscount = 0;
                double laborHours;
                string result = "";

                //Begin Calculations for total;
                if (chkInspection.Checked == true)
                {
                    totalAmount += INSPECTION;
                    result += "Inspection".PadRight(30, ' ') + "\t" + INSPECTION.ToString("C2").PadLeft(6, ' ') + "\n";
                }
                if (chkLubeJob.Checked == true)
                {
                    totalAmount += LUBEJOB;
                    result += "Lube Job".PadRight(30, ' ') + "\t" + LUBEJOB.ToString("C2").PadLeft(6, ' ') + "\n";
                }
                if (chkMufflerReplacement.Checked == true)
                {
                    totalAmount += MUFFLERREPLACEMENT;
                    result += "Muffler Replacement".PadRight(30, ' ') + "\t" + MUFFLERREPLACEMENT.ToString("C2").PadLeft(6, ' ') + "\n";
                }
                if (chkOilChange.Checked == true)
                {
                    totalAmount += OILCHANGE;
                    result += "Oil Change".PadRight(30, ' ') + "\t" + OILCHANGE.ToString("C2").PadLeft(6, ' ') + "\n";
                }
                if (chkRadiatorFlush.Checked == true)
                {
                    totalAmount += RADIATORFLUSH;
                    result += "Radiator Flush".PadRight(30, ' ') + "\t" + MUFFLERREPLACEMENT.ToString("C2").PadLeft(6, ' ') + "\n";
                }
                if (chkTireRotation.Checked == true)
                {
                    totalAmount += TIREROTATION;
                    result += "Tire Rotation".PadRight(30, ' ') + "\t" + TIREROTATION.ToString("C2").PadLeft(6, ' ') + "\n";
                }
                if (chkTranFlush.Checked == true)
                {
                    totalAmount += TRANSMISSIONFLUSH;
                    result += "Transmission Flush".PadRight(30, ' ') + "\t" + TRANSMISSIONFLUSH.ToString("C2").PadLeft(6, ' ') + "\n";
                }
                //Cost of Non Routine Serivices
                if (chkNonRoutine.Checked == true)
                {
                    if (!(txtPartsCost.Text == "") && !(hsbHours.Value == 0))
                    {
                        laborHours = hsbHours.Value;
                        partsCost = double.Parse(txtPartsCost.Text);
                        nonRoutineLaborCost = laborHours * LABORRATE;
                        result += "Cost of Parts".PadRight(30, ' ') + "\t" + partsCost.ToString("C2").PadLeft(6, ' ') + "\n";
                        if (contractDiscount != 0)
                        {
                            partDiscount = partsCost * CONTRACTDISCOUNT;
                            result += "Parts Discount".PadRight(30, ' ') + "\t" + "-" + partDiscount.ToString("C2").PadLeft(6, ' ') + "\n";
                        }
                        else
                            partDiscount = 0;
                        result += "Cost of Labor".PadRight(30, ' ') + "\t" + nonRoutineLaborCost.ToString("C2").PadLeft(6, ' ') + "\n";

                        totalAmount += partsCost + nonRoutineLaborCost - partDiscount;
                    }
                    else
                    {
                        MessageBox.Show("Please enter cost of Parts and the amount of Labor Hours to complete",
                            "Missing Data",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                if (chkExpeditedService.Checked == true)
                {
                    totalAmount += EXPEDITEDFEE;
                    result += "Expedited Service Fee".PadRight(30, ' ') + "\t" + EXPEDITEDFEE.ToString("C2").PadLeft(6, ' ') + "\n";
                }
                if (rdb10.Checked == true && rdb20.Checked == true)
                {
                    MessageBox.Show("You have selected both the discount option. Only one discount can be given at a time.",
                        "Discount Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    if (rdb10.Checked == true)
                    {
                        otherDiscountRate = .10;
                        otherDiscountAmount = -(totalAmount * otherDiscountRate);
                        totalAmount += otherDiscountAmount;
                        result += "Other Discount".PadRight(30, ' ') + "\t" + otherDiscountAmount.ToString("C2").PadLeft(6, ' ') + "\n";

                    }
                    if (rdb20.Checked == true)
                    {
                        otherDiscountRate = .20;
                        otherDiscountAmount = -(totalAmount * otherDiscountRate);
                        totalAmount += otherDiscountAmount;
                        result += "Other Discount".PadRight(30, ' ') + "\t" + otherDiscountAmount.ToString("C2").PadLeft(6, ' ') + "\n";
                    }
                }
                



                //display results
                lblResult.Text = result + "Total".PadRight(30, ' ') + "\t" + totalAmount.ToString("C2").PadLeft(6, ' ');
            }
            else
            {//error messsage if car brand is not selected
                MessageBox.Show("Please Select a Car Brand"
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void hsbHours_Scroll(object sender, ScrollEventArgs e)
        {//lable event for hours scroll bar
            lblHourAmount.Text = hsbHours.Value.ToString();
        }

        private void cmbCarBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Status and Text change event to clear results
            lblResult.Text = null;
        }

        private void txtPartsCost_KeyPress(object sender, KeyPressEventArgs e)
        {//allow only numbers, controls, and keys
            if (!(char.IsNumber(e.KeyChar)) &
                !(char.IsControl(e.KeyChar)) &
                (e.KeyChar != '.'))
                //cancel the key
                e.Handled = true;
        }
    }
}
