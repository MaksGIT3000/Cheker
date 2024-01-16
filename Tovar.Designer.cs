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
            this.Tovarlabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Photo = new System.Windows.Forms.Label();
            this.Escape = new System.Windows.Forms.Button();
            this.Change_avatar = new System.Windows.Forms.Button();
            this.Description_tovar = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Ostalos = new System.Windows.Forms.Label();
            this.Kolvo = new System.Windows.Forms.Label();
            this.Count_weight = new System.Windows.Forms.Label();
            this.Minus = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tovarlabel
            // 
            this.Tovarlabel.AutoSize = true;
            this.Tovarlabel.BackColor = System.Drawing.Color.Transparent;
            this.Tovarlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tovarlabel.Location = new System.Drawing.Point(276, 9);
            this.Tovarlabel.Name = "Tovarlabel";
            this.Tovarlabel.Size = new System.Drawing.Size(213, 73);
            this.Tovarlabel.TabIndex = 0;
            this.Tovarlabel.Text = "Товар";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(315, 91);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(450, 38);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Название товара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(309, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Цена:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(465, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "руб.";
            // 
            // Photo
            // 
            this.Photo.Location = new System.Drawing.Point(12, 91);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(275, 275);
            this.Photo.TabIndex = 4;
            // 
            // Escape
            // 
            this.Escape.AutoSize = true;
            this.Escape.BackColor = System.Drawing.Color.Red;
            this.Escape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Escape.Location = new System.Drawing.Point(764, 9);
            this.Escape.Name = "Escape";
            this.Escape.Size = new System.Drawing.Size(26, 25);
            this.Escape.TabIndex = 5;
            this.Escape.Text = "X";
            this.Escape.UseVisualStyleBackColor = false;
            // 
            // Change_avatar
            // 
            this.Change_avatar.BackColor = System.Drawing.Color.Silver;
            this.Change_avatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_avatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change_avatar.Location = new System.Drawing.Point(12, 369);
            this.Change_avatar.Name = "Change_avatar";
            this.Change_avatar.Size = new System.Drawing.Size(275, 35);
            this.Change_avatar.TabIndex = 6;
            this.Change_avatar.Text = "Изменить аватар";
            this.Change_avatar.UseVisualStyleBackColor = false;
            // 
            // Description_tovar
            // 
            this.Description_tovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description_tovar.Location = new System.Drawing.Point(315, 208);
            this.Description_tovar.Name = "Description_tovar";
            this.Description_tovar.Size = new System.Drawing.Size(450, 196);
            this.Description_tovar.TabIndex = 7;
            this.Description_tovar.Text = "Описание товара";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(330, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Ostalos
            // 
            this.Ostalos.AutoSize = true;
            this.Ostalos.BackColor = System.Drawing.Color.Transparent;
            this.Ostalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ostalos.Location = new System.Drawing.Point(40, 423);
            this.Ostalos.Name = "Ostalos";
            this.Ostalos.Size = new System.Drawing.Size(113, 25);
            this.Ostalos.TabIndex = 9;
            this.Ostalos.Text = "Осталось:";
            // 
            // Kolvo
            // 
            this.Kolvo.AutoSize = true;
            this.Kolvo.BackColor = System.Drawing.Color.Transparent;
            this.Kolvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kolvo.Location = new System.Drawing.Point(36, 454);
            this.Kolvo.Name = "Kolvo";
            this.Kolvo.Size = new System.Drawing.Size(60, 25);
            this.Kolvo.TabIndex = 10;
            this.Kolvo.Text = "1000";
            // 
            // Count_weight
            // 
            this.Count_weight.AutoSize = true;
            this.Count_weight.BackColor = System.Drawing.Color.Transparent;
            this.Count_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count_weight.Location = new System.Drawing.Point(94, 454);
            this.Count_weight.Name = "Count_weight";
            this.Count_weight.Size = new System.Drawing.Size(70, 25);
            this.Count_weight.TabIndex = 11;
            this.Count_weight.Text = "шт./кг";
            // 
            // Minus
            // 
            this.Minus.AutoSize = true;
            this.Minus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minus.Location = new System.Drawing.Point(5, 447);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(32, 37);
            this.Minus.TabIndex = 12;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            // 
            // Plus
            // 
            this.Plus.AutoSize = true;
            this.Plus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plus.Location = new System.Drawing.Point(164, 448);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(37, 37);
            this.Plus.TabIndex = 13;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            // 
            // Tovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Count_weight);
            this.Controls.Add(this.Kolvo);
            this.Controls.Add(this.Ostalos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Description_tovar);
            this.Controls.Add(this.Change_avatar);
            this.Controls.Add(this.Escape);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Tovarlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tovar";
            this.Text = "Tovar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tovarlabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Photo;
        private System.Windows.Forms.Button Escape;
        private System.Windows.Forms.Button Change_avatar;
        private System.Windows.Forms.RichTextBox Description_tovar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Ostalos;
        private System.Windows.Forms.Label Kolvo;
        private System.Windows.Forms.Label Count_weight;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Plus;
    }
}

