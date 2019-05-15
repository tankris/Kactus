using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace Kactus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //Required method for designer support
            PrivateFontCollection pfc = new PrivateFontCollection(); //Allows to maintain a set of fonts specifically for the application
            pfc.AddFontFile(@"../../\Resources\\PermanentMarker-Regular.ttf"); //Adding the google font ttf file
            label3.Font = new Font(pfc.Families[0], 50, FontStyle.Regular); //Initialising a new font using the google font added in the prev statement and setting size
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"|DataDirectory|\\cactus.mdf\"; Integrated Security = True"); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM master WHERE username='" + textBox1.Text + "' AND password='" + textBox2.Text + "'", con); //Selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //Creating a virtual table  
            sda.Fill(dt); //Dropping values

            if (dt.Rows[0][0].ToString() == "1")
            {
                /*If the user is successfully authenticated then the form1 will transition to form2 */

                sda = new SqlDataAdapter("SELECT mid FROM master WHERE username='" + textBox1.Text + "' AND password='" + textBox2.Text + "'", con); //Selecting the mid from table and the matching it with the user name and password provided by user*/
                DataTable dt2 = new DataTable(); //Creating a virtual table
                sda.Fill(dt2); //Dropping values

                label4.Hide();//Hides label4 which indicates incorrect details panel
                this.Hide(); //Hides current form
                MessageBox.Show("Welcome " + textBox1.Text); //Prints a welcome message box with username
                Form2 form2 = new Form2(Convert.ToInt32(dt2.Rows[0][0].ToString())); //Creating an object of the form2 in order to transition to  and passing the current user mid. Using the convert function to convert string to int32 which is int
                form2.Show(); //shows the new form to the user
            }

            else
            {
                label4.Show(); //Displays an error message panel

                //$$$$$$$$$$$$$$$$$$$$$$$$$$$$       Needs to be clickable
            }
                
        }
    }
}
