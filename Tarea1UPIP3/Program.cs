using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1UPIP3
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //METODO PARA CADA TAREA CON MENU
            //UUSANDO DO WHILE


            //crear variable llamada opcion, usuario tiene que digitar
            int opcion = 0;
            do //primero ejecuta y luego evalua
            {
                //menu que siempre se ejecute y con while pregunte si quiere continuar
                Console.Clear();
                Console.WriteLine("1- Ejercicio 1");
                Console.WriteLine("2- Ejercicio 2");
                Console.WriteLine("3- Ejercicio 3");
                Console.WriteLine("4- Salir");
                Console.WriteLine("Digite una opcion");
                opcion = int.Parse(Console.ReadLine());
                //validacion 
                switch (opcion)
                {
                    case 1: Ejercicio1();
                        break;
                    case 2: Ejercicio2();
                        break;
                    case 3:Ejercicio3();
                        break;
                    case 4:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("opcion incorrecta"); break;
                        Console.ReadLine();
                }

            } while (opcion != 4); //primero evalua y luego ejecuta //programa ejecuta mientras opcion sea diff de 4


        }

        public static void Ejercicio1() {
            //1 camisa = no hay descuento
            //2-5 = 15% desc
            //5+ = 20% desc

            //variable para precio
            float precio = 0f;
            //variable para cantidad
            int cantidad;
        
            Console.WriteLine("digite el precio: ");
            precio=float.Parse(Console.ReadLine());
            Console.WriteLine("digite la cantidad de camisas: ");
            cantidad=int.Parse(Console.ReadLine());

            if (cantidad==1)
            {
                Console.WriteLine($"el precio de la camisa es de {cantidad*precio}");            
            } else
            if (cantidad>=2 && cantidad <=5)
            {
                Console.WriteLine($"el precio de la camisa es de {((precio-(precio*0.15f))*cantidad)}");
            }else
            if (cantidad >= 6)
            {
                Console.WriteLine($"el precio de la camisa es de {((precio - (precio * 0.20f)) * cantidad)}");
            }
            Console.ReadLine ();
        }


        public static void Ejercicio2() {

            //calcular promedio final
            //cantidad de entradas 11
            //% de quices, tareas y examenes
            //si promedio final es mayor a 70=aprobado
            //si promesio es mayor o igual a 50 pero menor que 70 es aplazado
            //si promedio es menor a 50 es reprobado

            float quiz1, quiz2, quiz3;
            String nombre;
            int carnet;

            Console.WriteLine("Bienvenid@ a su calculadora de notas. Por favor, Digite su nombre: ");
            nombre=Console.ReadLine();
            Console.WriteLine("Bienvenid@ a su calculadora de notas. Por favor, Digite su carnet: ");
            carnet = int.Parse(Console.ReadLine());
            Console.WriteLine("Bienvenid@ a su calculadora de notas. Por favor, Digite la nota del quiz #1: ");
            quiz1 = float.Parse(Console.ReadLine());
            Console.WriteLine(" Por favor, Digite la nota del quiz #2: ");
            quiz2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" Por favor, Digite la nota del quiz #3: ");
            quiz3 = float.Parse(Console.ReadLine());
            Console.WriteLine(" Por favor, Digite la nota del quiz #2: ");

            //operacion suma quiz
           float sumaquices = (quiz1+quiz2+quiz3);
           float promedioquices = (sumaquices/3);
            float porcentajequices = (promedioquices * 25 / 100);
            float tarea1, tarea2, tarea3;
          
            Console.WriteLine(" Por favor, ahora Digite la nota de las tareas, empezando con la tarea #1: ");
            tarea1 = float.Parse(Console.ReadLine());
            Console.WriteLine(" Por favor, Digite la nota de la tarea #2: ");
            tarea2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" Por favor, Digite la nota de la tarea #3: ");
            tarea3 = float.Parse(Console.ReadLine());
            

            //operacion suma tareas
            float sumatareas = (tarea1+tarea2+tarea3);
           float  promediotareas = (sumatareas / 3);
            float porcentajetareas = (promediotareas * 30 / 100);

         
            float examen1, examen2, examen3;
            Console.WriteLine(" Por favor, ahora Digite la nota de los examenes, empezando con la examen #1: ");
            examen1 = float.Parse(Console.ReadLine());
            Console.WriteLine(" Por favor, Digite la nota del examen #2: ");
            examen2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" Por favor, Digite la nota del examen #3: ");
            examen3 = float.Parse(Console.ReadLine());


            //operacion suma examenes
            float sumaexamenes = (examen1+examen2+examen3);
           float promedioexamenes = (sumaexamenes / 3);
            float porcentajeexamenes = (promedioexamenes * 45 / 100);

            float sumasporcentajes = (porcentajequices + porcentajetareas + porcentajeexamenes);
           

            if (sumasporcentajes >= 70)
            {
                Console.WriteLine($"Estimad@ Estudiante: {nombre} con carnet {carnet} Usted se encuentra aprobad@, su promedio final es de {sumasporcentajes} distribuido de la siguiente manera: % Quices: {porcentajequices}, % Tareas: {porcentajetareas}, % Examenes: {porcentajeexamenes}");
            } else if (sumasporcentajes == 69 || sumasporcentajes >= 50) {
                Console.WriteLine($"Estimad@ Estudiante: {nombre} con carnet {carnet} Usted se encuentra aplazado, su promedio final es de {sumasporcentajes} distribuido de la siguiente manera: % Quices: {porcentajequices}, % Tareas: {porcentajetareas}, % Examenes: {porcentajeexamenes}");
            } else if (sumasporcentajes < 50) {
                Console.WriteLine($"Estimad@ Estudiante: {nombre} con carnet {carnet} Usted se encuentra reprobado, su promedio final es de {sumasporcentajes} distribuido de la siguiente manera: % Quices: {porcentajequices}, % Tareas: {porcentajetareas}, % Examenes: {porcentajeexamenes}");

            }
            Console.ReadLine();

        }


        public static void Ejercicio3() {
            //10 productos o menos = $20 por unidad
            //10> productos = $15 por unidad 
            //indicar cantidad de articulos, precio y cantidad 

            //variable para precio
            float precio1 = 20f;
            float precio2 = 15f;
            //variable para cantidad
            int cantidad;


            Console.WriteLine("digite la cantidad de tulipanes que desea comprar: ");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad <= 10)
            {
                Console.WriteLine($"el precio total es de $ {cantidad * precio1}");
            }
            else
            if (cantidad >= 11)
            {
                Console.WriteLine($"el precio total es de $ {cantidad * precio2}");
            }
   
            Console.ReadLine();

        }


    }
}
