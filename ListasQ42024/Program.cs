
List<string> listaString = new List<string>();
//listaString.Clear(); //Limpia el objeto de la lista
//listaString.Capacity = 1; //Establece el limite de la lista
//listaString.Remove("1"); //Elimina un elemento de la lista en específico
//listaString.RemoveAt(0); //Elimina un elemento de la lista al establecer un indice de la lista
//listaString.RemoveAll(lista => lista.Contains("Real")); //Elimina todos los elementos de la lista que contengan la palabra Real
//listaString.RemoveAll(lista => lista.Equals("Barcelona")); //Elimina todos los elementos de la lista que sean igual a la palabra Barcelona
//listaString.RemoveAll(lista => lista.Contains("Real") || lista.Equals("1")); //Elimina todos los elementos de la lista que contengan la palabra Real o sean iguales a 1
listaString.Add("Juan Perez");
listaString.Add("Real Juventud");
listaString.Add("Naranja");
listaString.Add("Real Madrid");
listaString.Add("Barcelona");
listaString.Add("Lempira Real");
listaString.Add("Real San Pedro");
listaString.Add("Santa Maria del Real");
listaString.Add("Real España");
listaString.Add("Madrid Real");
listaString.Add("1");
listaString.Add(2.ToString());
listaString.Add("4.2");
listaString.Add("España de Real la Azura");

Console.WriteLine($"listaString ({listaString.Count}):");
foreach (string str in listaString)
{
    Console.WriteLine(str);
}
Console.WriteLine();

List<int> listaInt = new List<int>() {
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20
};

Console.WriteLine($"listaInt ({listaInt.Count}):");
foreach (int i in listaInt)
{
    Console.WriteLine(i);
}

