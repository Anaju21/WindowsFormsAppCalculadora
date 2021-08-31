using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCalculadora
{
    public partial class Form1 : Form
    {

        double numero_pre_operacao;
        double numero_pos_operacao;
        double resultado;

        string operacao_selecionada;
 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_visor.Text += '0';

        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            numero_pos_operacao = Convert.ToDouble(txt_visor.Text);

            if (operacao_selecionada == "+")
            { resultado = numero_pre_operacao + numero_pos_operacao; }

            else if (operacao_selecionada == "-")
            { resultado = numero_pre_operacao - numero_pos_operacao; }

            else if (operacao_selecionada == "*")
            { resultado = numero_pre_operacao * numero_pos_operacao; }

            else if (operacao_selecionada == "/")
            { resultado = numero_pre_operacao / numero_pos_operacao; }

            else if (operacao_selecionada == "%")
            { resultado = numero_pre_operacao/100 * numero_pos_operacao; }


            txt_visor.Text = resultado.ToString();



        }

        private void btn_vezes_Click(object sender, EventArgs e)
        {
            numero_pre_operacao = Convert.ToDouble(txt_visor.Text);
            txt_visor.Text = "";
            operacao_selecionada = "*";
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            numero_pre_operacao = Convert.ToDouble(txt_visor.Text);
            txt_visor.Text = "";
            operacao_selecionada = "+";
        }

        private void txt_resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_visor.Text += '2';
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_visor.Text += '1';
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_visor.Text += '3';
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_visor.Text += '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt_visor.Text += '5';
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_visor.Text += '6';
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_visor.Text += '7';
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_visor.Text += '8';
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_visor.Text += '9';
        }

        private void btn_porcentagem_Click(object sender, EventArgs e)
        {
            numero_pre_operacao = Convert.ToDouble(txt_visor.Text);
            txt_visor.Text = "";
            operacao_selecionada = "%";
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            numero_pre_operacao = Convert.ToDouble(txt_visor.Text);
            txt_visor.Text = "";
            operacao_selecionada = "/";
        }

        private void btn_subtrai_Click(object sender, EventArgs e)
        {
            numero_pre_operacao = Convert.ToDouble(txt_visor.Text);
            txt_visor.Text = "";
            operacao_selecionada = "-";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txt_visor.Text += ',';
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_visor.Text = "";
      
        }
    }
}
