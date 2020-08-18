using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_case
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            //Apresenta o formulario e chama em seguida
            novo.Show();
            //fecha o formulario atual
            this.Visible = false;

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            switch (cboOpcao.Text)
            /* de acordo com o final da placa escolhida no combobox sera exibida uma mensagem diferente
             * caso o final seja 1 ou 2 sera na segunda, 3 ou 4 na erça e assim vai */
            {
                case "1 ou 2":
                    lblRes.Text = "Seu dia é na segunda";
                    break;
                case "3 ou 4":
                    lblRes.Text = "Seu dia é na terça";
                    break;
                case "5 ou 6":
                    lblRes.Text = "Seu dia é na quarta";
                    break;
                case "7 ou 8":
                    lblRes.Text = "Seu dia é na quinta";
                    break;
                case "9 ou 0":
                    lblRes.Text = "Seu dia é na sexta";
                    break;
            }
        }
    }
}
