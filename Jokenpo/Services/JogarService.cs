using System;

namespace Jokenpo.Services
{
    class JogarService
    {
        string vencedor;

        public void Jokenpo(string nomeJ1, int opcaoJ1, string nomeJ2, int opcaoJ2)
        {
            if (opcaoJ1 == opcaoJ2)
            {
                vencedor = "EMPATE";
            }

            else if (opcaoJ1 == 1 && opcaoJ2 == 2)
            {
                vencedor = nomeJ2;
            }

            else if (opcaoJ1 == 1 && opcaoJ2 == 3)
            {
                vencedor = nomeJ1;
            }

            else if (opcaoJ1 == 2 & opcaoJ2 == 1)
            {
                vencedor = nomeJ1;
            }

            else if (opcaoJ1 == 2 & opcaoJ2 == 3)
            {
                vencedor = nomeJ2;
            }

            else if (opcaoJ1 == 3 & opcaoJ2 == 1)
            {
                vencedor = nomeJ2;
            }

            else if (opcaoJ1 == 3 & opcaoJ2 == 2)
            {
                vencedor = nomeJ1;
            }
        }
        public override string ToString()
        {
            if(vencedor == "EMPATE")
            {
                return "É um EMPATE";
            }

            return "O vencedor é: " + vencedor.ToString();
        }
    }
}

