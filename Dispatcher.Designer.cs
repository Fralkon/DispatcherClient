namespace DispatcherClient
{
    partial class Dispatcher
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторизацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.созданоToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отправленоToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.доставленоToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отказToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.просроченоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.админкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправленоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доставленоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дублироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.заявкаToolStripMenuItem,
            this.фильтToolStripMenuItem,
            this.админкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1051, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авторизацияToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // авторизацияToolStripMenuItem
            // 
            this.авторизацияToolStripMenuItem.Name = "авторизацияToolStripMenuItem";
            this.авторизацияToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.авторизацияToolStripMenuItem.Text = "Авторизация";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // заявкаToolStripMenuItem
            // 
            this.заявкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяToolStripMenuItem});
            this.заявкаToolStripMenuItem.Name = "заявкаToolStripMenuItem";
            this.заявкаToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.заявкаToolStripMenuItem.Text = "Заявка";
            // 
            // новаяToolStripMenuItem
            // 
            this.новаяToolStripMenuItem.Name = "новаяToolStripMenuItem";
            this.новаяToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.новаяToolStripMenuItem.Text = "Создать";
            this.новаяToolStripMenuItem.Click += new System.EventHandler(this.новаяToolStripMenuItem_Click);
            // 
            // фильтToolStripMenuItem
            // 
            this.фильтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.статусToolStripMenuItem1});
            this.фильтToolStripMenuItem.Name = "фильтToolStripMenuItem";
            this.фильтToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.фильтToolStripMenuItem.Text = "Фильт";
            // 
            // статусToolStripMenuItem1
            // 
            this.статусToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданоToolStripMenuItem1,
            this.отправленоToolStripMenuItem1,
            this.доставленоToolStripMenuItem1,
            this.отказToolStripMenuItem1,
            this.просроченоToolStripMenuItem});
            this.статусToolStripMenuItem1.Name = "статусToolStripMenuItem1";
            this.статусToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.статусToolStripMenuItem1.Text = "Статус";
            // 
            // созданоToolStripMenuItem1
            // 
            this.созданоToolStripMenuItem1.Checked = true;
            this.созданоToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.созданоToolStripMenuItem1.Name = "созданоToolStripMenuItem1";
            this.созданоToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.созданоToolStripMenuItem1.Text = "Создано";
            this.созданоToolStripMenuItem1.Click += new System.EventHandler(this.созданоToolStripMenuItem1_Click);
            // 
            // отправленоToolStripMenuItem1
            // 
            this.отправленоToolStripMenuItem1.Checked = true;
            this.отправленоToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.отправленоToolStripMenuItem1.Name = "отправленоToolStripMenuItem1";
            this.отправленоToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.отправленоToolStripMenuItem1.Text = "Отправлено";
            this.отправленоToolStripMenuItem1.Click += new System.EventHandler(this.созданоToolStripMenuItem1_Click);
            // 
            // доставленоToolStripMenuItem1
            // 
            this.доставленоToolStripMenuItem1.Name = "доставленоToolStripMenuItem1";
            this.доставленоToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.доставленоToolStripMenuItem1.Text = "Доставлено";
            this.доставленоToolStripMenuItem1.Click += new System.EventHandler(this.созданоToolStripMenuItem1_Click);
            // 
            // отказToolStripMenuItem1
            // 
            this.отказToolStripMenuItem1.Name = "отказToolStripMenuItem1";
            this.отказToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.отказToolStripMenuItem1.Text = "Отказ";
            this.отказToolStripMenuItem1.Click += new System.EventHandler(this.созданоToolStripMenuItem1_Click);
            // 
            // просроченоToolStripMenuItem
            // 
            this.просроченоToolStripMenuItem.Checked = true;
            this.просроченоToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.просроченоToolStripMenuItem.Name = "просроченоToolStripMenuItem";
            this.просроченоToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.просроченоToolStripMenuItem.Text = "Просрочено";
            this.просроченоToolStripMenuItem.Click += new System.EventHandler(this.созданоToolStripMenuItem1_Click);
            // 
            // админкаToolStripMenuItem
            // 
            this.админкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарыToolStripMenuItem,
            this.пользователиToolStripMenuItem});
            this.админкаToolStripMenuItem.Name = "админкаToolStripMenuItem";
            this.админкаToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.админкаToolStripMenuItem.Text = "Админка";
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.товарыToolStripMenuItem.Text = "Товары";
            this.товарыToolStripMenuItem.Click += new System.EventHandler(this.товарыToolStripMenuItem_Click);
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(0, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1051, 475);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.статусToolStripMenuItem,
            this.дублироватьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 92);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.новаяToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // статусToolStripMenuItem
            // 
            this.статусToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отправленоToolStripMenuItem,
            this.доставленоToolStripMenuItem,
            this.отказToolStripMenuItem});
            this.статусToolStripMenuItem.Name = "статусToolStripMenuItem";
            this.статусToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.статусToolStripMenuItem.Text = "Статус";
            // 
            // отправленоToolStripMenuItem
            // 
            this.отправленоToolStripMenuItem.Name = "отправленоToolStripMenuItem";
            this.отправленоToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.отправленоToolStripMenuItem.Text = "Отправлено";
            this.отправленоToolStripMenuItem.Click += new System.EventHandler(this.отправленоToolStripMenuItem_Click);
            // 
            // доставленоToolStripMenuItem
            // 
            this.доставленоToolStripMenuItem.Name = "доставленоToolStripMenuItem";
            this.доставленоToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.доставленоToolStripMenuItem.Text = "Доставлено";
            this.доставленоToolStripMenuItem.Click += new System.EventHandler(this.отправленоToolStripMenuItem_Click);
            // 
            // отказToolStripMenuItem
            // 
            this.отказToolStripMenuItem.Name = "отказToolStripMenuItem";
            this.отказToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.отказToolStripMenuItem.Text = "Отказ";
            this.отказToolStripMenuItem.Click += new System.EventHandler(this.отправленоToolStripMenuItem_Click);
            // 
            // дублироватьToolStripMenuItem
            // 
            this.дублироватьToolStripMenuItem.Name = "дублироватьToolStripMenuItem";
            this.дублироватьToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.дублироватьToolStripMenuItem.Text = "Дублировать";
            this.дублироватьToolStripMenuItem.Click += new System.EventHandler(this.дублироватьToolStripMenuItem_Click);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(73, 27);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(207, 23);
            this.searchText.TabIndex = 3;
            this.searchText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск";
            // 
            // Dispatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dispatcher";
            this.Text = "Dispatcher";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem авторизацияToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem заявкаToolStripMenuItem;
        private ToolStripMenuItem новаяToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem статусToolStripMenuItem;
        private TextBox searchText;
        private Label label1;
        private ToolStripMenuItem отправленоToolStripMenuItem;
        private ToolStripMenuItem доставленоToolStripMenuItem;
        private ToolStripMenuItem отказToolStripMenuItem;
        private ToolStripMenuItem дублироватьToolStripMenuItem;
        private ToolStripMenuItem фильтToolStripMenuItem;
        private ToolStripMenuItem статусToolStripMenuItem1;
        private ToolStripMenuItem созданоToolStripMenuItem1;
        private ToolStripMenuItem отправленоToolStripMenuItem1;
        private ToolStripMenuItem доставленоToolStripMenuItem1;
        private ToolStripMenuItem отказToolStripMenuItem1;
        private ToolStripMenuItem просроченоToolStripMenuItem;
        private ToolStripMenuItem админкаToolStripMenuItem;
        private ToolStripMenuItem товарыToolStripMenuItem;
        private ToolStripMenuItem пользователиToolStripMenuItem;
    }
}