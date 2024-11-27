using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Threading;

namespace funciones
{
    class Program
    {
        public static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine(@"
1-CONSTRUIR UNA FUNCIÓN QUE SALUDE
2-FUNCION QUE RETORNE EL ULTIMO DIGITO
3-PAR O IMPAR
4-TABLA DE MULTIPLICACION
5-MAYOR DE LOS DOS DÍGITOS.
0- Salir");
                opcion = Convert.ToInt16(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        string nombre;
                        System.Console.Write("Ingrese su nombre: ");
                        nombre = (System.Console.ReadLine()!);
                        nombre_usario(nombre);
                        Console.ReadKey();
                        despedida(nombre);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        //2-CONSTRUIR UNA FUNCIÓN QUE RECIBA COMO PARÁMETRO UN ENTERO DE DOS DÍGITOS Y RETORNE SU ÚLTIMO DÍGITO
                        int numero_ingresado;
                        System.Console.WriteLine("Ingresa un numero: ");
                        numero_ingresado = Convert.ToInt16(Console.ReadLine()!);
                        Console.WriteLine($" El ultimo digito es: {div(numero_ingresado)} ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        // 3-CONSTRUIR UNA FUNCIÓN QUE RECIBA COMO PARÁMETRO UN NUMERO Y RETORNE UN MENSAJE DICIENDO SI ES PAR O IMPAR, SEGÚN SEA EL CASO.
                        Console.Clear();
                        int numero_ingresado2;
                        System.Console.WriteLine("ingrese el numero");
                        numero_ingresado2 = Convert.ToInt16(Console.ReadLine()!);
                        Console.WriteLine();
                        par_impar(numero_ingresado2);
                        break;
                    case 4:
                        // 4-CONSTRUIR UNA FUNCIÓN QUE RECIBA COMO PARÁMETRO UN ENTERO DE DOS DÍGITOS Y QUE ESTA FUNCIÓN GENERE Y MUESTRE EN PANTALLA LA TABLA DE MULTIPLICAR DEL PRIMER DÍGITO, SIENDO EL LÍMITE DE LA TABLA EL SEGUNDO DÍGITO.
                        int numero_ingresado3;
                        System.Console.WriteLine("Ingrese el numero: ");
                        numero_ingresado3 = Convert.ToInt16(Console.ReadLine());
                        tabla_multiplicar(numero_ingresado3);
                        break;
                    case 5:
                        // 5-CONSTRUIR UNA FUNCIÓN QUE RECIBA COMO PARÁMETRO UN ENTERO DE DOS DÍGITOS. LA FUNCIÓN DEBE RETORNAR EL MAYOR DE LOS DOS DÍGITOS.
                        int numero_ingresa4;
                        System.Console.WriteLine("Ingrese el  numero: ");
                        numero_ingresa4 = Convert.ToInt16(Console.ReadLine());
                        mayor_menor(numero_ingresa4);
                        break;
                }
            } while (opcion != 0);
        }
        // ejercicio 1
        static void nombre_usario(string nombre)
        {
            System.Console.WriteLine($"Hola {nombre}");
        }
        static void despedida(string nombre)
        {
            System.Console.WriteLine($"Adios {nombre}");
        }
        // ejercicio 2
        static int div(int numero_ingresado)
        {
            int digito2;
            digito2 = numero_ingresado % 10;
            return digito2;
        }
        // ejercicio 3
        static void par_impar(int numero_ingresado2)
        {
            if (numero_ingresado2 % 2 == 0)
            {
                System.Console.WriteLine($"{numero_ingresado2} es par");
            }
            else
            {
                System.Console.WriteLine($"{numero_ingresado2} es impar");
            }
        }
        //ejercicio4
        static void tabla_multiplicar(int numero_ingresado3)
        {
            int digito1, digito_2, multiplicacion;
            digito1 = numero_ingresado3 / 10;
            digito_2 = numero_ingresado3 % 10;
            for (int i = 0; i <= digito_2; i++)
            {
                multiplicacion = i * digito1;
                System.Console.WriteLine($"{digito1} * {i} = {multiplicacion}");
            }
        }
        static void mayor_menor(int numero_ingresado4)
        {
            int digito__1, digito__2;
            digito__1 = numero_ingresado4 / 10;
            digito__2 = numero_ingresado4 % 10;
            if (digito__1 > digito__2)
            {
                System.Console.WriteLine($"{digito__1} es mayor");
            }
            else if (digito__1 < digito__2)
            {
                System.Console.WriteLine($"{digito__2} es mayor");
            }
        }
    }
}

