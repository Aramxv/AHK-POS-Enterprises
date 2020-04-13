using System;
using System.Windows.Forms;
using System.Drawing;
namespace AHKPOSENKTHESIS
{
    public partial class Alert : Form
    {
        public Alert(string _message, AlertType type)
        {
            InitializeComponent();

            messages.Text = _message;
            switch (type)
            {
                case AlertType.critical:
                    this.BackColor = Color.FromArgb(236, 42, 61);
                    icon.Image = imageList1.Images[0];
                    break;
                case AlertType.info:
                    this.BackColor = Color.Gray;
                    icon.Image = imageList1.Images[1];
                    break;
                case AlertType.success:
                    this.BackColor = Color.SeaGreen;
                    icon.Image = imageList1.Images[2];
                    break;
                case AlertType.error:
                    this.BackColor = Color.FromArgb(255, 128, 0);
                    icon.Image = imageList1.Images[3];
                    break;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_message"></param>
        /// <param name="type"></param>
        public static void Show(string message, AlertType type)
        {
            new AHKPOSENKTHESIS.Alert(message, type).Show();
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            //set position to top left
            // this.Bottom; //* (this.Height);
            // this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 1;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width -5, Screen.PrimaryScreen.WorkingArea.Height - Height -3);

            show.Start();
        }

        public enum AlertType
        {
            success, info, critical, error
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            closealert.Start();
        }

        private void timeout_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        int interval = 0;

        //show notification with transition 
        private void show_Tick(object sender, EventArgs e)
        {
            if (this.Top < 60)
            {
                this.Top += interval; //double the alert;
                interval += 2;        //double the speed;
            }
            else
            {
                show.Stop();
            }
        }

        private void close_Tick(object sender, EventArgs e)
        {
            if (this.Opacity>0)
            {
                this.Opacity -= 0.001; //reduce opactity to zero
            }
            else
            {
                this.Close();   //then close
            }
        }
    }
}
