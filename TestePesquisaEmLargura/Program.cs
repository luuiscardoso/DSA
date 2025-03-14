namespace TestePesquisaEmLargura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Dictionary<string, List<string>> grafo = new Dictionary<string, List<string>>();

                grafo["voce"] = new List<string> { "alice", "bob", "claire" };
                grafo["bob"] = new List<string> { "angy", "peggy", "voce" };
                grafo["alice"] = new List<string> { "peggy" };
                grafo["claire"] = new List<string> { "tom", "jonny" };
                grafo["angy"] = new List<string>();
                grafo["peggy"] = new List<string>();
                grafo["tom"] = new List<string>();
                grafo["jonny"] = new List<string>();

                Queue<string> rede = new Queue<string>();
                List<string> verificados = new List<string>();

                void AddFila(List<string> valorGrafo)
                {
                    foreach (var pessoa in valorGrafo)
                    {
                        rede.Enqueue(pessoa);
                    }
                }

                AddFila(grafo["voce"]);

                while (rede.Count > 0)
                {
                    var pessoa = rede.Dequeue();


                    if (!verificados.Contains(pessoa))
                    {
                        if (EhVendedor(pessoa))
                        {
                            Console.WriteLine($"{pessoa} é vendedor de manga");
                            break;
                        }
                        else
                        {
                            AddFila(grafo[pessoa]);
                            verificados.Add(pessoa);
                        }
                    }
                }
            }


            static bool EhVendedor(string pessoa)
            {
                char ultimaLetra = pessoa[pessoa.Length - 1];
                if (ultimaLetra == 'm')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

           
        }
    }
}
