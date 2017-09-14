namespace Change_Search_Machine
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextBoxGoogle = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBoxCustom = new System.Windows.Forms.TextBox();
            this.RadioButtonCustom = new System.Windows.Forms.RadioButton();
            this.RadioButtonGoogle = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RadioButtonDuckDuckGo = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxGoogle
            // 
            this.TextBoxGoogle.Location = new System.Drawing.Point(235, 123);
            this.TextBoxGoogle.Name = "TextBoxGoogle";
            this.TextBoxGoogle.Size = new System.Drawing.Size(137, 29);
            this.TextBoxGoogle.TabIndex = 1;
            this.TextBoxGoogle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxGoogle_KeyDown);
            // 
            // Button1
            // 
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.ForeColor = System.Drawing.Color.Black;
            this.Button1.Location = new System.Drawing.Point(20, 22);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(360, 37);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Reset to Bing (default)";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBoxCustom
            // 
            this.TextBoxCustom.Location = new System.Drawing.Point(36, 48);
            this.TextBoxCustom.Name = "TextBoxCustom";
            this.TextBoxCustom.Size = new System.Drawing.Size(341, 29);
            this.TextBoxCustom.TabIndex = 7;
            this.TextBoxCustom.Tag = "";
            this.TextBoxCustom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxCustom_KeyDown);
            // 
            // RadioButtonCustom
            // 
            this.RadioButtonCustom.AutoSize = true;
            this.RadioButtonCustom.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RadioButtonCustom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioButtonCustom.ForeColor = System.Drawing.Color.Black;
            this.RadioButtonCustom.Location = new System.Drawing.Point(17, 14);
            this.RadioButtonCustom.Name = "RadioButtonCustom";
            this.RadioButtonCustom.Size = new System.Drawing.Size(278, 28);
            this.RadioButtonCustom.TabIndex = 9;
            this.RadioButtonCustom.TabStop = true;
            this.RadioButtonCustom.Text = "Use Custom Search Machine:";
            this.RadioButtonCustom.UseVisualStyleBackColor = false;
            this.RadioButtonCustom.CheckedChanged += new System.EventHandler(this.RadioButtonCustom_CheckedChanged);
            // 
            // RadioButtonGoogle
            // 
            this.RadioButtonGoogle.AutoSize = true;
            this.RadioButtonGoogle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioButtonGoogle.Location = new System.Drawing.Point(12, 92);
            this.RadioButtonGoogle.Name = "RadioButtonGoogle";
            this.RadioButtonGoogle.Size = new System.Drawing.Size(230, 28);
            this.RadioButtonGoogle.TabIndex = 10;
            this.RadioButtonGoogle.TabStop = true;
            this.RadioButtonGoogle.Text = "Use Google (supported)";
            this.RadioButtonGoogle.UseVisualStyleBackColor = true;
            this.RadioButtonGoogle.CheckedChanged += new System.EventHandler(this.RadioButtonGoogle_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter your country code:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.TextBoxCustom);
            this.panel1.Controls.Add(this.RadioButtonCustom);
            this.panel1.ForeColor = System.Drawing.Color.Cornsilk;
            this.panel1.Location = new System.Drawing.Point(-5, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 258);
            this.panel1.TabIndex = 14;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(36, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(341, 175);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.Button1);
            this.panel2.ForeColor = System.Drawing.Color.Cornsilk;
            this.panel2.Location = new System.Drawing.Point(-8, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 75);
            this.panel2.TabIndex = 15;
            // 
            // RadioButtonDuckDuckGo
            // 
            this.RadioButtonDuckDuckGo.AutoSize = true;
            this.RadioButtonDuckDuckGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioButtonDuckDuckGo.Location = new System.Drawing.Point(12, 169);
            this.RadioButtonDuckDuckGo.Name = "RadioButtonDuckDuckGo";
            this.RadioButtonDuckDuckGo.Size = new System.Drawing.Size(279, 28);
            this.RadioButtonDuckDuckGo.TabIndex = 17;
            this.RadioButtonDuckDuckGo.TabStop = true;
            this.RadioButtonDuckDuckGo.Text = "Use DuckDuckGo (supported)";
            this.RadioButtonDuckDuckGo.UseVisualStyleBackColor = true;
            this.RadioButtonDuckDuckGo.CheckedChanged += new System.EventHandler(this.RadioButtonDuckDuckGo_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 471);
            this.Controls.Add(this.RadioButtonDuckDuckGo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxGoogle);
            this.Controls.Add(this.RadioButtonGoogle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(400, 510);
            this.MinimumSize = new System.Drawing.Size(400, 510);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Cortanas Search Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxGoogle;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox TextBoxCustom;
        private System.Windows.Forms.RadioButton RadioButtonCustom;
        private System.Windows.Forms.RadioButton RadioButtonGoogle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RadioButtonDuckDuckGo;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

