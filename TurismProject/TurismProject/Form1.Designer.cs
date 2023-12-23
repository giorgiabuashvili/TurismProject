namespace TurismProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDTBLogInPage = new System.Windows.Forms.TextBox();
            this.PWTBLogInPage = new System.Windows.Forms.TextBox();
            this.LogInButtonLogInPage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ValidationLabelLogInPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(131, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In";
            // 
            // IDTBLogInPage
            // 
            this.IDTBLogInPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTBLogInPage.Location = new System.Drawing.Point(98, 163);
            this.IDTBLogInPage.Name = "IDTBLogInPage";
            this.IDTBLogInPage.Size = new System.Drawing.Size(172, 26);
            this.IDTBLogInPage.TabIndex = 2;
            this.IDTBLogInPage.TextChanged += new System.EventHandler(this.ValidateInput);
            // 
            // PWTBLogInPage
            // 
            this.PWTBLogInPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWTBLogInPage.Location = new System.Drawing.Point(98, 210);
            this.PWTBLogInPage.Name = "PWTBLogInPage";
            this.PWTBLogInPage.Size = new System.Drawing.Size(172, 26);
            this.PWTBLogInPage.TabIndex = 3;
            this.PWTBLogInPage.TextChanged += new System.EventHandler(this.ValidateInput);
            // 
            // LogInButtonLogInPage
            // 
            this.LogInButtonLogInPage.BackColor = System.Drawing.SystemColors.Control;
            this.LogInButtonLogInPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButtonLogInPage.ForeColor = System.Drawing.Color.IndianRed;
            this.LogInButtonLogInPage.Location = new System.Drawing.Point(129, 272);
            this.LogInButtonLogInPage.Name = "LogInButtonLogInPage";
            this.LogInButtonLogInPage.Size = new System.Drawing.Size(105, 35);
            this.LogInButtonLogInPage.TabIndex = 4;
            this.LogInButtonLogInPage.Text = "Log In";
            this.LogInButtonLogInPage.UseVisualStyleBackColor = false;
            this.LogInButtonLogInPage.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = " ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = " Password";
            // 
            // ValidationLabelLogInPage
            // 
            this.ValidationLabelLogInPage.AutoSize = true;
            this.ValidationLabelLogInPage.ForeColor = System.Drawing.Color.IndianRed;
            this.ValidationLabelLogInPage.Location = new System.Drawing.Point(95, 239);
            this.ValidationLabelLogInPage.Name = "ValidationLabelLogInPage";
            this.ValidationLabelLogInPage.Size = new System.Drawing.Size(10, 13);
            this.ValidationLabelLogInPage.TabIndex = 7;
            this.ValidationLabelLogInPage.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.ValidationLabelLogInPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogInButtonLogInPage);
            this.Controls.Add(this.PWTBLogInPage);
            this.Controls.Add(this.IDTBLogInPage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDTBLogInPage;
        private System.Windows.Forms.TextBox PWTBLogInPage;
        private System.Windows.Forms.Button LogInButtonLogInPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ValidationLabelLogInPage;
    }
}

