namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = QuickSort(new List<int> { 5, 4, 3 });
            Console.WriteLine(string.Join(" ,", result));
        }

        // [] ou [ 1 ] - return array
        static List<int> QuickSort(List<int> nums)
        {
            //caso base
            if(nums.Count < 2)
            {
                return nums;
            }

            int pivo = nums[0];
            List<int> menores = new List<int>();
            List<int> maiores = new List<int>();

            for(int i = 1; i < nums.Count; i++)
            {
                if (nums[i] < pivo)
                {
                    menores.Add(nums[i]);
                } else
                {
                    maiores.Add(nums[i]);
                }
            }

            return QuickSort(menores).Concat(new List<int> {pivo}).Concat(maiores).ToList();

        } 
    }
}
