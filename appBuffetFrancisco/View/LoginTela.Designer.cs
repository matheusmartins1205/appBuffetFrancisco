namespace appBuffetFrancisco.View
{
    partial class LoginTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginTela));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            btn_acessar = new Button();
            groupBox1 = new GroupBox();
            btn_sair = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 71);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Buffet Francisco";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 75);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 127);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Senha :";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(88, 72);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(100, 23);
            txt_usuario.TabIndex = 3;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(88, 120);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(100, 23);
            txt_senha.TabIndex = 4;
            // 
            // btn_acessar
            // 
            btn_acessar.Location = new Point(128, 176);
            btn_acessar.Name = "btn_acessar";
            btn_acessar.Size = new Size(75, 23);
            btn_acessar.TabIndex = 5;
            btn_acessar.Text = "Acessar";
            btn_acessar.UseVisualStyleBackColor = true;
            btn_acessar.Click += btn_acessar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_sair);
            groupBox1.Controls.Add(btn_acessar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_senha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_usuario);
            groupBox1.Location = new Point(370, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 247);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Credenciais";
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(229, 176);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(75, 23);
            btn_sair.TabIndex = 8;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 247);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // LoginTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 376);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginTela";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_usuario;
        private TextBox txt_senha;
        private Button btn_acessar;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button btn_sair;
    }
}