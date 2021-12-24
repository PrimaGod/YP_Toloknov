using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalPractice
{
    public partial class FormAddClient : Form
    {
        public FormAddClient()
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                MainClass.writeData2DB(tbFirstName.Text,tbLastName.Text,tbPatron.Text,dateTimePicker.Value,cmbGender.SelectedIndex+1,tbEmail.Text,tbPhone.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
