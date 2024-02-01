namespace mainWindow
{
    partial class Tovar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tovar));
            Tovarlabel = new Label();
            nameTovar = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            Escape = new Button();
            DescriptionTovar = new RichTextBox();
            button1 = new Button();
            Ostalos = new Label();
            Kolvo = new Label();
            Count_weight = new Label();
            Minus = new Button();
            Plus = new Button();
            priceTxt = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            Change_avatar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Tovarlabel
            // 
            Tovarlabel.AutoSize = true;
            Tovarlabel.BackColor = Color.Transparent;
            Tovarlabel.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point);
            Tovarlabel.Location = new Point(322, 10);
            Tovarlabel.Margin = new Padding(4, 0, 4, 0);
            Tovarlabel.Name = "Tovarlabel";
            Tovarlabel.Size = new Size(213, 73);
            Tovarlabel.TabIndex = 0;
            Tovarlabel.Text = "Товар";
            Tovarlabel.Click += Tovarlabel_Click;
            // 
            // nameTovar
            // 
            nameTovar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nameTovar.Location = new Point(368, 105);
            nameTovar.Margin = new Padding(4, 3, 4, 3);
            nameTovar.Name = "nameTovar";
            nameTovar.Size = new Size(524, 43);
            nameTovar.TabIndex = 1;
            nameTovar.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(360, 181);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 31);
            label1.TabIndex = 2;
            label1.Text = "Цена:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(542, 181);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 31);
            label2.TabIndex = 3;
            label2.Text = "руб.";
            // 
            // Escape
            // 
            Escape.AutoSize = true;
            Escape.BackColor = Color.Red;
            Escape.FlatStyle = FlatStyle.Flat;
            Escape.Location = new Point(903, -1);
            Escape.Margin = new Padding(4, 3, 4, 3);
            Escape.Name = "Escape";
            Escape.Size = new Size(30, 29);
            Escape.TabIndex = 5;
            Escape.Text = "X";
            Escape.UseVisualStyleBackColor = false;
            Escape.Click += Escape_Click;
            // 
            // DescriptionTovar
            // 
            DescriptionTovar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionTovar.Location = new Point(368, 240);
            DescriptionTovar.Margin = new Padding(4, 3, 4, 3);
            DescriptionTovar.Name = "DescriptionTovar";
            DescriptionTovar.Size = new Size(524, 226);
            DescriptionTovar.TabIndex = 7;
            DescriptionTovar.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(385, 646);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(169, 32);
            button1.TabIndex = 8;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += NewTovar_click;
            // 
            // Ostalos
            // 
            Ostalos.AutoSize = true;
            Ostalos.BackColor = Color.Transparent;
            Ostalos.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Ostalos.Location = new Point(47, 488);
            Ostalos.Margin = new Padding(4, 0, 4, 0);
            Ostalos.Name = "Ostalos";
            Ostalos.Size = new Size(113, 25);
            Ostalos.TabIndex = 9;
            Ostalos.Text = "Осталось:";
            // 
            // Kolvo
            // 
            Kolvo.AutoSize = true;
            Kolvo.BackColor = Color.Transparent;
            Kolvo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Kolvo.Location = new Point(42, 524);
            Kolvo.Margin = new Padding(4, 0, 4, 0);
            Kolvo.Name = "Kolvo";
            Kolvo.Size = new Size(60, 25);
            Kolvo.TabIndex = 10;
            Kolvo.Text = "1000";
            // 
            // Count_weight
            // 
            Count_weight.AutoSize = true;
            Count_weight.BackColor = Color.Transparent;
            Count_weight.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Count_weight.Location = new Point(110, 524);
            Count_weight.Margin = new Padding(4, 0, 4, 0);
            Count_weight.Name = "Count_weight";
            Count_weight.Size = new Size(70, 25);
            Count_weight.TabIndex = 11;
            Count_weight.Text = "шт./кг";
            // 
            // Minus
            // 
            Minus.AutoSize = true;
            Minus.BackColor = SystemColors.ActiveBorder;
            Minus.FlatStyle = FlatStyle.Flat;
            Minus.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Minus.Location = new Point(6, 516);
            Minus.Margin = new Padding(4, 3, 4, 3);
            Minus.Name = "Minus";
            Minus.Size = new Size(37, 43);
            Minus.TabIndex = 12;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = false;
            // 
            // Plus
            // 
            Plus.AutoSize = true;
            Plus.BackColor = SystemColors.ActiveBorder;
            Plus.FlatStyle = FlatStyle.Flat;
            Plus.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Plus.Location = new Point(191, 517);
            Plus.Margin = new Padding(4, 3, 4, 3);
            Plus.Name = "Plus";
            Plus.Size = new Size(43, 43);
            Plus.TabIndex = 13;
            Plus.Text = "+";
            Plus.UseVisualStyleBackColor = false;
            // 
            // priceTxt
            // 
            priceTxt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            priceTxt.Location = new Point(454, 184);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(77, 32);
            priceTxt.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Change_avatar
            // 
            Change_avatar.BackColor = Color.Silver;
            Change_avatar.FlatStyle = FlatStyle.Flat;
            Change_avatar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Change_avatar.Location = new Point(14, 426);
            Change_avatar.Margin = new Padding(4, 3, 4, 3);
            Change_avatar.Name = "Change_avatar";
            Change_avatar.Size = new Size(321, 40);
            Change_avatar.TabIndex = 6;
            Change_avatar.Text = "Изменить аватар";
            Change_avatar.UseVisualStyleBackColor = false;
            Change_avatar.Click += Change_avatar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(24, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 290);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Tovar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(933, 692);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(priceTxt);
            Controls.Add(Plus);
            Controls.Add(Minus);
            Controls.Add(Count_weight);
            Controls.Add(Kolvo);
            Controls.Add(Ostalos);
            Controls.Add(button1);
            Controls.Add(DescriptionTovar);
            Controls.Add(Change_avatar);
            Controls.Add(Escape);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameTovar);
            Controls.Add(Tovarlabel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Tovar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tovar";
            Load += Tovar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tovarlabel;
        private RichTextBox nameTovar;
        private Label label1;
        private Label label2;
        private Button Escape;
        private RichTextBox DescriptionTovar;
        private Button button1;
        private Label Ostalos;
        private Label Kolvo;
        private Label Count_weight;
        private Button Minus;
        private Button Plus;
        private TextBox priceTxt;
        private OpenFileDialog openFileDialog1;
        private Button Change_avatar;
        private PictureBox pictureBox1;
    }
}

