namespace Disci_Hekim_Program
{
    partial class HizmetIslemleriEkran
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhizmetekle = new System.Windows.Forms.Button();
            this.txthizmetfiyatekle = new System.Windows.Forms.TextBox();
            this.txthizmetadiekle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtidguncelle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txthizmetadiguncelle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txthizmetfiyatguncelle = new System.Windows.Forms.TextBox();
            this.btnhizmetguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1354, 403);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnhizmetekle);
            this.groupBox1.Controls.Add(this.txthizmetfiyatekle);
            this.groupBox1.Controls.Add(this.txthizmetadiekle);
            this.groupBox1.Location = new System.Drawing.Point(12, 421);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hizmet Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hizmet Fiyatı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hizmet Adı:";
            // 
            // btnhizmetekle
            // 
            this.btnhizmetekle.Location = new System.Drawing.Point(397, 165);
            this.btnhizmetekle.Name = "btnhizmetekle";
            this.btnhizmetekle.Size = new System.Drawing.Size(153, 37);
            this.btnhizmetekle.TabIndex = 2;
            this.btnhizmetekle.Text = "Hizmet Ekle";
            this.btnhizmetekle.UseVisualStyleBackColor = true;
            this.btnhizmetekle.Click += new System.EventHandler(this.btnhizmetekle_Click);
            // 
            // txthizmetfiyatekle
            // 
            this.txthizmetfiyatekle.Location = new System.Drawing.Point(194, 133);
            this.txthizmetfiyatekle.Name = "txthizmetfiyatekle";
            this.txthizmetfiyatekle.Size = new System.Drawing.Size(356, 26);
            this.txthizmetfiyatekle.TabIndex = 1;
            this.txthizmetfiyatekle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthizmetfiyatekle_KeyPress);
            // 
            // txthizmetadiekle
            // 
            this.txthizmetadiekle.Location = new System.Drawing.Point(194, 91);
            this.txthizmetadiekle.Name = "txthizmetadiekle";
            this.txthizmetadiekle.Size = new System.Drawing.Size(356, 26);
            this.txthizmetadiekle.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtidguncelle);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txthizmetadiguncelle);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txthizmetfiyatguncelle);
            this.groupBox2.Controls.Add(this.btnhizmetguncelle);
            this.groupBox2.Location = new System.Drawing.Point(674, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 272);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hizmet Güncelle";
            // 
            // txtidguncelle
            // 
            this.txtidguncelle.Enabled = false;
            this.txtidguncelle.Location = new System.Drawing.Point(214, 62);
            this.txtidguncelle.Name = "txtidguncelle";
            this.txtidguncelle.Size = new System.Drawing.Size(356, 26);
            this.txtidguncelle.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hizmet ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hizmet Fiyatı:";
            // 
            // txthizmetadiguncelle
            // 
            this.txthizmetadiguncelle.Enabled = false;
            this.txthizmetadiguncelle.Location = new System.Drawing.Point(214, 108);
            this.txthizmetadiguncelle.Name = "txthizmetadiguncelle";
            this.txthizmetadiguncelle.Size = new System.Drawing.Size(356, 26);
            this.txthizmetadiguncelle.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hizmet Adı:";
            // 
            // txthizmetfiyatguncelle
            // 
            this.txthizmetfiyatguncelle.Enabled = false;
            this.txthizmetfiyatguncelle.Location = new System.Drawing.Point(214, 154);
            this.txthizmetfiyatguncelle.Name = "txthizmetfiyatguncelle";
            this.txthizmetfiyatguncelle.Size = new System.Drawing.Size(356, 26);
            this.txthizmetfiyatguncelle.TabIndex = 6;
            this.txthizmetfiyatguncelle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthizmetfiyatguncelle_KeyPress);
            // 
            // btnhizmetguncelle
            // 
            this.btnhizmetguncelle.Enabled = false;
            this.btnhizmetguncelle.Location = new System.Drawing.Point(417, 186);
            this.btnhizmetguncelle.Name = "btnhizmetguncelle";
            this.btnhizmetguncelle.Size = new System.Drawing.Size(153, 37);
            this.btnhizmetguncelle.TabIndex = 7;
            this.btnhizmetguncelle.Text = "Hizmet Güncelle";
            this.btnhizmetguncelle.UseVisualStyleBackColor = true;
            this.btnhizmetguncelle.Click += new System.EventHandler(this.btnhizmetguncelle_Click);
            // 
            // HizmetIslemleriEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 705);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HizmetIslemleriEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HizmetIslemleriEkran";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HizmetIslemleriEkran_FormClosing);
            this.Load += new System.EventHandler(this.HizmetIslemleriEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhizmetekle;
        private System.Windows.Forms.TextBox txthizmetfiyatekle;
        private System.Windows.Forms.TextBox txthizmetadiekle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtidguncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthizmetadiguncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthizmetfiyatguncelle;
        private System.Windows.Forms.Button btnhizmetguncelle;
    }
}