namespace FinalProject.Gui
{
    partial class Reset_Password
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
            this.linkForget = new System.Windows.Forms.LinkLabel();
            this.btnReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRepass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkForget
            // 
            this.linkForget.AutoSize = true;
            this.linkForget.Location = new System.Drawing.Point(513, 641);
            this.linkForget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkForget.Name = "linkForget";
            this.linkForget.Size = new System.Drawing.Size(170, 25);
            this.linkForget.TabIndex = 13;
            this.linkForget.TabStop = true;
            this.linkForget.Text = "Go Back to login";
            this.linkForget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForget_LinkClicked);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(527, 553);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(145, 48);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 321);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(414, 316);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(528, 31);
            this.txtPass.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "User Name";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(414, 231);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(528, 31);
            this.txtUser.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 429);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Re-Enter Password";
            // 
            // textBoxRepass
            // 
            this.textBoxRepass.Location = new System.Drawing.Point(414, 426);
            this.textBoxRepass.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRepass.Name = "textBoxRepass";
            this.textBoxRepass.Size = new System.Drawing.Size(528, 31);
            this.textBoxRepass.TabIndex = 14;
            // 
            // Reset_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 786);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRepass);
            this.Controls.Add(this.linkForget);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Name = "Reset_Password";
            this.Text = "Reset_Password";
            this.Load += new System.EventHandler(this.Reset_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkForget;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRepass;
    }
}