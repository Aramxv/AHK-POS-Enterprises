using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AHKPOSENKTHESIS
{
    public partial class AdminRoutes : UserControl
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;

        public int rowindex = 0;

        public AdminRoutes()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        public void ShowRoutes()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblRoutes WHERE route like '%" + txtSearch.Text + "%' order by route", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            cn.Close();
        }

        private void AdminRoutes_Load(object sender, EventArgs e)
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.FromArgb(217, 219, 223);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 54, 75);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Set a cell padding to provide space for the top of the focus 
            // rectangle and for the content that spans multiple columns. 
            Padding newPadding = new Padding(0, 5, 0, 5);
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = newPadding;

            // Set the selection background color to transparent so 
            // the cell won't paint over the custom selection background.
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor =  Color.FromArgb(2, 119, 231);

            // Set the row height to accommodate the content that 
            // spans multiple columns.
            this.dataGridView1.RowTemplate.Height += CUSTOM_CONTENT_HEIGHT;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Group")
            {
                this.lblRoute.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminGroupByRoute"))
                {
                    AdminGroupByRoute group = new AdminGroupByRoute(this);
                    group.Dock = DockStyle.Fill;
                    AdminAdministrator.Instance.PnlContainer.Controls.Add(group);

                    group.ShowCustomerGroup();
                    group.BtnGoupedBy.Text = "Group by " + lblRoute.Text + " Route";
                }
                AdminAdministrator.Instance.PnlContainer.Controls["AdminGroupByRoute"].BringToFront();
                AdminAdministrator.Instance.BackButton.Visible = true;
            }
            if (colName == "Edit")
            {
                AdminAddRoutes frm = new AdminAddRoutes(this);
                frm.lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.txtRoute.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.BtnSave.Visible = false;
                frm.BtnUpdate.Visible = true;
                frm.lbl1.Text = "Update Route";
                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to Delete this Route?", "Delete Route", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblRoutes WHERE rid like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Route has been Successfully Deleted", "Delete Route", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowRoutes();
                }
            }
        }

        private void BtnAddRoutes_Click(object sender, EventArgs e)
        {
            AdminAddRoutes route = new AdminAddRoutes(this);

            //Show the Save button 
            route.BtnSave.Visible = true;
            route.BtnUpdate.Visible = false;

            //Relocate the Save button
            route.BtnSave.Location = new System.Drawing.Point(116, 181);

            //Show the Add new Route Form
            route.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowRoutes();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Routes Shown";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Routes Shown";
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            ShowRoutes();
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminCustomer"))
            {
                AdminCustomer cust = new AdminCustomer();
                cust.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(cust);

                cust.ShowCustomersInformation();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminCustomer"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
        }

        private void BtnRoutes_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminRoutes"))
            {
                AdminRoutes rout = new AdminRoutes();
                rout.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(rout);

                rout.ShowRoutes();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminRoutes"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
        }

     
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //Transfer the data into a buffer when clicked(right)
                this.lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.lblRoute.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                this.dataGridView1.Rows[e.RowIndex].Selected = true;
                this.rowindex = e.RowIndex;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[0];
                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
            else
            {
                lblRoute.Text = "";
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //File a switch case statement
            switch (e.ClickedItem.Name.ToString())
            {
                case "edi":

                    contextMenuStrip1.Hide();
                    AdminAddRoutes c = new AdminAddRoutes(this);

                    c.lblID.Text = lblID.Text;
                    c.txtRoute.Text = lblRoute.Text;

                    //Hide the Save Button
                    c.BtnSave.Visible = false;

                    //Show Only the Update Button
                    c.BtnUpdate.Visible = true;
                    c.lbl1.Text = "Update Route";
                    c.Show();

                    break;

                case "del":

                    contextMenuStrip1.Hide();
                    if (MessageBox.Show("Are you sure you want to Delete this Route?", "Delete Route", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("DELETE FROM tblRoutes WHERE rid like '" + lblID.Text + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Route has been Successfully Deleted", "Delete Route", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowRoutes();
                    }

                    break;

                case "deta":

                    contextMenuStrip1.Hide();

                    if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminGroupByRoute"))
                    {
                        AdminGroupByRoute group = new AdminGroupByRoute(this);
                        group.Dock = DockStyle.Fill;
                        AdminAdministrator.Instance.PnlContainer.Controls.Add(group);

                        group.ShowCustomerGroup();
                        group.BtnGoupedBy.Text = "Grouped by " + lblRoute.Text + " Route";
                    }
                    AdminAdministrator.Instance.PnlContainer.Controls["AdminGroupByRoute"].BringToFront();
                    AdminAdministrator.Instance.BackButton.Visible = true;


                    break;
            }
        }

   
    }
}
