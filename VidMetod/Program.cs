// Виды методов:
//1 вид:
// Ничего не принимает и ничего не возвращает.

void Metod1()
{
    Sistem.Console.WriteLine();
}
Metod1();

//2 вид:
//Принимают данные, но не возвращают.

void Metod2(string msg)
{
    Sistem.Console.WriteLine(msg);
}
Metod2("Текст сообщения");
//или
void Metod21(string msg, int count)
{
    int i = 0;
    while(i < count){
        Console.WriteLine(msg);
        i++;
    } 
    Sistem.Console.WriteLine(msg);
}
Metod21(msg: "Текст сообщения",count: 4);
/* Metod21(count: 4, msg: "Text"); */

//3 вид:
//Не принимают ничего, но возвращают.

int Metod3()
{
   return Data.Tame.Now.Year;
}
int year = Metod3();
Console.WriteLine(year);


//4 вид:
/* Принимают и возвращают. */

string Metod4(int count, string text)
{
   int i = 0;
   string result = string.Empty;

   while(i < count){
    result = result + text;
    i++;
   }
return result;
}
string res = Metod4(10, "Hello");
Console.WriteLine(res);