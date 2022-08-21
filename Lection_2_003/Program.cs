int[] array = { 11, 21, 31, 4, 18, 15, 16, 17, 18 };
int n = array.Length;

int find = Convert.ToInt32(Console.ReadLine());
//int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
