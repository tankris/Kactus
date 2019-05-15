using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kactus
{
    public partial class groupsUserControl : UserControl
    {
        //Singleton Pattern

        /* Lazy initialization is the tactic of delaying the creation of an object, the calculation of a value, 
           or some other expensive process until the first time it is needed. 
           It is a kind of lazy evaluation that refers specifically to the instantiation of objects or other resources*/

        //Lazy initialization code below

        private static readonly Lazy<groupsUserControl> lazy = new Lazy<groupsUserControl>(() => new groupsUserControl());
        //Using Lazy<T> class, we pass groupsUC as a object parameter to be lazy initialised using a lambda expression =>

        public static groupsUserControl Instance
        {
            get //Use accessor to read the property lazy<t>, since it's being called from another class
            {
                return lazy.Value; //Return the lazily initialised value of the current lazy<t> instance
            }
        }

        public groupsUserControl()
        {
            InitializeComponent();
        }

        private void groupsUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
