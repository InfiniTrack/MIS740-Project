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
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
            this.Opacity = 0;
            navigation.FadeIn(this, 50);
        }

        infiniTrack.Navigation navigation = new Navigation();

        private void frmStart_Load(object sender, EventArgs e)
        {
            string iconsDirectory = Directory.GetCurrentDirectory() + "\\icons\\";
            picLogo.ImageLocation = iconsDirectory + "start.png";
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            tmrStart.Enabled = true;
        }

        private void tmrStart_Tick(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
            tmrStart.Enabled = false;
        }
    }
}
