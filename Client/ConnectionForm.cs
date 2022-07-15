using System;
using System.Windows.Forms;

namespace Client
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            var mainForm = new Form1(textBoxUsername.Text);
            Hide();
            mainForm.ShowDialog();
        }
    }
}
