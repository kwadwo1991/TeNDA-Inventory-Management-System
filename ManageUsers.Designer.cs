
namespace TeNDA_Inventory_Management_System
{
    partial class ManageUsers
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contacts = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.home = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.deleteedit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Display = new System.Windows.Forms.DataGridView();
            this.teNDAInventoryDataSet = new TeNDA_Inventory_Management_System.TeNDAInventoryDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new TeNDA_Inventory_Management_System.TeNDAInventoryDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new TeNDA_Inventory_Management_System.TeNDAInventoryDataSetTableAdapters.TableAdapterManager();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNDAInventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
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
            this.panel1.TabIndex = 0;
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
            this.close.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(802, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(39, 38);
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
            this.label1.Size = new System.Drawing.Size(235, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Users";
            // 
            // contacts
            // 
            this.contacts.AccessibleDescription = "";
            this.contacts.AccessibleName = "";
            this.contacts.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Contact", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.contacts.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.usersBindingSource, "Contact", true));
            this.contacts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacts.Location = new System.Drawing.Point(65, 293);
            this.contacts.Name = "contacts";
            this.contacts.Size = new System.Drawing.Size(191, 27);
            this.contacts.TabIndex = 1;
            this.contacts.Text = "Contact";
            // 
            // email
            // 
            this.email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Email", true));
            this.email.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.usersBindingSource, "Email", true));
            this.email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(65, 260);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(191, 27);
            this.email.TabIndex = 1;
            this.email.Text = "Email";
            // 
            // pass
            // 
            this.pass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Password", true));
            this.pass.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.usersBindingSource, "Contact", true));
            this.pass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(65, 227);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(191, 27);
            this.pass.TabIndex = 1;
            this.pass.Text = "Password";
            // 
            // username
            // 
            this.username.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Username", true));
            this.username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(65, 194);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(191, 27);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            // 
            // fname
            // 
            this.fname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "FullName", true));
            this.fname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(65, 161);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(191, 27);
            this.fname.TabIndex = 1;
            this.fname.Text = "Fullname";
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Green;
            this.home.FlatAppearance.BorderSize = 0;
            this.home.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(122, 391);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(92, 30);
            this.home.TabIndex = 2;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Green;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(220, 355);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(92, 30);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.edit_Click);
            // 
            // deleteedit
            // 
            this.deleteedit.BackColor = System.Drawing.Color.Green;
            this.deleteedit.FlatAppearance.BorderSize = 0;
            this.deleteedit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteedit.ForeColor = System.Drawing.Color.White;
            this.deleteedit.Location = new System.Drawing.Point(122, 355);
            this.deleteedit.Name = "deleteedit";
            this.deleteedit.Size = new System.Drawing.Size(92, 30);
            this.deleteedit.TabIndex = 2;
            this.deleteedit.Text = "Edit";
            this.deleteedit.UseVisualStyleBackColor = false;
            this.deleteedit.Click += new System.EventHandler(this.deleteedit_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Green;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(24, 355);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(92, 30);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 478);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(844, 10);
            this.panel3.TabIndex = 4;
            // 
            // Display
            // 
            this.Display.BackgroundColor = System.Drawing.Color.White;
            this.Display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Display.Location = new System.Drawing.Point(363, 157);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(451, 315);
            this.Display.TabIndex = 5;
            this.Display.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Display_CellContentClick);
            // 
            // teNDAInventoryDataSet
            // 
            this.teNDAInventoryDataSet.DataSetName = "TeNDAInventoryDataSet";
            this.teNDAInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.teNDAInventoryDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = TeNDA_Inventory_Management_System.TeNDAInventoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.teNDAInventoryDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(533, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Users List";
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.add);
            this.Controls.Add(this.deleteedit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.home);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.email);
            this.Controls.Add(this.contacts);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNDAInventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contacts;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button deleteedit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.DataGridView Display;
        private TeNDAInventoryDataSet teNDAInventoryDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private TeNDAInventoryDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private TeNDAInventoryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.Label label3;
    }
}