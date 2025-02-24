//crie um array e somw todos os elementos e exiba o resultado

int[] array = { 1, 2, 3, 4, 5 };
int total = 0;

foreach (int num in array)
{
    total += num;
}
Console.WriteLine(total);

// dada uma lista de string list
 List<string> nomes = new List<string> { "Jeane", "Wanderson", "Jeane", "Ryan", "Jeane" };
        int contagem = nomes.Count(nome => nome == "Jeane");
        Console.WriteLine();
        
 // Exercício 3: Remover elementos duplicados da lista de inteiro
   List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 2, 3, 4, 5 };
   numeros = numeros.Distinct().ToList();
   Console.WriteLine("Números sem duplicados: " + string.Join(", ", numeros));

  // Exercício 4: Verificar se "Banana" está no conjunto HashSet
  HashSet<string> frutas = new HashSet<string> { "Maçã", "Laranja", "Banana", "Uva", "Melão" };
  bool existeBanana = frutas.Contains("Banana");
  Console.WriteLine("A fruta 'Banana' existe no HashSet: " + existeBanana);


 // Exercício 5: Criar uma lista vazia e adicionar números de 1 a 5
 List<int> numerosNovos = new List<int>();
 for (int i = 1; i <= 5; i++)
 {
     numerosNovos.Add(i);
 }
 Console.WriteLine("Números adicionados à lista: " + string.Join(", ", numerosNovos));