using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cờ_cá_ngựa
{
    public partial class Server : Form
    {
        
        public Server()
        {
            InitializeComponent();
            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            User_control gui = new User_control();
            gui.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Room_control gui = new Room_control();
            gui.Show();
        }
    }
}
