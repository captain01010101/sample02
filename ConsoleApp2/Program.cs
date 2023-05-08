int[] array = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
int largestSum=0;
int sum = 0;

int startPosition = 0;
int endPosition = 0;
for (int x = 0; x < array.Length; x++)
{

    for (int y = x; y < array.Length - x; y++)
    {
        if (y > x)
        {
            //sum += array[x];
            for (int p = x; p <= y; p++)
            {
                sum += array[p];
            }

            if (sum > largestSum)
            {
                startPosition = x;
                endPosition = y;
                largestSum = sum;
            }
            sum = 0;
        }
    }

}

Console.WriteLine("startPosition: " + startPosition);
Console.WriteLine("endPosition: " + endPosition);

Console.WriteLine("Largest sum: " + largestSum);
Console.WriteLine("Subarray: [" + string.Join(", ", array.Skip(startPosition).Take(endPosition - startPosition + 1)) + "]");