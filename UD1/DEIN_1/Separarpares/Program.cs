using System;

namespace Separarpares
{
    class Program
    {
        /*Separar en 2 arrays los valores int que se encuentran en otro array en función de si son pares o
impares: pedir al usuario cuantos valores int va a utilizar y crear un array de int del tamaño
solicitado.Pedir al usuario que proporcione los valores del array y a continuación separar en otros 2
array los valores según sean pares o impares, mostrar el resultado*/

        static void Main(string[] args)
        {
            int[] arrayNumerosIngresadoPorElUsuario = new int[20];
            Random rnd = new Random();

            for (int i = 0; i < arrayNumerosIngresadoPorElUsuario.Length; i++)
            {
                arrayNumerosIngresadoPorElUsuario[i] = rnd.Next(1, 101);
            }

            int contadorPares = 0;
            int contadorImpares = 0;

            for (int i = 0; i < arrayNumerosIngresadoPorElUsuario.Length; i++)
            {
                if (arrayNumerosIngresadoPorElUsuario[i] % 2 == 0)
                    contadorPares++;
                else
                    contadorImpares++;
            }

            int[] pares = new int[contadorPares];
            int[] impares = new int[contadorImpares];

            int indicePares = 0;
            int indiceImpares = 0;

            for (int i = 0; i < arrayNumerosIngresadoPorElUsuario.Length; i++)
            {
                if (arrayNumerosIngresadoPorElUsuario[i] % 2 == 0)
                {
                    pares[indicePares] = arrayNumerosIngresadoPorElUsuario[i];
                    indicePares++;
                }
                else
                {
                    impares[indiceImpares] = arrayNumerosIngresadoPorElUsuario[i];
                    indiceImpares++;
                }
            }

            Console.WriteLine("Números generados: [" + string.Join(", ", arrayNumerosIngresadoPorElUsuario) + "]");
            Console.WriteLine("Números pares: [" + string.Join(", ", pares) + "]");
            Console.WriteLine("Números impares: [" + string.Join(", ", impares) + "]");

            Console.ReadLine();
        }
    }
}
