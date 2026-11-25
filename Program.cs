Console.Write("Adet Giriniz:");
int adet = Convert.ToInt32(Console.ReadLine());

int a = 0, b = 1;
for (int i =0; i<adet; i++)
{
    Console.Write(a + " ");
    int toplam = a+b;
    a = b;
    b = toplam;
}