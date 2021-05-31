
namespace Gestion
{
    partial class Gestion_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.userbuttona = new System.Windows.Forms.Button();
            this.adminbutton = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSales = new System.Windows.Forms.Panel();
            this.buttonSalesSelect = new System.Windows.Forms.Button();
            this.buttonSalesModify = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonModifyProduct = new System.Windows.Forms.Button();
            this.buttonCreateProduct = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.buttonDeleteUsers = new System.Windows.Forms.Button();
            this.buttonModifyUsers = new System.Windows.Forms.Button();
            this.buttonCreateUsers = new System.Windows.Forms.Button();
            this.buttonusers = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.userButon = new System.Windows.Forms.Button();
            this.Roles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.brandbox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboboxSubcategory = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.butonProduct = new System.Windows.Forms.Button();
            this.comboboxCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.stokbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nameProduct = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userCurrentlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelSales.SuspendLayout();
            this.panelProducts.SuspendLayout();
            this.panelUsers.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // userbuttona
            // 
            this.userbuttona.Location = new System.Drawing.Point(811, 980);
            this.userbuttona.Name = "userbuttona";
            this.userbuttona.Size = new System.Drawing.Size(66, 29);
            this.userbuttona.TabIndex = 0;
            this.userbuttona.Text = "user";
            this.userbuttona.UseVisualStyleBackColor = true;
            this.userbuttona.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminbutton
            // 
            this.adminbutton.Enabled = false;
            this.adminbutton.Location = new System.Drawing.Point(697, 980);
            this.adminbutton.Name = "adminbutton";
            this.adminbutton.Size = new System.Drawing.Size(108, 33);
            this.adminbutton.TabIndex = 1;
            this.adminbutton.Text = "admin";
            this.adminbutton.UseVisualStyleBackColor = true;
            this.adminbutton.Click += new System.EventHandler(this.adminbutton_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.ControlDark;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.close.Location = new System.Drawing.Point(1874, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(34, 22);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panelSales);
            this.panel1.Controls.Add(this.salesButton);
            this.panel1.Controls.Add(this.panelProducts);
            this.panel1.Controls.Add(this.productsButton);
            this.panel1.Controls.Add(this.panelUsers);
            this.panel1.Controls.Add(this.buttonusers);
            this.panel1.Controls.Add(this.panelLogin);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 1056);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelSales
            // 
            this.panelSales.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelSales.Controls.Add(this.buttonSalesSelect);
            this.panelSales.Controls.Add(this.buttonSalesModify);
            this.panelSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSales.Location = new System.Drawing.Point(0, 865);
            this.panelSales.Name = "panelSales";
            this.panelSales.Size = new System.Drawing.Size(386, 181);
            this.panelSales.TabIndex = 6;
            // 
            // buttonSalesSelect
            // 
            this.buttonSalesSelect.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSalesSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSalesSelect.FlatAppearance.BorderSize = 0;
            this.buttonSalesSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalesSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSalesSelect.Location = new System.Drawing.Point(0, 61);
            this.buttonSalesSelect.Name = "buttonSalesSelect";
            this.buttonSalesSelect.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonSalesSelect.Size = new System.Drawing.Size(386, 61);
            this.buttonSalesSelect.TabIndex = 2;
            this.buttonSalesSelect.Text = "SALES SELECT";
            this.buttonSalesSelect.UseVisualStyleBackColor = false;
            this.buttonSalesSelect.Click += new System.EventHandler(this.buttonSalesSelect_Click);
            // 
            // buttonSalesModify
            // 
            this.buttonSalesModify.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSalesModify.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSalesModify.FlatAppearance.BorderSize = 0;
            this.buttonSalesModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalesModify.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSalesModify.Location = new System.Drawing.Point(0, 0);
            this.buttonSalesModify.Name = "buttonSalesModify";
            this.buttonSalesModify.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonSalesModify.Size = new System.Drawing.Size(386, 61);
            this.buttonSalesModify.TabIndex = 1;
            this.buttonSalesModify.Text = "SALES MODIFY";
            this.buttonSalesModify.UseVisualStyleBackColor = false;
            this.buttonSalesModify.Click += new System.EventHandler(this.buttonSalesModify_Click);
            // 
            // salesButton
            // 
            this.salesButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.salesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesButton.FlatAppearance.BorderSize = 0;
            this.salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesButton.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salesButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salesButton.Image = ((System.Drawing.Image)(resources.GetObject("salesButton.Image")));
            this.salesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesButton.Location = new System.Drawing.Point(0, 795);
            this.salesButton.Name = "salesButton";
            this.salesButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.salesButton.Size = new System.Drawing.Size(386, 70);
            this.salesButton.TabIndex = 5;
            this.salesButton.Text = "          BILLS";
            this.salesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesButton.UseVisualStyleBackColor = false;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // panelProducts
            // 
            this.panelProducts.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelProducts.Controls.Add(this.buttonDeleteProduct);
            this.panelProducts.Controls.Add(this.buttonModifyProduct);
            this.panelProducts.Controls.Add(this.buttonCreateProduct);
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProducts.Location = new System.Drawing.Point(0, 595);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(386, 200);
            this.panelProducts.TabIndex = 4;
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDeleteProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDeleteProduct.FlatAppearance.BorderSize = 0;
            this.buttonDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeleteProduct.Location = new System.Drawing.Point(0, 122);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonDeleteProduct.Size = new System.Drawing.Size(386, 61);
            this.buttonDeleteProduct.TabIndex = 3;
            this.buttonDeleteProduct.Text = "DELETE PRODUCT";
            this.buttonDeleteProduct.UseVisualStyleBackColor = false;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonModifyProduct
            // 
            this.buttonModifyProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonModifyProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonModifyProduct.FlatAppearance.BorderSize = 0;
            this.buttonModifyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifyProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonModifyProduct.Location = new System.Drawing.Point(0, 61);
            this.buttonModifyProduct.Name = "buttonModifyProduct";
            this.buttonModifyProduct.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonModifyProduct.Size = new System.Drawing.Size(386, 61);
            this.buttonModifyProduct.TabIndex = 1;
            this.buttonModifyProduct.Text = "MODIFY PRODUCT";
            this.buttonModifyProduct.UseVisualStyleBackColor = false;
            this.buttonModifyProduct.Click += new System.EventHandler(this.buttonModifyProduct_Click);
            // 
            // buttonCreateProduct
            // 
            this.buttonCreateProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreateProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCreateProduct.FlatAppearance.BorderSize = 0;
            this.buttonCreateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCreateProduct.Location = new System.Drawing.Point(0, 0);
            this.buttonCreateProduct.Name = "buttonCreateProduct";
            this.buttonCreateProduct.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonCreateProduct.Size = new System.Drawing.Size(386, 61);
            this.buttonCreateProduct.TabIndex = 0;
            this.buttonCreateProduct.Text = "CREATE PRODUCT";
            this.buttonCreateProduct.UseVisualStyleBackColor = false;
            this.buttonCreateProduct.Click += new System.EventHandler(this.buttonCreateProduct_Click);
            // 
            // productsButton
            // 
            this.productsButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.productsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsButton.FlatAppearance.BorderSize = 0;
            this.productsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsButton.Font = new System.Drawing.Font("Lato", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productsButton.Image = ((System.Drawing.Image)(resources.GetObject("productsButton.Image")));
            this.productsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsButton.Location = new System.Drawing.Point(0, 525);
            this.productsButton.Name = "productsButton";
            this.productsButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.productsButton.Size = new System.Drawing.Size(386, 70);
            this.productsButton.TabIndex = 3;
            this.productsButton.Text = "          PRODUCT";
            this.productsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsButton.UseVisualStyleBackColor = false;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // panelUsers
            // 
            this.panelUsers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelUsers.Controls.Add(this.buttonDeleteUsers);
            this.panelUsers.Controls.Add(this.buttonModifyUsers);
            this.panelUsers.Controls.Add(this.buttonCreateUsers);
            this.panelUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsers.Location = new System.Drawing.Point(0, 329);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(386, 196);
            this.panelUsers.TabIndex = 2;
            // 
            // buttonDeleteUsers
            // 
            this.buttonDeleteUsers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDeleteUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDeleteUsers.FlatAppearance.BorderSize = 0;
            this.buttonDeleteUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUsers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeleteUsers.Location = new System.Drawing.Point(0, 122);
            this.buttonDeleteUsers.Name = "buttonDeleteUsers";
            this.buttonDeleteUsers.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonDeleteUsers.Size = new System.Drawing.Size(386, 61);
            this.buttonDeleteUsers.TabIndex = 3;
            this.buttonDeleteUsers.Text = "DELETE USER";
            this.buttonDeleteUsers.UseVisualStyleBackColor = false;
            this.buttonDeleteUsers.Click += new System.EventHandler(this.buttonDeleteUsers_Click);
            // 
            // buttonModifyUsers
            // 
            this.buttonModifyUsers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonModifyUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonModifyUsers.FlatAppearance.BorderSize = 0;
            this.buttonModifyUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifyUsers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonModifyUsers.Location = new System.Drawing.Point(0, 61);
            this.buttonModifyUsers.Name = "buttonModifyUsers";
            this.buttonModifyUsers.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonModifyUsers.Size = new System.Drawing.Size(386, 61);
            this.buttonModifyUsers.TabIndex = 1;
            this.buttonModifyUsers.Text = "MODIFY USER";
            this.buttonModifyUsers.UseVisualStyleBackColor = false;
            this.buttonModifyUsers.Click += new System.EventHandler(this.buttonModifyUsers_Click);
            // 
            // buttonCreateUsers
            // 
            this.buttonCreateUsers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreateUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCreateUsers.FlatAppearance.BorderSize = 0;
            this.buttonCreateUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateUsers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCreateUsers.Location = new System.Drawing.Point(0, 0);
            this.buttonCreateUsers.Name = "buttonCreateUsers";
            this.buttonCreateUsers.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonCreateUsers.Size = new System.Drawing.Size(386, 61);
            this.buttonCreateUsers.TabIndex = 0;
            this.buttonCreateUsers.Text = "CREATE USER";
            this.buttonCreateUsers.UseVisualStyleBackColor = false;
            this.buttonCreateUsers.Click += new System.EventHandler(this.buttonCreateUsers_Click);
            // 
            // buttonusers
            // 
            this.buttonusers.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonusers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonusers.FlatAppearance.BorderSize = 0;
            this.buttonusers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonusers.Font = new System.Drawing.Font("Beatrice", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonusers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonusers.Image = ((System.Drawing.Image)(resources.GetObject("buttonusers.Image")));
            this.buttonusers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonusers.Location = new System.Drawing.Point(0, 259);
            this.buttonusers.Name = "buttonusers";
            this.buttonusers.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonusers.Size = new System.Drawing.Size(386, 70);
            this.buttonusers.TabIndex = 1;
            this.buttonusers.Text = "          USERS";
            this.buttonusers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonusers.UseVisualStyleBackColor = false;
            this.buttonusers.Click += new System.EventHandler(this.Users_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(386, 259);
            this.panelLogin.TabIndex = 0;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.userPassword);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.userButon);
            this.panel2.Controls.Add(this.Roles);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.emailUser);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.userUsername);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(453, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 708);
            this.panel2.TabIndex = 8;
            // 
            // userPassword
            // 
            this.userPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.userPassword.Location = new System.Drawing.Point(109, 237);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(214, 29);
            this.userPassword.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(25, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "password:";
            // 
            // userButon
            // 
            this.userButon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userButon.Location = new System.Drawing.Point(222, 659);
            this.userButon.Name = "userButon";
            this.userButon.Size = new System.Drawing.Size(101, 31);
            this.userButon.TabIndex = 7;
            this.userButon.Text = "Create";
            this.userButon.UseVisualStyleBackColor = true;
            this.userButon.Click += new System.EventHandler(this.createUser_Click);
            // 
            // Roles
            // 
            this.Roles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Roles.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Roles.FormattingEnabled = true;
            this.Roles.Items.AddRange(new object[] {
            "ADMIN",
            "USER",
            "NO_SELECTED"});
            this.Roles.Location = new System.Drawing.Point(96, 462);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(227, 29);
            this.Roles.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "ROL:";
            // 
            // emailUser
            // 
            this.emailUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailUser.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.emailUser.Location = new System.Drawing.Point(112, 340);
            this.emailUser.Name = "emailUser";
            this.emailUser.Size = new System.Drawing.Size(211, 29);
            this.emailUser.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "email";
            // 
            // userUsername
            // 
            this.userUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userUsername.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.userUsername.Location = new System.Drawing.Point(112, 150);
            this.userUsername.Name = "userUsername";
            this.userUsername.Size = new System.Drawing.Size(211, 29);
            this.userUsername.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "USER ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.pricebox);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.brandbox);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.comboboxSubcategory);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.butonProduct);
            this.panel3.Controls.Add(this.comboboxCategory);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.stokbox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.nameProduct);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(883, 287);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 714);
            this.panel3.TabIndex = 9;
            // 
            // pricebox
            // 
            this.pricebox.Location = new System.Drawing.Point(98, 383);
            this.pricebox.Name = "pricebox";
            this.pricebox.ShortcutsEnabled = false;
            this.pricebox.Size = new System.Drawing.Size(210, 23);
            this.pricebox.TabIndex = 13;
            this.pricebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pricePressed);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 388);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 15);
            this.label16.TabIndex = 12;
            this.label16.Text = "Price:";
            // 
            // brandbox
            // 
            this.brandbox.Location = new System.Drawing.Point(96, 298);
            this.brandbox.Name = "brandbox";
            this.brandbox.Size = new System.Drawing.Size(210, 23);
            this.brandbox.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 303);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 15);
            this.label17.TabIndex = 10;
            this.label17.Text = "Brand:";
            // 
            // comboboxSubcategory
            // 
            this.comboboxSubcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxSubcategory.FormattingEnabled = true;
            this.comboboxSubcategory.Items.AddRange(new object[] {
            "NO_DATA"});
            this.comboboxSubcategory.Location = new System.Drawing.Point(98, 608);
            this.comboboxSubcategory.Name = "comboboxSubcategory";
            this.comboboxSubcategory.Size = new System.Drawing.Size(210, 23);
            this.comboboxSubcategory.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 611);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 15);
            this.label15.TabIndex = 8;
            this.label15.Text = "Subcategory:";
            // 
            // butonProduct
            // 
            this.butonProduct.Location = new System.Drawing.Point(222, 659);
            this.butonProduct.Name = "butonProduct";
            this.butonProduct.Size = new System.Drawing.Size(84, 31);
            this.butonProduct.TabIndex = 7;
            this.butonProduct.Text = "Create";
            this.butonProduct.UseVisualStyleBackColor = true;
            this.butonProduct.Click += new System.EventHandler(this.createProduct_onClick);
            // 
            // comboboxCategory
            // 
            this.comboboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxCategory.FormattingEnabled = true;
            this.comboboxCategory.Items.AddRange(new object[] {
            "NO_SELECTED"});
            this.comboboxCategory.Location = new System.Drawing.Point(96, 505);
            this.comboboxCategory.Name = "comboboxCategory";
            this.comboboxCategory.Size = new System.Drawing.Size(210, 23);
            this.comboboxCategory.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Category:";
            // 
            // stokbox
            // 
            this.stokbox.Location = new System.Drawing.Point(96, 202);
            this.stokbox.Name = "stokbox";
            this.stokbox.ShortcutsEnabled = false;
            this.stokbox.Size = new System.Drawing.Size(210, 23);
            this.stokbox.TabIndex = 4;
            this.stokbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stockPressed);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Stock:";
            // 
            // nameProduct
            // 
            this.nameProduct.Location = new System.Drawing.Point(98, 110);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(210, 23);
            this.nameProduct.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "PRODUCT";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel4.Controls.Add(this.close);
            this.panel4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1930, 28);
            this.panel4.TabIndex = 11;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(1450, 287);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(402, 625);
            this.panel5.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 22);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(316, 234);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rowSelected);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Location = new System.Drawing.Point(948, 193);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(904, 59);
            this.panel6.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Welcome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userCurrentlabel
            // 
            this.userCurrentlabel.AutoSize = true;
            this.userCurrentlabel.Location = new System.Drawing.Point(516, 145);
            this.userCurrentlabel.Name = "userCurrentlabel";
            this.userCurrentlabel.Size = new System.Drawing.Size(0, 15);
            this.userCurrentlabel.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(838, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(8, 23);
            this.textBox1.TabIndex = 16;
            // 
            // Gestion_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.userCurrentlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.userbuttona);
            this.Controls.Add(this.adminbutton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Gestion_Form";
            this.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.Text = "DELETE PRODUCT";
            this.Load += new System.EventHandler(this.Gestion_Form_Load_1);
            this.panel1.ResumeLayout(false);
            this.panelSales.ResumeLayout(false);
            this.panelProducts.ResumeLayout(false);
            this.panelUsers.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userbuttona;
        private System.Windows.Forms.Button adminbutton;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.Button buttonDeleteUsers;
        private System.Windows.Forms.Button buttonModifyUsers;
        private System.Windows.Forms.Button buttonCreateUsers;
        private System.Windows.Forms.Button buttonusers;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonModifyProduct;
        private System.Windows.Forms.Button buttonCreateProduct;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Panel panelSales;
        private System.Windows.Forms.Button buttonSalesSelect;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button userButon;
        private System.Windows.Forms.ComboBox Roles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button butonProduct;
        private System.Windows.Forms.ComboBox comboboxCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox stokbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox pricebox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox brandbox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboboxSubcategory;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSalesModify;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userCurrentlabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}