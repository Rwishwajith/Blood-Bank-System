namespace WindowsFormsApplication22
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.frmknw = new System.Windows.Forms.Panel();
            this.btnafterdonation = new System.Windows.Forms.Button();
            this.btndonate = new System.Windows.Forms.Button();
            this.btnmedical = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnfacts = new System.Windows.Forms.Button();
            this.btnwhatblood = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfacts = new System.Windows.Forms.TextBox();
            this.txtregister = new System.Windows.Forms.TextBox();
            this.txtblood = new System.Windows.Forms.TextBox();
            this.txtmedical = new System.Windows.Forms.TextBox();
            this.txthowtodonate = new System.Windows.Forms.TextBox();
            this.txtafterdonation = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.frmknw.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmknw
            // 
            this.frmknw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frmknw.BackgroundImage")));
            this.frmknw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frmknw.Controls.Add(this.btnback);
            this.frmknw.Controls.Add(this.txtafterdonation);
            this.frmknw.Controls.Add(this.txthowtodonate);
            this.frmknw.Controls.Add(this.txtmedical);
            this.frmknw.Controls.Add(this.txtregister);
            this.frmknw.Controls.Add(this.txtfacts);
            this.frmknw.Controls.Add(this.txtblood);
            this.frmknw.Controls.Add(this.btnafterdonation);
            this.frmknw.Controls.Add(this.btndonate);
            this.frmknw.Controls.Add(this.btnmedical);
            this.frmknw.Controls.Add(this.btnregister);
            this.frmknw.Controls.Add(this.btnfacts);
            this.frmknw.Controls.Add(this.btnwhatblood);
            this.frmknw.Controls.Add(this.label1);
            this.frmknw.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmknw.Location = new System.Drawing.Point(-2, 4);
            this.frmknw.Name = "frmknw";
            this.frmknw.Size = new System.Drawing.Size(757, 508);
            this.frmknw.TabIndex = 0;
            this.frmknw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlknowledge_Paint);
            // 
            // btnafterdonation
            // 
            this.btnafterdonation.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnafterdonation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnafterdonation.Location = new System.Drawing.Point(465, 126);
            this.btnafterdonation.Name = "btnafterdonation";
            this.btnafterdonation.Size = new System.Drawing.Size(178, 49);
            this.btnafterdonation.TabIndex = 3;
            this.btnafterdonation.Text = "After Donation";
            this.btnafterdonation.UseVisualStyleBackColor = false;
            this.btnafterdonation.Click += new System.EventHandler(this.btnafterdonation_Click);
            // 
            // btndonate
            // 
            this.btndonate.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btndonate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndonate.Location = new System.Drawing.Point(249, 126);
            this.btndonate.Name = "btndonate";
            this.btndonate.Size = new System.Drawing.Size(172, 49);
            this.btndonate.TabIndex = 3;
            this.btndonate.Text = "How To Donate";
            this.btndonate.UseVisualStyleBackColor = false;
            this.btndonate.Click += new System.EventHandler(this.btndonate_Click);
            // 
            // btnmedical
            // 
            this.btnmedical.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnmedical.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmedical.Location = new System.Drawing.Point(40, 126);
            this.btnmedical.Name = "btnmedical";
            this.btnmedical.Size = new System.Drawing.Size(166, 49);
            this.btnmedical.TabIndex = 3;
            this.btnmedical.Text = "Medical History";
            this.btnmedical.UseVisualStyleBackColor = false;
            this.btnmedical.Click += new System.EventHandler(this.btnmedical_Click);
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregister.Location = new System.Drawing.Point(465, 76);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(178, 47);
            this.btnregister.TabIndex = 3;
            this.btnregister.Text = "How To Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnfacts
            // 
            this.btnfacts.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnfacts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfacts.Location = new System.Drawing.Point(251, 76);
            this.btnfacts.Name = "btnfacts";
            this.btnfacts.Size = new System.Drawing.Size(170, 47);
            this.btnfacts.TabIndex = 2;
            this.btnfacts.Text = "Facts to know Before";
            this.btnfacts.UseVisualStyleBackColor = false;
            this.btnfacts.Click += new System.EventHandler(this.btnfacts_Click);
            // 
            // btnwhatblood
            // 
            this.btnwhatblood.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnwhatblood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnwhatblood.Location = new System.Drawing.Point(40, 76);
            this.btnwhatblood.Name = "btnwhatblood";
            this.btnwhatblood.Size = new System.Drawing.Size(166, 47);
            this.btnwhatblood.TabIndex = 1;
            this.btnwhatblood.Text = "What is Blood";
            this.btnwhatblood.UseVisualStyleBackColor = false;
            this.btnwhatblood.Click += new System.EventHandler(this.btnwhatblood_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(193, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "For Your Knowledge";
            // 
            // txtfacts
            // 
            this.txtfacts.BackColor = System.Drawing.Color.AliceBlue;
            this.txtfacts.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfacts.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtfacts.Location = new System.Drawing.Point(36, 187);
            this.txtfacts.Multiline = true;
            this.txtfacts.Name = "txtfacts";
            this.txtfacts.ReadOnly = true;
            this.txtfacts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtfacts.Size = new System.Drawing.Size(607, 264);
            this.txtfacts.TabIndex = 6;
            this.txtfacts.Text = resources.GetString("txtfacts.Text");
            this.txtfacts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtregister
            // 
            this.txtregister.BackColor = System.Drawing.Color.Honeydew;
            this.txtregister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtregister.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtregister.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtregister.Location = new System.Drawing.Point(36, 187);
            this.txtregister.Multiline = true;
            this.txtregister.Name = "txtregister";
            this.txtregister.ReadOnly = true;
            this.txtregister.Size = new System.Drawing.Size(607, 264);
            this.txtregister.TabIndex = 6;
            this.txtregister.Text = resources.GetString("txtregister.Text");
            this.txtregister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtblood
            // 
            this.txtblood.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtblood.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtblood.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtblood.Location = new System.Drawing.Point(36, 187);
            this.txtblood.Multiline = true;
            this.txtblood.Name = "txtblood";
            this.txtblood.ReadOnly = true;
            this.txtblood.Size = new System.Drawing.Size(607, 264);
            this.txtblood.TabIndex = 6;
            this.txtblood.Text = resources.GetString("txtblood.Text");
            this.txtblood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmedical
            // 
            this.txtmedical.BackColor = System.Drawing.Color.PeachPuff;
            this.txtmedical.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmedical.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmedical.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtmedical.Location = new System.Drawing.Point(36, 187);
            this.txtmedical.Multiline = true;
            this.txtmedical.Name = "txtmedical";
            this.txtmedical.ReadOnly = true;
            this.txtmedical.Size = new System.Drawing.Size(607, 264);
            this.txtmedical.TabIndex = 7;
            this.txtmedical.Text = resources.GetString("txtmedical.Text");
            this.txtmedical.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txthowtodonate
            // 
            this.txthowtodonate.BackColor = System.Drawing.Color.MistyRose;
            this.txthowtodonate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txthowtodonate.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthowtodonate.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txthowtodonate.Location = new System.Drawing.Point(36, 187);
            this.txthowtodonate.Multiline = true;
            this.txthowtodonate.Name = "txthowtodonate";
            this.txthowtodonate.ReadOnly = true;
            this.txthowtodonate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txthowtodonate.Size = new System.Drawing.Size(607, 264);
            this.txthowtodonate.TabIndex = 8;
            this.txthowtodonate.Text = resources.GetString("txthowtodonate.Text");
            this.txthowtodonate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtafterdonation
            // 
            this.txtafterdonation.BackColor = System.Drawing.Color.Beige;
            this.txtafterdonation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtafterdonation.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtafterdonation.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtafterdonation.Location = new System.Drawing.Point(36, 190);
            this.txtafterdonation.Multiline = true;
            this.txtafterdonation.Name = "txtafterdonation";
            this.txtafterdonation.ReadOnly = true;
            this.txtafterdonation.Size = new System.Drawing.Size(607, 264);
            this.txtafterdonation.TabIndex = 9;
            this.txtafterdonation.Text = resources.GetString("txtafterdonation.Text");
            this.txtafterdonation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Gray;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Location = new System.Drawing.Point(26, 16);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 30);
            this.btnback.TabIndex = 10;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 478);
            this.Controls.Add(this.frmknw);
            this.Name = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.frmknw.ResumeLayout(false);
            this.frmknw.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel frmknw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnafterdonation;
        private System.Windows.Forms.Button btndonate;
        private System.Windows.Forms.Button btnmedical;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnfacts;
        private System.Windows.Forms.Button btnwhatblood;
        private System.Windows.Forms.TextBox txtregister;
        private System.Windows.Forms.TextBox txtfacts;
        private System.Windows.Forms.TextBox txtblood;
        private System.Windows.Forms.TextBox txtafterdonation;
        private System.Windows.Forms.TextBox txthowtodonate;
        private System.Windows.Forms.TextBox txtmedical;
        private System.Windows.Forms.Button btnback;
    }
}