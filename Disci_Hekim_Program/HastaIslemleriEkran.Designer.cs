namespace Disci_Hekim_Program
{
    partial class HastaIslemleriEkran
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttelekle = new System.Windows.Forms.TextBox();
            this.cmbcinsiyetekle = new System.Windows.Forms.ComboBox();
            this.msktcekle = new System.Windows.Forms.MaskedTextBox();
            this.nmyasekle = new System.Windows.Forms.NumericUpDown();
            this.btnhastaekle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmailekle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoyadekle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadekle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txthastaidguncelle = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txttelguncelle = new System.Windows.Forms.TextBox();
            this.cmbcinsiyetguncelle = new System.Windows.Forms.ComboBox();
            this.txthastaadiguncelle = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.msktcguncelle = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nmyasguncelle = new System.Windows.Forms.NumericUpDown();
            this.txthastasoyadiguncelle = new System.Windows.Forms.TextBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmailguncelle = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmyasekle)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmyasguncelle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.msktc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 47);
            this.panel1.TabIndex = 0;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(1255, 12);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(111, 26);
            this.msktc.TabIndex = 0;
            this.msktc.TextChanged += new System.EventHandler(this.msktc_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1354, 270);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttelekle);
            this.groupBox1.Controls.Add(this.cmbcinsiyetekle);
            this.groupBox1.Controls.Add(this.msktcekle);
            this.groupBox1.Controls.Add(this.nmyasekle);
            this.groupBox1.Controls.Add(this.btnhastaekle);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtmailekle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsoyadekle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtadekle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 364);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Ekle";
            // 
            // txttelekle
            // 
            this.txttelekle.Location = new System.Drawing.Point(121, 207);
            this.txttelekle.MaxLength = 10;
            this.txttelekle.Name = "txttelekle";
            this.txttelekle.Size = new System.Drawing.Size(204, 26);
            this.txttelekle.TabIndex = 3;
            // 
            // cmbcinsiyetekle
            // 
            this.cmbcinsiyetekle.FormattingEnabled = true;
            this.cmbcinsiyetekle.Items.AddRange(new object[] {
            "Erkek",
            "Bayan"});
            this.cmbcinsiyetekle.Location = new System.Drawing.Point(419, 97);
            this.cmbcinsiyetekle.Name = "cmbcinsiyetekle";
            this.cmbcinsiyetekle.Size = new System.Drawing.Size(204, 28);
            this.cmbcinsiyetekle.TabIndex = 6;
            // 
            // msktcekle
            // 
            this.msktcekle.Location = new System.Drawing.Point(121, 156);
            this.msktcekle.Mask = "00000000000";
            this.msktcekle.Name = "msktcekle";
            this.msktcekle.Size = new System.Drawing.Size(204, 26);
            this.msktcekle.TabIndex = 2;
            // 
            // nmyasekle
            // 
            this.nmyasekle.Location = new System.Drawing.Point(419, 55);
            this.nmyasekle.Name = "nmyasekle";
            this.nmyasekle.Size = new System.Drawing.Size(204, 26);
            this.nmyasekle.TabIndex = 5;
            // 
            // btnhastaekle
            // 
            this.btnhastaekle.Location = new System.Drawing.Point(526, 131);
            this.btnhastaekle.Name = "btnhastaekle";
            this.btnhastaekle.Size = new System.Drawing.Size(97, 33);
            this.btnhastaekle.TabIndex = 7;
            this.btnhastaekle.Text = "Ekle";
            this.btnhastaekle.UseVisualStyleBackColor = true;
            this.btnhastaekle.Click += new System.EventHandler(this.btnhastaekle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cinsiyet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Yaş:";
            // 
            // txtmailekle
            // 
            this.txtmailekle.Location = new System.Drawing.Point(121, 258);
            this.txtmailekle.Name = "txtmailekle";
            this.txtmailekle.Size = new System.Drawing.Size(204, 26);
            this.txtmailekle.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC:";
            // 
            // txtsoyadekle
            // 
            this.txtsoyadekle.Location = new System.Drawing.Point(121, 105);
            this.txtsoyadekle.Name = "txtsoyadekle";
            this.txtsoyadekle.Size = new System.Drawing.Size(204, 26);
            this.txtsoyadekle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta Soyadı:";
            // 
            // txtadekle
            // 
            this.txtadekle.Location = new System.Drawing.Point(121, 54);
            this.txtadekle.Name = "txtadekle";
            this.txtadekle.Size = new System.Drawing.Size(204, 26);
            this.txtadekle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txthastaidguncelle);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txttelguncelle);
            this.groupBox2.Controls.Add(this.cmbcinsiyetguncelle);
            this.groupBox2.Controls.Add(this.txthastaadiguncelle);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.msktcguncelle);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.nmyasguncelle);
            this.groupBox2.Controls.Add(this.txthastasoyadiguncelle);
            this.groupBox2.Controls.Add(this.btnguncelle);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtmailguncelle);
            this.groupBox2.Location = new System.Drawing.Point(699, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 364);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta Güncelle";
            // 
            // txthastaidguncelle
            // 
            this.txthastaidguncelle.Enabled = false;
            this.txthastaidguncelle.Location = new System.Drawing.Point(138, 58);
            this.txthastaidguncelle.Name = "txthastaidguncelle";
            this.txthastaidguncelle.Size = new System.Drawing.Size(204, 26);
            this.txthastaidguncelle.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(55, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Hasta ID:";
            // 
            // txttelguncelle
            // 
            this.txttelguncelle.Enabled = false;
            this.txttelguncelle.Location = new System.Drawing.Point(138, 253);
            this.txttelguncelle.MaxLength = 10;
            this.txttelguncelle.Name = "txttelguncelle";
            this.txttelguncelle.Size = new System.Drawing.Size(204, 26);
            this.txttelguncelle.TabIndex = 13;
            // 
            // cmbcinsiyetguncelle
            // 
            this.cmbcinsiyetguncelle.Enabled = false;
            this.cmbcinsiyetguncelle.FormattingEnabled = true;
            this.cmbcinsiyetguncelle.Items.AddRange(new object[] {
            "Erkek",
            "Bayan"});
            this.cmbcinsiyetguncelle.Location = new System.Drawing.Point(435, 98);
            this.cmbcinsiyetguncelle.Name = "cmbcinsiyetguncelle";
            this.cmbcinsiyetguncelle.Size = new System.Drawing.Size(204, 28);
            this.cmbcinsiyetguncelle.TabIndex = 22;
            // 
            // txthastaadiguncelle
            // 
            this.txthastaadiguncelle.Enabled = false;
            this.txthastaadiguncelle.Location = new System.Drawing.Point(138, 100);
            this.txthastaadiguncelle.Name = "txthastaadiguncelle";
            this.txthastaadiguncelle.Size = new System.Drawing.Size(204, 26);
            this.txthastaadiguncelle.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Hasta Adı:";
            // 
            // msktcguncelle
            // 
            this.msktcguncelle.Enabled = false;
            this.msktcguncelle.Location = new System.Drawing.Point(138, 202);
            this.msktcguncelle.Mask = "00000000000";
            this.msktcguncelle.Name = "msktcguncelle";
            this.msktcguncelle.Size = new System.Drawing.Size(204, 26);
            this.msktcguncelle.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "Hasta Soyadı:";
            // 
            // nmyasguncelle
            // 
            this.nmyasguncelle.Enabled = false;
            this.nmyasguncelle.Location = new System.Drawing.Point(435, 56);
            this.nmyasguncelle.Name = "nmyasguncelle";
            this.nmyasguncelle.Size = new System.Drawing.Size(204, 26);
            this.nmyasguncelle.TabIndex = 21;
            // 
            // txthastasoyadiguncelle
            // 
            this.txthastasoyadiguncelle.Enabled = false;
            this.txthastasoyadiguncelle.Location = new System.Drawing.Point(138, 151);
            this.txthastasoyadiguncelle.Name = "txthastasoyadiguncelle";
            this.txthastasoyadiguncelle.Size = new System.Drawing.Size(204, 26);
            this.txthastasoyadiguncelle.TabIndex = 15;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Enabled = false;
            this.btnguncelle.Location = new System.Drawing.Point(542, 132);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(97, 33);
            this.btnguncelle.TabIndex = 24;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(99, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "TC:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Cinsiyet:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(98, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tel:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(378, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Yaş:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Mail:";
            // 
            // txtmailguncelle
            // 
            this.txtmailguncelle.Enabled = false;
            this.txtmailguncelle.Location = new System.Drawing.Point(138, 304);
            this.txtmailguncelle.Name = "txtmailguncelle";
            this.txtmailguncelle.Size = new System.Drawing.Size(204, 26);
            this.txtmailguncelle.TabIndex = 19;
            // 
            // HastaIslemleriEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 705);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HastaIslemleriEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaIslemleriEkran";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HastaIslemleriEkran_FormClosing);
            this.Load += new System.EventHandler(this.HastaIslemleriEkran_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmyasekle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmyasguncelle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox msktcekle;
        private System.Windows.Forms.NumericUpDown nmyasekle;
        private System.Windows.Forms.Button btnhastaekle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmailekle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoyadekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbcinsiyetekle;
        private System.Windows.Forms.ComboBox cmbcinsiyetguncelle;
        private System.Windows.Forms.TextBox txthastaadiguncelle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox msktcguncelle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nmyasguncelle;
        private System.Windows.Forms.TextBox txthastasoyadiguncelle;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmailguncelle;
        private System.Windows.Forms.TextBox txttelekle;
        private System.Windows.Forms.TextBox txttelguncelle;
        private System.Windows.Forms.TextBox txthastaidguncelle;
        private System.Windows.Forms.Label label15;
    }
}