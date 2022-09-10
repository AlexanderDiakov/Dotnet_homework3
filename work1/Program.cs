Console.WriteLine("Введите число ");
string number = Convert.ToString(Console.ReadLine());

bool CheckPalindrome(string num)
{
    string sNum = num.ToString();
    for (int i = 0; i < sNum.Length; i++)
        if (sNum[i] != sNum[sNum.Length - 1 - i]) return false;

    return true;
}
Console.WriteLine(CheckPalindrome(number));
