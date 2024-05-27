using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2_tarea2_ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, id, faq, loc=" "; int localidad, lN = 0, lE = 0, lP = 0,dd=0,sistema=1;
            double entradas, subT = 0, serv = 0, total = 0, acumN = 0, acumE = 0, acumP = 0;

            while (sistema==1 && sistema!=0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Digite el numero de factura");
                faq = Console.ReadLine();
                Console.WriteLine("Digite la cedula del comprador ");
                id = Console.ReadLine();
                Console.WriteLine("Digite el nombre del comprador ");
                name = Console.ReadLine();
                do{
                    Console.WriteLine("-------Seleccione una localidad-------  \n" +
                        "   1- Sol Norte/Sur   \n" +
                        "   2- Sombra Este/Oeste   \n" +
                        "   3-Preferencial  ");
                    localidad = int.Parse(Console.ReadLine());
                    if ((localidad==1)||(localidad==2) || (localidad==3))
                    {
                        dd = 1;
                    }
                    else {
                    Console.WriteLine("   Localidad invalida, intente denuevo");
                    Console.WriteLine(" ");dd = 0;
                    } 
                } while (dd==0 );

                Console.WriteLine("Digite la cantidad de entradas (Max.4 entradas por cliente)");
                entradas = int.Parse(Console.ReadLine());
                while (entradas>4)
                {
                    if (entradas > 4) {
                        Console.WriteLine(" ");
                        Console.WriteLine(" Cantidad maxima de entradas por cliente 4, intente denuevo");
                        Console.WriteLine(" "); }
                    Console.WriteLine("Digite la cantidad de entradas (Max.4 entradas por cliente)");
                    entradas = int.Parse(Console.ReadLine());
                }
                switch (localidad)
                {
                    case 1:
                        loc = "Sol Norte/Sur";
                        subT = entradas * 10500;
                        serv = entradas * 1000;
                        lN ++;
                        total = subT+serv;
                        acumN = acumN + total;
                        break;
                    case 2:
                        loc = "Sombra Este/Oeste";
                        subT = entradas * 20500;
                        serv = entradas * 1000;
                        lE ++;
                        total = subT + serv;
                        acumE = acumE + total;
                        break;
                    case 3:
                        loc = "Preferencial";
                        subT = entradas * 25500;
                        serv = entradas * 1000;
                        lP ++;
                        total = subT + serv;
                        acumP = acumP + total;
                        break;
                }
                Console.WriteLine(" ");
                Console.WriteLine("Numero de Factura: " + faq + "\n" +
                    "Cedula: " + id + "\r\n" +
                    "Nombre comprador: " + name + "\r\n" +
                    "Localidad: "+loc+"\r\n" +
                    "Cantidad de Entradas: "+entradas+"\r\n" +
                    "Subtotal: "+subT+"\r\n" +
                    "Cargos por Servicios: "+serv+"\r\n" +
                    "Total a pagar: "+total+"\r\n");
                Console.WriteLine("                 \n" +
                        "                               \n" +
                        "Presione Enter para continuar..");
                Console.ReadLine();
                Console.WriteLine("         Desea seguir ingresando datos? \n" +
                    "   (Digite 1 para seguir ingresando datos)\n" +
                    "   (Digite 0 para salir del programa");
                sistema = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" ");
            Console.WriteLine(" Cantidad Entradas Localidad Sol Norte/Sur: "+lN+"  \r\n" +
                "Acumulado Dinero Localidad Sol Norte/Sur: "+acumN+"\r\n" +
                "Cantidad Entradas Localidad Sombra Este/Oeste: "+lE+" \r\n" +
                "Acumulado Dinero Localidad Sombra Este/Oeste: "+acumE+"\r\n" +
                "Cantidad Entradas Localidad Preferencial "+lP+" \r\n" +
                "Acumulado Dinero Localidad Preferencial: "+acumP+"\r\n");
            Console.ReadLine();
        }
    }
}
