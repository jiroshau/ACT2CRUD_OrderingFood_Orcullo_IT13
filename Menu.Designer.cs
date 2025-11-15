namespace OrderingFood_Orcullo_IT13
{
    partial class Menu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel1 = new Panel();
            txtMenu = new Label();
            txtName = new Label();
            txtPrice = new Label();
            txtQuantity = new Label();
            txtSizes = new Label();
            foodtextBox = new TextBox();
            priceTextBox = new TextBox();
            sizeTextBox = new TextBox();
            quantityTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            viewButton = new Button();
            button6 = new Button();
            clearButton = new Button();
            label6 = new Label();
            textBox5 = new TextBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(txtMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(874, 77);
            panel1.TabIndex = 18;
            // 
            // txtMenu
            // 
            txtMenu.AutoSize = true;
            txtMenu.BackColor = Color.Gray;
            txtMenu.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMenu.ForeColor = Color.White;
            txtMenu.Location = new Point(285, 9);
            txtMenu.Name = "txtMenu";
            txtMenu.Size = new Size(277, 52);
            txtMenu.TabIndex = 0;
            txtMenu.Text = "MENU ITEMS";
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(25, 140);
            txtName.Name = "txtName";
            txtName.Size = new Size(182, 31);
            txtName.TabIndex = 17;
            txtName.Text = "FOOD NAME : ";
            // 
            // txtPrice
            // 
            txtPrice.AutoSize = true;
            txtPrice.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(45, 210);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(114, 31);
            txtPrice.TabIndex = 16;
            txtPrice.Text = "PRICE : ";
            // 
            // txtQuantity
            // 
            txtQuantity.AutoSize = true;
            txtQuantity.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(25, 271);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 31);
            txtQuantity.TabIndex = 15;
            txtQuantity.Text = "QUANTITY :";
            // 
            // txtSizes
            // 
            txtSizes.AutoSize = true;
            txtSizes.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSizes.Location = new Point(45, 333);
            txtSizes.Name = "txtSizes";
            txtSizes.Size = new Size(107, 31);
            txtSizes.TabIndex = 14;
            txtSizes.Text = "SIZES : ";
            // 
            // foodtextBox
            // 
            foodtextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foodtextBox.Location = new Point(219, 131);
            foodtextBox.Name = "foodtextBox";
            foodtextBox.Size = new Size(201, 43);
            foodtextBox.TabIndex = 13;
            // 
            // priceTextBox
            // 
            priceTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceTextBox.Location = new Point(219, 201);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(202, 43);
            priceTextBox.TabIndex = 12;
            // 
            // sizeTextBox
            // 
            sizeTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sizeTextBox.Location = new Point(218, 324);
            sizeTextBox.Name = "sizeTextBox";
            sizeTextBox.Size = new Size(202, 43);
            sizeTextBox.TabIndex = 11;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityTextBox.Location = new Point(218, 262);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(202, 43);
            quantityTextBox.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(444, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(418, 280);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 392);
            addButton.Name = "addButton";
            addButton.Size = new Size(83, 28);
            addButton.TabIndex = 8;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(219, 391);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(94, 29);
            updateButton.TabIndex = 7;
            updateButton.Text = "UPDATE";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(327, 392);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "DELETE";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // viewButton
            // 
            viewButton.Location = new Point(113, 391);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(94, 29);
            viewButton.TabIndex = 5;
            viewButton.Text = "VIEW";
            viewButton.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(497, 440);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 4;
            button6.Text = "SEARCH ";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(444, 392);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 3;
            clearButton.Text = "CLEAR";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(129, 440);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 2;
            label6.Text = "Search : ";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(219, 442);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(129, 27);
            textBox5.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(113, 474);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(533, 183);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 669);
            Controls.Add(dataGridView1);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(clearButton);
            Controls.Add(button6);
            Controls.Add(viewButton);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(pictureBox1);
            Controls.Add(quantityTextBox);
            Controls.Add(sizeTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(foodtextBox);
            Controls.Add(txtSizes);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(panel1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label txtMenu;
        private Label txtName;
        private Label txtPrice;
        private Label txtQuantity;
        private Label txtSizes;
        private TextBox foodtextBox;
        private TextBox priceTextBox;
        private TextBox sizeTextBox;
        private TextBox quantityTextBox;
        private PictureBox pictureBox1;
        private Button addButton;
        private Button updateButton;
        private Button deleteButton;
        private Button viewButton;
        private Button button6;
        private Button clearButton;
        private Label label6;
        private TextBox textBox5;
        private DataGridView dataGridView1;
    }
}
