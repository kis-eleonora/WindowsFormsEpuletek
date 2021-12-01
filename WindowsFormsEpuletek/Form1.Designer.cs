
namespace WindowsFormsEpuletek
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox_Epuletek = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_tipus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_cim = new System.Windows.Forms.TextBox();
            this.textBox_alapterulet = new System.Windows.Forms.TextBox();
            this.textBox_kezdet = new System.Windows.Forms.TextBox();
            this.textBox_anyag = new System.Windows.Forms.TextBox();
            this.textBox_ottelok = new System.Windows.Forms.TextBox();
            this.textBox_vege = new System.Windows.Forms.TextBox();
            this.textBox_teto = new System.Windows.Forms.TextBox();
            this.textBox_garazs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox_Epuletek
            // 
            this.listBox_Epuletek.FormattingEnabled = true;
            this.listBox_Epuletek.ItemHeight = 25;
            this.listBox_Epuletek.Location = new System.Drawing.Point(37, 47);
            this.listBox_Epuletek.Name = "listBox_Epuletek";
            this.listBox_Epuletek.Size = new System.Drawing.Size(361, 429);
            this.listBox_Epuletek.TabIndex = 0;
            this.listBox_Epuletek.SelectedIndexChanged += new System.EventHandler(this.listBox_Epuletek_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(481, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Típus:";
            // 
            // label_tipus
            // 
            this.label_tipus.AutoSize = true;
            this.label_tipus.Location = new System.Drawing.Point(595, 47);
            this.label_tipus.Name = "label_tipus";
            this.label_tipus.Size = new System.Drawing.Size(64, 25);
            this.label_tipus.TabIndex = 3;
            this.label_tipus.Text = "label3";
            this.label_tipus.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cím:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Alapterület:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Építési anyag:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(481, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Munkavégzés kezdete:";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tető típusa:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(482, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Garázs:";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(482, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ottélők száma:";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(482, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "Munkavégzés vége:";
            this.label11.Visible = false;
            // 
            // textBox_cim
            // 
            this.textBox_cim.Location = new System.Drawing.Point(772, 117);
            this.textBox_cim.Name = "textBox_cim";
            this.textBox_cim.Size = new System.Drawing.Size(206, 30);
            this.textBox_cim.TabIndex = 12;
            this.textBox_cim.Visible = false;
            // 
            // textBox_alapterulet
            // 
            this.textBox_alapterulet.Location = new System.Drawing.Point(772, 168);
            this.textBox_alapterulet.Name = "textBox_alapterulet";
            this.textBox_alapterulet.Size = new System.Drawing.Size(206, 30);
            this.textBox_alapterulet.TabIndex = 13;
            this.textBox_alapterulet.Visible = false;
            // 
            // textBox_kezdet
            // 
            this.textBox_kezdet.Location = new System.Drawing.Point(772, 260);
            this.textBox_kezdet.Name = "textBox_kezdet";
            this.textBox_kezdet.Size = new System.Drawing.Size(206, 30);
            this.textBox_kezdet.TabIndex = 15;
            this.textBox_kezdet.Visible = false;
            // 
            // textBox_anyag
            // 
            this.textBox_anyag.Location = new System.Drawing.Point(772, 209);
            this.textBox_anyag.Name = "textBox_anyag";
            this.textBox_anyag.Size = new System.Drawing.Size(206, 30);
            this.textBox_anyag.TabIndex = 14;
            this.textBox_anyag.Visible = false;
            // 
            // textBox_ottelok
            // 
            this.textBox_ottelok.Location = new System.Drawing.Point(772, 364);
            this.textBox_ottelok.Name = "textBox_ottelok";
            this.textBox_ottelok.Size = new System.Drawing.Size(206, 30);
            this.textBox_ottelok.TabIndex = 17;
            this.textBox_ottelok.Visible = false;
            // 
            // textBox_vege
            // 
            this.textBox_vege.Location = new System.Drawing.Point(772, 313);
            this.textBox_vege.Name = "textBox_vege";
            this.textBox_vege.Size = new System.Drawing.Size(206, 30);
            this.textBox_vege.TabIndex = 16;
            this.textBox_vege.Visible = false;
            // 
            // textBox_teto
            // 
            this.textBox_teto.Location = new System.Drawing.Point(772, 460);
            this.textBox_teto.Name = "textBox_teto";
            this.textBox_teto.Size = new System.Drawing.Size(206, 30);
            this.textBox_teto.TabIndex = 19;
            this.textBox_teto.Visible = false;
            // 
            // textBox_garazs
            // 
            this.textBox_garazs.Location = new System.Drawing.Point(772, 409);
            this.textBox_garazs.Name = "textBox_garazs";
            this.textBox_garazs.Size = new System.Drawing.Size(206, 30);
            this.textBox_garazs.TabIndex = 18;
            this.textBox_garazs.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.textBox_teto);
            this.Controls.Add(this.textBox_garazs);
            this.Controls.Add(this.textBox_ottelok);
            this.Controls.Add(this.textBox_vege);
            this.Controls.Add(this.textBox_kezdet);
            this.Controls.Add(this.textBox_anyag);
            this.Controls.Add(this.textBox_alapterulet);
            this.Controls.Add(this.textBox_cim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_tipus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Epuletek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Épületek";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Epuletek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_tipus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_cim;
        private System.Windows.Forms.TextBox textBox_alapterulet;
        private System.Windows.Forms.TextBox textBox_kezdet;
        private System.Windows.Forms.TextBox textBox_anyag;
        private System.Windows.Forms.TextBox textBox_ottelok;
        private System.Windows.Forms.TextBox textBox_vege;
        private System.Windows.Forms.TextBox textBox_teto;
        private System.Windows.Forms.TextBox textBox_garazs;
    }
}

