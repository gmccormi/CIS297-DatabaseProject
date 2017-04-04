using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class Form1 : Form
    {
        const int NUMBER_OF_MONTHS = 12;

        List<string> Months = new List<string>();

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Months.Add("January");
            Months.Add("Febuary");
            Months.Add("March");
            Months.Add("April");
            Months.Add("May");
            Months.Add("June");
            Months.Add("July");
            Months.Add("August");
            Months.Add("September");
            Months.Add("October");
            Months.Add("November");
            Months.Add("December");

            for (int i = 0; i < NUMBER_OF_MONTHS; i++)
            {
                expenseDateMonth.Items.Add(Months[i]);
                incomeDateMonth.Items.Add(Months[i]);
            }
            for (int i = 0; i < 31; i++)
            {
                expenseDateDay.Items.Add(i + 1);
                incomeDateDay.Items.Add(i + 1);
            }
        }
    }
}
