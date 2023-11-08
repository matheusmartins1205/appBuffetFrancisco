namespace appBuffetFrancisco.View
{
    partial class FiscalTela
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
            txt_total = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // txt_total
            // 
            txt_total.AutoSize = true;
            txt_total.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_total.Location = new Point(435, 305);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(36, 25);
            txt_total.TabIndex = 0;
            txt_total.Text = "0,0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(277, 351);
            label1.Name = "label1";
            label1.Size = new Size(226, 25);
            label1.TabIndex = 1;
            label1.Text = "Pagamento Confirmado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(396, 305);
            label2.Name = "label2";
            label2.Size = new Size(33, 25);
            label2.TabIndex = 2;
            label2.Text = "R$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(256, 305);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 3;
            label3.Text = "Total Recebido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("BankGothic Lt BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(284, 94);
            label4.Name = "label4";
            label4.Size = new Size(205, 22);
            label4.TabIndex = 4;
            label4.Text = "Buffet Francisco";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 166);
            label5.Name = "label5";
            label5.Size = new Size(175, 15);
            label5.TabIndex = 5;
            label5.Text = "Rua: Avenida Senador Vergueiro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(235, 196);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 6;
            label6.Text = "Número: 400";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(235, 225);
            label7.Name = "label7";
            label7.Size = new Size(111, 15);
            label7.TabIndex = 7;
            label7.Text = "CPF: 542.568.658-70";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(235, 255);
            label8.Name = "label8";
            label8.Size = new Size(140, 15);
            label8.TabIndex = 8;
            label8.Text = "CNPJ: 12.345.678/0001-00";
            // 
            // FiscalTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_total);
            Name = "FiscalTela";
            Text = "FiscalTela";
            Load += FiscalTela_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt_total;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}