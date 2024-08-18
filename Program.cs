





List<string> isimler = new List<string>();


Console.WriteLine("EN SEVDİĞİN 0 5 KAHVE.. BAŞLIYORUZ");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"En sevdiğiniz {i + 1}. kahve çeşidi");
    string kahve = Console.ReadLine();
    isimler.Add(kahve);
}

Console.WriteLine("İşte o favori kahvelerin aşşağıda \n");
foreach (string item in isimler)
{
    Console.WriteLine(item);
}
