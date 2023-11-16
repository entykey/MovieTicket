namespace MovieTicket
{
    using System;
    using System.Drawing;
    using System.Media;
    using System.Windows.Forms;


    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Size = new Size(920, 660);
            SoundPlayer splayer = new SoundPlayer(@"C:\Windows\Media\Windows Logon.wav");
            splayer.Play();
        }

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
    }
}
