namespace EducationalPractice
{
    partial class FormClients
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClients));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBackPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-28, -14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 96);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(174, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Салон красоты \"Мордочка\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EducationalPractice.Properties.Resources.beauty_logo;
            this.pictureBox1.Location = new System.Drawing.Point(40, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(225)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-13, 794);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1296, 80);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "check";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1241, 574);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // btnBackPage
            // 
            this.btnBackPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.btnBackPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackPage.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackPage.Location = new System.Drawing.Point(550, 673);
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.Size = new System.Drawing.Size(101, 23);
            this.btnBackPage.TabIndex = 4;
            this.btnBackPage.Text = "<<";
            this.btnBackPage.UseVisualStyleBackColor = false;
            this.btnBackPage.Click += new System.EventHandler(this.btnBackPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNextPage.Location = new System.Drawing.Point(708, 673);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(101, 23);
            this.btnNextPage.TabIndex = 5;
            this.btnNextPage.Text = ">>";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.btnDeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRow.ForeColor = System.Drawing.Color.Snow;
            this.btnDeleteRow.Location = new System.Drawing.Point(1132, 666);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(121, 37);
            this.btnDeleteRow.TabIndex = 7;
            this.btnDeleteRow.Text = "Удалить";
            this.btnDeleteRow.UseVisualStyleBackColor = false;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.ForeColor = System.Drawing.Color.Snow;
            this.btnAddClient.Location = new System.Drawing.Point(991, 666);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(121, 37);
            this.btnAddClient.TabIndex = 8;
            this.btnAddClient.Text = "Добавить клиента";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(149, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Сброс";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(7, 27);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(136, 20);
            this.tbFirstName.TabIndex = 12;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(7, 71);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(137, 20);
            this.tbLastName.TabIndex = 13;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Фамилия";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Дата регистрации";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 666);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 104);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 29);
            this.button3.TabIndex = 20;
            this.button3.Text = "Фамилия";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(239, 673);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 67);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сортировка";
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 776);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnBackPage);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с клиентами";
            this.Load += new System.EventHandler(this.FormClients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBackPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

