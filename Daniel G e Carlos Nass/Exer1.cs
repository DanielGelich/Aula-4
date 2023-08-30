using System;

namespace TremAutonomo {
    
    class Trem {
        static void Main(string[] args) {
            int posicao = 0;
            int[] limites = { -8, 8 };

            Console.WriteLine("limite esquerdo do trilho ( trilho infinito = 0 !): ");
            int limiteEsquerdo = int.Parse(Console.ReadLine());
            if (limiteEsquerdo != 0) {
                Console.WriteLine("limite direito do trilho: ");
                int limiteDireito = int.Parse(Console.ReadLine());
                limites[0] = limiteEsquerdo;
                limites[1] = limiteDireito;
            }

            Console.WriteLine("lista de comandos (maximo 10 comandos possiveis): ");
            string[] comandos = Console.ReadLine().Split(' ');           
            if (comandos.Length > 10) {
                Console.WriteLine("A lista so pode ter no maximo 10 comandos.");
                return;
            }
            foreach (string comando in comandos) {
                if (comando == "DIREITA") {
                    posicao++;
                    if (posicao > limites[1]) {
                        posicao = limites[1];
                    }
                } else if (comando == "ESQUERDA") {
                    posicao--;
                    if (posicao < limites[0]) {
                        posicao = limites[0];
                    }
                }
            }
        Console.WriteLine("Posicao final do trem = {0}", posicao);
        }
    }
}