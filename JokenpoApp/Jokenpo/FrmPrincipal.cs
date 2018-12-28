using Jokenpo.BUS;
using Jokenpo.Entidades;
using System.Windows.Forms;

namespace Jokenpo
{
    public partial class FrmPrincipal : Form
    {
        private Jogador jogador1;
        private Jogador jogador2;



        public FrmPrincipal()
        {
            InitializeComponent();
            this.jogador1 = new Jogador(1);
            this.jogador2 = new Jogador(2);
        }

        private void btnPapel1_Click(object sender, System.EventArgs e)
        {
            this.jogador1.JogadaSelecionada = JogadasPossiveis.Papel;
        }

        private void btnPedra1_Click(object sender, System.EventArgs e)
        {
            this.jogador1.JogadaSelecionada = JogadasPossiveis.Pedra;
        }

        private void btnTesoura1_Click(object sender, System.EventArgs e)
        {
            this.jogador1.JogadaSelecionada = JogadasPossiveis.Tesoura;
        }

        private void btnPapel2_Click(object sender, System.EventArgs e)
        {
            this.jogador2.JogadaSelecionada = JogadasPossiveis.Papel;
        }

        private void btnPedra2_Click(object sender, System.EventArgs e)
        {
            this.jogador2.JogadaSelecionada = JogadasPossiveis.Pedra;
        }

        private void btnTesoura2_Click(object sender, System.EventArgs e)
        {
            this.jogador2.JogadaSelecionada = JogadasPossiveis.Tesoura;
        }

        private void btnAvaliar_Click(object sender, System.EventArgs e)
        {
            try
            {
                Jogador jogadorVencedor;
                string resultado;

                jogadorVencedor = AvaliadorJogada.AvaliarJogada(this.jogador1, this.jogador2);
                if (jogadorVencedor == null)
                {
                    resultado = "Houve empate!";
                }
                else
                {
                    resultado = string.Format("O jogador {0} venceu!", jogadorVencedor.IdJogador);
                }

                MessageBox.Show(resultado);
            }
            catch (System.Exception exc)
            {
                MessageBox.Show(exc.Message);
                throw;
            }
        }
    }
}
