using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCoCaNgua
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 HostForm = new Form2();
            HostForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 Player__Form = new Form3();
            Player__Form.Show();
        }
    }
}
