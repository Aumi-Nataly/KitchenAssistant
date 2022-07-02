namespace KitchenAssistant.forChef
{
    partial class frmOneNewOrder
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
            this.labelTimeCook = new System.Windows.Forms.Label();
            this.labelNumberOrder = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxIngredient = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFood = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTimeCook
            // 
            this.labelTimeCook.AutoSize = true;
            this.labelTimeCook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTimeCook.ForeColor = System.Drawing.Color.LightYellow;
            this.labelTimeCook.Location = new System.Drawing.Point(358, 163);
            this.labelTimeCook.Name = "labelTimeCook";
            this.labelTimeCook.Size = new System.Drawing.Size(73, 21);
            this.labelTimeCook.TabIndex = 12;
            this.labelTimeCook.Text = "120 мин";
            // 
            // labelNumberOrder
            // 
            this.labelNumberOrder.AutoSize = true;
            this.labelNumberOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumberOrder.ForeColor = System.Drawing.Color.LightYellow;
            this.labelNumberOrder.Location = new System.Drawing.Point(19, 243);
            this.labelNumberOrder.Name = "labelNumberOrder";
            this.labelNumberOrder.Size = new System.Drawing.Size(103, 21);
            this.labelNumberOrder.TabIndex = 11;
            this.labelNumberOrder.Text = "Заказ № 123";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.LightYellow;
            this.button1.Location = new System.Drawing.Point(343, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "В работу";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // richTextBoxIngredient
            // 
            this.richTextBoxIngredient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxIngredient.Location = new System.Drawing.Point(19, 70);
            this.richTextBoxIngredient.Name = "richTextBoxIngredient";
            this.richTextBoxIngredient.Size = new System.Drawing.Size(318, 146);
            this.richTextBoxIngredient.TabIndex = 9;
            this.richTextBoxIngredient.Text = "Список ингрендиентов";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KitchenAssistant.Properties.Resources.meat_food_chicken;
            this.pictureBox1.Location = new System.Drawing.Point(343, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFood.ForeColor = System.Drawing.Color.LightYellow;
            this.labelFood.Location = new System.Drawing.Point(19, 9);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(442, 30);
            this.labelFood.TabIndex = 7;
            this.labelFood.Text = "123456789123456789123456789123456";
            // 
            // frmOneNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(479, 283);
            this.Controls.Add(this.labelTimeCook);
            this.Controls.Add(this.labelNumberOrder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxIngredient);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOneNewOrder";
            this.Text = "frmOneNewOrder";
            this.Load += new System.EventHandler(this.frmOneNewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTimeCook;
        private Label labelNumberOrder;
        private Button button1;
        private RichTextBox richTextBoxIngredient;
        private PictureBox pictureBox1;
        private Label labelFood;
    }
}