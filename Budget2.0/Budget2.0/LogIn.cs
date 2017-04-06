using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Budget2._0
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            
            //Account NewAccount = new Account();
            //BudgetDatabaseEntities Database = new BudgetDatabaseEntities();
            //NewAccount.Name = "Nick";
            //NewAccount.Id = 1234;
            //NewAccount.Cash = 500000;
            //NewAccount.Credit_Cards = 34000;
            //NewAccount.Bank = 5000;
            //NewAccount.Investment = 0;

            //Database.Accounts.Add(NewAccount);
            //Database.SaveChanges();


        }

        private void LogInbutton_Click(object sender, EventArgs e)
        {
            string Name = AccountNameBox.Text;
            int id = Convert.ToInt32(AccountIDBox.Text);
            BudgetDatabaseEntities2 Database = new BudgetDatabaseEntities2();
            if ((Database.Accounts.Where(c => c.Id == id).SingleOrDefault() != null) && (Database.Accounts.Where(c => c.Name == Name).SingleOrDefault() != null))// if user name and id does exist in the database
            {
                MainMenu MM = new MainMenu();
                MM.LoadInfo(Name, id);
                this.Hide();
                MM.ShowDialog();
            }
            else
            {
                MessageBox.Show("User not in system", "Login Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

    }
}
