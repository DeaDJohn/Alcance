using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alcance
{
    public class Alcance
    {
        //variable de instancia que es accesible para todos los metodos de esta clase
        private int x = 1;

        //el metodo Iniciar crea e inicializa la variable local x
        // y llama a los metodos UsarVariableLocal y UsarVariableInstancia
        public void Iniciar()
        {
            int x = 5; // la variable local x del metodo oculta a la variable de instacia x

            Console.WriteLine(" x local en el metodo Iniciar es {0}", x);

            // UsarVariableLocal tiene su propia x local 
            
            UsarVariableLocal();  
            // UsarVariableInstancia utiliza la variable de instancia x de la clase Alcance  
            
            UsarVariableInstancia(); 
            // UsarVariableLocal reinicializa su propia x local 
            
            UsarVariableLocal();  
            // la variable de instancia x de la clase Alcance retiene su valor 
            
            UsarVariableInstancia(); 
        }

        // crea e inicia la variable local x durante cada llamada
        public void UsarVariableLocal()
        {
            int x = 25; // se inicia cada vez que se hace una llamada a UsarVariableLocal

            Console.WriteLine(
                "\nx local al entrar al metodo UsarVariableLocar es {0}", x);
            x++; //modifica la variable local x de este metodo
            Console.WriteLine(
                "x local antes de salir del metodo UsarVariableLocal es {0}", x);
        }

        public void UsarVariableInstancia()
        {
            Console.WriteLine("\nvariable de instancia x al entrar al {0} es {1}", "metodo UsarVariableInstancia", x);
            x *= 10; //modifica la variable de instancia x de la clase Alcance
                Console.WriteLine("variable de instancia x antes de salir del {0} es {1}", "metodo UsarVariableInstancia", x);
        }
    }
    class PruebaAlcance
    {
        static void Main(string[] args)
        {
            Alcance pruebaAlcance = new Alcance();
            pruebaAlcance.Iniciar();
            Console.ReadKey();

        }
    }
}
