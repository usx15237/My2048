using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _2048Game
{
    public partial class StartForm : Form
    {
        static public string method;

        public StartForm()
        {
            InitializeComponent();

        }



        private void Start_Click(object sender, EventArgs e)
        {


            if (this.link.Checked)
            {
                method = "link";
                if (wait.Checked)
                {
                    MessageBox.Show(Customer.Customer_open(MainForm.username));
                }
                else
                {
                    MessageBox.Show(Server.Server_find(MainForm.username));
                }
            }
            else
            {
                method = "alone";
            }

                this.Hide();
                MainForm mainform = new MainForm();
                mainform.ShowDialog();
            
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            wait.Hide();
            find.Hide();
        }

        private void link_CheckedChanged(object sender, EventArgs e)
        {
            if (this.link.Checked)
            {
                wait.Show();
                find.Show();
            }
        }

      
       
    }
}
