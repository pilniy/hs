using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hs
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            hostTextBox.Text = Properties.Settings.Default.pgHost;
            portTextBox.Text = Properties.Settings.Default.pgPort;
            dbTextBox.Text = Properties.Settings.Default.pgDB;
            userTextBox.Text = Properties.Settings.Default.pgUser;
            schemaTextBox.Text = Properties.Settings.Default.pgSchema;
            passwdTextBox.Text = Properties.Settings.Default.pgPasswd;
            

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.pgHost = hostTextBox.Text;
            Properties.Settings.Default.pgPort = portTextBox.Text;
            Properties.Settings.Default.pgSchema = schemaTextBox.Text;
            Properties.Settings.Default.pgDB = dbTextBox.Text;
            Properties.Settings.Default.pgUser = userTextBox.Text;
            Properties.Settings.Default.pgPasswd = passwdTextBox.Text;
            Properties.Settings.Default.Save();
            Close();

        }
    }
}
