namespace pp1
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pp1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pp1DataSet = new pp1.pp1DataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.coatingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pp1DataSet1 = new pp1.pp1DataSet1();
            this.coatingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.sotrudnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sotrudnikiTableAdapter = new pp1.pp1DataSetTableAdapters.SotrudnikiTableAdapter();
            this.coatingTableAdapter = new pp1.pp1DataSetTableAdapters.CoatingTableAdapter();
            this.usersTableAdapter = new pp1.pp1DataSetTableAdapters.UsersTableAdapter();
            this.coatingTableAdapter1 = new pp1.pp1DataSet1TableAdapters.CoatingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(185, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить договор";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.usersBindingSource;
            this.comboBox1.DisplayMember = "Контактный_телефон";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(185, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "id_пользователя";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.pp1DataSetBindingSource;
            // 
            // pp1DataSetBindingSource
            // 
            this.pp1DataSetBindingSource.DataSource = this.pp1DataSet;
            this.pp1DataSetBindingSource.Position = 0;
            // 
            // pp1DataSet
            // 
            this.pp1DataSet.DataSetName = "pp1DataSet";
            this.pp1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.coatingBindingSource1;
            this.comboBox2.DisplayMember = "Улица";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(185, 172);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(228, 24);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "id_дома";
            // 
            // coatingBindingSource1
            // 
            this.coatingBindingSource1.DataMember = "Coating";
            this.coatingBindingSource1.DataSource = this.pp1DataSet1;
            // 
            // pp1DataSet1
            // 
            this.pp1DataSet1.DataSetName = "pp1DataSet1";
            this.pp1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coatingBindingSource
            // 
            this.coatingBindingSource.DataMember = "Coating";
            this.coatingBindingSource.DataSource = this.pp1DataSetBindingSource;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.sotrudnikiBindingSource;
            this.comboBox3.DisplayMember = "Фамилия";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(185, 234);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(228, 24);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.ValueMember = "id_сотрудника";
            // 
            // sotrudnikiBindingSource
            // 
            this.sotrudnikiBindingSource.DataMember = "Sotrudniki";
            this.sotrudnikiBindingSource.DataSource = this.pp1DataSetBindingSource;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 206);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(185, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(185, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(228, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(185, 144);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(228, 22);
            this.textBox4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Баланс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Номер лицевого счета";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Id дома";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(15, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата подключения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Id сотрудника";
            // 
            // sotrudnikiTableAdapter
            // 
            this.sotrudnikiTableAdapter.ClearBeforeFill = true;
            // 
            // coatingTableAdapter
            // 
            this.coatingTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // coatingTableAdapter1
            // 
            this.coatingTableAdapter1.ClearBeforeFill = true;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(443, 330);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "Add";
            this.Text = "Add dogovor";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private pp1DataSet pp1DataSet;
        private System.Windows.Forms.BindingSource pp1DataSetBindingSource;
        private System.Windows.Forms.BindingSource sotrudnikiBindingSource;
        private pp1DataSetTableAdapters.SotrudnikiTableAdapter sotrudnikiTableAdapter;
        private System.Windows.Forms.BindingSource coatingBindingSource;
        private pp1DataSetTableAdapters.CoatingTableAdapter coatingTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private pp1DataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private pp1DataSet1 pp1DataSet1;
        private System.Windows.Forms.BindingSource coatingBindingSource1;
        private pp1DataSet1TableAdapters.CoatingTableAdapter coatingTableAdapter1;
    }
}