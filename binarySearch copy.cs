using System.Diagnostics;
using System;
namespace Prueba;
class binarySearch
{
    static int BusquedaBinaria(int[] A, int n, int clave){
        int bajo=0, alto=n-1, central=-1;
        bool encontrado = false;
        while ((bajo <= alto)&&(!encontrado))
        {
            central=(bajo+alto)/2;
            if (A[central]==clave)
            {
                encontrado = true;
            }else{
                
            }
        }
        return 0;
    }

    static int BusquedaLinealID(int[] A, int n, int clave){
        int i;
        for(i=0 ; i<n ; i++){
            if(A[i] == clave)
            return i;
        }
        return-1;
    }
    static void MainB(string[] args)
    {
        string datetime = DateTime.Now.ToString("hh:mm:ss tt");
        Console.WriteLine("INICIO Ejecucion: " + datetime);
        Console.Write("Algoritmo de Busqueda Lineal");
        int[] A = {79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24, 13,17,12,7,39,5,45,21};
        Console.WriteLine("El arreglo desordenado es: ");
        for (int i = 0 ; i<A.Length ; i++){
            Console.Write ($"A[{i}] = {A[i]}");
            }
        int posicionEncontrada = BusquedaLinealID(A, A.Length, 25);
        Console.WriteLine("Elemento encontrado en posicion: " + posicionEncontrada);
        datetime = DateTime.Now.ToString("hh:mm:ss tt");
        Console.WriteLine("FINAL Ejecucion: " + datetime);

    }
}