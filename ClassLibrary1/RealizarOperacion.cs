using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class RealizarOperacion
    {
        double Calcular(int operandoUno , double operandoDos, string operador)
        {

            double resultado = 0;

            switch (operador)
            {   
                case "+":
                    {
                        resultado = Suma.Operar(operandoUno, operandoDos);
                        break;
                    }
                case "-":
                    {
                        resultado = Suma.Operar(operandoUno, -operandoDos);
                        break;
                    }
                case "*":
                    {
                        resultado = Multiplicacion.Operar(operandoUno, operandoDos);
                        break;
                    }
                case "/":
                    {
                        resultado = Division.Operar(operandoUno, operandoDos);
                        break;
                    }

            }
            return resultado;
        }
    }
}
