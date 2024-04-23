

List<string> itens = new List<string>();

int quantidade = 3;

// TODO: Solicite os itens ao usuário
for (int contador = 0; contador < quantidade; contador++)
{
    string ? item = Console.ReadLine();
    itens.Add(item: item);

}

// Exibe a lista de itens
Console.WriteLine("Lista de itens:");
foreach (string item in itens)
{
    Console.WriteLine($"- {item}");
}



// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");
// listaString.Add("RS");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("BA");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");




// for(int contador = 0; contador < listaString.Count; contador++) {
//       Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
// }

// int contadorForeach = 0;
// foreach(string item in listaString) {
//       Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
//       contadorForeach++;
// }







// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 56;
// arrayInteiros[1] = 6;
// arrayInteiros[2] = 34;

// Console.WriteLine(arrayInteiros[2]);

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];

// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// for (int contador = 0; contador < arrayInteiros.Length; contador++) {
//       Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }

// int contadorForeach = 0;
// foreach(int valor in arrayInteiros) {
//       Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
//       contadorForeach++;
// }



// int numero = 0;
// do {
//       Console.WriteLine("Numbers");
//       numero = Convert.ToInt32(Console.ReadLine());

// }
// while(numero !=0);
//       Console.WriteLine($"{numero}");
