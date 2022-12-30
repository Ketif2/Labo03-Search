namespace Prueba;
class sequentialSearch{
    static void MainSS(string[] args)
    {

        int aciertos = 0, fallos = 0, total = 0;
        double pAciertos, Pfallos;
        Random aleatorio = new Random(); //Aleatorio
        int [] arreglo = new int [100];
        int [] busqueda = new int [50];
        //Llenamos
        for (int i = 0; i < arreglo.Length; i++)
        {
            arreglo[i] = aleatorio.Next(1,200); //Llenamos con aleatorios
        }
        for (int j = 0; j < busqueda.Length; j++)
        {
            busqueda[j] = aleatorio.Next(1,200);//Llenamos con aleatorio
        }

        //Busqueda
        for (int i = 0; i < busqueda.Length; i++)
        {
            int aux = BusquedaLineal(arreglo, arreglo.Length, busqueda[i]);//Compuesto
            if (aux != -1){
                aciertos++;
            }else{
                fallos++;
            }
        }

        //Despliegue
        total = aciertos+fallos; // Suma 
        Console.WriteLine("Busquedas con exito: "+aciertos+" \nBusquedas con fallos: "+fallos);
        pAciertos = (double)aciertos/total;
        Pfallos = (double) fallos/total;
        Console.WriteLine("Porcentaje de exito: "+pAciertos*100+"% \nPorcentaje de fallo: "+Pfallos*100+"%");
        Array.Sort(arreglo);
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.Write(arreglo[i]+ ", ");
        }
    }

    static int BusquedaLineal(int[] A, int n, int clave)
    {
        for (int i = 0; i < n; i++)
            if (A[i] == clave)
                return i;
        return -1;
    }
}
