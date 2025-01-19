C# Ejercicio 3
Descripción : Implementar el método de búsqueda en la clase lista, el cual debe retornar el número de veces que se encuentre un dato dentro de la lista. En caso de no encontrarse, el método debe mostrar un mensaje indicando que el dato no fue encontrado.
  // Método para buscar un valor y contar cuántas veces aparece
public int Buscar(int valor)
{
    int contador = 0;
    Nodo actual = cabeza;

    while (actual != null)
    {
        if (actual.Valor == valor)
        {
            contador++;
        }
        actual = actual.Siguiente;
    }

    if (contador == 0)
    {
        Console.WriteLine($"El dato {valor} no fue encontrado.");
    }

    return contador;
}
Ejercicio 4
Descripción : Crear una lista enlazada con 50 números enteros, del 1 al 999 generados aleatoriamente. Una vez creada la lista, se deben eliminar los nodos que estén fuera de un rango de valores leídos desde el teclado.
  // Generar 50 números aleatorios del 1 al 999
for (int i = 0; i < 50; i++)
{
    lista.Agregar(random.Next(1, 1000));
}

Console.WriteLine("Lista original:");
lista.Imprimir();

// Leer el rango de valores desde el teclado
Console.WriteLine("Ingrese el valor mínimo del rango:");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor máximo del rango:");
int max = int.Parse(Console.ReadLine());

// Eliminar nodos fuera del rango
lista.EliminarFueraDeRango(min, max);
Console.WriteLine("Lista después de eliminar nodos fuera del rango:");
lista.Imprimir();
