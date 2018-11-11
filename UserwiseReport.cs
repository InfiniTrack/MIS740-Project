using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace infiniTrack
{
    public partial class frmUserwiseReport : Form
    {
        public frmUserwiseReport()
        {
            InitializeComponent();
        }

        infiniTrack.Navigation navigation = new Navigation();
        infiniTrack.TitleBar titleBar = new TitleBar();

        private void frmUserwiseReport_Load(object sender, EventArgs e)
        {
            pnlMenuDescription.Hide();
            pnlMenuDescription.Width = 204;
            string iconsDirectory = Directory.GetCurrentDirectory() + "\\icons\\";
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            btnClose.Image = Image.FromFile(iconsDirectory + "close.png");
            btnMax.Image = Image.FromFile(iconsDirectory + "max.png");
            btnMin.Image = Image.FromFile(iconsDirectory + "min.png");
            picLogo.ImageLocation = iconsDirectory + "logo.png";
            btnHome.Image = Image.FromFile(iconsDirectory + "home.png");
            btnReport.Image = Image.FromFile(iconsDirectory + "report.png");
            picHorizontalLine.ImageLocation = iconsDirectory + "horizontalline.png";
            btnUser.Image = Image.FromFile(iconsDirectory + "user.png");
            picVerticalLine.Image = Image.FromFile(iconsDirectory + "verticalline.png");
            toolTipUserwiseReport.SetToolTip(btnClose, "Close");
            toolTipUserwiseReport.SetToolTip(btnMax, "Restore");
            toolTipUserwiseReport.SetToolTip(btnMin, "Minimize");
            toolTipUserwiseReport.SetToolTip(btnHome, "Home");
            toolTipUserwiseReport.SetToolTip(btnReport, "Report");
            toolTipUserwiseReport.SetToolTip(btnUser, "Employee/Customer/Vendor");
        }

        private void titleBar_Controls(object sender, EventArgs e)
        {
            if (sender == btnClose)
            {
                titleBar.Close();
            }
            else if (sender == btnMax)
            {
                titleBar.Maximize(this);
            }
            else if (sender == btnMin)
            {
                titleBar.Minimize(this);
            }
        }

        private void pnlMenu_Click(object sender, EventArgs e)
        {
            if (sender == btnHome)
            {
                navigation.Navigate(this, "Dashboard");
            }
            else
            {
                if (pnlMenuDescription.Visible == false)
                {
                    Load_MenuDescription(sender);
                    pnlMenuDescription.Show();
                }
                else if (pnlMenuDescription.Visible == true)
                {
                    pnlMenuDescription.Hide();
                    lstMenuDescription.Items.Clear();
                }
            }
        }

        private void Load_MenuDescription(object sender)
        {
            if (sender == btnUser)
            {
                lstMenuDescription.Items.Add("Add/Update Employee");
                lstMenuDescription.Items.Add("");
                lstMenuDescription.Items.Add("Add/Update Customer");
                lstMenuDescription.Items.Add("");
                lstMenuDescription.Items.Add("Add/Update Vendor");
            }
            else if (sender == btnReport)
            {
                lstMenuDescription.Items.Add("Project Wise Report");
                lstMenuDescription.Items.Add("");
                lstMenuDescription.Items.Add("User Wise Report");
            }
        }

        private void frmUserwiseReport_Click(object sender, EventArgs e)
        {
            pnlMenuDescription.Hide();
            lstMenuDescription.Items.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Today;
            dtpEnd.Value = DateTime.Today;
        }

        private void lstMenuDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMenuDescription.SelectedItem.ToString() != "User Wise Report")
            {
                navigation.Navigate(this, lstMenuDescription.SelectedItem.ToString());
            }
            pnlMenuDescription.Hide();
            lstMenuDescription.Items.Clear();
        }
    }
}
