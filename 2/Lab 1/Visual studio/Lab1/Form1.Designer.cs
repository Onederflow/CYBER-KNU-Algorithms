namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_title = new System.Windows.Forms.Button();
            this.Button_exit = new System.Windows.Forms.Button();
            this.Button_result = new System.Windows.Forms.Button();
            this.Button_products = new System.Windows.Forms.Button();
            this.Button_categories = new System.Windows.Forms.Button();
            this.panel_categories = new System.Windows.Forms.Panel();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.TextBoxCategories = new System.Windows.Forms.TextBox();
            this.panel_title = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAS = new System.Windows.Forms.Label();
            this.panel_result = new System.Windows.Forms.Panel();
            this.panel_exit = new System.Windows.Forms.Panel();
            this.panel_products = new System.Windows.Forms.Panel();
            this.listBox_Categories_p = new System.Windows.Forms.ListBox();
            this.textBox_pro = new System.Windows.Forms.TextBox();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.TableAbsolute = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown_a = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_m = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_b = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_p = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Next3 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Next1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Next4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.ButtonAddItem = new System.Windows.Forms.Button();
            this.Next2 = new System.Windows.Forms.Button();
            this.pictureBox_menu = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_paralax = new System.Windows.Forms.Panel();
            this.checkBox_x = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel_categories.SuspendLayout();
            this.panel_title.SuspendLayout();
            this.panel_result.SuspendLayout();
            this.panel_exit.SuspendLayout();
            this.panel_products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableAbsolute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.pictureBox_menu);
            this.panel1.Controls.Add(this.Button_title);
            this.panel1.Controls.Add(this.Button_exit);
            this.panel1.Controls.Add(this.Button_result);
            this.panel1.Controls.Add(this.Button_products);
            this.panel1.Controls.Add(this.Button_categories);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Button_title
            // 
            this.Button_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Button_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_title.FlatAppearance.BorderSize = 0;
            this.Button_title.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Button_title.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Button_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_title.Font = new System.Drawing.Font("Fibre Vintage", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_title.ForeColor = System.Drawing.Color.White;
            this.Button_title.Location = new System.Drawing.Point(81, 0);
            this.Button_title.Margin = new System.Windows.Forms.Padding(0);
            this.Button_title.Name = "Button_title";
            this.Button_title.Size = new System.Drawing.Size(95, 70);
            this.Button_title.TabIndex = 13;
            this.Button_title.Text = "Title";
            this.Button_title.UseVisualStyleBackColor = false;
            this.Button_title.Click += new System.EventHandler(this.Button_title_Click);
            // 
            // Button_exit
            // 
            this.Button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_exit.FlatAppearance.BorderSize = 0;
            this.Button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_exit.Font = new System.Drawing.Font("Fibre Vintage", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_exit.ForeColor = System.Drawing.Color.White;
            this.Button_exit.Location = new System.Drawing.Point(633, 0);
            this.Button_exit.Margin = new System.Windows.Forms.Padding(0);
            this.Button_exit.Name = "Button_exit";
            this.Button_exit.Size = new System.Drawing.Size(94, 70);
            this.Button_exit.TabIndex = 14;
            this.Button_exit.Text = "Exit";
            this.Button_exit.UseVisualStyleBackColor = false;
            this.Button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // Button_result
            // 
            this.Button_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Button_result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_result.FlatAppearance.BorderSize = 0;
            this.Button_result.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Button_result.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Button_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_result.Font = new System.Drawing.Font("Fibre Vintage", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_result.ForeColor = System.Drawing.Color.White;
            this.Button_result.Location = new System.Drawing.Point(515, 0);
            this.Button_result.Margin = new System.Windows.Forms.Padding(0);
            this.Button_result.Name = "Button_result";
            this.Button_result.Size = new System.Drawing.Size(118, 70);
            this.Button_result.TabIndex = 17;
            this.Button_result.Text = "Result";
            this.Button_result.UseVisualStyleBackColor = false;
            this.Button_result.Click += new System.EventHandler(this.Button_result_Click);
            // 
            // Button_products
            // 
            this.Button_products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Button_products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_products.FlatAppearance.BorderSize = 0;
            this.Button_products.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Button_products.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Button_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_products.Font = new System.Drawing.Font("Fibre Vintage", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_products.ForeColor = System.Drawing.Color.White;
            this.Button_products.Location = new System.Drawing.Point(356, 0);
            this.Button_products.Margin = new System.Windows.Forms.Padding(0);
            this.Button_products.Name = "Button_products";
            this.Button_products.Size = new System.Drawing.Size(159, 70);
            this.Button_products.TabIndex = 16;
            this.Button_products.Text = "Products";
            this.Button_products.UseVisualStyleBackColor = false;
            this.Button_products.Click += new System.EventHandler(this.Button_products_Click);
            // 
            // Button_categories
            // 
            this.Button_categories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Button_categories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_categories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_categories.FlatAppearance.BorderSize = 0;
            this.Button_categories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Button_categories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Button_categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_categories.Font = new System.Drawing.Font("Fibre Vintage", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_categories.ForeColor = System.Drawing.Color.White;
            this.Button_categories.Location = new System.Drawing.Point(176, 0);
            this.Button_categories.Margin = new System.Windows.Forms.Padding(0);
            this.Button_categories.Name = "Button_categories";
            this.Button_categories.Size = new System.Drawing.Size(180, 70);
            this.Button_categories.TabIndex = 15;
            this.Button_categories.Text = "Categories";
            this.Button_categories.UseVisualStyleBackColor = false;
            this.Button_categories.Click += new System.EventHandler(this.Button_categories_Click);
            // 
            // panel_categories
            // 
            this.panel_categories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.panel_categories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_categories.Controls.Add(this.button2);
            this.panel_categories.Controls.Add(this.button_delete);
            this.panel_categories.Controls.Add(this.listBoxCategories);
            this.panel_categories.Controls.Add(this.ButtonAddItem);
            this.panel_categories.Controls.Add(this.TextBoxCategories);
            this.panel_categories.Controls.Add(this.Next2);
            this.panel_categories.ForeColor = System.Drawing.Color.Black;
            this.panel_categories.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel_categories.Location = new System.Drawing.Point(1000, 104);
            this.panel_categories.Margin = new System.Windows.Forms.Padding(0);
            this.panel_categories.Name = "panel_categories";
            this.panel_categories.Size = new System.Drawing.Size(640, 320);
            this.panel_categories.TabIndex = 14;
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.listBoxCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCategories.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.HorizontalScrollbar = true;
            this.listBoxCategories.ItemHeight = 29;
            this.listBoxCategories.Location = new System.Drawing.Point(15, 14);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(250, 290);
            this.listBoxCategories.TabIndex = 30;
            this.listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.listBoxCategories_SelectedIndexChanged);
            // 
            // TextBoxCategories
            // 
            this.TextBoxCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.TextBoxCategories.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TextBoxCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBoxCategories.Location = new System.Drawing.Point(276, 16);
            this.TextBoxCategories.Name = "TextBoxCategories";
            this.TextBoxCategories.Size = new System.Drawing.Size(344, 35);
            this.TextBoxCategories.TabIndex = 24;
            this.TextBoxCategories.TextChanged += new System.EventHandler(this.TextBoxCategories_TextChanged);
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.panel_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_title.Controls.Add(this.label3);
            this.panel_title.Controls.Add(this.pictureBox2);
            this.panel_title.Controls.Add(this.label2);
            this.panel_title.Controls.Add(this.pictureBox1);
            this.panel_title.Controls.Add(this.Next1);
            this.panel_title.Controls.Add(this.label1);
            this.panel_title.Controls.Add(this.labelAS);
            this.panel_title.ForeColor = System.Drawing.Color.Black;
            this.panel_title.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel_title.Location = new System.Drawing.Point(80, 104);
            this.panel_title.Margin = new System.Windows.Forms.Padding(0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(640, 320);
            this.panel_title.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Casual", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(171, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "by Alexander Kozhanovskiy ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(25, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(589, 56);
            this.label2.TabIndex = 20;
            this.label2.Text = " Lab №1 Perfect hashing";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Casual", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "algorithms and complexity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelAS
            // 
            this.labelAS.AutoSize = true;
            this.labelAS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAS.ForeColor = System.Drawing.Color.White;
            this.labelAS.Location = new System.Drawing.Point(107, 73);
            this.labelAS.Name = "labelAS";
            this.labelAS.Size = new System.Drawing.Size(349, 16);
            this.labelAS.TabIndex = 0;
            this.labelAS.Text = "FACULTY OF COMPUTER SCIENCE AND CYBERNETICS";
            this.labelAS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_result
            // 
            this.panel_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.panel_result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_result.Controls.Add(this.checkBox_x);
            this.panel_result.Controls.Add(this.label7);
            this.panel_result.Controls.Add(this.label6);
            this.panel_result.Controls.Add(this.label5);
            this.panel_result.Controls.Add(this.label4);
            this.panel_result.Controls.Add(this.numericUpDown_p);
            this.panel_result.Controls.Add(this.numericUpDown_b);
            this.panel_result.Controls.Add(this.numericUpDown_m);
            this.panel_result.Controls.Add(this.numericUpDown_a);
            this.panel_result.Controls.Add(this.button1);
            this.panel_result.Controls.Add(this.TableAbsolute);
            this.panel_result.Controls.Add(this.listBoxResult);
            this.panel_result.Controls.Add(this.Next4);
            this.panel_result.ForeColor = System.Drawing.Color.Black;
            this.panel_result.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel_result.Location = new System.Drawing.Point(1000, 104);
            this.panel_result.Margin = new System.Windows.Forms.Padding(0);
            this.panel_result.Name = "panel_result";
            this.panel_result.Size = new System.Drawing.Size(640, 320);
            this.panel_result.TabIndex = 15;
            // 
            // panel_exit
            // 
            this.panel_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.panel_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_exit.Controls.Add(this.button5);
            this.panel_exit.ForeColor = System.Drawing.Color.Black;
            this.panel_exit.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel_exit.Location = new System.Drawing.Point(1000, 104);
            this.panel_exit.Margin = new System.Windows.Forms.Padding(0);
            this.panel_exit.Name = "panel_exit";
            this.panel_exit.Size = new System.Drawing.Size(640, 320);
            this.panel_exit.TabIndex = 16;
            // 
            // panel_products
            // 
            this.panel_products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.panel_products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_products.Controls.Add(this.button6);
            this.panel_products.Controls.Add(this.numericUpDown1);
            this.panel_products.Controls.Add(this.listBoxProducts);
            this.panel_products.Controls.Add(this.button3);
            this.panel_products.Controls.Add(this.listBox_Categories_p);
            this.panel_products.Controls.Add(this.button4);
            this.panel_products.Controls.Add(this.textBox_pro);
            this.panel_products.Controls.Add(this.Next3);
            this.panel_products.Controls.Add(this.pictureBox4);
            this.panel_products.ForeColor = System.Drawing.Color.Black;
            this.panel_products.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel_products.Location = new System.Drawing.Point(1000, 104);
            this.panel_products.Margin = new System.Windows.Forms.Padding(0);
            this.panel_products.Name = "panel_products";
            this.panel_products.Size = new System.Drawing.Size(640, 320);
            this.panel_products.TabIndex = 33;
            // 
            // listBox_Categories_p
            // 
            this.listBox_Categories_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.listBox_Categories_p.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Categories_p.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Categories_p.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox_Categories_p.FormattingEnabled = true;
            this.listBox_Categories_p.HorizontalScrollbar = true;
            this.listBox_Categories_p.ItemHeight = 29;
            this.listBox_Categories_p.Location = new System.Drawing.Point(15, 14);
            this.listBox_Categories_p.Name = "listBox_Categories_p";
            this.listBox_Categories_p.Size = new System.Drawing.Size(189, 290);
            this.listBox_Categories_p.TabIndex = 30;
            this.listBox_Categories_p.SelectedIndexChanged += new System.EventHandler(this.listBox_Categories_p_SelectedIndexChanged);
            // 
            // textBox_pro
            // 
            this.textBox_pro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.textBox_pro.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBox_pro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_pro.Location = new System.Drawing.Point(472, 11);
            this.textBox_pro.Name = "textBox_pro";
            this.textBox_pro.Size = new System.Drawing.Size(148, 35);
            this.textBox_pro.TabIndex = 24;
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.listBoxProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxProducts.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.HorizontalScrollbar = true;
            this.listBoxProducts.ItemHeight = 25;
            this.listBoxProducts.Location = new System.Drawing.Point(235, 11);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(218, 275);
            this.listBoxProducts.TabIndex = 33;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numericUpDown1.Location = new System.Drawing.Point(472, 165);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 22);
            this.numericUpDown1.TabIndex = 34;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Fibre Vintage", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(518, 160);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button6.Size = new System.Drawing.Size(102, 32);
            this.button6.TabIndex = 35;
            this.button6.Text = "add random";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.listBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxResult.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.HorizontalScrollbar = true;
            this.listBoxResult.ItemHeight = 29;
            this.listBoxResult.Location = new System.Drawing.Point(18, 11);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(123, 290);
            this.listBoxResult.TabIndex = 38;
            this.listBoxResult.SelectedIndexChanged += new System.EventHandler(this.listBoxResult_SelectedIndexChanged);
            // 
            // TableAbsolute
            // 
            this.TableAbsolute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TableAbsolute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableAbsolute.Location = new System.Drawing.Point(147, 11);
            this.TableAbsolute.Name = "TableAbsolute";
            this.TableAbsolute.Size = new System.Drawing.Size(380, 290);
            this.TableAbsolute.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.button1.Location = new System.Drawing.Point(542, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 40;
            this.button1.Text = "ReWrite";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // numericUpDown_a
            // 
            this.numericUpDown_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numericUpDown_a.Location = new System.Drawing.Point(565, 28);
            this.numericUpDown_a.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_a.Name = "numericUpDown_a";
            this.numericUpDown_a.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_a.TabIndex = 41;
            this.numericUpDown_a.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown_m
            // 
            this.numericUpDown_m.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numericUpDown_m.Location = new System.Drawing.Point(565, 80);
            this.numericUpDown_m.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_m.Name = "numericUpDown_m";
            this.numericUpDown_m.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_m.TabIndex = 42;
            this.numericUpDown_m.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // numericUpDown_b
            // 
            this.numericUpDown_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numericUpDown_b.Location = new System.Drawing.Point(565, 54);
            this.numericUpDown_b.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_b.Name = "numericUpDown_b";
            this.numericUpDown_b.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_b.TabIndex = 43;
            this.numericUpDown_b.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // numericUpDown_p
            // 
            this.numericUpDown_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numericUpDown_p.Location = new System.Drawing.Point(565, 106);
            this.numericUpDown_p.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_p.Name = "numericUpDown_p";
            this.numericUpDown_p.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_p.TabIndex = 44;
            this.numericUpDown_p.Value = new decimal(new int[] {
            10007,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(536, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "a =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(536, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "b =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(536, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "m =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(536, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "p =";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Fibre Vintage", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(472, 106);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(148, 47);
            this.button3.TabIndex = 31;
            this.button3.Text = "delete";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Fibre Vintage", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(472, 53);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(148, 47);
            this.button4.TabIndex = 25;
            this.button4.Text = "Add";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Next3
            // 
            this.Next3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Next3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Next3.BackgroundImage")));
            this.Next3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Next3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next3.FlatAppearance.BorderSize = 0;
            this.Next3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Next3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Next3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next3.Font = new System.Drawing.Font("Fibre Vintage", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next3.ForeColor = System.Drawing.Color.White;
            this.Next3.Location = new System.Drawing.Point(553, 234);
            this.Next3.Margin = new System.Windows.Forms.Padding(0);
            this.Next3.Name = "Next3";
            this.Next3.Size = new System.Drawing.Size(70, 70);
            this.Next3.TabIndex = 22;
            this.Next3.UseVisualStyleBackColor = false;
            this.Next3.Click += new System.EventHandler(this.Next3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(197, 115);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 77);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox2.Location = new System.Drawing.Point(13, 109);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(615, 10);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Next1
            // 
            this.Next1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Next1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Next1.BackgroundImage")));
            this.Next1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Next1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next1.FlatAppearance.BorderSize = 0;
            this.Next1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Next1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Next1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next1.Font = new System.Drawing.Font("Fibre Vintage", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next1.ForeColor = System.Drawing.Color.White;
            this.Next1.Location = new System.Drawing.Point(553, 234);
            this.Next1.Margin = new System.Windows.Forms.Padding(0);
            this.Next1.Name = "Next1";
            this.Next1.Size = new System.Drawing.Size(70, 70);
            this.Next1.TabIndex = 18;
            this.Next1.UseVisualStyleBackColor = false;
            this.Next1.Click += new System.EventHandler(this.Next1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Fibre Vintage", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Image = global::Lab1.Properties.Resources.exit;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(202, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(233, 235);
            this.button5.TabIndex = 0;
            this.button5.Text = "Exit";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Next4
            // 
            this.Next4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Next4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Next4.BackgroundImage")));
            this.Next4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Next4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next4.FlatAppearance.BorderSize = 0;
            this.Next4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Next4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Next4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next4.Font = new System.Drawing.Font("Fibre Vintage", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next4.ForeColor = System.Drawing.Color.White;
            this.Next4.Location = new System.Drawing.Point(553, 234);
            this.Next4.Margin = new System.Windows.Forms.Padding(0);
            this.Next4.Name = "Next4";
            this.Next4.Size = new System.Drawing.Size(70, 70);
            this.Next4.TabIndex = 37;
            this.Next4.UseVisualStyleBackColor = false;
            this.Next4.Click += new System.EventHandler(this.Next4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Fibre Vintage", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(276, 137);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(344, 41);
            this.button2.TabIndex = 32;
            this.button2.Text = "add default categories";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Fibre Vintage", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.button_delete.Image = ((System.Drawing.Image)(resources.GetObject("button_delete.Image")));
            this.button_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_delete.Location = new System.Drawing.Point(445, 63);
            this.button_delete.Name = "button_delete";
            this.button_delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_delete.Size = new System.Drawing.Size(175, 68);
            this.button_delete.TabIndex = 31;
            this.button_delete.Text = "delete";
            this.button_delete.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // ButtonAddItem
            // 
            this.ButtonAddItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonAddItem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonAddItem.FlatAppearance.BorderSize = 0;
            this.ButtonAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddItem.Font = new System.Drawing.Font("Fibre Vintage", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.ButtonAddItem.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAddItem.Image")));
            this.ButtonAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAddItem.Location = new System.Drawing.Point(276, 63);
            this.ButtonAddItem.Name = "ButtonAddItem";
            this.ButtonAddItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonAddItem.Size = new System.Drawing.Size(163, 68);
            this.ButtonAddItem.TabIndex = 25;
            this.ButtonAddItem.Text = "Add";
            this.ButtonAddItem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ButtonAddItem.UseVisualStyleBackColor = false;
            this.ButtonAddItem.Click += new System.EventHandler(this.ButtonAddItem_Click);
            // 
            // Next2
            // 
            this.Next2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Next2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Next2.BackgroundImage")));
            this.Next2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Next2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next2.FlatAppearance.BorderSize = 0;
            this.Next2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Next2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.Next2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next2.Font = new System.Drawing.Font("Fibre Vintage", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next2.ForeColor = System.Drawing.Color.White;
            this.Next2.Location = new System.Drawing.Point(553, 234);
            this.Next2.Margin = new System.Windows.Forms.Padding(0);
            this.Next2.Name = "Next2";
            this.Next2.Size = new System.Drawing.Size(70, 70);
            this.Next2.TabIndex = 22;
            this.Next2.UseVisualStyleBackColor = false;
            this.Next2.Click += new System.EventHandler(this.Next2_Click);
            // 
            // pictureBox_menu
            // 
            this.pictureBox_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBox_menu.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_menu.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_menu.Name = "pictureBox_menu";
            this.pictureBox_menu.Size = new System.Drawing.Size(800, 8);
            this.pictureBox_menu.TabIndex = 11;
            this.pictureBox_menu.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.pictureBox3.Location = new System.Drawing.Point(0, 70);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(800, 8);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // panel_paralax
            // 
            this.panel_paralax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_paralax.BackgroundImage")));
            this.panel_paralax.Location = new System.Drawing.Point(0, 0);
            this.panel_paralax.Name = "panel_paralax";
            this.panel_paralax.Size = new System.Drawing.Size(1200, 450);
            this.panel_paralax.TabIndex = 14;
            // 
            // checkBox_x
            // 
            this.checkBox_x.AutoSize = true;
            this.checkBox_x.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.checkBox_x.ForeColor = System.Drawing.Color.White;
            this.checkBox_x.Location = new System.Drawing.Point(533, 136);
            this.checkBox_x.Name = "checkBox_x";
            this.checkBox_x.Size = new System.Drawing.Size(89, 44);
            this.checkBox_x.TabIndex = 49;
            this.checkBox_x.Text = "Use count\r\nas \"m\"";
            this.checkBox_x.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_x.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(798, 448);
            this.ControlBox = false;
            this.Controls.Add(this.panel_products);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.panel_exit);
            this.Controls.Add(this.panel_result);
            this.Controls.Add(this.panel_categories);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel_paralax);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "algorithms and complexity";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel_categories.ResumeLayout(false);
            this.panel_categories.PerformLayout();
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.panel_result.ResumeLayout(false);
            this.panel_result.PerformLayout();
            this.panel_exit.ResumeLayout(false);
            this.panel_products.ResumeLayout(false);
            this.panel_products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableAbsolute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox_menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Button_title;
        private System.Windows.Forms.Button Button_exit;
        private System.Windows.Forms.Button Button_result;
        private System.Windows.Forms.Button Button_products;
        private System.Windows.Forms.Button Button_categories;
        public System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel_paralax;
        public System.Windows.Forms.Panel panel_categories;
        public System.Windows.Forms.Panel panel_result;
        public System.Windows.Forms.Panel panel_exit;
        private System.Windows.Forms.Label labelAS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Next1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Next2;
        private System.Windows.Forms.Button ButtonAddItem;
        private System.Windows.Forms.TextBox TextBoxCategories;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Panel panel_products;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox_Categories_p;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox_pro;
        private System.Windows.Forms.Button Next3;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button Next4;
        private System.Windows.Forms.DataGridView TableAbsolute;
        private System.Windows.Forms.NumericUpDown numericUpDown_b;
        private System.Windows.Forms.NumericUpDown numericUpDown_m;
        private System.Windows.Forms.NumericUpDown numericUpDown_a;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_p;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox_x;
    }
}

