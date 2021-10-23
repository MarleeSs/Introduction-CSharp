using System;
using System.Windows.Forms;

namespace Popapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg,type);
        }
        
        private void Btn1_Click(object sender, EventArgs e)
        {
           this.Alert("Sumarli", Form_Alert.enmType.Smrl);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            this.Alert("Kelas IF21D", Form_Alert.enmType.Kls);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            this.Alert("Subang Patokbeusi", Form_Alert.enmType.Almt);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            this.Alert("Terimakasi!", Form_Alert.enmType.Skn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
