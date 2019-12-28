using System;

namespace CalculoTabelaPreco
{
    class CalculoPreco
    {
        double Total;
        double CachorroQuente = 4.0;
        double XSalada = 4.5;
        double XBacon = 5.0;
        double TorradaSimples = 2.0;
        double Refrigerante = 1.5;

        public double CalculoCachorroQuente (int vQtd)
        {
            return CachorroQuente * vQtd;
        }
        public double CalculoXsalada(int vQtd)
        {
            return XSalada * vQtd;
        }
        public double CalculoXBacon(int vQtd)
        {
            return XBacon * vQtd;
        }
        public double CalculoTorradaSimples(int vQtd)
        {
            return TorradaSimples * vQtd;
        }
        public double CalculoRefrigerante(int vQtd)
        {
            return Refrigerante * vQtd;
        }
    }
}
