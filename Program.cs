List<int> numeros = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6, 7, 8, 9, 1, 5, 67, 3, 4 };

var numerosUnicos = numeros.Distinct();

Console.WriteLine("Números únicos da lista: ");
foreach (var  numero in numerosUnicos) {
    Console.WriteLine($" -  {numero}");
}
