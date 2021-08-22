
namespace TeNDA_Inventory_Management_System
{
    partial class ManageStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStock));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.itemtype = new System.Windows.Forms.ComboBox();
            this.unit = new System.Windows.Forms.ComboBox();
            this.purpose = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 100);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(663, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "TeNDA INVENTORY MANAGEMENT SYSTEM";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(818, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 23);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(292, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Stocks";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(35, 140);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(191, 27);
            this.id.TabIndex = 2;
            this.id.Text = "ID";
            // 
            // itemtype
            // 
            this.itemtype.AllowDrop = true;
            this.itemtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemtype.FormattingEnabled = true;
            this.itemtype.Items.AddRange(new object[] {
            "Desktop",
            "Laptop",
            "Printer",
            "UPS"});
            this.itemtype.Location = new System.Drawing.Point(35, 174);
            this.itemtype.Name = "itemtype";
            this.itemtype.Size = new System.Drawing.Size(191, 24);
            this.itemtype.TabIndex = 3;
            // 
            // unit
            // 
            this.unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit.FormattingEnabled = true;
            this.unit.Items.AddRange(new object[] {
            "",
            "DCE",
            "DCD",
            "DFO",
            "GHANA HEALTH SERVICE",
            "MIS/IT",
            "PLANNING",
            "BUDGET",
            "ASSISTANT DIRECTOR",
            "WORKS",
            "AUDIT",
            "FINANCE",
            "NABCO",
            "NADMO",
            "YOUTH EMPLOYMENT",
            "HUMAN RESOURCE",
            "INFORMATION SERVICE",
            "PROCUREMENT/STORES",
            "CLIENT SERVICE",
            "REGISTRY",
            "AGRIC",
            "ENVIRONMENTAL",
            "SOCIAL WELFARE",
            "STATISTICS"});
            this.unit.Location = new System.Drawing.Point(35, 205);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(191, 24);
            this.unit.TabIndex = 4;
            // 
            // purpose
            // 
            this.purpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purpose.FormattingEnabled = true;
            this.purpose.Items.AddRange(new object[] {
            "PERSONAL",
            "OFFICIAL"});
            this.purpose.Location = new System.Drawing.Point(35, 235);
            this.purpose.Name = "purpose";
            this.purpose.Size = new System.Drawing.Size(191, 24);
            this.purpose.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 467);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(844, 21);
            this.panel3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(104, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(660, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Design and Development By: Anointed | 0240449678 | MIS UNIT | antwialbert1991@hot" +
    "mail.com";
            // 
            // ManageStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 488);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.purpose);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.itemtype);
            this.Controls.Add(this.id);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageStock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.ComboBox itemtype;
        private System.Windows.Forms.ComboBox unit;
        private System.Windows.Forms.ComboBox purpose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
    }
}