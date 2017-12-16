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
            this.lbWelcome = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.butView = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.pnView = new System.Windows.Forms.Panel();
            this.butExit = new System.Windows.Forms.Button();
            this.pnView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.BackColor = System.Drawing.Color.Black;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWelcome.ForeColor = System.Drawing.Color.Silver;
            this.lbWelcome.Location = new System.Drawing.Point(12, 19);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(450, 24);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "Приветствуем вас в нашем каталогизаторе!";
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.Black;
            this.butAdd.ForeColor = System.Drawing.Color.Silver;
            this.butAdd.Location = new System.Drawing.Point(125, 26);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(224, 56);
            this.butAdd.TabIndex = 1;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butView
            // 
            this.butView.BackColor = System.Drawing.Color.Black;
            this.butView.ForeColor = System.Drawing.Color.Silver;
            this.butView.Location = new System.Drawing.Point(125, 99);
            this.butView.Name = "butView";
            this.butView.Size = new System.Drawing.Size(224, 56);
            this.butView.TabIndex = 2;
            this.butView.Text = "Просмотр/ Удаление/Редактирование";
            this.butView.UseVisualStyleBackColor = false;
            this.butView.Click += new System.EventHandler(this.butView_Click);
            // 
            // butSearch
            // 
            this.butSearch.BackColor = System.Drawing.Color.Black;
            this.butSearch.ForeColor = System.Drawing.Color.Silver;
            this.butSearch.Location = new System.Drawing.Point(125, 170);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(224, 56);
            this.butSearch.TabIndex = 4;
            this.butSearch.Text = "Поиск";
            this.butSearch.UseVisualStyleBackColor = false;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // pnView
            // 
            this.pnView.BackColor = System.Drawing.Color.DarkGray;
            this.pnView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnView.Controls.Add(this.butExit);
            this.pnView.Controls.Add(this.butSearch);
            this.pnView.Controls.Add(this.butView);
            this.pnView.Controls.Add(this.butAdd);
            this.pnView.Location = new System.Drawing.Point(3, 59);
            this.pnView.Name = "pnView";
            this.pnView.Size = new System.Drawing.Size(474, 296);
            this.pnView.TabIndex = 5;
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.Black;
            this.butExit.ForeColor = System.Drawing.Color.Silver;
            this.butExit.Location = new System.Drawing.Point(384, 263);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(83, 26);
            this.butExit.TabIndex = 6;
            this.butExit.Text = "Выход";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // Greeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.pnView);
            this.Controls.Add(this.lbWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Greeting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталогизатор книг";
            this.Load += new System.EventHandler(this.Greeting_Load);
            this.pnView.ResumeLayout(false);
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
    }
}

