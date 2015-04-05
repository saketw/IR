using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iRdbDataSet.Family' table. You can move, or remove it, as needed.
            this.familyTableAdapter.Fill(this.iRdbDataSet.Family);

        }

        private void onSelChangeTotalPassengers(object sender, EventArgs e)
        {
            ComboBox cbTotalPassengers = new ComboBox();
            string str = this.cbTotalPassengers.GetItemText(this.cbTotalPassengers.SelectedItem);
            
           // MessageBox.Show(str.ToString());

            //DataTable dt = new DataTable();
            //DataRow dr;
            //dt.Columns.Add("test1");
            //dt.Columns.Add("test2");
            //dr = dt.NewRow();
            //dr["test1"] = "some value";
            //dr["teste2"] = "some value";
            //dt.Rows.Add(dr);

            int x = int.Parse(str);
            if(x==2)
            {
             //   dataGridView1.DataSource = dt;
                MessageBox.Show(x.ToString());
            }
        }

       
    }
}
