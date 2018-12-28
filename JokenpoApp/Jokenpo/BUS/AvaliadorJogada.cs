using Jokenpo.Entidades;
using System;

namespace Jokenpo.BUS
{
    static class AvaliadorJogada
    {
        static public Jogador AvaliarJogada(Jogador jogador1, Jogador jogador2)
        {
            //Recebe dois jogadores, avalia as jogadas selecionadas e retorna o Jogador vencedor.
            //Em caso de empate, retorna nulo.
            //Caso um jogador não tenha selecionado nenhuma opção, retorna uma exceção.

            if (jogador1.JogadaSelecionada == JogadasPossiveis.Nenhuma)
            {
                throw new Exception(String.Format("O jogador {0} não selecionou uma jogada válida.", jogador1.IdJogador));
            }
            else if (jogador2.JogadaSelecionada == JogadasPossiveis.Nenhuma)
            {
                throw new Exception(String.Format("O jogador {0} não selecionou uma jogada válida.", jogador2.IdJogador));
            }
            else
            {
                int resultado = jogador1.AvaliarJogada(jogador2.JogadaSelecionada);

                if (resultado < 0)
                {
                    return jogador2;
                }
                else if (resultado > 0)
                {
                    return jogador1;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
