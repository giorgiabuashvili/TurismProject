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
    public partial class DashBoardForm : Form
    {
        private Account account;
        public DashBoardForm(Account account)
        {
            InitializeComponent();
            this.account = account;
        }
    }
}
