int solution(int[] inputArray)
{
    int r = inputArray[0] * inputArray[1];
    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        if (inputArray[i] * inputArray[i + 1] >= r)
        {
            r = inputArray[i] * inputArray[i + 1];
        }
    }
    return r;


}


int[] test = { -23, 4, -3, 8, -12 };
Console.WriteLine(solution(test));
