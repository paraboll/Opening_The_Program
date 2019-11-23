namespace Opening_The_Program
{
    partial class CookingBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CookingBookForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_addRacipe = new System.Windows.Forms.Button();
            this.btn_listOfRecipes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.listRecipes1 = new Opening_The_Program.ListRecipes();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.btn_Exit);
            this.panelMenu.Controls.Add(this.btn_addRacipe);
            this.panelMenu.Controls.Add(this.btn_listOfRecipes);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 600);
            this.panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.BackgroundImage = global::Opening_The_Program.Properties.Resources.move_Form;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 50);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Exit.Image = global::Opening_The_Program.Properties.Resources.Exit;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(0, 547);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(200, 50);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Выйти";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_addRacipe
            // 
            this.btn_addRacipe.FlatAppearance.BorderSize = 0;
            this.btn_addRacipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addRacipe.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addRacipe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_addRacipe.Image = global::Opening_The_Program.Properties.Resources.add;
            this.btn_addRacipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addRacipe.Location = new System.Drawing.Point(0, 145);
            this.btn_addRacipe.Name = "btn_addRacipe";
            this.btn_addRacipe.Size = new System.Drawing.Size(200, 50);
            this.btn_addRacipe.TabIndex = 3;
            this.btn_addRacipe.Text = "Добавть рецепт";
            this.btn_addRacipe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addRacipe.UseVisualStyleBackColor = true;
            // 
            // btn_listOfRecipes
            // 
            this.btn_listOfRecipes.FlatAppearance.BorderSize = 0;
            this.btn_listOfRecipes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listOfRecipes.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_listOfRecipes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_listOfRecipes.Image = ((System.Drawing.Image)(resources.GetObject("btn_listOfRecipes.Image")));
            this.btn_listOfRecipes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_listOfRecipes.Location = new System.Drawing.Point(0, 89);
            this.btn_listOfRecipes.Name = "btn_listOfRecipes";
            this.btn_listOfRecipes.Size = new System.Drawing.Size(200, 50);
            this.btn_listOfRecipes.TabIndex = 0;
            this.btn_listOfRecipes.Text = "Список рецептов";
            this.btn_listOfRecipes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_listOfRecipes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 1;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_Title.Location = new System.Drawing.Point(290, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(233, 22);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Книга для Ваших рецептов";
            // 
            // listRecipes1
            // 
            this.listRecipes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listRecipes1.Location = new System.Drawing.Point(200, 30);
            this.listRecipes1.Name = "listRecipes1";
            this.listRecipes1.Size = new System.Drawing.Size(800, 570);
            this.listRecipes1.TabIndex = 2;
            this.listRecipes1.Load += new System.EventHandler(this.listRecipes1_Load);
            // 
            // CookingBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.listRecipes1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CookingBookForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_listOfRecipes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_addRacipe;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel2;
        private ListRecipes listRecipes1;
    }
}

