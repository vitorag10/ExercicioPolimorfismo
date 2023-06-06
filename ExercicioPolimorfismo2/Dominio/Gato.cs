using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPolimorfismo2.Dominio
{
    public class Gato: Animal
    {
        public override void emitirSom()
        {
            Console.WriteLine("O gato que tem 4 patas, faz MIAAUUUUU");
        }
    }
}
