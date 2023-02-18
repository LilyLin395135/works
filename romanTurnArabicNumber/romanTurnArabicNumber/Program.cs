var result = RomanNumberToArabic("XCIX");
Console.WriteLine(result);
//-----------------------------------
int RomanNumberToArabic(string romanNumber)
{
    var dic = new Dictionary<char, int>()
    {
        {'I',1 },
        {'V',5 },
        {'X',10 },
        {'L',50 },
        {'C',100 },
        {'D',500 },
        {'M',1000 }

    };

    char[] romanNoArray = romanNumber.ToCharArray();
    var result = 0;
    for (int i = 0; i < romanNoArray.Length; i++)
    {
        if (dic.ContainsKey(romanNoArray[i]))
        {
            int value = dic[romanNoArray[i]]; //學到dic裡面放key，他會直接跑value出來
            if (i < romanNoArray.Length - 1 && value < dic[romanNoArray[i + 1]])//值小於右邊的數字就變負數，最後一個數字沒有其他數字可以比一定是加
            {
                result -= value;
            }
            else
            {
                result += value;
            }
        }
        else
        {
            throw new KeyNotFoundException($"Invalid Roman numeral character:{romanNoArray[i]}");
            //Exception例外
        }
    }

}


