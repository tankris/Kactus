using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kactus
{
    public partial class sitesUserControl : UserControl
    {
        private int _masterID;

        public int masterIDProperty
        {
            get { return this._masterID; }
            set { this._masterID = value;}
        }

        //Singleton Pattern

        /* Lazy initialization is the tactic of delaying the creation of an object, the calculation of a value, 
           or some other expensive process until the first time it is needed. 
           It is a kind of lazy evaluation that refers specifically to the instantiation of objects or other resources*/

        //Lazy initialization code below

        private static readonly Lazy<sitesUserControl> lazy = new Lazy<sitesUserControl>(() => new sitesUserControl());
        //Using Lazy<T> class, we pass sitesUC as a object parameter to be lazy initialised using a lambda expression =>

        public static sitesUserControl Instance
        {
            get //Use accessor to read the property lazy<t>, since it's being called from another class
            {
                return lazy.Value; //Return the lazily initialised value of the current lazy<t> instance
            }
        }

        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"|DataDirectory|\\cactus.mdf\"; Integrated Security = True"); // making connection   

        public sitesUserControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void refreshDataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("displaySitesSP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                Form2 myParent = (Form2)this.Parent.Parent;
                
                cmd.Parameters.AddWithValue("@mid", myParent.masterIDProperty);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                con.Open();                

                try
                {
                    cmd.ExecuteNonQuery();
                }

                catch(Exception e)
                {
                    MessageBox.Show("INVALID SQL OPERATION:" + e);
                }

                con.Close();

                dataGridView.DataSource = ds.Tables[0];
                dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            catch (Exception e)
            {
                MessageBox.Show("" + e);
            }
        }

        private void addSiteButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("addSitesSP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            Form2 myParent = (Form2)this.Parent.Parent;

            cmd.Parameters.AddWithValue("@mid", myParent.masterIDProperty);
            cmd.Parameters.AddWithValue("@sname", siteTextBox.Text);
            cmd.Parameters.AddWithValue("@surl", siteUrlTextBox.Text);
            cmd.Parameters.AddWithValue("@uname", usernameTextBox.Text);
            cmd.Parameters.AddWithValue("@pass", passwordTextBox.Text);
            cmd.Parameters.AddWithValue("@gid", groupIDTextBox.Text);
            cmd.Parameters.AddWithValue("@gname", groupNameTextBox.Text);

            con.Open();

            try
            {
                cmd.ExecuteNonQuery();                
            }

            catch (Exception ex)
            {
                MessageBox.Show("INVALID SQL OPERATION:" + ex);
            }

            con.Close();
            refreshDataGridView();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {            
            try
            {
                SqlCommand cmd = new SqlCommand("deleteSitesSP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                Form2 myParent = (Form2)this.Parent.Parent;

                cmd.Parameters.AddWithValue("@mid", myParent.masterIDProperty);
                cmd.Parameters.AddWithValue("@sname", dataGridView.SelectedRows[0].Cells[0].Value);
                cmd.Parameters.AddWithValue("@surl", dataGridView.SelectedRows[0].Cells[1].Value);
                cmd.Parameters.AddWithValue("@uname", dataGridView.SelectedRows[0].Cells[2].Value);
                cmd.Parameters.AddWithValue("@pass", dataGridView.SelectedRows[0].Cells[3].Value);
                cmd.Parameters.AddWithValue("@gname", dataGridView.SelectedRows[0].Cells[4].Value);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }

                catch(Exception ex)
                {
                    MessageBox.Show("INVALID SQL OPERATION:" + ex);
                }

                con.Close();

                refreshDataGridView();
            }

            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void sitesUserControl_Load(object sender, EventArgs e)
        {
            dataGridView.DefaultCellStyle.ForeColor = Color.Black; //Setting the color of the content inside the dataGrid as black
        }

        string search = string.Empty;
        bool sval;

        private void siteSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.dataGridView.ClearSelection();
            sval = false;

            if (e.KeyChar == (char)Keys.Back && search.Length != 0)
            {
                search = search.Substring(0, search.Length-1);
                sval = true;
            }

            if (Char.IsLetterOrDigit(e.KeyChar))
            {
                search += e.KeyChar.ToString();
                sval = true;
            }

            if (sval == true & search.Length != 0)
            {
                for (int i = 0; i < this.dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < this.dataGridView.Columns.Count; j++)
                    {
                        if (this.dataGridView.Rows[i].Cells[j].Value != null)
                        {
                            if (this.dataGridView.Rows[i].Cells[j].Value.ToString().Contains(search))
                            {
                                this.dataGridView.Rows[i].Cells[j].Selected = true;
                            }
                        }
                    }
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            siteSearchTextBox.Text = "Search My Vault";
            siteTextBox.Text = "Site Name";
            siteUrlTextBox.Text = "Site Url";
            usernameTextBox.Text = "Username";
            passwordTextBox.Text = "Password";
            groupIDTextBox.Text = "Group ID";
            groupNameTextBox.Text = "Group Name";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updateSitesSP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                Form2 myParent = (Form2)this.Parent.Parent;

                cmd.Parameters.AddWithValue("@mid", myParent.masterIDProperty);
                cmd.Parameters.AddWithValue("@sname", dataGridView.SelectedRows[0].Cells[0].Value);
                cmd.Parameters.AddWithValue("@surl", dataGridView.SelectedRows[0].Cells[1].Value);
                cmd.Parameters.AddWithValue("@uname", dataGridView.SelectedRows[0].Cells[2].Value);
                cmd.Parameters.AddWithValue("@pass", dataGridView.SelectedRows[0].Cells[3].Value);
                cmd.Parameters.AddWithValue("@gname", dataGridView.SelectedRows[0].Cells[4].Value);

                cmd.Parameters.AddWithValue("@nuname", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("@npass", passwordTextBox.Text);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("INVALID SQL OPERATION:" + ex);
                }

                con.Close();

                refreshDataGridView();
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
