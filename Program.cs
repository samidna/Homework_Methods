

//TASK-1   FindCharIndex

//static int FindCharIndex(string word, char ch)
//{
//    int row = 0;
//    for (int i = 0; i < word.Length; i++)
//    {
//        if (word[i]==ch)
//        {
//            row = i;
//        }
//    }
//    return row;
//} 

//Console.WriteLine(FindCharIndex("salam",'s'));


//TASK-2   CalcAvg

//static void CalcAvg(params int[] scores)
//{
//    int total = 0;
//    int count = 0;
//    for (int i = 0; i < scores.Length; i++)
//    {
//        total += scores[i];
//        count++;
//    }
//    if (total/count>60)
//    {
//        Console.WriteLine("Mezun oldunuz");
//    }
//    else
//    {
//        Console.WriteLine("Mezun ola bilmediniz");
//    }
//}

//CalcAvg(65, 65, 65, 65, 65, 20);


//TASK-3   IsPrime

//static void IsPrime(int number)
//{
//    int sum = 0;
//    for (int i = 2; i*i <= number; i++)
//    {
//        if (number%i == 0)
//        {
//            sum += i;
//        }
//        else
//        {
//            continue;
//        }
//    }
//    if (sum == 0)
//    {
//        Console.WriteLine("Number is prime");
//    }
//    else
//    {
//        Console.WriteLine("Number is not prime");
//    }
//}

//IsPrime(23);

//TASK-4   FindMax

static int FindMax(params int[] numbers)
{
	int max = 0;
	for (int i = 0; i < numbers.Length; i++)
	{
		if (numbers[i] > max)
		{
			max = numbers[i];
		}
	}
	return max;
}

Console.WriteLine(FindMax(15,78,56,57));

