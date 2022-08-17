// Напишите программу, кот. выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке

void RandArray()
{
    int[] arr = new int[10];
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(0, 2);
            //Console.Write("{0} ", arr[i]);
        }
    }
        
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}

RandArray();
