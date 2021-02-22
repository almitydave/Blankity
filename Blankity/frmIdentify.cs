using System;
using System.Drawing;
using System.Windows.Forms;

namespace Blankity
{
    public partial class frmIdentify : Form
    {
        //Static factory method to create and return a form that shows the given number for the given amount of time, then kills itself.
        public static frmIdentify CreateIdentificationForm(int screenNumber, int milliseconds = 2000)
        {
            frmIdentify frm = new frmIdentify(screenNumber, milliseconds);
            frm.ShowIdentification();
            return frm;
        }

        //Constructor.  Default 2 seconds
        public frmIdentify(int screenNumber, int milliseconds = 2000)
        {
            InitializeComponent();

            //Get the bounds of the provided screen, and set the window location to be just off the top left corner.
            Point p = Screen.AllScreens[screenNumber].Bounds.Location;
            p.Offset(32, 32);
            this.Location = p;
            tmrAutoKill.Interval = milliseconds;

            //Set the number label to the standardized screen numbering.  Windows starts screens at 1 in its own
            // "Identify" feature, our GetScreenNumber ensures we start at one as well.  Yes, it just adds 1.
            lblNumber.Text = Utils.GetScreenNumber(screenNumber);
        }

        //Apparently they *DO* need to see our identification.
        public void ShowIdentification()
        {
            //Show ourselves (briefly)
            Show();
            tmrAutoKill.Start();
        }

        private void tmrAutoKill_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
