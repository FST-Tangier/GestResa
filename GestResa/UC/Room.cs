using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestResa.UC
{
    public partial class Room : UserControl
    {
        public int  Number { get; set; }
        public bool IsFree = false;
        public Room()
        {
            InitializeComponent();
        }
        public void ShowStatus(DateTime dateRes)
        {

        }
        public void ShowStatus()
        {
            this.BackColor = IsFree ? Color.Yellow : Color.Red;
            libMenu.Visible = !IsFree;
            resMenu.Visible = IsFree;
        }
        private void Room_Load(object sender, EventArgs e)
        {
            lbNumber.Text = Number.ToString();
            IsFree = Number % 2 == 0;
            ShowStatus();


        }

        private void resMenu_Click(object sender, EventArgs e)
        {
            IsFree = false;
            ShowStatus();
        }

        private void libMenu_Click(object sender, EventArgs e)
        {
            IsFree = true;
            ShowStatus();
        }
    }
}