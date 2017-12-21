namespace BookCataloger
{
    partial class Greeting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Greeting));
            this.lbWelcome = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.butView = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.pnView = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butExit = new System.Windows.Forms.Button();
            this.pnView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.BackColor = System.Drawing.Color.Black;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWelcome.ForeColor = System.Drawing.Color.Silver;
            this.lbWelcome.Location = new System.Drawing.Point(35, 25);
            this.lbWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(564, 29);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "Приветствуем вас в нашем каталогизаторе!";
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.Black;
            this.butAdd.ForeColor = System.Drawing.Color.Silver;
            this.butAdd.Location = new System.Drawing.Point(167, 95);
            this.butAdd.Margin = new System.Windows.Forms.Padding(4);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(299, 69);
            this.butAdd.TabIndex = 1;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butView
            // 
            this.butView.BackColor = System.Drawing.Color.Black;
            this.butView.ForeColor = System.Drawing.Color.Silver;
            this.butView.Location = new System.Drawing.Point(167, 186);
            this.butView.Margin = new System.Windows.Forms.Padding(4);
            this.butView.Name = "butView";
            this.butView.Size = new System.Drawing.Size(299, 69);
            this.butView.TabIndex = 2;
            this.butView.Text = "Просмотр/ Удаление/Редактирование";
            this.butView.UseVisualStyleBackColor = false;
            this.butView.Click += new System.EventHandler(this.butView_Click);
            // 
            // butSearch
            // 
            this.butSearch.BackColor = System.Drawing.Color.Black;
            this.butSearch.ForeColor = System.Drawing.Color.Silver;
            this.butSearch.Location = new System.Drawing.Point(167, 278);
            this.butSearch.Margin = new System.Windows.Forms.Padding(4);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(299, 69);
            this.butSearch.TabIndex = 4;
            this.butSearch.Text = "Поиск";
            this.butSearch.UseVisualStyleBackColor = false;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // pnView
            // 
            this.pnView.BackColor = System.Drawing.Color.DarkGray;
            this.pnView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnView.Controls.Add(this.pictureBox1);
            this.pnView.Controls.Add(this.butExit);
            this.pnView.Controls.Add(this.butSearch);
            this.pnView.Controls.Add(this.butView);
            this.pnView.Controls.Add(this.butAdd);
            this.pnView.Location = new System.Drawing.Point(0, 58);
            this.pnView.Margin = new System.Windows.Forms.Padding(4);
            this.pnView.Name = "pnView";
            this.pnView.Size = new System.Drawing.Size(639, 380);
            this.pnView.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 78);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.Black;
            this.butExit.ForeColor = System.Drawing.Color.Silver;
            this.butExit.Location = new System.Drawing.Point(512, 324);
            this.butExit.Margin = new System.Windows.Forms.Padding(4);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(111, 32);
            this.butExit.TabIndex = 6;
            this.butExit.Text = "Выход";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // Greeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(640, 439);
            this.Controls.Add(this.pnView);
            this.Controls.Add(this.lbWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Greeting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталогизатор книг";
            this.Load += new System.EventHandler(this.Greeting_Load);
            this.pnView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butView;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Panel pnView;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

