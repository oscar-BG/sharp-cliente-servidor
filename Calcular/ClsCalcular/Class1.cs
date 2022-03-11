using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsCalcular
{
    public class Calculadora : MarshalByRefObject
    {
        public Calculadora()
        {

        }
        public int suma(int a, int b)
        {
            return a + b;
        }
        public int resta(int a, int b)
        {
            return a - b;
        }
        public int multiplicacion(int a, int b)
        {
            return a * b;
        }
    }
    public class Class1
    {
        
    }
}
