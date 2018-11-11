using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace infiniTrack
{
    class Navigation
    {

        internal async void FadeIn(Form form, int interval)
        {
            //Form is not fully invisible. Fade it in
            while (form.Opacity < 1.0)
            {
                //await task by the delay interval
                await Task.Delay(interval);
                form.Opacity += 0.05;
            }
            //Make form fully visible 
            form.Opacity = 1;
        }

        internal async void FadeOut(Form form, int interval)
        {
            //Form is fully visible. Fade it out
            while (form.Opacity > 0.0)
            {
                //await task by the delay interval
                await Task.Delay(interval);
                form.Opacity -= 0.05;
            }
            //Make form fully invisible
            form.Opacity = 0;

            //Task ClosePrevious = ClosePreviousAsync(form);
            //await ClosePrevious;

            //close the previous form.
            form.Close();
        }

        //public async Task ClosePreviousAsync(Form form)
        //{
        //    await Task.Delay(1);
        //    form.Close();
        //} 
        internal void Navigate(Form source, string menuSelection)
        { 
            FadeOut(source, 50);
            if (menuSelection == "Dashboard")
            {
                frmDashboard dashboard = new frmDashboard();
                dashboard.Show();
            }
            else if (menuSelection == "User Wise Report")
            {
                frmUserwiseReport userwiseReport = new frmUserwiseReport();
                userwiseReport.Show();
            }
            else if(menuSelection == "Project Wise Report")
            {

            }
            else if(menuSelection == "Add/Update User")
            {

            }
            else if(menuSelection == "Add/Update Client")
            {

            }
        }
    }
}
