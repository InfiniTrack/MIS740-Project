using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace infiniTrack
{
    class TitleBar
    {
        public void Close()
        {
            Application.Exit();
        }

        public void Maximize(Form form)
        {
            if (form.WindowState == FormWindowState.Normal)
            {
                form.WindowState = FormWindowState.Maximized;
            }
            else
            {
                form.WindowState = FormWindowState.Normal;
            }
        }

        public void Minimize(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }
    }
}
