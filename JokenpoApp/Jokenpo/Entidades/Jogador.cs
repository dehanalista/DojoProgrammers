using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo.Entidades
{
    public enum JogadasPossiveis { Nenhuma, Papel, Pedra, Tesoura }

    public class Jogador
    {
        #region Atributos
        private readonly int idJogador;
        private JogadasPossiveis jogadaSelecionada;
        #endregion

        #region Construtores
        public Jogador (int id)
        {
            this.idJogador = id;
            this.jogadaSelecionada = JogadasPossiveis.Nenhuma;
        }
        #endregion


        public int AvaliarJogada(JogadasPossiveis comparador)
        {
            //Avalia o comparador com a jogada selecionada pelo jogador.
            //Caso o jogador tenha selecionado uma opção vencedora se comparado ao comparador, retorna 1.
            //Caso seja perdedora, retorna -1.
            //Em caso de empate, retorna 0.
            switch (this.jogadaSelecionada)
            {
                case JogadasPossiveis.Papel:
                    {
                        switch (comparador)
                        {
                            case JogadasPossiveis.Papel:
                                {
                                    return 0;
                                }
                            case JogadasPossiveis.Pedra:
                                {
                                    return 1;
                                }
                            case JogadasPossiveis.Tesoura:
                                {
                                    return -1;
                                }
                            default:
                                {
                                    string exc = String.Format("Opção inválida!");
                                    throw new Exception(exc);
                                }
                        }
                    }
                case JogadasPossiveis.Pedra:
                    {
                        switch (comparador)
                        {
                            case JogadasPossiveis.Papel:
                                {
                                    return -1;
                                }
                            case JogadasPossiveis.Pedra:
                                {
                                    return 0;
                                }
                            case JogadasPossiveis.Tesoura:
                                {
                                    return 1;
                                }
                            default:
                                {
                                    string exc = String.Format("Opção inválida!");
                                    throw new Exception(exc);
                                }
                        }
                    }
                case JogadasPossiveis.Tesoura:
                    {
                        switch (comparador)
                        {
                            case JogadasPossiveis.Papel:
                                {
                                    return 1;
                                }
                            case JogadasPossiveis.Pedra:
                                {
                                    return -1;
                                }
                            case JogadasPossiveis.Tesoura:
                                {
                                    return 0;
                                }
                            default:
                                {
                                    string exc = String.Format("Opção inválida!");
                                    throw new Exception(exc);
                                }
                        }
                    }
                default:
                    {
                        string exc = "O jogador não escolheu nenhuma opção válida!";
                        throw new Exception(exc);
                    }
            }
        }


        public int IdJogador { get => idJogador; }
        public JogadasPossiveis JogadaSelecionada { get => jogadaSelecionada; set => jogadaSelecionada = value; }
    }
}
