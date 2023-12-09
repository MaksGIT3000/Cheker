namespace MaksProject
{
    partial class MainForm
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
            CloseBtn = new Button();
            FrutBtn = new Button();
            VegBtn = new Button();
            HalfProdBtn = new Button();
            SeaBtn = new Button();
            BakaleaBtn = new Button();
            CandyBtn = new Button();
            AlcBtn = new Button();
            MeatBtn = new Button();
            FlourBtn = new Button();
            DrinkBtn = new Button();
            MilkBtn = new Button();
            listView = new ListView();
            columnHeader2 = new ColumnHeader();
            AddBtn = new Button();
            SuspendLayout();
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.Red;
            CloseBtn.Location = new Point(764, 12);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(24, 23);
            CloseBtn.TabIndex = 0;
            CloseBtn.Text = "X";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += button1_Click;
            // 
            // FrutBtn
            // 
            FrutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FrutBtn.Location = new Point(12, 116);
            FrutBtn.Name = "FrutBtn";
            FrutBtn.Size = new Size(140, 33);
            FrutBtn.TabIndex = 1;
            FrutBtn.Text = "Фрукты";
            FrutBtn.UseVisualStyleBackColor = true;
            // 
            // VegBtn
            // 
            VegBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            VegBtn.Location = new Point(12, 157);
            VegBtn.Name = "VegBtn";
            VegBtn.Size = new Size(140, 33);
            VegBtn.TabIndex = 2;
            VegBtn.Text = "Овощи";
            VegBtn.UseVisualStyleBackColor = true;
            // 
            // HalfProdBtn
            // 
            HalfProdBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HalfProdBtn.Location = new Point(12, 199);
            HalfProdBtn.Name = "HalfProdBtn";
            HalfProdBtn.Size = new Size(140, 33);
            HalfProdBtn.TabIndex = 3;
            HalfProdBtn.Text = "Полуфабрикаты";
            HalfProdBtn.UseVisualStyleBackColor = true;
            // 
            // SeaBtn
            // 
            SeaBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SeaBtn.Location = new Point(12, 243);
            SeaBtn.Name = "SeaBtn";
            SeaBtn.Size = new Size(140, 33);
            SeaBtn.TabIndex = 4;
            SeaBtn.Text = "Морепродукты";
            SeaBtn.UseVisualStyleBackColor = true;
            // 
            // BakaleaBtn
            // 
            BakaleaBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BakaleaBtn.Location = new Point(12, 285);
            BakaleaBtn.Name = "BakaleaBtn";
            BakaleaBtn.Size = new Size(140, 33);
            BakaleaBtn.TabIndex = 5;
            BakaleaBtn.Text = "Бакалея";
            BakaleaBtn.UseVisualStyleBackColor = true;
            // 
            // CandyBtn
            // 
            CandyBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CandyBtn.Location = new Point(12, 403);
            CandyBtn.Name = "CandyBtn";
            CandyBtn.Size = new Size(140, 33);
            CandyBtn.TabIndex = 6;
            CandyBtn.Text = "Сладости";
            CandyBtn.UseVisualStyleBackColor = true;
            // 
            // AlcBtn
            // 
            AlcBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AlcBtn.Location = new Point(12, 323);
            AlcBtn.Name = "AlcBtn";
            AlcBtn.Size = new Size(140, 33);
            AlcBtn.TabIndex = 6;
            AlcBtn.Text = "Алкоголь";
            AlcBtn.UseVisualStyleBackColor = true;
            // 
            // MeatBtn
            // 
            MeatBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MeatBtn.Location = new Point(12, 362);
            MeatBtn.Name = "MeatBtn";
            MeatBtn.Size = new Size(140, 33);
            MeatBtn.TabIndex = 7;
            MeatBtn.Text = "Мясо";
            MeatBtn.UseVisualStyleBackColor = true;
            // 
            // FlourBtn
            // 
            FlourBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FlourBtn.Location = new Point(12, 447);
            FlourBtn.Name = "FlourBtn";
            FlourBtn.Size = new Size(140, 33);
            FlourBtn.TabIndex = 8;
            FlourBtn.Text = "Мучное";
            FlourBtn.UseVisualStyleBackColor = true;
            // 
            // DrinkBtn
            // 
            DrinkBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DrinkBtn.Location = new Point(12, 489);
            DrinkBtn.Name = "DrinkBtn";
            DrinkBtn.Size = new Size(140, 33);
            DrinkBtn.TabIndex = 9;
            DrinkBtn.Text = "Напитки";
            DrinkBtn.UseVisualStyleBackColor = true;
            // 
            // MilkBtn
            // 
            MilkBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MilkBtn.Location = new Point(12, 530);
            MilkBtn.Name = "MilkBtn";
            MilkBtn.Size = new Size(140, 33);
            MilkBtn.TabIndex = 10;
            MilkBtn.Text = "Молочная продукция";
            MilkBtn.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            listView.BackColor = Color.Lime;
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView.Location = new Point(197, 116);
            listView.Name = "listView";
            listView.Size = new Size(582, 447);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader2
            // 
            columnHeader2.Width = 200;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(694, 87);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 12;
            AddBtn.Text = "Добавить";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Лист_товаров;
            ClientSize = new Size(800, 600);
            Controls.Add(AddBtn);
            Controls.Add(listView);
            Controls.Add(MilkBtn);
            Controls.Add(DrinkBtn);
            Controls.Add(FlourBtn);
            Controls.Add(MeatBtn);
            Controls.Add(AlcBtn);
            Controls.Add(CandyBtn);
            Controls.Add(BakaleaBtn);
            Controls.Add(SeaBtn);
            Controls.Add(HalfProdBtn);
            Controls.Add(VegBtn);
            Controls.Add(FrutBtn);
            Controls.Add(CloseBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button CloseBtn;
        private Button FrutBtn;
        private Button VegBtn;
        private Button HalfProdBtn;
        private Button SeaBtn;
        private Button BakaleaBtn;
        private Button CandyBtn;
        private Button AlcBtn;
        private Button MeatBtn;
        private Button FlourBtn;
        private Button DrinkBtn;
        private Button MilkBtn;
        private ListView listView;
        private Button AddBtn;
        private ColumnHeader columnHeader2;
    }
}