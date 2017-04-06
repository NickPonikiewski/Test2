using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget2._0
{
    public partial class TransactionMenu : Form
    {
        public string Name;
        public int ID;
        public TransactionMenu()
        {
            InitializeComponent();
        }

        private void TransactionMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'budgetDatabaseDataSet4.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.budgetDatabaseDataSet4.Transactions);
            foreach(DataGridViewRow dr in dataGridView1.Rows)
            {
                if(Convert.ToInt32(dr.Cells[3].Value) != ID)
                {
                    dr.Visible = false;
                }
            }

        }

        internal void LoadInfo(string name, int id)
        {
            Name = name;
            ID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransactionAdd TA = new TransactionAdd();
            TA.LoadInfo(Name, ID);
            TA.ShowDialog();
            TransactionMenu_Load(sender, e);

        }
    }
}
