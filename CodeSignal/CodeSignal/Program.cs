﻿//int solution(int[] inputArray)
//{
//    int r = inputArray[0] * inputArray[1];
//    for (int i = 0; i < inputArray.Length - 1; i++)
//    {
//        if (inputArray[i] * inputArray[i + 1] >= r)
//        {
//            r = inputArray[i] * inputArray[i + 1];
//        }
//    }
//    return r;


//}


//int[] test = { -23, 4, -3, 8, -12 };
//Console.WriteLine(solution(test));


//int solution(int n)
//{
//    int r = 0;
//    for (int i = 1; i < n; i++)
//    {
//        r += (2 * i - 1) * 2;
//    }
//    return r + (2 * n - 1);

//}

int solution(int[] statues)
{
    Array.Sort(statues);
    int counter = 0;
    for (int i = 0; i < statues.Length - 1; i++)
    {
        if (statues[i] - statues[i + 1] != -1)
        {
            for (int j = statues[i]; j - statues[i + 1] < -1; j++)
            { counter++; }

        }
    }
    return counter;

}