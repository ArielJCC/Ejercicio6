/*Modificar el programa anterior para que, en lugar de leer 8 números, se puedan leer tantos números como se quiera hasta que llegue un cero.
 El resultado es la suma de todos los números leídos.*/

internal class Program
{
    private static void Main(string[] args)
    {
        int num = 1; int suma = 0; int i = 1;

        while(num != 0)
        {
            Console.WriteLine("Digite cualquier número");
            num = int.Parse(Console.ReadLine());

            suma = suma + num;            
        } 
        Console.WriteLine("Finalizado");
        Console.WriteLine("El resultado de la suma de los números leídos es: "+suma);
    }
}