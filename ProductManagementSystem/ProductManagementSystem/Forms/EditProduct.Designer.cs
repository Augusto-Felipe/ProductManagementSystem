namespace ProductManagementSystem
{
    partial class EditProduct
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
            label1 = new Label();
            txt_newName = new TextBox();
            btn_send = new Button();
            label2 = new Label();
            txt_id = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 95);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do Produto";
            // 
            // txt_newName
            // 
            txt_newName.Location = new Point(124, 113);
            txt_newName.Name = "txt_newName";
            txt_newName.Size = new Size(100, 23);
            txt_newName.TabIndex = 1;
            // 
            // btn_send
            // 
            btn_send.Location = new Point(138, 142);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(75, 23);
            btn_send.TabIndex = 2;
            btn_send.Text = "Alterar";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += Btn_send_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 40);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 3;
            label2.Text = "Digite o ID do Produto";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(124, 58);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(100, 23);
            txt_id.TabIndex = 4;
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 212);
            Controls.Add(txt_id);
            Controls.Add(label2);
            Controls.Add(btn_send);
            Controls.Add(txt_newName);
            Controls.Add(label1);
            Name = "EditProduct";
            Text = "EditProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_newName;
        private Button btn_send;
        private Label label2;
        private TextBox txt_id;
    }
}