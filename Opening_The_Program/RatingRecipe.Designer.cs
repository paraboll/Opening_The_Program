namespace Opening_The_Program
{
    partial class RatingRecipe
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_DifficultlyRecipe = new System.Windows.Forms.ComboBox();
            this.cb_Taste = new System.Windows.Forms.ComboBox();
            this.btn_Rating = new System.Windows.Forms.Button();
            this.btn_later = new System.Windows.Forms.Button();
            this.cb_TimeCooking = new System.Windows.Forms.ComboBox();
            this.lbl_TimeCooking = new System.Windows.Forms.Label();
            this.lbl_Taste = new System.Windows.Forms.Label();
            this.lbl_DifficultlyRecipe = new System.Windows.Forms.Label();
            this.labelRatingRecipe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_DifficultlyRecipe
            // 
            this.cb_DifficultlyRecipe.FormattingEnabled = true;
            this.cb_DifficultlyRecipe.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cb_DifficultlyRecipe.Location = new System.Drawing.Point(83, 43);
            this.cb_DifficultlyRecipe.Name = "cb_DifficultlyRecipe";
            this.cb_DifficultlyRecipe.Size = new System.Drawing.Size(100, 21);
            this.cb_DifficultlyRecipe.TabIndex = 28;
            // 
            // cb_Taste
            // 
            this.cb_Taste.FormattingEnabled = true;
            this.cb_Taste.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_Taste.Location = new System.Drawing.Point(83, 70);
            this.cb_Taste.Name = "cb_Taste";
            this.cb_Taste.Size = new System.Drawing.Size(100, 21);
            this.cb_Taste.TabIndex = 27;
            // 
            // btn_Rating
            // 
            this.btn_Rating.Location = new System.Drawing.Point(108, 132);
            this.btn_Rating.Name = "btn_Rating";
            this.btn_Rating.Size = new System.Drawing.Size(75, 42);
            this.btn_Rating.TabIndex = 26;
            this.btn_Rating.Text = "Оценить!";
            this.btn_Rating.UseVisualStyleBackColor = true;
            this.btn_Rating.Click += new System.EventHandler(this.btn_Rating_Click);
            // 
            // btn_later
            // 
            this.btn_later.Location = new System.Drawing.Point(18, 132);
            this.btn_later.Name = "btn_later";
            this.btn_later.Size = new System.Drawing.Size(75, 42);
            this.btn_later.TabIndex = 25;
            this.btn_later.Text = "Оценить посже";
            this.btn_later.UseVisualStyleBackColor = true;
            this.btn_later.Click += new System.EventHandler(this.btn_later_Click);
            // 
            // cb_TimeCooking
            // 
            this.cb_TimeCooking.FormattingEnabled = true;
            this.cb_TimeCooking.Items.AddRange(new object[] {
            "быстро",
            "средне",
            "долго"});
            this.cb_TimeCooking.Location = new System.Drawing.Point(83, 97);
            this.cb_TimeCooking.Name = "cb_TimeCooking";
            this.cb_TimeCooking.Size = new System.Drawing.Size(100, 21);
            this.cb_TimeCooking.TabIndex = 24;
            // 
            // lbl_TimeCooking
            // 
            this.lbl_TimeCooking.AutoSize = true;
            this.lbl_TimeCooking.Location = new System.Drawing.Point(31, 100);
            this.lbl_TimeCooking.Name = "lbl_TimeCooking";
            this.lbl_TimeCooking.Size = new System.Drawing.Size(40, 13);
            this.lbl_TimeCooking.TabIndex = 23;
            this.lbl_TimeCooking.Text = "Время";
            // 
            // lbl_Taste
            // 
            this.lbl_Taste.AutoSize = true;
            this.lbl_Taste.Location = new System.Drawing.Point(40, 73);
            this.lbl_Taste.Name = "lbl_Taste";
            this.lbl_Taste.Size = new System.Drawing.Size(31, 13);
            this.lbl_Taste.TabIndex = 22;
            this.lbl_Taste.Text = "Вкус";
            // 
            // lbl_DifficultlyRecipe
            // 
            this.lbl_DifficultlyRecipe.AutoSize = true;
            this.lbl_DifficultlyRecipe.Location = new System.Drawing.Point(15, 43);
            this.lbl_DifficultlyRecipe.Name = "lbl_DifficultlyRecipe";
            this.lbl_DifficultlyRecipe.Size = new System.Drawing.Size(63, 13);
            this.lbl_DifficultlyRecipe.TabIndex = 21;
            this.lbl_DifficultlyRecipe.Text = "Сложность";
            // 
            // labelRatingRecipe
            // 
            this.labelRatingRecipe.AutoSize = true;
            this.labelRatingRecipe.Location = new System.Drawing.Point(57, 20);
            this.labelRatingRecipe.Name = "labelRatingRecipe";
            this.labelRatingRecipe.Size = new System.Drawing.Size(89, 13);
            this.labelRatingRecipe.TabIndex = 20;
            this.labelRatingRecipe.Text = "Оцените Рецепт";
            // 
            // RatingRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_DifficultlyRecipe);
            this.Controls.Add(this.cb_Taste);
            this.Controls.Add(this.btn_Rating);
            this.Controls.Add(this.btn_later);
            this.Controls.Add(this.cb_TimeCooking);
            this.Controls.Add(this.lbl_TimeCooking);
            this.Controls.Add(this.lbl_Taste);
            this.Controls.Add(this.lbl_DifficultlyRecipe);
            this.Controls.Add(this.labelRatingRecipe);
            this.Name = "RatingRecipe";
            this.Size = new System.Drawing.Size(199, 194);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_DifficultlyRecipe;
        private System.Windows.Forms.ComboBox cb_Taste;
        private System.Windows.Forms.Button btn_Rating;
        private System.Windows.Forms.Button btn_later;
        private System.Windows.Forms.ComboBox cb_TimeCooking;
        private System.Windows.Forms.Label lbl_TimeCooking;
        private System.Windows.Forms.Label lbl_Taste;
        private System.Windows.Forms.Label lbl_DifficultlyRecipe;
        private System.Windows.Forms.Label labelRatingRecipe;
    }
}
