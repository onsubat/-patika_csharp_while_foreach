// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Şimdi sizlere while döngüsüyle hazırlanmış bir kod hazırlıyorummm..! ***");

//WHILE 

int a = 10;
int q = 0;
int toplam = 0;

while (q < a)
{
     Console.WriteLine("q değeri 0'dan 9'a birer birer artıyor, şu an ki q değeri : " + q);
     q++;
}
    Console.WriteLine("işte bu kadar, q değeri 9 oldu bile! Bir de bu sayıların toplamlarını adım adım gösterelim ...");

q=0;
while (q < a)
{
    Console.WriteLine("q değeri 0'dan 9'a birer birer artıyor, şu an ki q değeri : " + q);
    toplam += q;
    Console.WriteLine("toplama işleminin \"q\".adımındaki toplamı: " + toplam);
    q++;
}

Console.WriteLine();

Console.WriteLine("***Şimdi sırada FOREACHHH !***");

//FOREACH

string[] burak = {"bak","bir","varmış","bir","yokmuş"};

foreach (var sozler in burak)
{
    Console.WriteLine(sozler);
}