int x = 3;
int y = 3;
int z = 3;

int[,,] Arrayxyz = new int[x, y, z];
CreateArray(Arrayxyz);
WriteArray(Arrayxyz);

void WriteArray(int[,,] Arrayxyz)
{
    for (int i = 0; i < Arrayxyz.GetLength(0); i++)
    {
        for (int j = 0; j < Arrayxyz.GetLength(1); j++)
        {
            for (int k = 0; k < Arrayxyz.GetLength(2); k++)
            {
                Console.Write($"{Arrayxyz[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void CreateArray(int[,,] Arrayxyz)
{
    int[] temp = new int[Arrayxyz.GetLength(0) * Arrayxyz.GetLength(1) * Arrayxyz.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < Arrayxyz.GetLength(0); x++)
    {
        for (int y = 0; y < Arrayxyz.GetLength(1); y++)
        {
            for (int z = 0; z < Arrayxyz.GetLength(2); z++)
            {
                Arrayxyz[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

