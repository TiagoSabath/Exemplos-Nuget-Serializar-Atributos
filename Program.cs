using ExemplosNuget.Models;
using Newtonsoft.Json;

DateTime dataAtual = DateTime.Now;

List<Venda> listaVenda = new List<Venda>();

Venda V1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
Venda V2 = new Venda(2, "Licença de Software", 125.00M, dataAtual);

listaVenda.Add(V1);
listaVenda.Add(V2);

string serializado = JsonConvert.SerializeObject(listaVenda, Formatting.Indented);

File.WriteAllText("Arquivos/venda.json", serializado);

Console.WriteLine(serializado);


//----------Deserializando --------

string conteudoAquivo = File.ReadAllText("Arquivos/venda.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoAquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}