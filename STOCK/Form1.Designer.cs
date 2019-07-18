namespace STOCK
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
            this.labelhead = new System.Windows.Forms.Label();
            this.btnSingIn = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.labelerror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelhead
            // 
            this.labelhead.BackColor = System.Drawing.Color.Cyan;
            this.labelhead.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelhead.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhead.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelhead.Location = new System.Drawing.Point(0, 0);
            this.labelhead.Name = "labelhead";
            this.labelhead.Size = new System.Drawing.Size(528, 96);
            this.labelhead.TabIndex = 1;
            this.labelhead.Text = "Welcome, dear customer!";
            this.labelhead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSingIn
            // 
            this.btnSingIn.BackColor = System.Drawing.Color.Cyan;
            this.btnSingIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingIn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSingIn.Location = new System.Drawing.Point(71, 512);
            this.btnSingIn.Name = "btnSingIn";
            this.btnSingIn.Size = new System.Drawing.Size(399, 86);
            this.btnSingIn.TabIndex = 2;
            this.btnSingIn.Text = "Sing in!";
            this.btnSingIn.UseVisualStyleBackColor = false;
            this.btnSingIn.Click += new System.EventHandler(this.BtnSingIn_Click);
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.SystemColors.Window;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(6, 168);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(301, 30);
            this.txtuser.TabIndex = 3;
            this.txtuser.TextChanged += new System.EventHandler(this.Txtuser_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(6, 252);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(301, 30);
            this.txtpassword.TabIndex = 7;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // labelerror
            // 
            this.labelerror.AutoSize = true;
            this.labelerror.BackColor = System.Drawing.Color.Transparent;
            this.labelerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelerror.ForeColor = System.Drawing.Color.Crimson;
            this.labelerror.Location = new System.Drawing.Point(89, 606);
            this.labelerror.Name = "labelerror";
            this.labelerror.Size = new System.Drawing.Size(369, 29);
            this.labelerror.TabIndex = 8;
            this.labelerror.Text = "Invalid username or password!";
            this.labelerror.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STOCK.Properties.Resources.stock;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 644);
            this.Controls.Add(this.labelerror);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btnSingIn);
            this.Controls.Add(this.labelhead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelhead;
        private System.Windows.Forms.Button btnSingIn;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label labelerror;
    }
}

