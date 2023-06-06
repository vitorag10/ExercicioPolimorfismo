using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPolimorfismo2.Dominio
{
    public class Vaca : Animal
    {
        public override void emitirSom()
        {
            Console.WriteLine("A vaca que tem 4 patas, faz MUUUUUUUUUU");
        }
    }
}
