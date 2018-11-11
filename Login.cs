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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        infiniTrack.TitleBar titleBar = new TitleBar();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string iconsDirectory = Directory.GetCurrentDirectory() + "\\icons\\";
            picLogo.ImageLocation = iconsDirectory + "start.png";
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            picLine.ImageLocation = iconsDirectory + "line.png";
            btnClose.Image = Image.FromFile(iconsDirectory + "close.png");
            tooltipLogin.SetToolTip(btnClose, "Close");
            picError.ImageLocation = iconsDirectory + "error.png";
            pnlError.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            titleBar.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                if (txtUserName.Text.Trim() == "")
                {
                    errLogin.SetError(txtUserName, "Cannot be empty");
                }
                if (txtPassword.Text.Trim() == "")
                {
                    errLogin.SetError(txtPassword, "Cannot be empty");
                }
            }
            else
            {
                if (txtUserName.Text.ToLower() == "sa" & txtPassword.Text == "password-1")
                {
                    this.Hide();
                    frmDashboard dashboard = new frmDashboard();
                    dashboard.Show();
                }
                else
                {
                    pnlError.Show();
                }
            }
        }

        private void Clear_Error(object sender, EventArgs e)
        {
            pnlError.Hide();            
            errLogin.Clear();           
        }
    }
}
