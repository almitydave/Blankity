namespace Blankity
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstScreens = new System.Windows.Forms.CheckedListBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSelectNone = new System.Windows.Forms.Button();
            this.btnSelectCurrent = new System.Windows.Forms.Button();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.btnBlank = new System.Windows.Forms.Button();
            this.btnUnblank = new System.Windows.Forms.Button();
            this.tmrCheckBlanks = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstScreens
            // 
            this.lstScreens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstScreens.CheckOnClick = true;
            this.lstScreens.FormattingEnabled = true;
            this.lstScreens.IntegralHeight = false;
            this.lstScreens.Location = new System.Drawing.Point(12, 25);
            this.lstScreens.Name = "lstScreens";
            this.lstScreens.Size = new System.Drawing.Size(187, 111);
            this.lstScreens.TabIndex = 0;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAll.Location = new System.Drawing.Point(205, 25);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(90, 23);
            this.btnSelectAll.TabIndex = 1;
            this.btnSelectAll.Text = "Select &All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectNone.Location = new System.Drawing.Point(205, 54);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(90, 23);
            this.btnSelectNone.TabIndex = 2;
            this.btnSelectNone.Text = "Select &None";
            this.btnSelectNone.UseVisualStyleBackColor = true;
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // btnSelectCurrent
            // 
            this.btnSelectCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectCurrent.Location = new System.Drawing.Point(205, 83);
            this.btnSelectCurrent.Name = "btnSelectCurrent";
            this.btnSelectCurrent.Size = new System.Drawing.Size(90, 23);
            this.btnSelectCurrent.TabIndex = 3;
            this.btnSelectCurrent.Text = "Select &Current";
            this.btnSelectCurrent.UseVisualStyleBackColor = true;
            this.btnSelectCurrent.Click += new System.EventHandler(this.btnSelectCurrent_Click);
            // 
            // btnIdentify
            // 
            this.btnIdentify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIdentify.Location = new System.Drawing.Point(205, 112);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(90, 23);
            this.btnIdentify.TabIndex = 4;
            this.btnIdentify.Text = "&Identify";
            this.btnIdentify.UseVisualStyleBackColor = true;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // btnBlank
            // 
            this.btnBlank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBlank.Location = new System.Drawing.Point(13, 143);
            this.btnBlank.Name = "btnBlank";
            this.btnBlank.Size = new System.Drawing.Size(100, 23);
            this.btnBlank.TabIndex = 5;
            this.btnBlank.Text = "&Blank Selected";
            this.btnBlank.UseVisualStyleBackColor = true;
            this.btnBlank.Click += new System.EventHandler(this.btnBlank_Click);
            // 
            // btnUnblank
            // 
            this.btnUnblank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUnblank.Location = new System.Drawing.Point(119, 142);
            this.btnUnblank.Name = "btnUnblank";
            this.btnUnblank.Size = new System.Drawing.Size(80, 23);
            this.btnUnblank.TabIndex = 6;
            this.btnUnblank.Text = "&Unblank All";
            this.btnUnblank.UseVisualStyleBackColor = true;
            this.btnUnblank.Click += new System.EventHandler(this.btnUnblank_Click);
            // 
            // tmrCheckBlanks
            // 
            this.tmrCheckBlanks.Interval = 150;
            this.tmrCheckBlanks.Tick += new System.EventHandler(this.tmrCheckBlanks_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Detected Screens:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 172);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnblank);
            this.Controls.Add(this.btnBlank);
            this.Controls.Add(this.btnIdentify);
            this.Controls.Add(this.btnSelectCurrent);
            this.Controls.Add(this.btnSelectNone);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.lstScreens);
            this.Name = "frmMain";
            this.Text = "Blankity Blank Blank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstScreens;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnSelectNone;
        private System.Windows.Forms.Button btnSelectCurrent;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.Button btnBlank;
        private System.Windows.Forms.Button btnUnblank;
        private System.Windows.Forms.Timer tmrCheckBlanks;
        private System.Windows.Forms.Label label1;
    }
}

