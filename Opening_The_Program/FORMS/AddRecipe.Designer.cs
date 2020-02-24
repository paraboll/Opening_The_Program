namespace Opening_The_Program
{
    partial class Panel_AddRecipe
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TitleRecipe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_NameIngrid = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_CountIngrid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AddIngrid = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_EditRecipe = new System.Windows.Forms.Button();
            this.btn_DeleteRecipe = new System.Windows.Forms.Button();
            this.tb_countIngr = new System.Windows.Forms.TextBox();
            this.tb_nameIngr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_NameIngr = new System.Windows.Forms.ComboBox();
            this.rtb_DescriptionRecie = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_SaveRecipe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя рецепта";
            // 
            // tb_TitleRecipe
            // 
            this.tb_TitleRecipe.Location = new System.Drawing.Point(188, 27);
            this.tb_TitleRecipe.Name = "tb_TitleRecipe";
            this.tb_TitleRecipe.Size = new System.Drawing.Size(159, 26);
            this.tb_TitleRecipe.TabIndex = 1;
            this.tb_TitleRecipe.Click += new System.EventHandler(this.tb_TitleRecipe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите ингридиент";
            // 
            // tb_NameIngrid
            // 
            this.tb_NameIngrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_NameIngrid.Location = new System.Drawing.Point(188, 28);
            this.tb_NameIngrid.Name = "tb_NameIngrid";
            this.tb_NameIngrid.Size = new System.Drawing.Size(159, 26);
            this.tb_NameIngrid.TabIndex = 3;
            this.tb_NameIngrid.Click += new System.EventHandler(this.tb_NameIngrid_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_TitleRecipe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(29, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 71);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Название";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_CountIngrid);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_AddIngrid);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_NameIngrid);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(29, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 158);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ингридиенты";
            // 
            // tb_CountIngrid
            // 
            this.tb_CountIngrid.Location = new System.Drawing.Point(188, 68);
            this.tb_CountIngrid.Name = "tb_CountIngrid";
            this.tb_CountIngrid.Size = new System.Drawing.Size(159, 26);
            this.tb_CountIngrid.TabIndex = 6;
            this.tb_CountIngrid.Click += new System.EventHandler(this.tb_CountIngrid_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Кол-во";
            // 
            // btn_AddIngrid
            // 
            this.btn_AddIngrid.Location = new System.Drawing.Point(188, 100);
            this.btn_AddIngrid.Name = "btn_AddIngrid";
            this.btn_AddIngrid.Size = new System.Drawing.Size(159, 46);
            this.btn_AddIngrid.TabIndex = 4;
            this.btn_AddIngrid.Text = "Добавить";
            this.btn_AddIngrid.UseVisualStyleBackColor = true;
            this.btn_AddIngrid.Click += new System.EventHandler(this.btn_AddIngrid_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_EditRecipe);
            this.groupBox3.Controls.Add(this.btn_DeleteRecipe);
            this.groupBox3.Controls.Add(this.tb_countIngr);
            this.groupBox3.Controls.Add(this.tb_nameIngr);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbx_NameIngr);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(29, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 264);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Редактировать Ингридиент";
            // 
            // btn_EditRecipe
            // 
            this.btn_EditRecipe.Location = new System.Drawing.Point(25, 194);
            this.btn_EditRecipe.Name = "btn_EditRecipe";
            this.btn_EditRecipe.Size = new System.Drawing.Size(158, 53);
            this.btn_EditRecipe.TabIndex = 11;
            this.btn_EditRecipe.Text = "Редактировать";
            this.btn_EditRecipe.UseVisualStyleBackColor = true;
            this.btn_EditRecipe.Click += new System.EventHandler(this.btn_EditRecipe_Click);
            // 
            // btn_DeleteRecipe
            // 
            this.btn_DeleteRecipe.Location = new System.Drawing.Point(189, 194);
            this.btn_DeleteRecipe.Name = "btn_DeleteRecipe";
            this.btn_DeleteRecipe.Size = new System.Drawing.Size(158, 53);
            this.btn_DeleteRecipe.TabIndex = 10;
            this.btn_DeleteRecipe.Text = "Удалить";
            this.btn_DeleteRecipe.UseVisualStyleBackColor = true;
            this.btn_DeleteRecipe.Click += new System.EventHandler(this.btn_DeleteRecipe_Click);
            // 
            // tb_countIngr
            // 
            this.tb_countIngr.Location = new System.Drawing.Point(189, 150);
            this.tb_countIngr.Name = "tb_countIngr";
            this.tb_countIngr.Size = new System.Drawing.Size(158, 26);
            this.tb_countIngr.TabIndex = 9;
            this.tb_countIngr.Click += new System.EventHandler(this.tb_countIngr_Click);
            // 
            // tb_nameIngr
            // 
            this.tb_nameIngr.Location = new System.Drawing.Point(189, 114);
            this.tb_nameIngr.Name = "tb_nameIngr";
            this.tb_nameIngr.Size = new System.Drawing.Size(158, 26);
            this.tb_nameIngr.TabIndex = 8;
            this.tb_nameIngr.Click += new System.EventHandler(this.tb_nameIngr_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Кол-во";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Имя ингридиента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Выберите ингридиент";
            // 
            // cbx_NameIngr
            // 
            this.cbx_NameIngr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_NameIngr.FormattingEnabled = true;
            this.cbx_NameIngr.Location = new System.Drawing.Point(188, 30);
            this.cbx_NameIngr.Name = "cbx_NameIngr";
            this.cbx_NameIngr.Size = new System.Drawing.Size(159, 28);
            this.cbx_NameIngr.TabIndex = 0;
            this.cbx_NameIngr.SelectedIndexChanged += new System.EventHandler(this.cbx_NameIngr_SelectedIndexChanged);
            // 
            // rtb_DescriptionRecie
            // 
            this.rtb_DescriptionRecie.Location = new System.Drawing.Point(6, 60);
            this.rtb_DescriptionRecie.Name = "rtb_DescriptionRecie";
            this.rtb_DescriptionRecie.Size = new System.Drawing.Size(351, 371);
            this.rtb_DescriptionRecie.TabIndex = 8;
            this.rtb_DescriptionRecie.Text = "";
            this.rtb_DescriptionRecie.Click += new System.EventHandler(this.rtb_DescriptionRecie_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.rtb_DescriptionRecie);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(395, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(363, 437);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Сам рецепт";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Описание";
            // 
            // btn_SaveRecipe
            // 
            this.btn_SaveRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SaveRecipe.Location = new System.Drawing.Point(395, 481);
            this.btn_SaveRecipe.Name = "btn_SaveRecipe";
            this.btn_SaveRecipe.Size = new System.Drawing.Size(363, 61);
            this.btn_SaveRecipe.TabIndex = 10;
            this.btn_SaveRecipe.Text = "Записать рецепт";
            this.btn_SaveRecipe.UseVisualStyleBackColor = true;
            this.btn_SaveRecipe.Click += new System.EventHandler(this.btn_SaveRecipe_Click);
            // 
            // Panel_AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_SaveRecipe);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Panel_AddRecipe";
            this.Size = new System.Drawing.Size(800, 570);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_TitleRecipe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_NameIngrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_AddIngrid;
        private System.Windows.Forms.TextBox tb_CountIngrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_NameIngr;
        private System.Windows.Forms.Button btn_EditRecipe;
        private System.Windows.Forms.Button btn_DeleteRecipe;
        private System.Windows.Forms.TextBox tb_countIngr;
        private System.Windows.Forms.TextBox tb_nameIngr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtb_DescriptionRecie;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_SaveRecipe;
    }
}
