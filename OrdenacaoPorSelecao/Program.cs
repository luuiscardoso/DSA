namespace OrdenacaoPorSelecao
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 5, 3, 6, 2, 10 };
            var listaOrdenada = OrdenarSelecao(nums);

            foreach (int num in listaOrdenada)
            {
                Console.WriteLine(num.ToString());
            }
        }

        static int Menor(List<int> nums)
        {
            int menor = nums[0];
            int indiceMenor = 0;

            for(int i = 1; i < nums.Count; i++)
            {
                if (nums[i] < menor)
                {
                    menor = nums[i];
                    indiceMenor = i;
                }
            }

            return indiceMenor;
        }

        // [5, 3, 6, 2, 10]
        static List<int> OrdenarSelecao(List<int> nums)
        {
            List<int> novaLista = new List<int>(nums.Count);
            int t = nums.Count;

            for (int i = 0; i < t; i++)
            {
                int indiceMenor = Menor(nums);
                novaLista.Add(nums[indiceMenor]);
                nums.Remove(nums[indiceMenor]);
            }

            return novaLista;
        }
    }
}
