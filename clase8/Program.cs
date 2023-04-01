using static System.Runtime.InteropServices.JavaScript.JSType;

void arreglos()
{
    string[] nombre = new string[]
    {
        "fernando","melvin","luis","brandon","yamileth"
    };

    int[] notas = new int[]
    {
        70,90,43,85,30
    };
    int n1 = 0;
    int mayor = 0;
    foreach (int a in notas)
    {
        if (a > mayor)
        {
            mayor = a;
            n1++;
            
        }

    }
    Console.WriteLine($"La nota mas alta es de: {nombre[n1-1]} con {mayor} puntos");
    
}
arreglos();
