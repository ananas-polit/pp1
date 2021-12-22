namespace pp1
{
    partial class Add_sotrudniki
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
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dogovorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pp1DataSet = new pp1.pp1DataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.vidtransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pp1DataSet1 = new pp1.pp1DataSet1();
            this.sotrudnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTableAdapter = new pp1.pp1DataSetTableAdapters.TransactionsTableAdapter();
            this.dogovorTableAdapter = new pp1.pp1DataSetTableAdapters.DogovorTableAdapter();
            this.sotrudnikiTableAdapter = new pp1.pp1DataSetTableAdapters.SotrudnikiTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vid_transactionsTableAdapter = new pp1.pp1DataSet1TableAdapters.Vid_transactionsTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dogovorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidtransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(146, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 43);
            this.button2.TabIndex = 47;
            this.button2.Text = "Добавить транзакцию";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dogovorBindingSource;
            this.comboBox1.DisplayMember = "Номер_лицевого_счета";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 24);
            this.comboBox1.TabIndex = 64;
            this.comboBox1.ValueMember = "id_договора";
            // 
            // dogovorBindingSource
            // 
            this.dogovorBindingSource.DataMember = "Dogovor";
            this.dogovorBindingSource.DataSource = this.pp1DataSet;
            // 
            // pp1DataSet
            // 
            this.pp1DataSet.DataSetName = "pp1DataSet";
            this.pp1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.vidtransactionsBindingSource;
            this.comboBox2.DisplayMember = "Название";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(146, 66);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(228, 24);
            this.comboBox2.TabIndex = 65;
            this.comboBox2.ValueMember = "id_денежной_операции";
            // 
            // vidtransactionsBindingSource
            // 
            this.vidtransactionsBindingSource.DataMember = "Vid_transactions";
            this.vidtransactionsBindingSource.DataSource = this.pp1DataSet1;
            // 
            // pp1DataSet1
            // 
            this.pp1DataSet1.DataSetName = "pp1DataSet1";
            this.pp1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrudnikiBindingSource
            // 
            this.sotrudnikiBindingSource.DataMember = "Sotrudniki";
            this.sotrudnikiBindingSource.DataSource = this.pp1DataSet;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.pp1DataSet;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // dogovorTableAdapter
            // 
            this.dogovorTableAdapter.ClearBeforeFill = true;
            // 
            // sotrudnikiTableAdapter
            // 
            this.sotrudnikiTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.sotrudnikiBindingSource;
            this.comboBox3.DisplayMember = "Фамилия";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(146, 154);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(228, 24);
            this.comboBox3.TabIndex = 66;
            this.comboBox3.ValueMember = "id_сотрудника";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 22);
            this.dateTimePicker1.TabIndex = 67;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 22);
            this.textBox1.TabIndex = 68;
            // 
            // vid_transactionsTableAdapter
            // 
            this.vid_transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "Вид операции";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 78;
            this.label4.Text = "Id договора";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 18);
            this.label5.TabIndex = 77;
            this.label5.Text = "Сумма операции";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 76;
            this.label6.Text = "Дата транзакции";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 75;
            this.label7.Text = "Id сотрудника";
            // 
            // Add_sotrudniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 269);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Name = "Add_sotrudniki";
            this.Text = "Add_transaction";
            this.Load += new System.EventHandler(this.Add_sotrudniki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dogovorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidtransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private pp1DataSet pp1DataSet;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private pp1DataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.BindingSource dogovorBindingSource;
        private pp1DataSetTableAdapters.DogovorTableAdapter dogovorTableAdapter;
        private System.Windows.Forms.BindingSource sotrudnikiBindingSource;
        private pp1DataSetTableAdapters.SotrudnikiTableAdapter sotrudnikiTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private pp1DataSet1 pp1DataSet1;
        private System.Windows.Forms.BindingSource vidtransactionsBindingSource;
        private pp1DataSet1TableAdapters.Vid_transactionsTableAdapter vid_transactionsTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}