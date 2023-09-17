namespace ProductManagementSystem
{
    partial class DeleteProduct
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
            txt_id = new TextBox();
            label2 = new Label();
            btn_delete = new Button();
            SuspendLayout();
            // 
            // txt_id
            // 
            txt_id.Location = new Point(101, 82);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(100, 23);
            txt_id.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 64);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 8;
            label2.Text = "Digite o ID do Produto";
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(116, 111);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Deletar";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += Btn_delete_Click;
            // 
            // DeleteProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 196);
            Controls.Add(txt_id);
            Controls.Add(label2);
            Controls.Add(btn_delete);
            Name = "DeleteProduct";
            Text = "DeleteProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_id;
        private Label label2;
        private Button btn_delete;
    }
}