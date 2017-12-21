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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionForm));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAdditionForm
            // 
            this.lbAdditionForm.AutoSize = true;
            this.lbAdditionForm.BackColor = System.Drawing.Color.Black;
            this.lbAdditionForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAdditionForm.ForeColor = System.Drawing.Color.DarkGray;
            this.lbAdditionForm.Location = new System.Drawing.Point(32, 18);
            this.lbAdditionForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAdditionForm.Name = "lbAdditionForm";
            this.lbAdditionForm.Size = new System.Drawing.Size(543, 25);
            this.lbAdditionForm.TabIndex = 0;
            this.lbAdditionForm.Text = "Для добавления книги заполните следующие поля:";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAuthor.Location = new System.Drawing.Point(100, 76);
            this.lbAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(72, 20);
            this.lbAuthor.TabIndex = 1;
            this.lbAuthor.Text = "Автор:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(61, 108);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(105, 20);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Название:";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbYear.Location = new System.Drawing.Point(37, 140);
            this.lbYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(134, 20);
            this.lbYear.TabIndex = 3;
            this.lbYear.Text = "Год издания:";
            // 
            // lbPublishingHouse
            // 
            this.lbPublishingHouse.AutoSize = true;
            this.lbPublishingHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPublishingHouse.Location = new System.Drawing.Point(19, 172);
            this.lbPublishingHouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPublishingHouse.Name = "lbPublishingHouse";
            this.lbPublishingHouse.Size = new System.Drawing.Size(148, 20);
            this.lbPublishingHouse.TabIndex = 4;
            this.lbPublishingHouse.Text = "Издательство:";
            // 
            // lbAnnotation
            // 
            this.lbAnnotation.AutoSize = true;
            this.lbAnnotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAnnotation.Location = new System.Drawing.Point(53, 204);
            this.lbAnnotation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAnnotation.Name = "lbAnnotation";
            this.lbAnnotation.Size = new System.Drawing.Size(116, 20);
            this.lbAnnotation.TabIndex = 5;
            this.lbAnnotation.Text = "Аннотация:";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCategory.Location = new System.Drawing.Point(57, 238);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(113, 20);
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
            "Учебная литература"});
            this.comboBox1.Location = new System.Drawing.Point(184, 231);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(278, 25);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 71);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 103);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(278, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(184, 135);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(278, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(184, 167);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(278, 22);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(184, 199);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(278, 22);
            this.textBox5.TabIndex = 12;
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.Black;
            this.butAdd.ForeColor = System.Drawing.Color.DarkGray;
            this.butAdd.Location = new System.Drawing.Point(23, 288);
            this.butAdd.Margin = new System.Windows.Forms.Padding(4);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(167, 49);
            this.butAdd.TabIndex = 13;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butBack
            // 
            this.butBack.BackColor = System.Drawing.Color.Black;
            this.butBack.ForeColor = System.Drawing.Color.DarkGray;
            this.butBack.Location = new System.Drawing.Point(233, 288);
            this.butBack.Margin = new System.Windows.Forms.Padding(4);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(167, 49);
            this.butBack.TabIndex = 14;
            this.butBack.Text = "Вернуться";
            this.butBack.UseVisualStyleBackColor = false;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.Black;
            this.butExit.ForeColor = System.Drawing.Color.DarkGray;
            this.butExit.Location = new System.Drawing.Point(451, 288);
            this.butExit.Margin = new System.Windows.Forms.Padding(4);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(167, 49);
            this.butExit.TabIndex = 15;
            this.butExit.Text = "Выход";
            this.butExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbAdditionForm);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 60);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(469, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // AdditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(645, 363);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdditionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdditionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}