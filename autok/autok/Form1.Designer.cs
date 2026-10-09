namespace autok
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnBeolvas = new System.Windows.Forms.Button();
            this.btnRendez = new System.Windows.Forms.Button();
            this.btnLegregebbi = new System.Windows.Forms.Button();
            this.btnLegujabb = new System.Windows.Forms.Button();
            this.btnKeres = new System.Windows.Forms.Button();
            this.txtEv = new System.Windows.Forms.TextBox();
            this.lblEredmeny = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(67, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 303);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnBeolvas
            // 
            this.btnBeolvas.Location = new System.Drawing.Point(337, 67);
            this.btnBeolvas.Name = "btnBeolvas";
            this.btnBeolvas.Size = new System.Drawing.Size(75, 23);
            this.btnBeolvas.TabIndex = 1;
            this.btnBeolvas.Text = "Betölt";
            this.btnBeolvas.UseVisualStyleBackColor = true;
            this.btnBeolvas.Click += new System.EventHandler(this.btnBeolvas_Click);
            // 
            // btnRendez
            // 
            this.btnRendez.Location = new System.Drawing.Point(337, 96);
            this.btnRendez.Name = "btnRendez";
            this.btnRendez.Size = new System.Drawing.Size(75, 23);
            this.btnRendez.TabIndex = 2;
            this.btnRendez.Text = "Rendezés";
            this.btnRendez.UseVisualStyleBackColor = true;
            this.btnRendez.Click += new System.EventHandler(this.btnRendez_Click);
            // 
            // btnLegregebbi
            // 
            this.btnLegregebbi.Location = new System.Drawing.Point(337, 125);
            this.btnLegregebbi.Name = "btnLegregebbi";
            this.btnLegregebbi.Size = new System.Drawing.Size(75, 23);
            this.btnLegregebbi.TabIndex = 3;
            this.btnLegregebbi.Text = "Legrégebbi";
            this.btnLegregebbi.UseVisualStyleBackColor = true;
            this.btnLegregebbi.Click += new System.EventHandler(this.btnLegregebbi_Click);
            // 
            // btnLegujabb
            // 
            this.btnLegujabb.Location = new System.Drawing.Point(337, 154);
            this.btnLegujabb.Name = "btnLegujabb";
            this.btnLegujabb.Size = new System.Drawing.Size(75, 23);
            this.btnLegujabb.TabIndex = 4;
            this.btnLegujabb.Text = "Legújabb";
            this.btnLegujabb.UseVisualStyleBackColor = true;
            this.btnLegujabb.Click += new System.EventHandler(this.btnLegujabb_Click);
            // 
            // btnKeres
            // 
            this.btnKeres.Location = new System.Drawing.Point(337, 183);
            this.btnKeres.Name = "btnKeres";
            this.btnKeres.Size = new System.Drawing.Size(75, 23);
            this.btnKeres.TabIndex = 5;
            this.btnKeres.Text = "Keresés";
            this.btnKeres.UseVisualStyleBackColor = true;
            this.btnKeres.Click += new System.EventHandler(this.btnKeres_Click);
            // 
            // txtEv
            // 
            this.txtEv.Location = new System.Drawing.Point(564, 125);
            this.txtEv.Name = "txtEv";
            this.txtEv.Size = new System.Drawing.Size(100, 20);
            this.txtEv.TabIndex = 6;
            this.txtEv.TextChanged += new System.EventHandler(this.txtEv_TextChanged);
            // 
            // lblEredmeny
            // 
            this.lblEredmeny.AutoSize = true;
            this.lblEredmeny.Location = new System.Drawing.Point(337, 274);
            this.lblEredmeny.Name = "lblEredmeny";
            this.lblEredmeny.Size = new System.Drawing.Size(35, 13);
            this.lblEredmeny.TabIndex = 7;
            this.lblEredmeny.Text = "label1";
            this.lblEredmeny.Click += new System.EventHandler(this.lblEredmeny_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEredmeny);
            this.Controls.Add(this.txtEv);
            this.Controls.Add(this.btnKeres);
            this.Controls.Add(this.btnLegujabb);
            this.Controls.Add(this.btnLegregebbi);
            this.Controls.Add(this.btnRendez);
            this.Controls.Add(this.btnBeolvas);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Autók";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBeolvas;
        private System.Windows.Forms.Button btnRendez;
        private System.Windows.Forms.Button btnLegregebbi;
        private System.Windows.Forms.Button btnLegujabb;
        private System.Windows.Forms.Button btnKeres;
        private System.Windows.Forms.TextBox txtEv;
        private System.Windows.Forms.Label lblEredmeny;
    }
}

