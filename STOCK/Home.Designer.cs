namespace STOCK
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.ProductsList = new System.Windows.Forms.ListBox();
            this.procategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductsList
            // 
            this.ProductsList.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ProductsList.Dock = System.Windows.Forms.DockStyle.Right;
            this.ProductsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsList.ForeColor = System.Drawing.Color.Red;
            this.ProductsList.FormattingEnabled = true;
            this.ProductsList.ItemHeight = 29;
            this.ProductsList.Location = new System.Drawing.Point(762, 0);
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.Size = new System.Drawing.Size(389, 654);
            this.ProductsList.TabIndex = 2;
            // 
            // procategory
            // 
            this.procategory.FormattingEnabled = true;
            this.procategory.Location = new System.Drawing.Point(12, 85);
            this.procategory.Name = "procategory";
            this.procategory.Size = new System.Drawing.Size(365, 28);
            this.procategory.TabIndex = 3;
            this.procategory.SelectedIndexChanged += new System.EventHandler(this.Procategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please,select category";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STOCK.Properties.Resources.stock;
            this.ClientSize = new System.Drawing.Size(1151, 654);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.procategory);
            this.Controls.Add(this.ProductsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductsList;
        private System.Windows.Forms.ComboBox procategory;
        private System.Windows.Forms.Label label1;
    }
}