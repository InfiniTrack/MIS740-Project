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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        infiniTrack.TitleBar titleBar = new TitleBar();
        infiniTrack.Navigation navigation = new Navigation();

        private void frmDashboard_Load(object sender, EventArgs e)
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
            btnProject.Image = Image.FromFile(iconsDirectory + "project.png");
            btnClock.Image = Image.FromFile(iconsDirectory + "clock.png");
            btnPower.Image = Image.FromFile(iconsDirectory + "logout.png");
            toolTipDashboard.SetToolTip(btnClose, "Close");
            toolTipDashboard.SetToolTip(btnMax, "Restore");
            toolTipDashboard.SetToolTip(btnMin, "Minimize");
            toolTipDashboard.SetToolTip(btnHome, "Home");
            toolTipDashboard.SetToolTip(btnReport, "Report");
            toolTipDashboard.SetToolTip(btnUser, "Employee/Customer/Vendor");
            toolTipDashboard.SetToolTip(btnPower, "Logout");
            toolTipDashboard.SetToolTip(btnClock, "Clock in/out");
        }

        private void titleBar_Controls(object sender, EventArgs e)
        {
            if(sender == btnClose)
            {
                titleBar.Close();
            }
            else if(sender == btnMax)
            {
                titleBar.Maximize(this);
            }
            else if(sender == btnMin)
            {
                titleBar.Minimize(this);
            }
        }

        private void pnlMenu_Click(object sender, EventArgs e)
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

        private void Load_MenuDescription(object sender)
        {
            if(sender == btnUser)
            {
                lstMenuDescription.Items.Add("Add/Update Employee");
                lstMenuDescription.Items.Add("");
                lstMenuDescription.Items.Add("Add/Update Customer");
                lstMenuDescription.Items.Add("");
                lstMenuDescription.Items.Add("Add/Update Vendor");
            }
            else if(sender == btnReport)
            {
                lstMenuDescription.Items.Add("Project Wise Report");
                lstMenuDescription.Items.Add("");
                lstMenuDescription.Items.Add("User Wise Report");
            }
        }

        private void lstMenuDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            navigation.Navigate(this, lstMenuDescription.SelectedItem.ToString());
            pnlMenuDescription.Hide();
            lstMenuDescription.Items.Clear();
        }

        private void frmDashboard_Click(object sender, EventArgs e)
        {
            pnlMenuDescription.Hide();
            lstMenuDescription.Items.Clear();
        }
    }
}
