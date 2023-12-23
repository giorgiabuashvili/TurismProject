using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurismProject
{
    public partial class Form1 : Form
    {
        AccountManagement accountManagement;

        public Form1()
        {
            accountManagement = new AccountManagement();
            InitializeComponent();
        }

        private void ValidateInput(object sender, EventArgs e)
        {
            string IDInput = IDTBLogInPage.Text;
            string PWInput = PWTBLogInPage.Text;

            if (IDInput.Any(x => char.IsLetter(x)) || PWInput.Length < 9)
            {
                LogInButtonLogInPage.Enabled = false;
                ValidationLabelLogInPage.Text = " Incorrect input.";
            } else
            {
                LogInButtonLogInPage.Enabled = true;
                ValidationLabelLogInPage.Text = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string IDInput = IDTBLogInPage.Text;
            string PWInput = PWTBLogInPage.Text;

            Account tryToGetAccount = accountManagement.Login(Convert.ToInt32(IDInput), PWInput);
            if (tryToGetAccount != null )
            {
                DashBoardForm dashBoardForm = new DashBoardForm(tryToGetAccount);
                dashBoardForm.Show();
                this.Hide();
            } else
            {
                ValidationLabelLogInPage.Text = " Type correct id or password";
            }
        }
    }
}
