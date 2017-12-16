namespace BookCataloger
{
    partial class AdditionForm
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
            this.lbAdditionForm = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbPublishingHouse = new System.Windows.Forms.Label();
            this.lbAnnotation = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAdditionForm
            // 
            this.lbAdditionForm.AutoSize = true;
            this.lbAdditionForm.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbAdditionForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAdditionForm.Location = new System.Drawing.Point(12, 9);
            this.lbAdditionForm.Name = "lbAdditionForm";
            this.lbAdditionForm.Size = new System.Drawing.Size(451, 20);
            this.lbAdditionForm.TabIndex = 0;
            this.lbAdditionForm.Text = "Для добавления книги заполните следующие поля:";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAuthor.Location = new System.Drawing.Point(75, 62);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(57, 16);
            this.lbAuthor.TabIndex = 1;
            this.lbAuthor.Text = "Автор:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(46, 88);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(86, 16);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Название:";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbYear.Location = new System.Drawing.Point(28, 114);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(104, 16);
            this.lbYear.TabIndex = 3;
            this.lbYear.Text = "Год издания:";
            // 
            // lbPublishingHouse
            // 
            this.lbPublishingHouse.AutoSize = true;
            this.lbPublishingHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPublishingHouse.Location = new System.Drawing.Point(14, 140);
            this.lbPublishingHouse.Name = "lbPublishingHouse";
            this.lbPublishingHouse.Size = new System.Drawing.Size(118, 16);
            this.lbPublishingHouse.TabIndex = 4;
            this.lbPublishingHouse.Text = "Издательство:";
            // 
            // lbAnnotation
            // 
            this.lbAnnotation.AutoSize = true;
            this.lbAnnotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAnnotation.Location = new System.Drawing.Point(40, 166);
            this.lbAnnotation.Name = "lbAnnotation";
            this.lbAnnotation.Size = new System.Drawing.Size(92, 16);
            this.lbAnnotation.TabIndex = 5;
            this.lbAnnotation.Text = "Аннотация:";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCategory.Location = new System.Drawing.Point(43, 193);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(89, 16);
            this.lbCategory.TabIndex = 6;
            this.lbCategory.Text = "Категория:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Художественная литература",
            "Научная литература",
            "Учебная литература",
            "Другое"});
            this.comboBox1.Location = new System.Drawing.Point(138, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(230, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(138, 136);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(230, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(138, 162);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(230, 20);
            this.textBox5.TabIndex = 12;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(17, 234);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(125, 40);
            this.butAdd.TabIndex = 13;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(175, 234);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(125, 40);
            this.butBack.TabIndex = 14;
            this.butBack.Text = "Вернуться";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(338, 234);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(125, 40);
            this.butExit.TabIndex = 15;
            this.butExit.Text = "Выход";
            this.butExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // AdditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(484, 295);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbAnnotation);
            this.Controls.Add(this.lbPublishingHouse);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbAdditionForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdditionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdditionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAdditionForm;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbPublishingHouse;
        private System.Windows.Forms.Label lbAnnotation;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butExit;
    }
}