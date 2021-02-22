using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Blankity
{
    public partial class frmMain : Form
    {
        //A map of screen indices to blanking windows
        private Dictionary<int, frmBlank> blanks = new Dictionary<int, frmBlank>();

        //A flag that can be set by a child blanking window that signals they should all be closed
        private bool closeBlanks = false;

        ////////// Constructor

        public frmMain()
        {
            InitializeComponent();
        }

        ////////// Form events

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Get a list of all screens detected by Windows
            for (int i = 0; i < Screen.AllScreens.Length; ++i)
            {
                lstScreens.Items.Add(Utils.GetScreenName(i));
                //All screens will default to checked except the primary display, the assumption being that the user
                // will most often want to blank all non-primary screens, e.g. when playing a game.
                lstScreens.SetItemChecked(i, !Screen.AllScreens[i].Primary);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //The program is being closed; first close any remaining blanking windows.
            CloseAllBlanks();
        }

        ////////// Button events

        private void btnSelectCurrent_Click(object sender, EventArgs e)
        {
            //Check the box for the screen that this window is currently displayed on
            for (int i = 0; i < Screen.AllScreens.Length; ++i)
            {
                if (Screen.AllScreens[i].Bounds.Contains(this.Location))
                {
                    lstScreens.SetItemChecked(i, true);
                }
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            //Check all screens in the list.  Probably won't be used much.
            for (int i = 0; i < lstScreens.Items.Count; ++i)
            {
                lstScreens.SetItemChecked(i, true);
            }
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            //Uncheck all the screens in the list.
            for (int i = 0; i < lstScreens.Items.Count; ++i)
            {
                lstScreens.SetItemChecked(i, false);
            }
        }

        private void btnIdentify_Click(object sender, EventArgs e)
        {
            //Show a little identification box on each screen similar to what Windows does
            // when you click "identify" on the display settings dialog.
            for (int i = 0; i < Screen.AllScreens.Length; ++i)
            {
                frmIdentify.CreateIdentificationForm(i, 2000);
            }
        }

        private void btnBlank_Click(object sender, EventArgs e)
        {
            //Blank checked screens.  First close any current blanking windows.
            CloseAllBlanks();

            //For each selected screen, create a blanking window
            foreach (int i in lstScreens.CheckedIndices)
            {
                blanks.Add(i, frmBlank.CreateScreenBlanker(i, this));
            }
            tmrCheckBlanks.Enabled = true;
            //this.Focus();     Don't do this, because then it'll put it on top of the blanking window.
        }

        private void btnUnblank_Click(object sender, EventArgs e)
        {
            //Close any blanking windows
            CloseAllBlanks();
        }

        ////////// Timer events

        private void tmrCheckBlanks_Tick(object sender, EventArgs e)
        {
            //Check to see if the flag to close all blanks has been set by one of the blanking windows, and if so close them all
            if (closeBlanks)
            {
                CloseAllBlanks();
            }
        }

        ////////// Other mehods

        //Close all blanking windows and reset variables and timers
        private void CloseAllBlanks()
        {
            //Clean up any existing blanking windows and reset the collection
            foreach (frmBlank frm in blanks.Values)
            {
                frm.Close();
                frm.Dispose();
            }
            blanks.Clear();
            closeBlanks = false;    //reset the flag
            tmrCheckBlanks.Enabled = false; //turn off the timer to that checks the flag
        }

        //Public method that sets the flag that causes all blanking windows to be closed.
        public void UnblankAll()
        {
            //Set a flag for the timer to check
            closeBlanks = true;
        }
    }
}
