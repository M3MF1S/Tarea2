using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2_tarea2_ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string id, name,tEm=" ";int op=0,bol=1,nTipo=0,eOpe=0,eTec=0,ePro=0; 
            double horas=0, aumento=0, pxh=0,salario=0,sBruto=0,sNeto=0,ccss=0,asnOP=0,asnTC=0,asnPR=0;

            Console.WriteLine(" Bienvenido Usuario");
            Console.WriteLine(" ");
            while (bol==1)
            {
                Console.WriteLine(" Digite el numero de cedula del empleado");
                Console.Write("--> ");
                name = Console.ReadLine();
                Console.WriteLine(" Digite el nombre del empleado");
                Console.Write("--> ");
                id = Console.ReadLine();
                Console.WriteLine(" Ingrese la cantidad de horas trabajadas por el empleado");
                Console.Write("--> ");
                horas =double.Parse(Console.ReadLine());
                Console.WriteLine("Cual es el precio de cada hora trabajada?");
                Console.Write("--> ");
                pxh =double.Parse(Console.ReadLine());
                Console.WriteLine(" -Digite el tipo de trabajador \n"+
                    "   1-Operario \n" +
                    "   2-Tecnico \n" +
                    "   3-Profesional\n");
                Console.Write("--> ");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                salario = horas * pxh;
                switch (op)
                {
                    case 1:
                        tEm = "Operario";
                        eOpe = eOpe + 1;
                        aumento=salario*0.15;
                        sBruto = salario + aumento;
                        ccss = sBruto * 0.0917;
                        sNeto = sBruto - ccss;
                        asnOP = asnOP + sNeto;
                        break;
                    case 2:
                        tEm = "Tecnico";
                        eTec = eTec + 1;
                        aumento = salario * 0.10;
                        sBruto = salario + aumento;
                        ccss = sBruto * 0.0917;
                        sNeto = sBruto - ccss;
                        asnTC = asnTC + sNeto;
                        break;
                    case 3:
                        tEm = "Profesional";
                        ePro = ePro + 1;
                        aumento = salario * 0.05;
                        sBruto = salario + aumento;
                        ccss = sBruto * 0.0917;
                        sNeto = sBruto - ccss;
                        asnPR = asnPR + sNeto;
                        break;
                        default: Console.WriteLine("Por favor seleccione un tipo de trabajador valido \n" +
                            "       Debera rellenar los datos denuevo"); Console.WriteLine(" ");break ;
                }
                if (op==1 || op==2 || op==3) {
                    Console.WriteLine
                    ("-------------FINAL DE TRANSACCION------------- \n" +
                    "       -Cedula: " + id + "\n" +
                    "       -Nombre del empleado: " + name + "\n" +
                    "       -Tipo de empleado: " + tEm + "\n" +
                    "       -Salario por Hora: " + pxh + "\n" +
                    "       -Cantidad de Horas: " + horas + "\n" +
                    "       -Salario Ordinario: " + salario + "\n" +
                    "       -Aumento: " + aumento + "\n" +
                    "       -Salario Bruto: " + sBruto + "\n" +
                    "       -Deduccion de CCSS: " + ccss + "\n" +
                    "       -Salario Neto: " + sNeto + " ");
                    Console.WriteLine("                 \n" +
                        "                               \n" +
                        "Presione Enter para continuar..");
                    Console.ReadLine();
                    Console.WriteLine("         Desea seguir ingresando datos? \n" +
                        "   (Digite 1 para seguir ingresando datos)\n" +
                        "   (Digite 0 para salir del programa");
                    Console.Write("-->  ");
                    bol = int.Parse(Console.ReadLine());
                    if (bol == 0) { Console.WriteLine("Saliendo del porgrama... Mostrando Estadisticas"); }
                }   

                
            }
            Console.WriteLine(" ");
            Console.WriteLine("     ----------------Estadisticas----------------");
            Console.WriteLine(" -> Cantidad Empleados Tipo Operarios "+(eOpe)+"\r\n" +
                "  ->Acumulado Salario Neto para Operarios "+asnOP +"\r\n" +
                "  ->Promedio Salario Neto para Operarios "+(asnOP/eOpe)+ "  \r\n" +
                "  ->Cantidad Empleados Tipo Técnico"+(eTec)+"\r\n" +
                "  ->Acumulado Salario Neto para Técnicos "+asnTC +"\r\n" +
                "  ->Promedio Salario Neto para Técnicos "+(asnTC/eTec)+ "\r\n" +
                "  ->Cantidad Empleados Tipo Profesional "+(ePro)+"\r\n" +
                "  ->Acumulado Salario Neto para Profesional "+asnPR +"\r\n" +
                "  ->Promedio Salario Neto para Profesionales "+ (asnPR / ePro)+"\r\n" +
                "   ");
            Console.ReadLine();

        }
    }
}
