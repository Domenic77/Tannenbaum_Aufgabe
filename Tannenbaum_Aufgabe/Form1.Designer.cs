namespace Tannenbaum_Aufgabe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StammbreiteTextBox = new System.Windows.Forms.TextBox();
            this.StammhoeheTextBox = new System.Windows.Forms.TextBox();
            this.KronenhoeheTextBox = new System.Windows.Forms.TextBox();
            this.TanneZeichnenButton = new System.Windows.Forms.Button();
            this.Ausgabe = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stammbreite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 140);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kronenhöhe";
         
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stammhöhe";
            // 
            // StammbreiteTextBox
            // 
            this.StammbreiteTextBox.Location = new System.Drawing.Point(180, 33);
            this.StammbreiteTextBox.Name = "StammbreiteTextBox";
            this.StammbreiteTextBox.Size = new System.Drawing.Size(146, 26);
            this.StammbreiteTextBox.TabIndex = 3;
            // 
            // StammhoeheTextBox
            // 
            this.StammhoeheTextBox.Location = new System.Drawing.Point(180, 85);
            this.StammhoeheTextBox.Name = "StammhoeheTextBox";
            this.StammhoeheTextBox.Size = new System.Drawing.Size(146, 26);
            this.StammhoeheTextBox.TabIndex = 4;
            // 
            // KronenhoeheTextBox
            // 
            this.KronenhoeheTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.KronenhoeheTextBox.Location = new System.Drawing.Point(180, 134);
            this.KronenhoeheTextBox.Name = "KronenhoeheTextBox";
            this.KronenhoeheTextBox.Size = new System.Drawing.Size(146, 26);
            this.KronenhoeheTextBox.TabIndex = 5;
            // 
            // TanneZeichnenButton
            // 
            this.TanneZeichnenButton.Location = new System.Drawing.Point(383, 119);
            this.TanneZeichnenButton.Name = "TanneZeichnenButton";
            this.TanneZeichnenButton.Size = new System.Drawing.Size(232, 56);
            this.TanneZeichnenButton.TabIndex = 6;
            this.TanneZeichnenButton.Text = "Tanne Zeichen";
            this.TanneZeichnenButton.UseVisualStyleBackColor = true;
            this.TanneZeichnenButton.Click += new System.EventHandler(this.TanneZeichnenButton_Click_1);
            // 
            // Ausgabe
            // 
            this.Ausgabe.Location = new System.Drawing.Point(30, 227);
            this.Ausgabe.Name = "Ausgabe";
            this.Ausgabe.Size = new System.Drawing.Size(585, 668);
            this.Ausgabe.TabIndex = 7;
            this.Ausgabe.Text = "";
        
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(668, 1017);
            this.Controls.Add(this.Ausgabe);
            this.Controls.Add(this.TanneZeichnenButton);
            this.Controls.Add(this.KronenhoeheTextBox);
            this.Controls.Add(this.StammhoeheTextBox);
            this.Controls.Add(this.StammbreiteTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StammbreiteTextBox;
        private System.Windows.Forms.TextBox StammhoeheTextBox;
        private System.Windows.Forms.TextBox KronenhoeheTextBox;
        private System.Windows.Forms.Button TanneZeichnenButton;
        private System.Windows.Forms.RichTextBox Ausgabe;
    }
}

