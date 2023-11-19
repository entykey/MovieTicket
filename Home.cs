namespace MovieTicket
{
    using System;
    using System.Drawing;
    using System.Media;
    using System.Windows.Forms;
    using AppContext = Models.AppContext;


    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        protected StatusBar mainStatusBar = new StatusBar();
        protected StatusBarPanel statusPanel = new StatusBarPanel();
        protected StatusBarPanel datetimePanel = new StatusBarPanel();

        #region Form methods
        private void Home_Load(object sender, EventArgs e)
        {
            this.Size = new Size(920, 660);
            SoundPlayer splayer = new SoundPlayer(@"C:\Windows\Media\Windows Logon.wav");
            splayer.Play();
            CreateStatusBar();
        }
        
        private void CreateStatusBar()
        {
            // Set first panel properties and add to StatusBar  
            statusPanel.BorderStyle = StatusBarPanelBorderStyle.Sunken;

            if (AppContext.CurrentUser != null)
            {
                statusPanel.Text = $"Logged in as: {AppContext.CurrentUser.UserName}, Roles: {string.Join(", ", AppContext.Roles)}";
            }
            else
            {
                statusPanel.Text = "Unidentified user.";
            }

            statusPanel.ToolTipText = "Last Activity";
            statusPanel.AutoSize = StatusBarPanelAutoSize.Spring;
            mainStatusBar.Panels.Add(statusPanel);

            // Set second panel properties and add to StatusBar  
            datetimePanel.BorderStyle = StatusBarPanelBorderStyle.Raised;

            datetimePanel.ToolTipText = "DateTime: " + System.DateTime.Today.ToString();
            datetimePanel.Text = System.DateTime.Today.ToLongDateString();
            datetimePanel.AutoSize = StatusBarPanelAutoSize.Contents;
            mainStatusBar.Panels.Add(datetimePanel);
            mainStatusBar.ShowPanels = true;

            // Add StatusBar to Form controls  
            this.Controls.Add(mainStatusBar);
        }
        #endregion



        #region buttons events
        private void btnBanVe_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Windows\Media\Windows Foreground.wav"); // SoundPlayer splayer = new SoundPlayer(@"C:\Users\jeevan\Desktop\11.wav")
            splayer.Play();

            if (!panelMain.Controls.Contains(ucBooking.Instance))
            {

                panelMain.Controls.Add(ucBooking.Instance);
                ucBooking.Instance.Dock = DockStyle.Fill;
                ucBooking.Instance.BringToFront();
            }
            else
            {
                ucBooking.Instance.BringToFront();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Windows\Media\Windows Foreground.wav"); // SoundPlayer splayer = new SoundPlayer(@"C:\Users\jeevan\Desktop\11.wav")
            splayer.Play();

            panelMain.Controls.Clear();
        }

        private void btnPhim_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Windows\Media\Windows Foreground.wav"); // SoundPlayer splayer = new SoundPlayer(@"C:\Users\jeevan\Desktop\11.wav")
            splayer.Play();

            if (!panelMain.Controls.Contains(ucMovies.Instance))
            {

                panelMain.Controls.Add(ucMovies.Instance);
                ucMovies.Instance.Dock = DockStyle.Fill;
                ucMovies.Instance.BringToFront();
            }
            else
            {
                ucMovies.Instance.BringToFront();
            }
        }

        private void btnShows_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Windows\Media\Windows Foreground.wav"); // SoundPlayer splayer = new SoundPlayer(@"C:\Users\jeevan\Desktop\11.wav")
            splayer.Play();

            if (!panelMain.Controls.Contains(ucShows.Instance))
            {

                panelMain.Controls.Add(ucShows.Instance);
                ucShows.Instance.Dock = DockStyle.Fill;
                ucShows.Instance.BringToFront();
            }
            else
            {
                ucShows.Instance.BringToFront();
            }
        }
        private void btnRoles_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Windows\Media\Windows Foreground.wav"); // SoundPlayer splayer = new SoundPlayer(@"C:\Users\jeevan\Desktop\11.wav")
            splayer.Play();

            if (!panelMain.Controls.Contains(ucRoles.Instance))
            {

                panelMain.Controls.Add(ucRoles.Instance);
                ucRoles.Instance.Dock = DockStyle.Fill;
                ucRoles.Instance.BringToFront();
            }
            else
            {
                ucRoles.Instance.BringToFront();
            }
        }
        private void btnAssignRole_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Windows\Media\Windows Foreground.wav"); // SoundPlayer splayer = new SoundPlayer(@"C:\Users\jeevan\Desktop\11.wav")
            splayer.Play();

            if (!panelMain.Controls.Contains(ucAssignRole.Instance))
            {

                panelMain.Controls.Add(ucAssignRole.Instance);
                ucAssignRole.Instance.Dock = DockStyle.Fill;
                ucAssignRole.Instance.BringToFront();
            }
            else
            {
                ucAssignRole.Instance.BringToFront();
            }
        }

        private void btnCreateStaffAccount_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Windows\Media\Windows Foreground.wav"); // SoundPlayer splayer = new SoundPlayer(@"C:\Users\jeevan\Desktop\11.wav")
            splayer.Play();

            if (!panelMain.Controls.Contains(ucCreateStaffAccount.Instance))
            {

                panelMain.Controls.Add(ucCreateStaffAccount.Instance);
                ucCreateStaffAccount.Instance.Dock = DockStyle.Fill;
                ucCreateStaffAccount.Instance.BringToFront();
            }
            else
            {
                ucCreateStaffAccount.Instance.BringToFront();
            }
        }

        #endregion


    }
}
