namespace DispatcherClient
{
    partial class Order
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.TextBox();
            this.addr = new System.Windows.Forms.TextBox();
            this.tell = new System.Windows.Forms.TextBox();
            this.products = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.basketGrid = new System.Windows.Forms.DataGridView();
            this.PricePR = new System.Windows.Forms.Label();
            this.priceCountPR = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.allPrice = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.basketGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Продукт";
            // 
            // fio
            // 
            this.fio.Location = new System.Drawing.Point(133, 54);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(350, 23);
            this.fio.TabIndex = 6;
            // 
            // addr
            // 
            this.addr.Location = new System.Drawing.Point(133, 83);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(350, 23);
            this.addr.TabIndex = 7;
            // 
            // tell
            // 
            this.tell.Location = new System.Drawing.Point(133, 112);
            this.tell.Name = "tell";
            this.tell.Size = new System.Drawing.Size(350, 23);
            this.tell.TabIndex = 8;
            // 
            // products
            // 
            this.products.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.products.FormattingEnabled = true;
            this.products.Location = new System.Drawing.Point(133, 141);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(186, 23);
            this.products.TabIndex = 9;
            this.products.SelectedIndexChanged += new System.EventHandler(this.products_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Количество";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(133, 170);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(186, 23);
            this.count.TabIndex = 11;
            this.count.TextChanged += new System.EventHandler(this.count_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Корзина";
            // 
            // basketGrid
            // 
            this.basketGrid.AllowUserToAddRows = false;
            this.basketGrid.AllowUserToResizeColumns = false;
            this.basketGrid.AllowUserToResizeRows = false;
            this.basketGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.basketGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.basketGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.basketGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basketGrid.Location = new System.Drawing.Point(133, 204);
            this.basketGrid.MultiSelect = false;
            this.basketGrid.Name = "basketGrid";
            this.basketGrid.RowHeadersVisible = false;
            this.basketGrid.RowTemplate.Height = 25;
            this.basketGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.basketGrid.Size = new System.Drawing.Size(350, 103);
            this.basketGrid.TabIndex = 15;
            this.basketGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.basketGrid_RowsRemoved);
            // 
            // PricePR
            // 
            this.PricePR.AutoSize = true;
            this.PricePR.Location = new System.Drawing.Point(328, 144);
            this.PricePR.Name = "PricePR";
            this.PricePR.Size = new System.Drawing.Size(13, 15);
            this.PricePR.TabIndex = 16;
            this.PricePR.Text = "0";
            // 
            // priceCountPR
            // 
            this.priceCountPR.AutoSize = true;
            this.priceCountPR.Location = new System.Drawing.Point(328, 173);
            this.priceCountPR.Name = "priceCountPR";
            this.priceCountPR.Size = new System.Drawing.Size(13, 15);
            this.priceCountPR.TabIndex = 17;
            this.priceCountPR.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Итого :";
            // 
            // allPrice
            // 
            this.allPrice.AutoSize = true;
            this.allPrice.Location = new System.Drawing.Point(131, 318);
            this.allPrice.Name = "allPrice";
            this.allPrice.Size = new System.Drawing.Size(13, 15);
            this.allPrice.TabIndex = 19;
            this.allPrice.Text = "0";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " HH:mm:ss dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 356);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 476);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.allPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.priceCountPR);
            this.Controls.Add(this.PricePR);
            this.Controls.Add(this.basketGrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.products);
            this.Controls.Add(this.tell);
            this.Controls.Add(this.addr);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Order";
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.basketGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox fio;
        private TextBox addr;
        private TextBox tell;
        private ComboBox products;
        private Label label5;
        private TextBox count;
        private Button button3;
        private Label label6;
        private DataGridView basketGrid;
        private Label PricePR;
        private Label priceCountPR;
        private Label label7;
        private Label allPrice;
        private DateTimePicker dateTimePicker1;
    }
}