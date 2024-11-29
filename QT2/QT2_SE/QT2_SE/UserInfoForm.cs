using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT2_SE
{
    public partial class UserInfoForm : Form
    {
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public UserInfoForm()
        {
            InitializeComponent();
        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
                // Validate user input
                if (string.IsNullOrWhiteSpace(txt_FullName.Text) ||
                    string.IsNullOrWhiteSpace(txt_Email.Text) ||
                    string.IsNullOrWhiteSpace(txt_PhoneNumber.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Store the user inputs into properties
                FullName = txt_FullName.Text;
                Email = txt_Email.Text;
                Phone = txt_PhoneNumber.Text;

                // Close the form with a success result
                this.DialogResult = DialogResult.OK;
                this.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate user input
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Store the user inputs into properties
            FullName = textBox1.Text;
            Email = textBox3.Text;
            Phone = textBox2.Text;

            // Close the form with a success result
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
