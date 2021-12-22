namespace pp1
{
    partial class Redact_transaction
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.sotrudnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pp1DataSet1 = new pp1.pp1DataSet1();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.vidtransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dogovorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dogovorTableAdapter = new pp1.pp1DataSet1TableAdapters.DogovorTableAdapter();
            this.vid_transactionsTableAdapter = new pp1.pp1DataSet1TableAdapters.Vid_transactionsTableAdapter();
            this.sotrudnikiTableAdapter = new pp1.pp1DataSet1TableAdapters.SotrudnikiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidtransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogovorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 22);
            this.textBox1.TabIndex = 79;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 22);
            this.dateTimePicker1.TabIndex = 78;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.sotrudnikiBindingSource;
            this.comboBox3.DisplayMember = "Фамилия";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(148, 143);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(228, 24);
            this.comboBox3.TabIndex = 77;
            this.comboBox3.ValueMember = "id_сотрудника";
            // 
            // sotrudnikiBindingSource
            // 
            this.sotrudnikiBindingSource.DataMember = "Sotrudniki";
            this.sotrudnikiBindingSource.DataSource = this.pp1DataSet1;
            // 
            // pp1DataSet1
            // 
            this.pp1DataSet1.DataSetName = "pp1DataSet1";
            this.pp1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.vidtransactionsBindingSource;
            this.comboBox2.DisplayMember = "Название";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(148, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(228, 24);
            this.comboBox2.TabIndex = 76;
            this.comboBox2.ValueMember = "id_денежной_операции";
            // 
            // vidtransactionsBindingSource
            // 
            this.vidtransactionsBindingSource.DataMember = "Vid_transactions";
            this.vidtransactionsBindingSource.DataSource = this.pp1DataSet1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dogovorBindingSource;
            this.comboBox1.DisplayMember = "Номер_лицевого_счета";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 24);
            this.comboBox1.TabIndex = 75;
            this.comboBox1.ValueMember = "id_договора";
            // 
            // dogovorBindingSource
            // 
            this.dogovorBindingSource.DataMember = "Dogovor";
            this.dogovorBindingSource.DataSource = this.pp1DataSet1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 74;
            this.label2.Text = "Вид операции";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 73;
            this.label1.Text = "Id договора";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 18);
            this.label11.TabIndex = 72;
            this.label11.Text = "Сумма операции";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(12, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 18);
            this.label12.TabIndex = 71;
            this.label12.Text = "Дата транзакции";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(13, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 18);
            this.label13.TabIndex = 70;
            this.label13.Text = "Id сотрудника";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(148, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 43);
            this.button2.TabIndex = 69;
            this.button2.Text = "Редактировать транзакцию";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dogovorTableAdapter
            // 
            this.dogovorTableAdapter.ClearBeforeFill = true;
            // 
            // vid_transactionsTableAdapter
            // 
            this.vid_transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // sotrudnikiTableAdapter
            // 
            this.sotrudnikiTableAdapter.ClearBeforeFill = true;
            // 
            // Redact_transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(410, 268);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Name = "Redact_transaction";
            this.Text = "Redact_transaction";
            this.Load += new System.EventHandler(this.Redact_transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidtransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogovorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private pp1DataSet1 pp1DataSet1;
        private System.Windows.Forms.BindingSource dogovorBindingSource;
        private pp1DataSet1TableAdapters.DogovorTableAdapter dogovorTableAdapter;
        private System.Windows.Forms.BindingSource vidtransactionsBindingSource;
        private pp1DataSet1TableAdapters.Vid_transactionsTableAdapter vid_transactionsTableAdapter;
        private System.Windows.Forms.BindingSource sotrudnikiBindingSource;
        private pp1DataSet1TableAdapters.SotrudnikiTableAdapter sotrudnikiTableAdapter;
    }
}