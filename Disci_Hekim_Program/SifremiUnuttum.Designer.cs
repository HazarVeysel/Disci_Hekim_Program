namespace Disci_Hekim_Program
{
    partial class SifremiUnuttum
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
            this.txtmail = new System.Windows.Forms.TextBox();
            this.btngonder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndogrula = new System.Windows.Forms.Button();
            this.txtdorduncu = new System.Windows.Forms.TextBox();
            this.txtucuncu = new System.Windows.Forms.TextBox();
            this.txtikinci = new System.Windows.Forms.TextBox();
            this.txtilk = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(12, 99);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(333, 26);
            this.txtmail.TabIndex = 0;
            // 
            // btngonder
            // 
            this.btngonder.Location = new System.Drawing.Point(351, 99);
            this.btngonder.Name = "btngonder";
            this.btngonder.Size = new System.Drawing.Size(86, 26);
            this.btngonder.TabIndex = 1;
            this.btngonder.Text = "Gönder";
            this.btngonder.UseVisualStyleBackColor = true;
            this.btngonder.Click += new System.EventHandler(this.btngonder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndogrula);
            this.groupBox1.Controls.Add(this.txtdorduncu);
            this.groupBox1.Controls.Add(this.txtucuncu);
            this.groupBox1.Controls.Add(this.txtikinci);
            this.groupBox1.Controls.Add(this.txtilk);
            this.groupBox1.Location = new System.Drawing.Point(12, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doğrulama Ekranı";
            this.groupBox1.Visible = false;
            // 
            // btndogrula
            // 
            this.btndogrula.Location = new System.Drawing.Point(234, 60);
            this.btndogrula.Name = "btndogrula";
            this.btndogrula.Size = new System.Drawing.Size(75, 30);
            this.btndogrula.TabIndex = 4;
            this.btndogrula.Text = "Doğrula";
            this.btndogrula.UseVisualStyleBackColor = true;
            this.btndogrula.Click += new System.EventHandler(this.btndogrula_Click);
            // 
            // txtdorduncu
            // 
            this.txtdorduncu.Location = new System.Drawing.Point(195, 62);
            this.txtdorduncu.MaxLength = 1;
            this.txtdorduncu.Name = "txtdorduncu";
            this.txtdorduncu.Size = new System.Drawing.Size(33, 26);
            this.txtdorduncu.TabIndex = 3;
            // 
            // txtucuncu
            // 
            this.txtucuncu.Location = new System.Drawing.Point(156, 62);
            this.txtucuncu.MaxLength = 1;
            this.txtucuncu.Name = "txtucuncu";
            this.txtucuncu.Size = new System.Drawing.Size(33, 26);
            this.txtucuncu.TabIndex = 2;
            this.txtucuncu.TextChanged += new System.EventHandler(this.txtucuncu_TextChanged);
            // 
            // txtikinci
            // 
            this.txtikinci.Location = new System.Drawing.Point(117, 62);
            this.txtikinci.MaxLength = 1;
            this.txtikinci.Name = "txtikinci";
            this.txtikinci.Size = new System.Drawing.Size(33, 26);
            this.txtikinci.TabIndex = 1;
            this.txtikinci.TextChanged += new System.EventHandler(this.txtikinci_TextChanged);
            // 
            // txtilk
            // 
            this.txtilk.Location = new System.Drawing.Point(78, 62);
            this.txtilk.MaxLength = 1;
            this.txtilk.Name = "txtilk";
            this.txtilk.Size = new System.Drawing.Size(33, 26);
            this.txtilk.TabIndex = 0;
            this.txtilk.TextChanged += new System.EventHandler(this.txtilk_TextChanged);
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btngonder);
            this.Controls.Add(this.txtmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifremiUnuttum";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SifremiUnuttum_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Button btngonder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndogrula;
        private System.Windows.Forms.TextBox txtdorduncu;
        private System.Windows.Forms.TextBox txtucuncu;
        private System.Windows.Forms.TextBox txtikinci;
        private System.Windows.Forms.TextBox txtilk;
    }
}