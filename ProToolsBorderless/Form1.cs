using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ProToolsBorderless
{
    public partial class Form1 : Form
    {
        private int waitTimeInSec = 3;
        private const int waitTimeInSecConst = 3;
        private bool captureEditWndButtonPressed = false;
        private bool editWindowTitleBarRemoved = false;
        private bool captureMixWndButtonPressed = false;
        private bool mixWindowTitleBarRemoved = false;
        private bool hideTitleBarButtonPressed = false;
        private bool hideMenuBarButtonPressed = false;
        private bool hideBothBarButtonPressed = false;
        private IntPtr mainWindow_hWnd;
        private IntPtr editWindow_hWnd;
        private IntPtr mixWindow_hWnd;
        private ProToolsWindowManager proToolsWindowManager = new ProToolsWindowManager();
        private BackgroundWorker backgroundWorker = new BackgroundWorker();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            backgroundWorker.DoWork += (obj, ea) => WorkerCheckProTools();
            backgroundWorker.RunWorkerAsync();
            backgroundWorker.RunWorkerCompleted += (obj, ea) =>
            {
                waitingBlock.Visible = false;

                string reportMainWindowTitle = proToolsWindowManager.GetWindowTitle(mainWindow_hWnd);

                string reportMainWindowProcessID = "" + proToolsWindowManager.GetWindowPID(mainWindow_hWnd);

                mainWindowInfoLabel.Text = "Window with the title \"" + reportMainWindowTitle + "\" and the PID of \"" + reportMainWindowProcessID + "\" is captured.";
            };
            backgroundWorker.Dispose();
        }

        private void WorkerCheckProTools()
        {
            mainWindow_hWnd = proToolsWindowManager.LookForTheProTools();
        }

        private void captureEditWndButton_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                captureEditWndButtonPressed = true;

                editWndButton.Enabled = false;

                captureMixWndButton.Enabled = false;

                captureEditWndButton.ForeColor = SystemColors.ControlText;
                captureEditWndButton.Text = "CAPTURE: " + waitTimeInSec;

                timer1.Enabled = true;
            }
            else
            {
                captureEditWndButtonPressed = false;

                captureMixWndButton.Enabled = true;

                captureEditWndButton.ForeColor = Color.FromArgb(255, 173, 104, 6);
                captureEditWndButton.Text = "CANCELLED BY USER";

                waitTimeInSec = waitTimeInSecConst;
                timer1.Stop();
            }
        }

        private void editWndButton_Click(object sender, EventArgs e)
        {
            if (!editWindowTitleBarRemoved)
            {
                editWindowTitleBarRemoved = true;

                proToolsWindowManager.childWindowsReStyle(editWindow_hWnd);

                editWndButton.Text = "REVERT CHANGES";
            }
            else
            {
                editWindowTitleBarRemoved = false;

                proToolsWindowManager.RevertChildWindowsStyle(editWindow_hWnd);

                editWndButton.Text = "MAKE BORDERLESS";
            }

        }

        private void captureMixWndButton_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                captureMixWndButtonPressed = true;

                mixWndButton.Enabled = false;

                captureEditWndButton.Enabled = false;

                captureMixWndButton.ForeColor = SystemColors.ControlText;
                captureMixWndButton.Text = "CAPTURE: " + waitTimeInSec;

                timer1.Enabled = true;
            }
            else
            {
                captureMixWndButtonPressed = false;

                captureEditWndButton.Enabled = true;

                captureMixWndButton.ForeColor = Color.FromArgb(255, 173, 104, 6);
                captureMixWndButton.Text = "CANCELLED BY USER";

                waitTimeInSec = waitTimeInSecConst;
                timer1.Stop();
            }
        }

        private void mixWndButton_Click(object sender, EventArgs e)
        {
            if (!mixWindowTitleBarRemoved)
            {
                mixWindowTitleBarRemoved = true;

                proToolsWindowManager.childWindowsReStyle(mixWindow_hWnd);

                mixWndButton.Text = "REVERT CHANGES";
            }
            else
            {
                mixWindowTitleBarRemoved = false;

                proToolsWindowManager.RevertChildWindowsStyle(mixWindow_hWnd);

                mixWndButton.Text = "MAKE BORDERLESS";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (waitTimeInSec > 1)
            {
                if (captureEditWndButtonPressed)
                {
                    waitTimeInSec--;
                    captureEditWndButton.Text = "CAPTURE: " + waitTimeInSec;
                }
                else if (captureMixWndButtonPressed)
                {
                    waitTimeInSec--;
                    captureMixWndButton.Text = "CAPTURE: " + waitTimeInSec;
                }
            }
            else
            {
                if (captureEditWndButtonPressed)
                {
                    object[] capturedWindowData = proToolsWindowManager.CaptureWindowsStyle();

                    if ((bool)capturedWindowData[1])
                    {
                        editWindow_hWnd = (IntPtr)capturedWindowData[0];

                        editWndButton.Enabled = true;

                        string reportWindowTitle = proToolsWindowManager.GetWindowTitle(editWindow_hWnd);

                        captureEditWndButton.ForeColor = Color.FromArgb(255, 35, 120, 4);
                        captureEditWndButton.Text = "Captured: \"" + reportWindowTitle + "\"";
                    }
                    else
                    {
                        editWindow_hWnd = (IntPtr)capturedWindowData[0];

                        editWndButton.Enabled = false;

                        string reportWindowTitle = proToolsWindowManager.GetWindowTitle(editWindow_hWnd);

                        captureEditWndButton.ForeColor = Color.FromArgb(255, 168, 7, 26);
                        captureEditWndButton.Text = "Wrong: \"" + reportWindowTitle + "\"";
                    }

                    captureEditWndButtonPressed = false;

                    captureMixWndButton.Enabled = true;

                    mainWindow_hWnd = (IntPtr)capturedWindowData[2];

                    string reportMainWindowTitle = proToolsWindowManager.GetWindowTitle(mainWindow_hWnd);

                    string reportMainWindowProcessID = "" + proToolsWindowManager.GetWindowPID(mainWindow_hWnd);

                    mainWindowInfoLabel.Text = "Window with the title \"" + reportMainWindowTitle + "\" and the PID of \"" + reportMainWindowProcessID + "\" is recaptured.";

                    waitTimeInSec = waitTimeInSecConst;
                    timer1.Stop();
                }
                else if (captureMixWndButtonPressed)
                {
                    object[] capturedWindowData = proToolsWindowManager.CaptureWindowsStyle();

                    if ((bool)capturedWindowData[1])
                    {
                        mixWindow_hWnd = (IntPtr)capturedWindowData[0];

                        mixWndButton.Enabled = true;

                        string reportWindowTitle = proToolsWindowManager.GetWindowTitle(mixWindow_hWnd);

                        captureMixWndButton.ForeColor = Color.FromArgb(255, 35, 120, 4);
                        captureMixWndButton.Text = "Captured: \"" + reportWindowTitle + "\"";
                    }
                    else
                    {
                        mixWindow_hWnd = (IntPtr)capturedWindowData[0];

                        mixWndButton.Enabled = false;

                        string reportWindowTitle = proToolsWindowManager.GetWindowTitle(mixWindow_hWnd);

                        captureMixWndButton.ForeColor = Color.FromArgb(255, 168, 7, 26);
                        captureMixWndButton.Text = "Wrong: \"" + reportWindowTitle + "\"";
                    }

                    captureMixWndButtonPressed = false;

                    captureEditWndButton.Enabled = true;

                    mainWindow_hWnd = (IntPtr)capturedWindowData[2];

                    string reportMainWindowTitle = proToolsWindowManager.GetWindowTitle(mainWindow_hWnd);

                    string reportMainWindowProcessID = "" + proToolsWindowManager.GetWindowPID(mainWindow_hWnd);

                    mainWindowInfoLabel.Text = "Window with the title \"" + reportMainWindowTitle + "\" and the PID of \"" + reportMainWindowProcessID + "\" is recaptured.";

                    waitTimeInSec = waitTimeInSecConst;
                    timer1.Stop();
                }
            }
        }

        //MAIN WINDOW
        private void hideTitleBarButton_Click(object sender, EventArgs e)
        {
            if (hideTitleBarButtonPressed)
            {
                hideTitleBarButtonPressed = false;

                if (!hideMenuBarButtonPressed && !hideTitleBarButtonPressed)
                {
                    hideBothButton.Enabled = true;
                }

                proToolsWindowManager.RevertMainWindowTitleBar();
                hideTitleBarButton.Text = "HIDE THE TITLE BAR";
            }
            else
            {
                hideTitleBarButtonPressed = true;

                hideBothButton.Enabled = false;

                proToolsWindowManager.RemoveMainWindowTitleBar();
                hideTitleBarButton.Text = "REVERT THE TITLE BAR";
            }
        }

        private void hideMenuBarButton_Click(object sender, EventArgs e)
        {
            if (hideMenuBarButtonPressed)
            {
                hideMenuBarButtonPressed = false;

                if (!hideMenuBarButtonPressed && !hideTitleBarButtonPressed)
                {
                    hideBothButton.Enabled = true;
                }

                proToolsWindowManager.RevertMainWindowMenuBar();
                hideMenuBarButton.Text = "HIDE THE MENU BAR";
            }
            else
            {
                hideMenuBarButtonPressed = true;

                hideBothButton.Enabled = false;

                proToolsWindowManager.RemoveMainWindowMenuBar();
                hideMenuBarButton.Text = "REVERT THE MENU BAR";
            }

            /*proToolsWindowManager.createWindow();*/
        }

        private void hideBothButton_Click(object sender, EventArgs e)
        {
            if (hideBothBarButtonPressed)
            {
                hideBothBarButtonPressed = false;

                hideTitleBarButton.Enabled = true;
                hideMenuBarButton.Enabled = true;

                proToolsWindowManager.RevertMainWindowTitleBar();
                proToolsWindowManager.RevertMainWindowMenuBar();

                hideBothButton.Text = "HIDE THE BOTH BARS";
            }
            else
            {
                hideBothBarButtonPressed = true;

                hideTitleBarButton.Enabled = false;
                hideMenuBarButton.Enabled = false;

                proToolsWindowManager.RemoveMainWindowTitleBar();
                proToolsWindowManager.RemoveMainWindowMenuBar();
                hideBothButton.Text = "REVERT THE BOTH BARS";
            }
        }
    }
}
