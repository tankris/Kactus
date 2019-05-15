using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kactus
{
    public partial class Form2 : Form
    {
        private bool mouseDown; //Keeping track of the mouseDown event
        private Point location; //To store the value of the location of the cursor
        private int masterID; //To store the master ID passed from Form1 after successfull authentication

        public int masterIDProperty
        {
            get { return this.masterID; }
            set { this.masterID = value; }
        }

        public Form2(int masterID) //Accepting masterID as Pass By Value from Form1 during Form2 call
        {
            InitializeComponent(); //Required method for design support
            masterIDProperty = masterID;

            //Default state of the side bar is set to expanded

            hideButtonsGUI(); //Hides the side bar buttons
            expandSlidingPannelText(); //Show the text within child panels
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            group.Hide(); //Will be unhid in X.2
            groupRetractButton.Hide(); //Will be unhid in X.2
        }

        private void TransitionTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.OKCancel); //Stores result of the input given to dialog box

            if(result == DialogResult.OK) //If user chooses to exit execute block
            {
                Environment.Exit(0); //Terminates the application
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Minimizes the form
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            logOut.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            DialogResult result = MessageBox.Show("Are you sure?", "Log Out", MessageBoxButtons.YesNo); //Stores result of input given by the user

            if (result == DialogResult.Yes) //If the input is yes, execute block        
            {
                this.Hide(); //Hides the current form
                MessageBox.Show("You have successfully logged out"); //Displays message about logging out
                Form1 form1 = new Form1(); //Creates an object of the login form
                form1.Show(); //Displays login form
            }            
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //Value of mousDown set to true to indicate event mouse down has occurred. Meaning titlebar has been clicked on by the mouse

            location = e.Location; //Gets location of the mouse during the mouse event
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown) //If mouse down event has occurred, execute block
            {
                this.Location = new Point((this.Location.X - location.X) + e.X, (this.Location.Y - location.Y) + e.Y); //Sets the new location based on mouse moevement
                this.Update(); //Updates the form's location
            }
        }

        private void titleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //If the mouse has stopped intracting with the titlebar, set mousedown event as false
        }

        //Sliding panel code begins here
        //Test this section without a timer attached to the panel later

        public void hideButtonsGUI() //Hides the retract buttons on the side bar
        {
            menuRetractButton.Hide();
            //groupRetractButton.Hide();
            sitesRetractButton.Hide();
            aboutRetractButton.Hide();
        }

        public void showButtonGUI() //Shows the retract buttons on the side bar
        {
            menuRetractButton.Show();
            //groupRetractButton.Show();
            sitesRetractButton.Show();
            aboutRetractButton.Show();
        }

        public void expandSlidingPannelText()
        {
            //GUI adjustments to the expanded panel to show below text

            toggleButton.Text = "Menu";
            group.Text = "Groups";
            sites.Text = "Sites";
            about.Text = "About";
        }

        public void retractSlidingPannelText()
        {
            //GUI adjustments to remove text from the panel while retracting

            toggleButton.Text = null;
            group.Text = null;
            sites.Text = null;
            about.Text = null;
        }

        bool slide = true; //Tracks the state of the panel, true for expanded and false for retracted. Currently set at expanded
        const int maxWidth = 200, minWidth = 100; //Set the max width when expanded and min width when retracted
        
        private void slidingPanelTimer_Tick(object sender, EventArgs e) //Sliding panel timer start function
        {
            if (slide.Equals(true)) //Checks if the panel is expanded
            {
                //Retract panel if true

                //Steadily decreade width of each child panel by 20

                slidingPanel.Width -= 20;
                group.Width -= 20;
                sites.Width -= 20;
                about.Width -= 20;

                if (slidingPanel.Width <= minWidth) //Check if the condition of min width has been met
                {
                    slide = false; //Set new state of the panel
                    showButtonGUI(); //Call function to show the new buttons
                    slidingPanelTimer.Stop(); //Stops the timer from continuing as condition has been met
                    retractSlidingPannelText(); //Call function to hide the text of the child panels
                    this.Refresh(); //Redraw the contents of the form
                }

            }

            else
            {
                //Expand panel if false 

                hideButtonsGUI(); //Call function to hide the buttons on the side bar

                //Steadily increase width of each child panel by 20

                slidingPanel.Width += 20;
                group.Width += 20;
                sites.Width += 20;
                about.Width += 20;

                if (slidingPanel.Width >= maxWidth) //Check if the max width of the panel has been met
                {
                    slide = true; //Set new value of the slide state
                    slidingPanelTimer.Stop(); //Stop the timer from continuing
                    expandSlidingPannelText(); //Show the text of each child panel
                    this.Refresh(); //Redraw the contents of the form       
                }
            }
        }

        private void groupsUserControlCall() //Code to call the groupsUC useb by group button and group panel
        {
            if (!contentPanel.Controls.Contains(groupsUserControl.Instance))
            {
                //Check if contentPanel has the Instance of the groupsUserControl. If not, execute block

                contentPanel.Controls.Add(groupsUserControl.Instance); //Add the instance onto the contentPanel
                groupsUserControl.Instance.Dock = DockStyle.Fill; //Ensure the groupsUC fills the controlPanel
                groupsUserControl.Instance.BringToFront(); //Bring the groupsUC to the front
            }

            else
            {
                //If the instance already exists, then execute block
                groupsUserControl.Instance.BringToFront(); //Bring the groupsUC to the front
            }
        }

        private void sitesUserControlCall() //Code to call the sitesUC useb by sites button and sites panel
        {
            if (!contentPanel.Controls.Contains(sitesUserControl.Instance))
            {
                //Check if contentPanel has the Instance of the sitesUserControl. If not, execute block

                contentPanel.Controls.Add(sitesUserControl.Instance); //Add the instance onto the contentPanel
                sitesUserControl.Instance.Dock = DockStyle.Fill; //Ensure the sitesUC fills the controlPanel
                sitesUserControl.Instance.refreshDataGridView(); //Refresh the dataGridView with values for te new user while removing the contents of the previous user
                sitesUserControl.Instance.BringToFront(); //Bring the sitesUC to the front
            }

            else
            {
                //If the instance already exists, then execute block
                sitesUserControl.Instance.refreshDataGridView(); //Refresh the dataGridView with values for te new user while removing the contents of the previous user
                sitesUserControl.Instance.BringToFront(); //Bring the sitesUC to the front
                
            }
        }

        private void aboutUserControlCall() //Code to call the aboutUC useb by about button and about panel
        {
            if (!contentPanel.Controls.Contains(aboutUserControl.Instance))
            {
                //Check if contentPanel has the Instance of the aboutUserControl. If not, execute block

                contentPanel.Controls.Add(aboutUserControl.Instance); //Add the instance onto the contentPanel
                aboutUserControl.Instance.Dock = DockStyle.None; //Ensure the aboutUC fills the controlPanel
                aboutUserControl.Instance.BringToFront(); //Bring the aboutUC to the front
            }

            else
            {
                //If the instance already exists, then execute block
                aboutUserControl.Instance.BringToFront(); //Bring the aboutUC to the front
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logOut_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void logOut_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void logOut_MouseHover(object sender, EventArgs e)
        {
        }        

        private void menuRetractButton_Click(object sender, EventArgs e)
        {
            slidingPanelTimer.Start(); //Start the sliding Panel timer and its associated code block
        }

        private void groupRetractButton_Click(object sender, EventArgs e)
        {
            //groupsUserControlCall(); //Call the function responsible to bring the groupsUC to the front
        }

        private void sites_Click(object sender, EventArgs e)
        {
            sitesUserControlCall(); //Call the function responsible to bring the sitesUC to the front
        }

        private void group_Click(object sender, EventArgs e)
        {
            //groupsUserControlCall(); //Call the function responsible to bring the groupsUC to the front
        }

        private void sitesRetractButton_Click(object sender, EventArgs e)
        {
            sitesUserControlCall(); //Call the function responsible to bring the sitesUC to the front
        }

        private void about_Click(object sender, EventArgs e)
        {
            aboutUserControlCall(); //Call the function responsible to bring the aboutUC to the front
        }

        private void aboutRetractButton_Click(object sender, EventArgs e)
        {
            aboutUserControlCall(); //Call the function responsible to bring the aboutUC to the front
        }

        private void groups_Click(object sender, EventArgs e) //If the child menu button has been clicked
        {
            
            slidingPanelTimer.Start(); //Start timer and execute timer block

        }


    }
}
