namespace KitchenAssistant.forChef
{
    partial class frmChef_Main
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonInProgressOrder = new System.Windows.Forms.Button();
            this.buttonNewOrders = new System.Windows.Forms.Button();
            this.panelUserName = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHead = new System.Windows.Forms.Panel();
            this.labelRazdel = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelUserName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenu.Controls.Add(this.buttonSetting);
            this.panelMenu.Controls.Add(this.buttonInProgressOrder);
            this.panelMenu.Controls.Add(this.buttonNewOrders);
            this.panelMenu.Controls.Add(this.panelUserName);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(285, 672);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonSetting
            // 
            this.buttonSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSetting.FlatAppearance.BorderSize = 0;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSetting.ForeColor = System.Drawing.Color.LightYellow;
            this.buttonSetting.Image = global::KitchenAssistant.Properties.Resources.settings;
            this.buttonSetting.Location = new System.Drawing.Point(0, 614);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(285, 58);
            this.buttonSetting.TabIndex = 3;
            this.buttonSetting.Text = "Настройки";
            this.buttonSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSetting.UseVisualStyleBackColor = true;
            // 
            // buttonInProgressOrder
            // 
            this.buttonInProgressOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInProgressOrder.FlatAppearance.BorderSize = 0;
            this.buttonInProgressOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInProgressOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonInProgressOrder.ForeColor = System.Drawing.Color.LightYellow;
            this.buttonInProgressOrder.Image = global::KitchenAssistant.Properties.Resources.clock;
            this.buttonInProgressOrder.Location = new System.Drawing.Point(0, 243);
            this.buttonInProgressOrder.Name = "buttonInProgressOrder";
            this.buttonInProgressOrder.Size = new System.Drawing.Size(285, 58);
            this.buttonInProgressOrder.TabIndex = 2;
            this.buttonInProgressOrder.Text = "Принятые     ";
            this.buttonInProgressOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInProgressOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonInProgressOrder.UseVisualStyleBackColor = true;
            this.buttonInProgressOrder.Click += new System.EventHandler(this.buttonInProgressOrder_Click);
            // 
            // buttonNewOrders
            // 
            this.buttonNewOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNewOrders.FlatAppearance.BorderSize = 0;
            this.buttonNewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNewOrders.ForeColor = System.Drawing.Color.LightYellow;
            this.buttonNewOrders.Image = global::KitchenAssistant.Properties.Resources.plus_green1;
            this.buttonNewOrders.Location = new System.Drawing.Point(0, 184);
            this.buttonNewOrders.Name = "buttonNewOrders";
            this.buttonNewOrders.Size = new System.Drawing.Size(285, 59);
            this.buttonNewOrders.TabIndex = 1;
            this.buttonNewOrders.Text = "Новые заявки";
            this.buttonNewOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNewOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonNewOrders.UseVisualStyleBackColor = true;
            this.buttonNewOrders.Click += new System.EventHandler(this.buttonNewOrders_Click);
            // 
            // panelUserName
            // 
            this.panelUserName.Controls.Add(this.labelUserName);
            this.panelUserName.Controls.Add(this.pictureBox1);
            this.panelUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserName.Location = new System.Drawing.Point(0, 0);
            this.panelUserName.Name = "panelUserName";
            this.panelUserName.Size = new System.Drawing.Size(285, 184);
            this.panelUserName.TabIndex = 1;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelUserName.ForeColor = System.Drawing.Color.LightYellow;
            this.labelUserName.Location = new System.Drawing.Point(52, 125);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(169, 20);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Имя пользователя";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::KitchenAssistant.Properties.Resources.chef_icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHead.Controls.Add(this.labelRazdel);
            this.panelHead.Controls.Add(this.buttonClose);
            this.panelHead.Controls.Add(this.labelDate);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(285, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(956, 106);
            this.panelHead.TabIndex = 1;
            // 
            // labelRazdel
            // 
            this.labelRazdel.AutoSize = true;
            this.labelRazdel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRazdel.ForeColor = System.Drawing.Color.LightYellow;
            this.labelRazdel.Location = new System.Drawing.Point(28, 16);
            this.labelRazdel.Name = "labelRazdel";
            this.labelRazdel.Size = new System.Drawing.Size(226, 37);
            this.labelRazdel.TabIndex = 2;
            this.labelRazdel.Text = "Новые заявки";
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.ForeColor = System.Drawing.Color.LightYellow;
            this.buttonClose.Location = new System.Drawing.Point(894, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(59, 44);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDate.ForeColor = System.Drawing.Color.LightYellow;
            this.labelDate.Location = new System.Drawing.Point(588, 65);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(215, 31);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "02 июня 2022г.";
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(285, 106);
            this.panelBody.Margin = new System.Windows.Forms.Padding(10);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(956, 566);
            this.panelBody.TabIndex = 2;
            // 
            // frmChef_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1241, 672);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChef_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChef_Main";
            this.Load += new System.EventHandler(this.frmChef_Main_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelUserName.ResumeLayout(false);
            this.panelUserName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button buttonSetting;
        private Button buttonInProgressOrder;
        private Button buttonNewOrders;
        private Panel panelUserName;
        private Label labelUserName;
        private PictureBox pictureBox1;
        private Panel panelHead;
        private Button buttonClose;
        private Label labelDate;
        private Panel panelBody;
        private Label labelRazdel;
    }
}