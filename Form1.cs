using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody18_IKAP_ML4058
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Vypočítá objem krychle z délky hrany a. 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double Objem(double a)
        {
            return a * a * a;
        }
        /// <summary>
        /// Vypočítá objem kvádru z parametru a,b,c. 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static double Objem(double a,double b, double c)
        {
            return a * b * c;
        }
        /// <summary>
        /// Vypočítá objem válce z výšky a poloměru. 
        /// </summary>
        /// <param name="polomer"></param>
        /// <param name="vyska"></param>
        /// <returns></returns>
        public static double Objem(double polomer, double vyska)
        {
            return Math.PI * polomer * polomer * vyska;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Objem krychle je:" + Form1.Objem(5) +" cm3"
            +"\nObjem válce je:" +Form1.Objem(5, 5) + " cm3" 
            +"\nObjem kvádru je: "+Form1.Objem(1, 2, 3) + " cm3");
        }
    }
}
