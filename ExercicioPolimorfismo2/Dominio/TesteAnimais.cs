using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPolimorfismo2.Dominio
{
    public class TesteAnimais
    {
        public void Main(string[] args)
        {
            Vaca vaca = new Vaca();
            Carneiro carneiro = new Carneiro();
            Gato gato = new Gato();

            vaca.emitirSom();
            carneiro.emitirSom();
            gato.emitirSom();

        }
    }
}
