﻿namespace ProductManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txt_name = new TextBox();
            btn_add = new Button();
            label2 = new Label();
            label3 = new Label();
            btn_search = new Button();
            label4 = new Label();
            btn_delete = new Button();
            label5 = new Label();
            btn_list = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(309, 47);
            label1.Name = "label1";
            label1.Size = new Size(123, 37);
            label1.TabIndex = 0;
            label1.Text = "Produto";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(438, 58);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(248, 26);
            txt_name.TabIndex = 1;
            // 
            // btn_add
            // 
            btn_add.BackgroundImage = (Image)resources.GetObject("btn_add.BackgroundImage");
            btn_add.BackgroundImageLayout = ImageLayout.Stretch;
            btn_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.Location = new Point(30, 49);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(107, 122);
            btn_add.TabIndex = 2;
            btn_add.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 174);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 3;
            label2.Text = "ADICIONAR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(172, 174);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "PESQUISAR";
            // 
            // btn_search
            // 
            btn_search.BackgroundImage = (Image)resources.GetObject("btn_search.BackgroundImage");
            btn_search.BackgroundImageLayout = ImageLayout.Stretch;
            btn_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_search.Location = new Point(156, 49);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(107, 122);
            btn_search.TabIndex = 4;
            btn_search.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(55, 326);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 7;
            label4.Text = "EXCLUIR";
            // 
            // btn_delete
            // 
            btn_delete.BackgroundImage = (Image)resources.GetObject("btn_delete.BackgroundImage");
            btn_delete.BackgroundImageLayout = ImageLayout.Stretch;
            btn_delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.Location = new Point(30, 201);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(107, 122);
            btn_delete.TabIndex = 6;
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(181, 326);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 9;
            label5.Text = "LISTAR";
            // 
            // btn_list
            // 
            btn_list.BackgroundImage = (Image)resources.GetObject("btn_list.BackgroundImage");
            btn_list.BackgroundImageLayout = ImageLayout.Stretch;
            btn_list.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_list.Location = new Point(156, 201);
            btn_list.Name = "btn_list";
            btn_list.Size = new Size(107, 122);
            btn_list.TabIndex = 8;
            btn_list.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 450);
            Controls.Add(label5);
            Controls.Add(btn_list);
            Controls.Add(label4);
            Controls.Add(btn_delete);
            Controls.Add(label3);
            Controls.Add(btn_search);
            Controls.Add(label2);
            Controls.Add(btn_add);
            Controls.Add(txt_name);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_name;
        private Button btn_add;
        private Label label2;
        private Label label3;
        private Button btn_search;
        private Label label4;
        private Button btn_delete;
        private Label label5;
        private Button btn_list;
    }
}