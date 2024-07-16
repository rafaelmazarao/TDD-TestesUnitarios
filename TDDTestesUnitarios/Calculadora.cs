using System;
using System.Collections.Generic;
using System.Text;

namespace TDDTestesUnitarios
{
    public class Calculadora
    {
        private List<string> lstHistorico = new List<string>();
        private string data;

        public Calculadora(string Data) 
        {
            lstHistorico = new List<string>();
            this.data = Data;
        }

        public int somar(int val1, int val2)
        {
            int resultado = val1 + val2;
            lstHistorico.Add(resultado.ToString() + data);
            return resultado;
        }

        public int subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;
            lstHistorico.Add(resultado.ToString() + data);
            return resultado;
        }

        public int multiplicar(int val1, int val2)
        {
            int resultado = val1 * val2;
            lstHistorico.Add(resultado.ToString() + data);
            return resultado;
        }

        public int dividir(int val1, int val2)
        {
            int resultado = val1 / val2;
            lstHistorico.Add(resultado.ToString() + data);
            return resultado;
        }

        public List<string> historico()
        {
            lstHistorico.RemoveRange(3, lstHistorico.Count - 3);
            return lstHistorico;
        }
    }
}
