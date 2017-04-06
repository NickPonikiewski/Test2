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
    public partial class MainMenu : Form
    {
        public string Name;
        public int ID;
        public MainMenu()
        {
            InitializeComponent();
        }
        internal void LoadInfo(string name, int id)
        {
            Name = name;
            ID = id;
        }
        private void Transactionbutton_Click(object sender, EventArgs e)
        {
            TransactionMenu TM = new TransactionMenu();
            TM.LoadInfo(Name, ID);
            TM.ShowDialog();
        }

        private void Budgetbutton_Click(object sender, EventArgs e)
        {
            //Add stuff here
        }
    }
}
