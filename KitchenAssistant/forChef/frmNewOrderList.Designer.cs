﻿namespace KitchenAssistant.forChef
{
    partial class frmNewOrderList
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
            this.tableLayoutPanelListOrder = new System.Windows.Forms.TableLayoutPanel();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.labelTimeCook = new System.Windows.Forms.Label();
            this.labelNumberOrder = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxIngredient = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFood = new System.Windows.Forms.Label();
            this.tableLayoutPanelListOrder.SuspendLayout();
            this.panelOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelListOrder
            // 
            this.tableLayoutPanelListOrder.ColumnCount = 2;
            this.tableLayoutPanelListOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelListOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelListOrder.Controls.Add(this.panelOrder, 0, 0);
            this.tableLayoutPanelListOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelListOrder.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelListOrder.Name = "tableLayoutPanelListOrder";
            this.tableLayoutPanelListOrder.RowCount = 2;
            this.tableLayoutPanelListOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelListOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelListOrder.Size = new System.Drawing.Size(956, 566);
            this.tableLayoutPanelListOrder.TabIndex = 0;
            // 
            // panelOrder
            // 
            this.panelOrder.BackColor = System.Drawing.Color.SteelBlue;
            this.panelOrder.Controls.Add(this.labelTimeCook);
            this.panelOrder.Controls.Add(this.labelNumberOrder);
            this.panelOrder.Controls.Add(this.button1);
            this.panelOrder.Controls.Add(this.richTextBoxIngredient);
            this.panelOrder.Controls.Add(this.pictureBox1);
            this.panelOrder.Controls.Add(this.labelFood);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrder.Location = new System.Drawing.Point(10, 10);
            this.panelOrder.Margin = new System.Windows.Forms.Padding(10);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(458, 263);
            this.panelOrder.TabIndex = 0;
            // 
            // labelTimeCook
            // 
            this.labelTimeCook.AutoSize = true;
            this.labelTimeCook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTimeCook.ForeColor = System.Drawing.Color.LightYellow;
            this.labelTimeCook.Location = new System.Drawing.Point(354, 159);
            this.labelTimeCook.Name = "labelTimeCook";
            this.labelTimeCook.Size = new System.Drawing.Size(73, 21);
            this.labelTimeCook.TabIndex = 6;
            this.labelTimeCook.Text = "120 мин";
            // 
            // labelNumberOrder
            // 
            this.labelNumberOrder.AutoSize = true;
            this.labelNumberOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumberOrder.ForeColor = System.Drawing.Color.LightYellow;
            this.labelNumberOrder.Location = new System.Drawing.Point(15, 239);
            this.labelNumberOrder.Name = "labelNumberOrder";
            this.labelNumberOrder.Size = new System.Drawing.Size(103, 21);
            this.labelNumberOrder.TabIndex = 4;
            this.labelNumberOrder.Text = "Заказ № 123";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.LightYellow;
            this.button1.Location = new System.Drawing.Point(339, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "В работу";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // richTextBoxIngredient
            // 
            this.richTextBoxIngredient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxIngredient.Location = new System.Drawing.Point(15, 66);
            this.richTextBoxIngredient.Name = "richTextBoxIngredient";
            this.richTextBoxIngredient.Size = new System.Drawing.Size(318, 146);
            this.richTextBoxIngredient.TabIndex = 2;
            this.richTextBoxIngredient.Text = "Список ингрендиентов";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KitchenAssistant.Properties.Resources.meat_food_chicken;
            this.pictureBox1.Location = new System.Drawing.Point(339, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFood.ForeColor = System.Drawing.Color.LightYellow;
            this.labelFood.Location = new System.Drawing.Point(15, 14);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(359, 30);
            this.labelFood.TabIndex = 0;
            this.labelFood.Text = "0Курица в кисло-сладком соусе";
            // 
            // frmNewOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(956, 566);
            this.Controls.Add(this.tableLayoutPanelListOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewOrderList";
            this.Text = "frmNewOrderList";
            this.tableLayoutPanelListOrder.ResumeLayout(false);
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanelListOrder;
        private Panel panelOrder;
        private Label labelFood;
        private RichTextBox richTextBoxIngredient;
        private PictureBox pictureBox1;
        private Button button1;
        private Label labelNumberOrder;
        private Label labelTimeCook;
    }
}