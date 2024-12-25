using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_velha
{
    public partial class Form1 : Form
    {
        private String jogador1 = "X";
        private String jogador2 = "O";
        private int quantidade = 0;

        public Form1()
        {
            InitializeComponent();
        }
        //verifica de quem é a vez do jogador
        public String vezDoJogador()
        {
            float resultadoParImpar = quantidade % 2;
            if (resultadoParImpar == 0)
            {
                quantidade++;
                return jogador1;
            }
            else 
            {
                quantidade++;
                return jogador2;
            }
        }
        //ações dos botões, rediciona para a verificação de campo
        private void button1_Click_1(object sender, EventArgs e)
        {
            Button btn1 = (Button)sender;
            verificacao(btn1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn2 = (Button)sender;
            verificacao(btn2);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {    
         Button btn3 = (Button)sender;
            verificacao(btn3);
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            Button btn4 = (Button)sender;
            verificacao(btn4);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Button btn5 = (Button)sender;
            verificacao(btn5);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Button btn6 = (Button)sender;
            verificacao(btn6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn7 = (Button)sender;
            verificacao(btn7);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Button btn8 = (Button)sender;
            verificacao(btn8);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Button btn9 = (Button)sender;
            verificacao(btn9);
        }
        //verifica se o espaço está vazio e redireciona para fazer 
        //outra verificação, para saber de quem é a vez
        private String verificacao(Button button) 
        {
            if (button.Text == "")
            {
                return button.Text = vezDoJogador();
            }
            return null;
        }
        //butão de limpar a tela do jogador, para começar um novo jogo
        private void button10_Click_1(object sender, EventArgs e)
        {
            foreach (Control controle in this.Controls) 
            {
                this.Controls["button1"].Text = "";
                this.Controls["button2"].Text = "";
                this.Controls["button3"].Text = "";
                this.Controls["button4"].Text = "";
                this.Controls["button5"].Text = "";
                this.Controls["button6"].Text = "";
                this.Controls["button7"].Text = "";
                this.Controls["button8"].Text = "";
                this.Controls["button9"].Text = "";
                quantidade = 0;
            }
        }
    }
}
