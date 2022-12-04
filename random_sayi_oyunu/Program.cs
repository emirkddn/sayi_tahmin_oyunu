Console.WriteLine("Zorluk derecesini seçiniz(easy,normal,hard):");
string secim1 = Convert.ToString(Console.ReadLine());
if (secim1 == "easy")
{
    Console.WriteLine("3 tahmin hakkınız var.");
    Random rnd = new Random();
    int RastgeleSayi2 = rnd.Next(11);
    Console.WriteLine("Bilgisayar 0'dan 10'a kadar bir sayı tuttu.");
    for (int i = 3; 0 < i ; i--)
    {
        Console.Write("Tahmininiz: ");
        int tahminEasy = Convert.ToInt32(Console.ReadLine());

        if ((RastgeleSayi2 - 1) == tahminEasy) 
        {
            Console.WriteLine("Tahmininiz Doğru!");
            Console.ReadLine();
            break;
        }
        else if ((RastgeleSayi2 - 1) > tahminEasy)
        {
            if ((i - 1) == 0)
            {
                Console.WriteLine("Hakkınız bitti. "+"Cevap: "+RastgeleSayi2);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Daha büyük. "+(i-1)+" tahmin hakkınız kaldı.");
            }
        }
        else if ((RastgeleSayi2-1)<tahminEasy)
        {
            if ((i - 1) == 0)
            {
                Console.WriteLine("Hakkınız bitti. " + "Cevap: " + RastgeleSayi2);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Daha küçük. " + (i - 1) + " tahmin hakkınız kaldı.");
            }
        }      
    }
}
else if (secim1 == "normal")
{
    Random rnd = new Random();
    int RastgeleSayi3 = rnd.Next(21);
    Console.WriteLine("Bilgisayar 0'dan 20'a kadar bir sayı tuttu.");
    for (int i = 5; 0 < i; i--)
    {
        Console.Write("Tahmininiz: ");
        int tahminNormal = Convert.ToInt32(Console.ReadLine());

        if ((RastgeleSayi3 - 1) == tahminNormal)
        {
            Console.WriteLine("Tahmininiz Doğru!");
            Console.ReadLine();
            break;
        }
        else if ((RastgeleSayi3 - 1) > tahminNormal)
        {
            if ((i - 1) == 0)
            {
                Console.WriteLine("Hakkınız bitti." + "Cevap: " + RastgeleSayi3);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Daha büyük. " + (i - 1) + " tahmin hakkınız kaldı.");
            }
        }
        else if ((RastgeleSayi3-1) < tahminNormal)
        {
            if ((i - 1) == 0)
            {
                Console.WriteLine("Hakkınız bitti." + "Cevap: " + RastgeleSayi3);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Daha küçük. " + (i - 1) + " tahmin hakkınız kaldı.");
            }
        }
    }
}
else if (secim1 == "hard")
{
    Random rnd = new Random();
    int RastgeleSayi4 = rnd.Next(11);
    Console.WriteLine("Bilgisayar 0'dan 30'a kadar bir sayı tuttu.");
    for (int i = 7; 0 < i; i--)
    {
        Console.Write("Tahmininiz: ");
        int tahminHard = Convert.ToInt32(Console.ReadLine());

        if ((RastgeleSayi4 - 1) == tahminHard)
        {
            Console.WriteLine("Tahmininiz Doğru!");
            Console.ReadLine();
            break;
        }
        else if ((RastgeleSayi4 - 1) > tahminHard)
        {
            if ((i - 1) == 0)
            {
                Console.WriteLine("Hakkınız bitti. " + "Cevap:" + RastgeleSayi4);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Daha büyük. " + (i - 1) + " tahmin hakkınız kaldı.");
            }
        }
        else if ((RastgeleSayi4-1) < tahminHard)
        {
            if ((i - 1) == 0)
            {
                Console.WriteLine("Hakkınız bitti. " + "Cevap:" + RastgeleSayi4);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Daha küçük. " + (i - 1) + " tahmin hakkınız kaldı.");
            }
        }
    }
}
else
{
    Console.WriteLine("HATA!");
    Console.ReadLine();
}