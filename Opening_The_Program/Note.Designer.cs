namespace Opening_The_Program
{
    partial class Note
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
            this.gb_Notes = new System.Windows.Forms.GroupBox();
            this.rtb_Notes = new System.Windows.Forms.RichTextBox();
            this.btn_SaveNote = new System.Windows.Forms.Button();
            this.gb_Notes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Notes
            // 
            this.gb_Notes.Controls.Add(this.rtb_Notes);
            this.gb_Notes.Controls.Add(this.btn_SaveNote);
            this.gb_Notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_Notes.Location = new System.Drawing.Point(0, 0);
            this.gb_Notes.Name = "gb_Notes";
            this.gb_Notes.Size = new System.Drawing.Size(800, 570);
            this.gb_Notes.TabIndex = 0;
            this.gb_Notes.TabStop = false;
            this.gb_Notes.Text = "Заметки";
            // 
            // rtb_Notes
            // 
            this.rtb_Notes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtb_Notes.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtb_Notes.Location = new System.Drawing.Point(3, 22);
            this.rtb_Notes.Name = "rtb_Notes";
            this.rtb_Notes.Size = new System.Drawing.Size(794, 502);
            this.rtb_Notes.TabIndex = 2;
            this.rtb_Notes.Text = "";
            // 
            // btn_SaveNote
            // 
            this.btn_SaveNote.Location = new System.Drawing.Point(653, 530);
            this.btn_SaveNote.Name = "btn_SaveNote";
            this.btn_SaveNote.Size = new System.Drawing.Size(141, 34);
            this.btn_SaveNote.TabIndex = 1;
            this.btn_SaveNote.Text = "Сохранить";
            this.btn_SaveNote.UseVisualStyleBackColor = true;
            this.btn_SaveNote.Click += new System.EventHandler(this.btn_SaveNote_Click);
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_Notes);
            this.Name = "Note";
            this.Size = new System.Drawing.Size(800, 570);
            this.gb_Notes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Notes;
        private System.Windows.Forms.Button btn_SaveNote;
        private System.Windows.Forms.RichTextBox rtb_Notes;
    }
}
