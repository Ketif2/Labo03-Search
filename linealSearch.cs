using System.Diagnostics;
namespace Prueba;
class linealSearch
{
   static void Main(string[] args)
    {
       Stopwatch reloj = new Stopwatch();
       string time = DateTime.Now.ToString("h:mm:ss tt");
       int [] A = {-8, 4, 5, 9, 12, 18, 25, 40, 60, 80, 15, 12, 43, 30, 39, 22, 11, 17, 37, 28};
       Console.WriteLine("DESORDENADO: ");
       for (int i = 0; i <A.Length ; i++)
       {
        Console.Write($"A[{i}] = {A[i]}, ");
       }
       Array.Sort(A);
       Console.WriteLine("\nOrdenado: ");
       for (int i = 0; i < A.Length; i++)
       {
        Console.Write($"A[{i}] = {A[i]}, ");
       }
       Console.Write("\nIngrese dato a search: ");
       int search = Convert.ToInt32(Console.ReadLine());
       reloj.Start();
       time = DateTime.Now.ToString("h:mm:ss tt");
       Console.WriteLine("La hora inicial es: {0}", time);
       int posicionEncontrada = BusquedaBinaria(A,A.Length,search);
       if (posicionEncontrada != -1){
            Console.WriteLine($"Elemento encontrado en la posicion: A[{posicionEncontrada}]={A[posicionEncontrada]}");
       }else{
            Console.WriteLine("Elemento no encontrado");
       }
       time = DateTime.Now.ToString("h:mm:ss tt");
       Console.WriteLine("La hora final: {0}", time);
       reloj.Stop();
       Console.WriteLine($"Tiempo de ejecución:{reloj.Elapsed.TotalMilliseconds} ms");

    }

    static int BusquedaBinaria(int[] lista, int n, int clave)
    {
        int central, bajo = 0, alto = n - 1;
        int valorCentral;
        while (bajo <= alto)
        {
            central = (bajo+alto)/2;
            valorCentral = lista[central];
            if (lista[central] == clave)
            {
                return central;
            }else if (clave < lista[central]){
                alto = central-1;
            }else{
                bajo = central+1;
            }
        }
        return -1;
    }

}