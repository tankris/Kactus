using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Kactus
{
    public partial class aboutUserControl : UserControl
    {
        //Singleton Pattern
        
        /* Lazy initialization is the tactic of delaying the creation of an object, the calculation of a value, 
           or some other expensive process until the first time it is needed. 
           It is a kind of lazy evaluation that refers specifically to the instantiation of objects or other resources*/

        //Lazy initialization code below

        private static readonly Lazy<aboutUserControl> lazy = new Lazy<aboutUserControl>(() => new aboutUserControl());
        //Using Lazy<T> class, we pass aboutUC as a object parameter to be lazy initialised using a lambda expression =>

        public static aboutUserControl Instance
        {
            get //Use accessor to read the property lazy<t>, since it's being called from another class
            {
                return lazy.Value; //Return the lazily initialised value of the current lazy<t> instance
            }
        }

        public aboutUserControl()
        {
            InitializeComponent();
            PrivateFontCollection pfc = new PrivateFontCollection(); //Allows to maintain a set of fonts specifically for the application
            pfc.AddFontFile(@"../../\Resources\\PermanentMarker-Regular.ttf"); //Adding the google font ttf file
            label1.Font = new Font(pfc.Families[0], 50, FontStyle.Regular); //Initialising a new font using the google font added in the prev statement and setting size
            //label2.Font = new Font(pfc.Families[0], 50, FontStyle.Regular); //Initialising a new font
            //label3.Font = new Font(pfc.Families[0], 50, FontStyle.Regular); //Initialising a new font
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
