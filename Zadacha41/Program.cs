/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

string userString=ReadString("Введите числа через пробел: ");
char[] userStringArray = new char[userString.Length];
for(int i=0; i<userString.Length; i++)
{
    userStringArray[i] = userString[i];
}

if(userString[userString.Length-1]!= ' ')
{
    Array.Resize(ref userStringArray, userStringArray.Length+1);
    userStringArray[userStringArray.Length-1] = ' ';
}
int size = 0;
for (int i = 0; i < userStringArray.Length; i++)
{
    if(userStringArray[i]==' ')
    {
        size++;
    }
}

int[] numbers = new int [size];
string temp=String.Empty;
int j=0;
for (int i=0; i<userStringArray.Length; i++)
{
    if(userStringArray[i]!=' ')
    {
        temp+=userStringArray[i];
    }
    else
    {
        numbers[j] = Convert.ToInt32(temp);
        temp=String.Empty;
        j++;
    }
}

int count = 0;
for(int i=0; i<numbers.Length; i++)
{
    if(numbers[i] > 0) count++;
}    
Console.WriteLine(count);



string ReadString(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}