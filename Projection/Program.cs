using System;

namespace Projection
{
    class Program
    {
        static void Main(string[] args)
        {
          
          
            Console.WriteLine("Bienvenido al Sistema de Projection de notas de Programacion Estructurada");
            Console.WriteLine("-------------- MI NOMBRE ES: Carlos Jesus Burgos --------------");
            Console.WriteLine("-------------- MI MATRICULA ES: 17-MIIN-1-003 -----------------");
            Console.WriteLine("-------------- MI SECCION ES: 0463 ----------------------------");
            Console.WriteLine("---------------MI BOMBRE ES: Genesis Mota Feliz----------------");
            Console.WriteLine("---------------MI MATRICULA ES: 17-SIIN-1-177 -----------------");
            Console.WriteLine("---------------MI SECCION ES: 0463 ----------------------------");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------");



            Console.WriteLine("CALCULO DE CALIFICACIONES DE SECCION 0463");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("-------------------- RECUERDE PARA EMPEZAR---------------------");
            Console.WriteLine("LA ASISTENCIA VALE 10 PUNTOS");
            Console.WriteLine("LA PRACTICA VALE 20 PUNTOS");
            Console.WriteLine("EL EXAM.PARCIAL VALE 20 PUNTOS");
            Console.WriteLine("EL EXAM.FINALVALE 50 PUNTOS");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("");

           int ASIST, PRACT, PP, EXMF;
            int NOTAT;
            string linea;
 

            Console.WriteLine("Calificacion de asistencia:");
            linea = Console.ReadLine();
            ASIST = int.Parse(linea);

            Console.WriteLine("Calificacion de Practica:");
            linea = Console.ReadLine();
            PRACT= int.Parse(linea);

            Console.WriteLine("Calificacion de Primer Parcial:");
            linea = Console.ReadLine();
            PP=int.Parse(linea);

            Console.WriteLine("Calificacion de Examen Final:");
            linea = Console.ReadLine();
            EXMF =int.Parse(linea);

            NOTAT = ASIST + PRACT + PP + EXMF;

            Console.WriteLine("Tu calificacion es:" + NOTAT);

            if (NOTAT >= 70)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                if (NOTAT < 70)
                {
                    Console.WriteLine("Reprobado!");
                }
            }
            Console.ReadKey();
          
          
          
          
          
          
          
            
        }
    }
}
