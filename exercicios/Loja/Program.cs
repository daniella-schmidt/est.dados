Dictionary<string, string> dictionaty = new Dictionary<string, string>()
{
    {"4512556", "A5"},
    {"4512559", "A5"},
    {"4512553", "A5"},
    {"4512551", "A5"},

    {"4512552", "C6"},
    {"6458668", "C6"},
    {"4512554", "C6"},
    {"4512555", "C6"},

    {"5789356", "C3"},
    {"5789357", "C3"},
    {"5789353", "C3"},
    {"5789355", "C3"},
    {"5789359", "C3"}
};

CarregarProdutos(produtos);

Console.Write("Codigo: ");
string codigo = Console.ReadLine();

string loc;
if (produtos.TryGetValue(codigo ))