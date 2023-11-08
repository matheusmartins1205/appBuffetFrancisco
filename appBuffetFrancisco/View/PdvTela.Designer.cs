namespace appBuffetFrancisco.View
{
    partial class PdvTela
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdvTela));
            label1 = new Label();
            groupBox1 = new GroupBox();
            btn_coxinha = new Button();
            btn_esfiha = new Button();
            btn_pastel = new Button();
            btn_bolinho = new Button();
            groupBox2 = new GroupBox();
            btn_cafe = new Button();
            btn_suco = new Button();
            btn_refrigerante = new Button();
            txt_valortt = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label5 = new Label();
            num_Qtd = new NumericUpDown();
            txb_Codigo = new TextBox();
            dataGridView_PDV = new DataGridView();
            Produto = new DataGridViewTextBoxColumn();
            Qtde = new DataGridViewTextBoxColumn();
            Unitário = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btn_Adicionar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_Qtd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_PDV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("BankGothic Md BT", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(190, 62);
            label1.Name = "label1";
            label1.Size = new Size(468, 28);
            label1.TabIndex = 0;
            label1.Text = "Buffet Franscisco - Pedidos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_coxinha);
            groupBox1.Controls.Add(btn_esfiha);
            groupBox1.Controls.Add(btn_pastel);
            groupBox1.Controls.Add(btn_bolinho);
            groupBox1.Location = new Point(31, 146);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 95);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos";
            // 
            // btn_coxinha
            // 
            btn_coxinha.Image = Properties.Resources.MicrosoftTeams_image__3_1;
            btn_coxinha.Location = new Point(6, 22);
            btn_coxinha.Name = "btn_coxinha";
            btn_coxinha.Size = new Size(75, 60);
            btn_coxinha.TabIndex = 2;
            btn_coxinha.UseVisualStyleBackColor = true;
            btn_coxinha.Click += btn_coxinha_Click;
            // 
            // btn_esfiha
            // 
            btn_esfiha.Image = Properties.Resources.MicrosoftTeams_image__6_;
            btn_esfiha.Location = new Point(292, 22);
            btn_esfiha.Name = "btn_esfiha";
            btn_esfiha.Size = new Size(75, 60);
            btn_esfiha.TabIndex = 4;
            btn_esfiha.UseVisualStyleBackColor = true;
            btn_esfiha.Click += btn_esfiha_Click;
            // 
            // btn_pastel
            // 
            btn_pastel.Image = Properties.Resources.MicrosoftTeams_image__4_;
            btn_pastel.Location = new Point(98, 22);
            btn_pastel.Name = "btn_pastel";
            btn_pastel.Size = new Size(75, 60);
            btn_pastel.TabIndex = 3;
            btn_pastel.UseVisualStyleBackColor = true;
            btn_pastel.Click += btn_pastel_Click;
            // 
            // btn_bolinho
            // 
            btn_bolinho.Image = Properties.Resources.MicrosoftTeams_image__5_1;
            btn_bolinho.Location = new Point(196, 22);
            btn_bolinho.Name = "btn_bolinho";
            btn_bolinho.Size = new Size(75, 60);
            btn_bolinho.TabIndex = 6;
            btn_bolinho.UseVisualStyleBackColor = true;
            btn_bolinho.Click += btn_bolinho_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_cafe);
            groupBox2.Controls.Add(btn_suco);
            groupBox2.Controls.Add(btn_refrigerante);
            groupBox2.Location = new Point(31, 272);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(304, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bebidas";
            // 
            // btn_cafe
            // 
            btn_cafe.Image = Properties.Resources.MicrosoftTeams_image__9_;
            btn_cafe.Location = new Point(196, 22);
            btn_cafe.Name = "btn_cafe";
            btn_cafe.Size = new Size(75, 60);
            btn_cafe.TabIndex = 8;
            btn_cafe.UseVisualStyleBackColor = true;
            btn_cafe.Click += btn_cafe_Click;
            // 
            // btn_suco
            // 
            btn_suco.Image = Properties.Resources.MicrosoftTeams_image__7_;
            btn_suco.Location = new Point(0, 22);
            btn_suco.Name = "btn_suco";
            btn_suco.Size = new Size(75, 65);
            btn_suco.TabIndex = 7;
            btn_suco.UseVisualStyleBackColor = true;
            btn_suco.Click += btn_suco_Click;
            // 
            // btn_refrigerante
            // 
            btn_refrigerante.Image = Properties.Resources.MicrosoftTeams_image__8_;
            btn_refrigerante.Location = new Point(98, 22);
            btn_refrigerante.Name = "btn_refrigerante";
            btn_refrigerante.Size = new Size(75, 60);
            btn_refrigerante.TabIndex = 5;
            btn_refrigerante.UseVisualStyleBackColor = true;
            btn_refrigerante.Click += btn_refrigerante_Click;
            // 
            // txt_valortt
            // 
            txt_valortt.BackColor = Color.Lime;
            txt_valortt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_valortt.Location = new Point(153, 424);
            txt_valortt.Name = "txt_valortt";
            txt_valortt.Size = new Size(126, 23);
            txt_valortt.TabIndex = 9;
            txt_valortt.Text = "R$ 0,0";
            txt_valortt.Click += txt_valortt_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(51, 424);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 10;
            label4.Text = "Valor Total";
            // 
            // button1
            // 
            button1.Location = new Point(51, 489);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Cancelar ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(147, 489);
            button2.Name = "button2";
            button2.Size = new Size(132, 23);
            button2.TabIndex = 12;
            button2.Text = "Receber e Finalizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(450, 146);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 14;
            label2.Text = "Código";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(614, 146);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 15;
            label5.Text = "Qtde";
            // 
            // num_Qtd
            // 
            num_Qtd.Location = new Point(614, 168);
            num_Qtd.Name = "num_Qtd";
            num_Qtd.Size = new Size(44, 23);
            num_Qtd.TabIndex = 16;
            // 
            // txb_Codigo
            // 
            txb_Codigo.Location = new Point(434, 170);
            txb_Codigo.Name = "txb_Codigo";
            txb_Codigo.Size = new Size(100, 23);
            txb_Codigo.TabIndex = 17;
            // 
            // dataGridView_PDV
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_PDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_PDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_PDV.Columns.AddRange(new DataGridViewColumn[] { Produto, Qtde, Unitário, Total });
            dataGridView_PDV.Location = new Point(427, 216);
            dataGridView_PDV.Name = "dataGridView_PDV";
            dataGridView_PDV.RowHeadersVisible = false;
            dataGridView_PDV.RowTemplate.Height = 25;
            dataGridView_PDV.Size = new Size(399, 204);
            dataGridView_PDV.TabIndex = 18;
            dataGridView_PDV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Produto
            // 
            Produto.HeaderText = "Produto";
            Produto.Name = "Produto";
            // 
            // Qtde
            // 
            Qtde.HeaderText = "Qtde";
            Qtde.Name = "Qtde";
            // 
            // Unitário
            // 
            Unitário.HeaderText = "Unitário";
            Unitário.Name = "Unitário";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.Font = new Font("Elephant", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Adicionar.Location = new Point(698, 162);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(128, 29);
            btn_Adicionar.TabIndex = 19;
            btn_Adicionar.Text = "Adicionar";
            btn_Adicionar.UseVisualStyleBackColor = true;
            btn_Adicionar.Click += btn_Adicionar_Click;
            // 
            // PdvTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(887, 549);
            Controls.Add(btn_Adicionar);
            Controls.Add(dataGridView_PDV);
            Controls.Add(txb_Codigo);
            Controls.Add(num_Qtd);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(txt_valortt);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PdvTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PdvTela";
            Load += PdvTela_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)num_Qtd).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_PDV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_coxinha;
        private Button btn_esfiha;
        private Button btn_pastel;
        private Button btn_bolinho;
        private Button btn_cafe;
        private Button btn_suco;
        private Button btn_refrigerante;
        private Label txt_valortt;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label5;
        private NumericUpDown num_Qtd;
        private TextBox txb_Codigo;
        private DataGridView dataGridView_PDV;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Qtde;
        private DataGridViewTextBoxColumn Unitário;
        private DataGridViewTextBoxColumn Total;
        private Button btn_Adicionar;
    }
}