namespace Backpack
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
            this.itemsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.solveButton = new System.Windows.Forms.Button();
            this.ShowConditionsButton = new System.Windows.Forms.Button();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.решитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьИсходныеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemsListView
            // 
            this.itemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.itemsListView.Location = new System.Drawing.Point(12, 62);
            this.itemsListView.Name = "itemsListView";
            this.itemsListView.Size = new System.Drawing.Size(364, 330);
            this.itemsListView.TabIndex = 0;
            this.itemsListView.UseCompatibleStateImageBehavior = false;
            this.itemsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Вес";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Стоимость";
            this.columnHeader3.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Максимальная вместимость в кг";
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(637, 95);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(151, 29);
            this.solveButton.TabIndex = 2;
            this.solveButton.Text = "Решить";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // ShowConditionsButton
            // 
            this.ShowConditionsButton.Location = new System.Drawing.Point(637, 130);
            this.ShowConditionsButton.Name = "ShowConditionsButton";
            this.ShowConditionsButton.Size = new System.Drawing.Size(151, 29);
            this.ShowConditionsButton.TabIndex = 3;
            this.ShowConditionsButton.Text = "Исходные данные";
            this.ShowConditionsButton.UseVisualStyleBackColor = true;
            this.ShowConditionsButton.Click += new System.EventHandler(this.ShowConditionsButton_Click);
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(637, 62);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(151, 27);
            this.weightTextBox.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.решитьToolStripMenuItem,
            this.показатьИсходныеДанныеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // решитьToolStripMenuItem
            // 
            this.решитьToolStripMenuItem.Name = "решитьToolStripMenuItem";
            this.решитьToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.решитьToolStripMenuItem.Text = "Решить";
            this.решитьToolStripMenuItem.Click += new System.EventHandler(this.решитьToolStripMenuItem_Click);
            // 
            // показатьИсходныеДанныеToolStripMenuItem
            // 
            this.показатьИсходныеДанныеToolStripMenuItem.Name = "показатьИсходныеДанныеToolStripMenuItem";
            this.показатьИсходныеДанныеToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.показатьИсходныеДанныеToolStripMenuItem.Text = "Показать исходные данные";
            this.показатьИсходныеДанныеToolStripMenuItem.Click += new System.EventHandler(this.показатьИсходныеДанныеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.ShowConditionsButton);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemsListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Задача о рюкзаке";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView itemsListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label1;
        private Button solveButton;
        private Button ShowConditionsButton;
        private TextBox weightTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem решитьToolStripMenuItem;
        private ToolStripMenuItem показатьИсходныеДанныеToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
    }
}