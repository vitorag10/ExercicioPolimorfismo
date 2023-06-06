using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPolimorfismo2.Dominio
{
    public class Animal
    {
        private string nome;
        private int numeroPatas;

        public abstract void emitirSom();
    }
}