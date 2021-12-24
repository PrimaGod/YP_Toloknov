using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalPractice
{
    public partial class FormClients : Form
    {
        public int ClientOffsetCurent;
        public int ClientRowsCount;
        public FormClients()
        {
            InitializeComponent();
            try
            {
                label3.Text = MainClass.authorizeMethod();
                updateTable(0);
                ClientRowsCount = MainClass.getCountOfClients();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //void Loading(string sql) //Способ загрузки таблицы
        //{
        //    string connectionString = (conString);

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
        //        DataSet ds = new DataSet();
        //        adapter.Fill(ds);
        //        dataGridView1.DataSource = ds.Tables[0];
        //        connection.Close();
        //    }
        //}

        private void btnBackPage_Click(object sender, EventArgs e)
        {
            if ((ClientOffsetCurent-25)>-1)
            {
                ClientOffsetCurent -= 25;
                updateTable(ClientOffsetCurent);
            }
            
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            ClientOffsetCurent += 25;
            updateTable(ClientOffsetCurent);
        }
        void updateTable(int offsetCount)
        {
            DataSet ds;
            if (tbFirstName.Text==""&&tbLastName.Text=="")
            {
                ds = MainClass.getDataFromClients(offsetCount);
                
            }
            else
            {
                ds = MainClass.getFilterData(offsetCount, tbFirstName.Text, tbLastName.Text);
            }
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }


        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            //передеам в метод "deleteRow" выделенный id и выполняем запрос на удаление
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?","Предупреждение",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                MainClass.deleteRow(Convert.ToInt32(selectedRow.Cells["ID"].Value));
                ClientOffsetCurent = 0;
                updateTable(ClientOffsetCurent);
            }
            
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            FormAddClient newClient = new FormAddClient();
            newClient.ShowDialog();
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            ClientOffsetCurent = 0;
            updateTable(ClientOffsetCurent);
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            ClientOffsetCurent = 0;
            updateTable(ClientOffsetCurent);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            
            tbFirstName.Text = "";
            tbLastName.Text = "";
            ClientOffsetCurent = 0;
            updateTable(ClientOffsetCurent);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormClients_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
