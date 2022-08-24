using System;
using System.Threading;

namespace ExpendedoraBase
{
    class Expendedora
    {
        string marca;//atributos
        byte temperatura;
        string codigo;
        float precio;

        public Expendedora()
        {
            saludar();
            marca = "AMS";
            Console.Write("Marca : " + marca);
            ControlarTiempoDisplay();
            temperatura = 14;
            Console.Write( " Temperatura : " +  temperatura + "°C");
            ControlarTiempoDisplay();
            codigo = MostrarCodigoDeProducto();
            ControlarTiempoDisplay();
            MostrarPrecio(codigo);
        }
        
        void ControlarTiempoDisplay()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }

        void saludar()
        {
            Console.WriteLine(" Bienvenido ");

        }

        string MostrarCodigoDeProducto()
        {
            Console.WriteLine("A1: Kinder Delice \tB2: Takis \tC3: Donitas");
            Console.WriteLine("Ingresa el codigo del producto que gustes");
            string codigo = Console.ReadLine();  //Variable de tipo local , nombrar 2 variables iguales 
            return codigo;
        }
        void MostrarPrecio(string codigo)
        {
         switch (codigo)
            {
                case "A1":
                    break;
                    Console.WriteLine("El precio es: {0}", precio);
                case "B2":
                    break;
                    Console.WriteLine("El precio es: {0}", precio);
                case "C3":
                    break;
                    Console.WriteLine("El precio es: {0}", precio);
                default:
                    Console.WriteLine("Producto no reconocido");
                    break;
            }
        }
    }
}
