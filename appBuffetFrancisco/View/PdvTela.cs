using appBuffetFrancisco.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBuffetFrancisco.View
{
    public partial class PdvTela : Form
    {
        int totalfinal;
        public PdvTela()
        {
            InitializeComponent();
        }

        private void btn_pastel_Click(object sender, EventArgs e)
        {
            string registrospastel = "1";

            txb_Codigo.Text = registrospastel;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PdvTela_Load(object sender, EventArgs e)
        {

        }

        private void btn_coxinha_Click(object sender, EventArgs e)
        {
            string registroscoxinha = "0";

            txb_Codigo.Text = registroscoxinha;
        }

        private void btn_bolinho_Click(object sender, EventArgs e)
        {
            string registrosbolinho = "2";

            txb_Codigo.Text = registrosbolinho;
        }

        private void btn_esfiha_Click(object sender, EventArgs e)
        {
            string registrosesfiha = "3";

            txb_Codigo.Text = registrosesfiha;
        }

        private void btn_suco_Click(object sender, EventArgs e)
        {
            string registrossuco = "4";

            txb_Codigo.Text = registrossuco;
        }

        private void btn_refrigerante_Click(object sender, EventArgs e)
        {
            string registrosrefrigerante = "5";

            txb_Codigo.Text = registrosrefrigerante;
        }

        private void btn_cafe_Click(object sender, EventArgs e)
        {
            string registroscafe = "6";

            txb_Codigo.Text = registroscafe;
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            string codigo = txb_Codigo.Text;
            int qtd = ((int)num_Qtd.Value);





            string[] itens = { "Coxinha", "Pastel", "Bolinho de Queijo", "Esfiha", "Sucos", "Refrigerantes", "Café" };
            int codigo_result = Convert.ToInt32(codigo);
            int[] array = { 8, 8, 8, 8, 12, 10, 15 };
            int total = qtd * array[codigo_result];

            dataGridView_PDV.Rows.Add(itens[codigo_result], qtd, array[codigo_result], total);
            totalfinal += total;
            txt_valortt.Text = totalfinal.ToString();

        }

        private void txt_valortt_Click(object sender, EventArgs e)

        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
           
            FiscalTela Fiscal = new FiscalTela(totalfinal);
            Fiscal.FormClosed += (s, args) => this.Close();
            Fiscal.Show();

               


        }
    }
}
