namespace OrderingFood_Orcullo_IT13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            orderButton = new Button();
            menuButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 60);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Britannic Bold", 15.8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(335, 30);
            label1.TabIndex = 0;
            label1.Text = "Fast Food Ordering System";
            // 
            // panel2
            // 
            panel2.Controls.Add(orderButton);
            panel2.Controls.Add(menuButton);
            panel2.Dock = DockStyle.Left;
            panel2.Enabled = true;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 673);
            panel2.TabIndex = 1;
            // 
            // orderButton
            // 
            orderButton.BackColor = Color.Gray;
            orderButton.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderButton.ForeColor = Color.White;
            orderButton.Location = new Point(12, 273);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(197, 88);
            orderButton.TabIndex = 1;
            orderButton.Text = "ORDER";
            orderButton.UseVisualStyleBackColor = false;
            orderButton.Click += orderButton_Click;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.Gray;
            menuButton.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuButton.ForeColor = Color.White;
            menuButton.Location = new Point(12, 123);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(197, 93);
            menuButton.TabIndex = 0;
            menuButton.Text = "MENU";
            menuButton.UseVisualStyleBackColor = false;
            menuButton.Click += menuButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(799, 673);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button orderButton;
        private Button menuButton;
    }
}
