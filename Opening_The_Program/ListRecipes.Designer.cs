﻿namespace Opening_The_Program
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
            this.tb_SearchResipe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_rtbController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingridTable)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.rtb_TitleRecipe.Location = new System.Drawing.Point(15, 7);
            this.rtb_TitleRecipe.Name = "rtb_TitleRecipe";
            this.rtb_TitleRecipe.ReadOnly = true;
            this.rtb_TitleRecipe.Size = new System.Drawing.Size(529, 29);
            this.rtb_TitleRecipe.TabIndex = 0;
            this.rtb_TitleRecipe.Text = "";
            // 
            // dgv_ingridTable
            // 
            this.dgv_ingridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ingridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_ingridTable.Location = new System.Drawing.Point(200, 50);
            this.dgv_ingridTable.Name = "dgv_ingridTable";
            this.dgv_ingridTable.ReadOnly = true;
            this.dgv_ingridTable.RowHeadersVisible = false;
            this.dgv_ingridTable.RowHeadersWidth = 55;
            this.dgv_ingridTable.Size = new System.Drawing.Size(300, 417);
            this.dgv_ingridTable.TabIndex = 2;
            this.dgv_ingridTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ingridTable_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ингридиенты";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Кол-во";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // rtb_DescriptionRecipe
            // 
            this.rtb_DescriptionRecipe.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtb_DescriptionRecipe.Location = new System.Drawing.Point(500, 50);
            this.rtb_DescriptionRecipe.Name = "rtb_DescriptionRecipe";
            this.rtb_DescriptionRecipe.Size = new System.Drawing.Size(300, 520);
            this.rtb_DescriptionRecipe.TabIndex = 3;
            this.rtb_DescriptionRecipe.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.tb_SearchResipe);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(200, 464);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 106);
            this.panel2.TabIndex = 4;
            // 
            // tb_SearchResipe
            // 
            this.tb_SearchResipe.Location = new System.Drawing.Point(7, 23);
            this.tb_SearchResipe.Name = "tb_SearchResipe";
            this.tb_SearchResipe.Size = new System.Drawing.Size(100, 20);
            this.tb_SearchResipe.TabIndex = 1;
            this.tb_SearchResipe.TextChanged += new System.EventHandler(this.tb_SearchResipe_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Строка поиска";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить этот рецепт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.Button button1;
    }
}
