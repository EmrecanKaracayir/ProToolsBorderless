
namespace ProToolsBorderless
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.captureEditWndButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.captureMixWndButton = new System.Windows.Forms.Button();
            this.labelChildWindowExplanation = new System.Windows.Forms.Label();
            this.editMixTitle = new System.Windows.Forms.Label();
            this.mainWindowTitle = new System.Windows.Forms.Label();
            this.hideTitleBarButton = new System.Windows.Forms.Button();
            this.hideMenuBarButton = new System.Windows.Forms.Button();
            this.hideBothButton = new System.Windows.Forms.Button();
            this.devLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.editWndButton = new System.Windows.Forms.Button();
            this.mixWndButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMainWindowExplanation = new System.Windows.Forms.Label();
            this.waitingBlock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // captureEditWndButton
            // 
            this.captureEditWndButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.captureEditWndButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.captureEditWndButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.captureEditWndButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.captureEditWndButton.Location = new System.Drawing.Point(12, 249);
            this.captureEditWndButton.Name = "captureEditWndButton";
            this.captureEditWndButton.Size = new System.Drawing.Size(296, 48);
            this.captureEditWndButton.TabIndex = 1;
            this.captureEditWndButton.Text = "CAPTURE";
            this.captureEditWndButton.UseVisualStyleBackColor = false;
            this.captureEditWndButton.Click += new System.EventHandler(this.captureEditWndButton_Click);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("SugarFont Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(250)))));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(600, 48);
            this.title.TabIndex = 4;
            this.title.Text = "Borderless Pro Tools for Windows";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // captureMixWndButton
            // 
            this.captureMixWndButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.captureMixWndButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.captureMixWndButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.captureMixWndButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.captureMixWndButton.Location = new System.Drawing.Point(316, 249);
            this.captureMixWndButton.Name = "captureMixWndButton";
            this.captureMixWndButton.Size = new System.Drawing.Size(296, 48);
            this.captureMixWndButton.TabIndex = 5;
            this.captureMixWndButton.Text = "CAPTURE";
            this.captureMixWndButton.UseVisualStyleBackColor = false;
            this.captureMixWndButton.Click += new System.EventHandler(this.captureMixWndButton_Click);
            // 
            // labelChildWindowExplanation
            // 
            this.labelChildWindowExplanation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChildWindowExplanation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(15)))), ((int)(((byte)(61)))));
            this.labelChildWindowExplanation.Font = new System.Drawing.Font("SugarFont Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelChildWindowExplanation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(194)))), ((int)(((byte)(240)))));
            this.labelChildWindowExplanation.Location = new System.Drawing.Point(12, 94);
            this.labelChildWindowExplanation.Margin = new System.Windows.Forms.Padding(3);
            this.labelChildWindowExplanation.Name = "labelChildWindowExplanation";
            this.labelChildWindowExplanation.Size = new System.Drawing.Size(600, 120);
            this.labelChildWindowExplanation.TabIndex = 6;
            this.labelChildWindowExplanation.Text = resources.GetString("labelChildWindowExplanation.Text");
            this.labelChildWindowExplanation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editMixTitle
            // 
            this.editMixTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editMixTitle.Font = new System.Drawing.Font("SugarFont Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editMixTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(72)))), ((int)(((byte)(209)))));
            this.editMixTitle.Location = new System.Drawing.Point(12, 57);
            this.editMixTitle.Margin = new System.Windows.Forms.Padding(3);
            this.editMixTitle.Name = "editMixTitle";
            this.editMixTitle.Size = new System.Drawing.Size(600, 31);
            this.editMixTitle.TabIndex = 8;
            this.editMixTitle.Text = "CHILD WINDOW SETTINGS";
            this.editMixTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainWindowTitle
            // 
            this.mainWindowTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainWindowTitle.Font = new System.Drawing.Font("SugarFont Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainWindowTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(72)))), ((int)(((byte)(209)))));
            this.mainWindowTitle.Location = new System.Drawing.Point(9, 386);
            this.mainWindowTitle.Margin = new System.Windows.Forms.Padding(3);
            this.mainWindowTitle.Name = "mainWindowTitle";
            this.mainWindowTitle.Size = new System.Drawing.Size(603, 31);
            this.mainWindowTitle.TabIndex = 9;
            this.mainWindowTitle.Text = "MAIN WINDOW SETTINGS";
            this.mainWindowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hideTitleBarButton
            // 
            this.hideTitleBarButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hideTitleBarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hideTitleBarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hideTitleBarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hideTitleBarButton.Location = new System.Drawing.Point(12, 472);
            this.hideTitleBarButton.Name = "hideTitleBarButton";
            this.hideTitleBarButton.Size = new System.Drawing.Size(296, 48);
            this.hideTitleBarButton.TabIndex = 10;
            this.hideTitleBarButton.Text = "HIDE THE TITLE BAR";
            this.hideTitleBarButton.UseVisualStyleBackColor = false;
            this.hideTitleBarButton.Click += new System.EventHandler(this.hideTitleBarButton_Click);
            // 
            // hideMenuBarButton
            // 
            this.hideMenuBarButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hideMenuBarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hideMenuBarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hideMenuBarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hideMenuBarButton.Location = new System.Drawing.Point(316, 472);
            this.hideMenuBarButton.Name = "hideMenuBarButton";
            this.hideMenuBarButton.Size = new System.Drawing.Size(296, 48);
            this.hideMenuBarButton.TabIndex = 12;
            this.hideMenuBarButton.Text = "HIDE THE MENU BAR";
            this.hideMenuBarButton.UseVisualStyleBackColor = false;
            this.hideMenuBarButton.Click += new System.EventHandler(this.hideMenuBarButton_Click);
            // 
            // hideBothButton
            // 
            this.hideBothButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hideBothButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hideBothButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hideBothButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hideBothButton.Location = new System.Drawing.Point(12, 526);
            this.hideBothButton.Name = "hideBothButton";
            this.hideBothButton.Size = new System.Drawing.Size(600, 48);
            this.hideBothButton.TabIndex = 13;
            this.hideBothButton.Text = "HIDE BOTH (MAIN WINDOW)";
            this.hideBothButton.UseVisualStyleBackColor = false;
            this.hideBothButton.Click += new System.EventHandler(this.hideBothButton_Click);
            // 
            // devLabel
            // 
            this.devLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.devLabel.Font = new System.Drawing.Font("SugarFont Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.devLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(250)))));
            this.devLabel.Location = new System.Drawing.Point(12, 595);
            this.devLabel.Margin = new System.Windows.Forms.Padding(3);
            this.devLabel.Name = "devLabel";
            this.devLabel.Size = new System.Drawing.Size(600, 36);
            this.devLabel.TabIndex = 14;
            this.devLabel.Text = "Emrecan Karaçayır - Borderless Pro Tools for Windows | Manual Version - Beta Buil" +
    "d v.0.2\r\n--- USE WITH CAUTION ---";
            this.devLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // editWndButton
            // 
            this.editWndButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.editWndButton.Enabled = false;
            this.editWndButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editWndButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editWndButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editWndButton.Location = new System.Drawing.Point(12, 303);
            this.editWndButton.Name = "editWndButton";
            this.editWndButton.Size = new System.Drawing.Size(296, 48);
            this.editWndButton.TabIndex = 15;
            this.editWndButton.Text = "MAKE BORDERLESS";
            this.editWndButton.UseVisualStyleBackColor = false;
            this.editWndButton.Click += new System.EventHandler(this.editWndButton_Click);
            // 
            // mixWndButton
            // 
            this.mixWndButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mixWndButton.Enabled = false;
            this.mixWndButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mixWndButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mixWndButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mixWndButton.Location = new System.Drawing.Point(316, 303);
            this.mixWndButton.Name = "mixWndButton";
            this.mixWndButton.Size = new System.Drawing.Size(296, 48);
            this.mixWndButton.TabIndex = 16;
            this.mixWndButton.Text = "MAKE BORDERLESS";
            this.mixWndButton.UseVisualStyleBackColor = false;
            this.mixWndButton.Click += new System.EventHandler(this.mixWndButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("SugarFont Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(72)))), ((int)(((byte)(209)))));
            this.label1.Location = new System.Drawing.Point(9, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "EDIT WINDOW SECTION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("SugarFont Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(72)))), ((int)(((byte)(209)))));
            this.label2.Location = new System.Drawing.Point(313, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "MIX WINDOW SECTION";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMainWindowExplanation
            // 
            this.labelMainWindowExplanation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMainWindowExplanation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(15)))), ((int)(((byte)(61)))));
            this.labelMainWindowExplanation.Font = new System.Drawing.Font("SugarFont Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMainWindowExplanation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(194)))), ((int)(((byte)(240)))));
            this.labelMainWindowExplanation.Location = new System.Drawing.Point(12, 423);
            this.labelMainWindowExplanation.Margin = new System.Windows.Forms.Padding(3);
            this.labelMainWindowExplanation.Name = "labelMainWindowExplanation";
            this.labelMainWindowExplanation.Size = new System.Drawing.Size(600, 40);
            this.labelMainWindowExplanation.TabIndex = 19;
            this.labelMainWindowExplanation.Text = "i. Do not close this program throughout your Pro Tools session!";
            this.labelMainWindowExplanation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // waitingBlock
            // 
            this.waitingBlock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.waitingBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(15)))), ((int)(((byte)(61)))));
            this.waitingBlock.Font = new System.Drawing.Font("SugarFont Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.waitingBlock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(72)))), ((int)(((byte)(209)))));
            this.waitingBlock.Location = new System.Drawing.Point(0, 0);
            this.waitingBlock.Margin = new System.Windows.Forms.Padding(0);
            this.waitingBlock.Name = "waitingBlock";
            this.waitingBlock.Size = new System.Drawing.Size(624, 586);
            this.waitingBlock.TabIndex = 20;
            this.waitingBlock.Text = "Waiting for the\r\nPro Tools";
            this.waitingBlock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(624, 643);
            this.Controls.Add(this.waitingBlock);
            this.Controls.Add(this.labelMainWindowExplanation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mixWndButton);
            this.Controls.Add(this.editWndButton);
            this.Controls.Add(this.devLabel);
            this.Controls.Add(this.hideBothButton);
            this.Controls.Add(this.hideMenuBarButton);
            this.Controls.Add(this.hideTitleBarButton);
            this.Controls.Add(this.mainWindowTitle);
            this.Controls.Add(this.editMixTitle);
            this.Controls.Add(this.labelChildWindowExplanation);
            this.Controls.Add(this.captureMixWndButton);
            this.Controls.Add(this.title);
            this.Controls.Add(this.captureEditWndButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borderless Pro Tools for Windows | Manual Version";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button captureEditWndButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button captureMixWndButton;
        private System.Windows.Forms.Label labelChildWindowExplanation;
        private System.Windows.Forms.Label editMixTitle;
        private System.Windows.Forms.Label mainWindowTitle;
        private System.Windows.Forms.Button hideTitleBarButton;
        private System.Windows.Forms.Button hideMenuBarButton;
        private System.Windows.Forms.Button hideBothButton;
        private System.Windows.Forms.Label devLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button editWndButton;
        private System.Windows.Forms.Button mixWndButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMainWindowExplanation;
        private System.Windows.Forms.Label waitingBlock;
    }
}

