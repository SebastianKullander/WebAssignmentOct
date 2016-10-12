using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebAdmin
{
    public partial class Form1 : Form
    {
        T4DBEntities MyDataBase = new T4DBEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           

            string education = string.Empty;
            string period = string.Empty;

            education = txbEducation.Text;
            period = txbPeriod.Text;

            Table MyTable = new Table() { education = education, period = period };

            
            MyDataBase.Tables.Add(MyTable);

            
            MyDataBase.SaveChanges();

            txbEducation.Text = null;
            txbPeriod.Text = null;

            MessageBox.Show("Data saved to DB");
            
        }
    }
}
