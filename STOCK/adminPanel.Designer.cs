namespace STOCK
{
    partial class adminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gotostock = new System.Windows.Forms.Button();
            this.catadder = new System.Windows.Forms.Button();
            this.catname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.catcount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proadder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.procategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.proname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.procount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Controls.Add(this.gotostock);
            this.groupBox1.Controls.Add(this.catadder);
            this.groupBox1.Controls.Add(this.catname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.catcount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 675);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gategory settings";
            // 
            // gotostock
            // 
            this.gotostock.Location = new System.Drawing.Point(20, 586);
            this.gotostock.Name = "gotostock";
            this.gotostock.Size = new System.Drawing.Size(383, 83);
            this.gotostock.TabIndex = 6;
            this.gotostock.Text = "Go to stock";
            this.gotostock.UseVisualStyleBackColor = true;
            this.gotostock.Click += new System.EventHandler(this.Gotostock_Click);
            // 
            // catadder
            // 
            this.catadder.Location = new System.Drawing.Point(20, 329);
            this.catadder.Name = "catadder";
            this.catadder.Size = new System.Drawing.Size(383, 83);
            this.catadder.TabIndex = 5;
            this.catadder.Text = "Add category";
            this.catadder.UseVisualStyleBackColor = true;
            this.catadder.Click += new System.EventHandler(this.Catadder_Click);
            // 
            // catname
            // 
            this.catname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catname.Location = new System.Drawing.Point(20, 190);
            this.catname.Multiline = true;
            this.catname.Name = "catname";
            this.catname.Size = new System.Drawing.Size(464, 53);
            this.catname.TabIndex = 4;
            this.catname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name of categories :";
            // 
            // catcount
            // 
            this.catcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catcount.Location = new System.Drawing.Point(20, 67);
            this.catcount.Multiline = true;
            this.catcount.Name = "catcount";
            this.catcount.Size = new System.Drawing.Size(110, 31);
            this.catcount.TabIndex = 2;
            this.catcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of new categories :";
            // 
            // proadder
            // 
            this.proadder.Location = new System.Drawing.Point(74, 430);
            this.proadder.Name = "proadder";
            this.proadder.Size = new System.Drawing.Size(383, 83);
            this.proadder.TabIndex = 1;
            this.proadder.Text = "Add product";
            this.proadder.UseVisualStyleBackColor = true;
            this.proadder.Click += new System.EventHandler(this.Proadder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.procategory);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.proname);
            this.groupBox2.Controls.Add(this.proadder);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.procount);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(562, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 675);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product settings";
            // 
            // procategory
            // 
            this.procategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procategory.FormattingEnabled = true;
            this.procategory.Location = new System.Drawing.Point(27, 350);
            this.procategory.Name = "procategory";
            this.procategory.Size = new System.Drawing.Size(464, 37);
            this.procategory.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Category of product :";
            // 
            // proname
            // 
            this.proname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proname.Location = new System.Drawing.Point(27, 190);
            this.proname.Multiline = true;
            this.proname.Name = "proname";
            this.proname.Size = new System.Drawing.Size(464, 53);
            this.proname.TabIndex = 6;
            this.proname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name of product :";
            // 
            // procount
            // 
            this.procount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procount.Location = new System.Drawing.Point(27, 67);
            this.procount.Multiline = true;
            this.procount.Name = "procount";
            this.procount.Size = new System.Drawing.Size(110, 31);
            this.procount.TabIndex = 4;
            this.procount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of new products :";
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 682);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminPanel";
            this.Text = "adminPanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox catname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button proadder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox proname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button catadder;
        private System.Windows.Forms.ComboBox procategory;
        private System.Windows.Forms.Button gotostock;
        private System.Windows.Forms.TextBox catcount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox procount;
        private System.Windows.Forms.Label label2;
    }
}