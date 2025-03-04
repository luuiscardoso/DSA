// See https://aka.ms/new-console-template for more information
List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

var result = BuscaBinaria(nums, 2);
Console.WriteLine(result.ToString());

// [ 1, 2, 3, 4, 5 ]
static int BuscaBinaria(List<int> nums, int valor)
{
    int baixo = 0;
    int alto = nums.Count - 1; 

    while(baixo <= alto)
    {
        int meio = (baixo + alto) / 2; 
        if(valor == nums[meio])
        {
            return nums[meio];
        }

        if(valor < nums[meio])
        {
            alto = meio - 1;
        }

        if(valor > nums[meio])
        {
            baixo = meio + 1;
        }
    }

    return 0;
}
