#region elementlerincemi
int cem = 0;
int[] numbers = { 10, 20, 30, 40, 50 };
foreach (int number in numbers)
{

    cem += number;
}
Console.WriteLine(cem);
#endregion

#region 10 dan boyuk ededler
int count = 0;
int[] numbers = { 2, 5, 7, 11, 26, 37, 56 };
foreach (int i in numbers)
{
    if (i > 10) { count++; }

}
Console.WriteLine(count);
#endregion



#region ededi orta
int result = 0;

int[] numbers = { 2, 5, 11, 6 };
for (int i=0; i < numbers.Length; i++)
{
   result += numbers[i];

}

Console.WriteLine(result/numbers.Length);
#endregion




#region fesil
string month = Console.ReadLine();
string[] months = { "yanvar", "fevral", "mart", "aprel", "may", "iyun", "iyul", "avqust", "sentyabr", "oktyabr", "noyabr", "dekabr" };

for (int i=0; i<months.Length; i++)
{
  if(month=="yanvar" || month=="fevral" || month == "dekabr")
 {
     Console.WriteLine("qis ayidir");
      break;
 }
   if(month == "mart" || month == "aprel" || month == "may")
  {
      Console.WriteLine("yaz ayidir");
       break;
   }
   if(month == "iyun" || month == "iyul" || month == "avqust")
   {
       Console.WriteLine("yay ayidir");
       break;
    }
}
#endregion