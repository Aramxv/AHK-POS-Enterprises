using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHKPOSENKTHESIS
{
    public partial class AdminSettings : UserControl
    {
        public AdminSettings()
        {
            InitializeComponent();
        }

        private void AdminSettings_Load(object sender, EventArgs e)
        {

        }

        private void BtnUserSettings_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminAccountSettings"))
            {
                AdminAccountSettings user = new AdminAccountSettings();
                user.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(user);

                user.ShowAllAccounts();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminAccountSettings"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
        }

        private void BtnTrailLogs_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminAccountLogTrails"))
            {
                AdminAccountLogTrails log = new AdminAccountLogTrails();
                log.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(log);

                log.ShowAccountsLogTrails();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminAccountLogTrails"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
        }
    }
}
