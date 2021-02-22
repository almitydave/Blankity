using System.Drawing;
using System.Windows.Forms;

namespace Blankity
{
    public partial class frmBlank : Form
    {
        private frmMain owner;

        //Static factory method to create blanking windows.
        public static frmBlank CreateScreenBlanker(int screenNumber, frmMain owner)
        {
            //Create a blanking form and return it to the caller
            frmBlank frm = new frmBlank(screenNumber, owner);
            frm.Show(owner);    //Setting the owner here prevents the blanking windows from showing up in ALT+TAB
            return frm;
        }

        //Constructor
        public frmBlank(int screenNumber, frmMain owner)
        {
            InitializeComponent();

            //Set this window's location and size to the bounds of the specified screen
            Rectangle r = Screen.AllScreens[screenNumber].Bounds;
            this.Bounds = r;

            //Remember who made us, so we can tell them to close all the blanking screens
            this.owner = owner;
        }

        //When the user clicks the mouse on any blanking screen, tell the main form to close all of them
        private void frmBlank_MouseUp(object sender, MouseEventArgs e)
        {
            owner.UnblankAll();
            //Close();      Don't do this, wait for the owner to close all of them at the same time (looks better)
        }
    }
}
