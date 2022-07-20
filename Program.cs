//Console.WriteLine("Введите ваше имя");
//string username = Console.ReadLine();
//Console.Write("Привет ");
//Console.WriteLine(username);

//int number1 = 45;
//int number2 = 55;
//int number3 = 50;
//int result = (number1 + number2) / number3;
//Console.WriteLine(result);

//int numberA = new Random().Next(1,10);
//Console.WriteLine(numberA);
//int numberB = new Random().Next(1,10);
//Console.WriteLine(numberB);
//int resultA = numberA + numberB;
//Console.WriteLine(resultA);

//Console.WriteLine("введите имя пользователя");
//string username = Console.ReadLine();
//if (username == "Маша")
//{
  //   Console.WriteLine("Ура, это же Маша"); 
//}
//else
//{
  //  Console.WriteLine("Привет," +username);
    
//}

//int a =45;
//int b =23;
//int c = 67;
//int d = 56;
/*int f =48;
ytjtytj
kuyuyk
jjuyjuy
kukuyuk
*/
//int max = a;
//if(a > max) max = a;
//if(b > max) max = b;
//if(c > max) max = c;
//if(d > max) max = d;
//if(f > max) max = f;
  //  Console.WriteLine(max);
  


//int[] array = {11,21,31,41,15,6,17,18,19};
//array[0] =12;
//Console.WriteLine(array[7]);

//int[] array = {1,2,4,6,7,8,9,56,78,45,789,567,57};
//int n =array.Length;
//int find =789;
//int index =0;
//while (index < n)
//{
  //if(array[index] == find)
  //{
    //Console.WriteLine(index);
  //}
  //index++;
//}


 void Method2(string msg)
{
  Console.WriteLine("msg: привет Денис" );
}
Method2("");

void Method21(string msg,int count)
{
  int i =0;
  while (i < count)
  {
    Console.WriteLine(msg);
    i++;
  }
}
//Method21("Текст",count: 4);

int Method23()
{
  return DateTime.Now.Year;
}
int year = Method23();
Console.WriteLine(year); 

