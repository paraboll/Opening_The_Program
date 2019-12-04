using System.Drawing;
using System.Windows.Forms;

namespace Opening_The_Program
{
    partial class ListRecipes
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
            this.panel_ListRecipe = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_rtbController = new System.Windows.Forms.Panel();
            this.rtb_TitleRecipe = new System.Windows.Forms.RichTextBox();
            this.dgv_ingridTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtb_DescriptionRecipe = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_AssessRecipe = new System.Windows.Forms.Button();
            this.btn_DeleteRecipe = new System.Windows.Forms.Button();
            this.tb_SearchResipe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_RaitingRecipe = new System.Windows.Forms.Panel();
            this.cb_DifficultlyRecipe = new System.Windows.Forms.ComboBox();
            this.cb_Taste = new System.Windows.Forms.ComboBox();
            this.btn_Rating = new System.Windows.Forms.Button();
            this.btn_later = new System.Windows.Forms.Button();
            this.cb_TimeCooking = new System.Windows.Forms.ComboBox();
            this.lbl_TimeCooking = new System.Windows.Forms.Label();
            this.lbl_Taste = new System.Windows.Forms.Label();
            this.lbl_DifficultlyRecipe = new System.Windows.Forms.Label();
            this.labelRatingRecipe = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_rtbController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingridTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_RaitingRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ListRecipe
            // 
            this.panel_ListRecipe.AutoScroll = true;
            this.panel_ListRecipe.BackColor = System.Drawing.Color.Silver;
            this.panel_ListRecipe.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ListRecipe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_ListRecipe.Location = new System.Drawing.Point(0, 0);
            this.panel_ListRecipe.Name = "panel_ListRecipe";
            this.panel_ListRecipe.Size = new System.Drawing.Size(200, 570);
            this.panel_ListRecipe.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.panel_rtbController);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 50);
            this.panel1.TabIndex = 1;
            // 
            // panel_rtbController
            // 
            this.panel_rtbController.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_rtbController.Controls.Add(this.rtb_TitleRecipe);
            this.panel_rtbController.Location = new System.Drawing.Point(21, 3);
            this.panel_rtbController.Name = "panel_rtbController";
            this.panel_rtbController.Padding = new System.Windows.Forms.Padding(15, 7, 15, 5);
            this.panel_rtbController.Size = new System.Drawing.Size(559, 41);
            this.panel_rtbController.TabIndex = 0;
            // 
            // rtb_TitleRecipe
            // 
            this.rtb_TitleRecipe.BackColor = System.Drawing.Color.White;
            this.rtb_TitleRecipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_TitleRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_TitleRecipe.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_TitleRecipe.Location = new System.Drawing.Point(15, 7);
            this.rtb_TitleRecipe.Name = "rtb_TitleRecipe";
            this.rtb_TitleRecipe.ReadOnly = true;
            this.rtb_TitleRecipe.Size = new System.Drawing.Size(529, 29);
            this.rtb_TitleRecipe.TabIndex = 0;
            this.rtb_TitleRecipe.Text = "";
            this.rtb_TitleRecipe.SelectionAlignment = HorizontalAlignment.Center;
            // 
            // dgv_ingridTable
            // 
            this.dgv_ingridTable.AllowUserToResizeColumns = false;
            this.dgv_ingridTable.AllowUserToResizeRows = false;
            this.dgv_ingridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ingridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_ingridTable.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_ingridTable.Location = new System.Drawing.Point(200, 50);
            this.dgv_ingridTable.Name = "dgv_ingridTable";
            this.dgv_ingridTable.ReadOnly = true;
            this.dgv_ingridTable.RowHeadersVisible = false;
            this.dgv_ingridTable.RowHeadersWidth = 55;
            this.dgv_ingridTable.Size = new System.Drawing.Size(250, 420);
            this.dgv_ingridTable.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ингридиенты";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Кол-во";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // rtb_DescriptionRecipe
            // 
            this.rtb_DescriptionRecipe.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtb_DescriptionRecipe.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_DescriptionRecipe.Location = new System.Drawing.Point(448, 50);
            this.rtb_DescriptionRecipe.Name = "rtb_DescriptionRecipe";
            this.rtb_DescriptionRecipe.Size = new System.Drawing.Size(352, 520);
            this.rtb_DescriptionRecipe.TabIndex = 3;
            this.rtb_DescriptionRecipe.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_AssessRecipe);
            this.panel2.Controls.Add(this.btn_DeleteRecipe);
            this.panel2.Controls.Add(this.tb_SearchResipe);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(200, 469);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 101);
            this.panel2.TabIndex = 4;
            // 
            // btn_AssessRecipe
            // 
            this.btn_AssessRecipe.Location = new System.Drawing.Point(9, 54);
            this.btn_AssessRecipe.Name = "btn_AssessRecipe";
            this.btn_AssessRecipe.Size = new System.Drawing.Size(117, 44);
            this.btn_AssessRecipe.TabIndex = 3;
            this.btn_AssessRecipe.Text = "Оценить Рецепт";
            this.btn_AssessRecipe.UseVisualStyleBackColor = true;
            this.btn_AssessRecipe.Click += new System.EventHandler(this.btn_AssessRecipe_Click);
            // 
            // btn_DeleteRecipe
            // 
            this.btn_DeleteRecipe.Location = new System.Drawing.Point(132, 54);
            this.btn_DeleteRecipe.Name = "btn_DeleteRecipe";
            this.btn_DeleteRecipe.Size = new System.Drawing.Size(113, 44);
            this.btn_DeleteRecipe.TabIndex = 2;
            this.btn_DeleteRecipe.Text = "Удалить этот рецепт";
            this.btn_DeleteRecipe.UseVisualStyleBackColor = true;
            this.btn_DeleteRecipe.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_SearchResipe
            // 
            this.tb_SearchResipe.Location = new System.Drawing.Point(6, 22);
            this.tb_SearchResipe.Name = "tb_SearchResipe";
            this.tb_SearchResipe.Size = new System.Drawing.Size(100, 20);
            this.tb_SearchResipe.TabIndex = 1;
            this.tb_SearchResipe.TextChanged += new System.EventHandler(this.tb_SearchResipe_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Строка поиска";
            // 
            // panel_RaitingRecipe
            // 
            this.panel_RaitingRecipe.Controls.Add(this.cb_DifficultlyRecipe);
            this.panel_RaitingRecipe.Controls.Add(this.cb_Taste);
            this.panel_RaitingRecipe.Controls.Add(this.btn_Rating);
            this.panel_RaitingRecipe.Controls.Add(this.btn_later);
            this.panel_RaitingRecipe.Controls.Add(this.cb_TimeCooking);
            this.panel_RaitingRecipe.Controls.Add(this.lbl_TimeCooking);
            this.panel_RaitingRecipe.Controls.Add(this.lbl_Taste);
            this.panel_RaitingRecipe.Controls.Add(this.lbl_DifficultlyRecipe);
            this.panel_RaitingRecipe.Controls.Add(this.labelRatingRecipe);
            this.panel_RaitingRecipe.Location = new System.Drawing.Point(206, 345);
            this.panel_RaitingRecipe.Name = "panel_RaitingRecipe";
            this.panel_RaitingRecipe.Size = new System.Drawing.Size(200, 166);
            this.panel_RaitingRecipe.TabIndex = 5;
            this.panel_RaitingRecipe.Visible = false;
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
            this.cb_DifficultlyRecipe.Location = new System.Drawing.Point(84, 29);
            this.cb_DifficultlyRecipe.Name = "cb_DifficultlyRecipe";
            this.cb_DifficultlyRecipe.Size = new System.Drawing.Size(100, 21);
            this.cb_DifficultlyRecipe.TabIndex = 37;
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
            this.cb_Taste.Location = new System.Drawing.Point(84, 56);
            this.cb_Taste.Name = "cb_Taste";
            this.cb_Taste.Size = new System.Drawing.Size(100, 21);
            this.cb_Taste.TabIndex = 36;
            // 
            // btn_Rating
            // 
            this.btn_Rating.Location = new System.Drawing.Point(109, 118);
            this.btn_Rating.Name = "btn_Rating";
            this.btn_Rating.Size = new System.Drawing.Size(75, 42);
            this.btn_Rating.TabIndex = 35;
            this.btn_Rating.Text = "Оценить!";
            this.btn_Rating.UseVisualStyleBackColor = true;
            this.btn_Rating.Click += new System.EventHandler(this.btn_Rating_Click);
            // 
            // btn_later
            // 
            this.btn_later.Location = new System.Drawing.Point(19, 118);
            this.btn_later.Name = "btn_later";
            this.btn_later.Size = new System.Drawing.Size(75, 42);
            this.btn_later.TabIndex = 34;
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
            this.cb_TimeCooking.Location = new System.Drawing.Point(84, 83);
            this.cb_TimeCooking.Name = "cb_TimeCooking";
            this.cb_TimeCooking.Size = new System.Drawing.Size(100, 21);
            this.cb_TimeCooking.TabIndex = 33;
            // 
            // lbl_TimeCooking
            // 
            this.lbl_TimeCooking.AutoSize = true;
            this.lbl_TimeCooking.Location = new System.Drawing.Point(32, 86);
            this.lbl_TimeCooking.Name = "lbl_TimeCooking";
            this.lbl_TimeCooking.Size = new System.Drawing.Size(40, 13);
            this.lbl_TimeCooking.TabIndex = 32;
            this.lbl_TimeCooking.Text = "Время";
            // 
            // lbl_Taste
            // 
            this.lbl_Taste.AutoSize = true;
            this.lbl_Taste.Location = new System.Drawing.Point(41, 59);
            this.lbl_Taste.Name = "lbl_Taste";
            this.lbl_Taste.Size = new System.Drawing.Size(31, 13);
            this.lbl_Taste.TabIndex = 31;
            this.lbl_Taste.Text = "Вкус";
            // 
            // lbl_DifficultlyRecipe
            // 
            this.lbl_DifficultlyRecipe.AutoSize = true;
            this.lbl_DifficultlyRecipe.Location = new System.Drawing.Point(16, 29);
            this.lbl_DifficultlyRecipe.Name = "lbl_DifficultlyRecipe";
            this.lbl_DifficultlyRecipe.Size = new System.Drawing.Size(63, 13);
            this.lbl_DifficultlyRecipe.TabIndex = 30;
            this.lbl_DifficultlyRecipe.Text = "Сложность";
            // 
            // labelRatingRecipe
            // 
            this.labelRatingRecipe.AutoSize = true;
            this.labelRatingRecipe.Location = new System.Drawing.Point(58, 6);
            this.labelRatingRecipe.Name = "labelRatingRecipe";
            this.labelRatingRecipe.Size = new System.Drawing.Size(89, 13);
            this.labelRatingRecipe.TabIndex = 29;
            this.labelRatingRecipe.Text = "Оцените Рецепт";
            // 
            // ListRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_RaitingRecipe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rtb_DescriptionRecipe);
            this.Controls.Add(this.dgv_ingridTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_ListRecipe);
            this.Name = "ListRecipes";
            this.Size = new System.Drawing.Size(800, 570);
            this.panel1.ResumeLayout(false);
            this.panel_rtbController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingridTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_RaitingRecipe.ResumeLayout(false);
            this.panel_RaitingRecipe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ListRecipe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_ingridTable;
        private System.Windows.Forms.RichTextBox rtb_DescriptionRecipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel panel_rtbController;
        private System.Windows.Forms.RichTextBox rtb_TitleRecipe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_SearchResipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DeleteRecipe;
        private Button btn_AssessRecipe;
        private Panel panel_RaitingRecipe;
        private ComboBox cb_DifficultlyRecipe;
        private ComboBox cb_Taste;
        private Button btn_Rating;
        private Button btn_later;
        private ComboBox cb_TimeCooking;
        private Label lbl_TimeCooking;
        private Label lbl_Taste;
        private Label lbl_DifficultlyRecipe;
        private Label labelRatingRecipe;
    }
}
