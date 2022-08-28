﻿namespace Inventory_System
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUser = new Inventory_System.CustomerButton();
            this.btnProduct = new Inventory_System.CustomerButton();
            this.btnOrder = new Inventory_System.CustomerButton();
            this.btnCategory = new Inventory_System.CustomerButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCustomer = new Inventory_System.CustomerButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 899);
            this.panel1.TabIndex = 0;
            // 
            // btnUser
            // 
            this.btnUser.Image = global::Inventory_System.Properties.Resources.user_groups_96px;
            this.btnUser.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnUser.ImageHover")));
            this.btnUser.ImageNormal = global::Inventory_System.Properties.Resources.box_96px;
            this.btnUser.Location = new System.Drawing.Point(70, 519);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(65, 52);
            this.btnUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUser.TabIndex = 3;
            this.btnUser.TabStop = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Image = global::Inventory_System.Properties.Resources.box_96px;
            this.btnProduct.ImageHover = null;
            this.btnProduct.ImageNormal = null;
            this.btnProduct.Location = new System.Drawing.Point(70, 152);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(65, 52);
            this.btnProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProduct.TabIndex = 14;
            this.btnProduct.TabStop = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Image = global::Inventory_System.Properties.Resources.purchase_order_96px;
            this.btnOrder.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnOrder.ImageHover")));
            this.btnOrder.ImageNormal = global::Inventory_System.Properties.Resources.box_96px;
            this.btnOrder.Location = new System.Drawing.Point(70, 647);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(65, 52);
            this.btnOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOrder.TabIndex = 4;
            this.btnOrder.TabStop = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Image = global::Inventory_System.Properties.Resources.diversity_96px;
            this.btnCategory.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnCategory.ImageHover")));
            this.btnCategory.ImageNormal = global::Inventory_System.Properties.Resources.box_96px;
            this.btnCategory.Location = new System.Drawing.Point(70, 273);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(65, 52);
            this.btnCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCategory.TabIndex = 2;
            this.btnCategory.TabStop = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(70, 585);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "USERS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "CUSTOMERS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "CATEGORIES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(57, 702);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "ORDERS";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Image = global::Inventory_System.Properties.Resources.people_96px;
            this.btnCustomer.ImageHover = null;
            this.btnCustomer.ImageNormal = null;
            this.btnCustomer.Location = new System.Drawing.Point(70, 386);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(65, 52);
            this.btnCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCustomer.TabIndex = 10;
            this.btnCustomer.TabStop = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "PRODUCTS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1355, 34);
            this.panel2.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 34);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1355, 865);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 899);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHOP RITE";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelMain;
        private Label label2;
        private CustomerButton btnOrder;
        private CustomerButton btnUser;
        private CustomerButton btnCategory;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private CustomerButton btnCustomer;
        private CustomerButton btnProduct;
    }
}