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
    
    public partial class TransactionAdd : Form
    {
        public string Name;
        public int ID;
        public TransactionAdd()
        {
            InitializeComponent();
        }
        internal void LoadInfo(string name, int id)
        {
            Name = name;
            ID = id;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            Transaction NewTransaction = new Transaction();
            BudgetDatabaseEntities2 Database = new BudgetDatabaseEntities2();
            NewTransaction.Date = DateTimePicker.Value.Date.ToString();
            NewTransaction.Account = ID;
            NewTransaction.Expenses = ExpensesBox.Text;
            NewTransaction.Price = Convert.ToInt32(PricesBox.Text);
            Database.Transactions.Add(NewTransaction);
            Database.SaveChanges();
        }
    }
}
