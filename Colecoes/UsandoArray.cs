using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class UsandoArray
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Augusto";
            alunos[1] = "Ayane";
            alunos[2] = "Marcos";
            alunos[3] = "Danilo";
            alunos[4] = "Manoela";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(alunos);  
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'R', 'R', 'A', 'Y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
