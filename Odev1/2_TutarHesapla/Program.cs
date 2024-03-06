/*
    2) Kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.
*/

string errorMessage = string.Empty;


while (true) //Projeye işlemden sonra tekrar başlaması için while döngüsü dahil ettim.
{
    Console.WriteLine("____________Tobeto AVM'ye hoşgeldin!________________");

    Console.WriteLine("*Çıkış yapmak için 'k' yazabilirsiniz.\n");
    if (!string.IsNullOrEmpty(errorMessage)) Console.WriteLine($"{errorMessage}");
    Console.WriteLine("Kaç adet ürün almak istersiniz?");

    string? input = Console.ReadLine();
    int itemCount = -1;

    if (string.IsNullOrEmpty(input) || ! int.TryParse(input, out itemCount)) //Eğer boşsa veya sayı girilmemişse;
    {
        if (input?.ToLower() == "k") break; //Eğer k girilmişse; Çıkış yap.
        errorMessage = "Hatalı giriş, lütfen bir adet belirtiniz!";
        Console.Clear();
        continue;
    }
    if (itemCount <= 0) //Sipariş No. 0 dan küçük ise;
    {
        errorMessage = "Ürün adedi pozitif olmalıdır!";
        Console.Clear();
        continue;
    }
    else
    {
        int totalPrice = 0;
        
        List<string> addedItems = new List<string>(); //Normalde tüm kodları OOP'ye uygun yapmak isterdim fakat fazla abartmamak lazım :)

        string[] itemNames = new string[6] {
                "1JBLT560bt Kulak Üstü Bluetooth Kulaklık - 1700 TL",
                "Xiaomi Redmi Buds 3 Bluetooth Kulaklık Beyaz - 890 TL",
                "Xiaomi Redmi Watch 3 Active Akıllı Saat - 1100 TL",
                "Mavi Logo Baskılı Siyah Tişört Slim Fit / Dar Kesim - 755 TL",
                "Parodontax Diş Eti + Diş Macunu 75 ml - 267 TL",
                "Puma Skye Clean - 680 TL" };

        for (int i = 0; i < itemCount; i++)
        {
            while (true) // For içerisindeyken hatalı girdiğinde devam etmemesi için for içinede while döngüsü koydum.
            {
                Console.WriteLine($"{i+1}. istediğiniz ürünün başındaki numarayı yazarak seçiniz.");
                Console.WriteLine($"[0] {itemNames[0]}");
                Console.WriteLine($"[1] {itemNames[1]}");
                Console.WriteLine($"[2] {itemNames[2]}");
                Console.WriteLine($"[3] {itemNames[3]}");
                Console.WriteLine($"[4] {itemNames[4]}");
                Console.WriteLine($"[5] {itemNames[5]}");
         
                input = Console.ReadLine();
                int itemNo = -1;

                if (string.IsNullOrEmpty(input) || !int.TryParse(input, out itemNo)) //Eğer boşsa veya sayı girilmemişse;
                {
                    if (input?.ToLower() == "k") break; //Eğer k girilmişse; Çıkış yap.
                    Console.WriteLine("Hatalı giriş, lütfen ürünlere ait bir numara seçiniz!");
                    continue;
                }

                addedItems.Add(itemNames[itemNo]);

                int itemPrice = 0;
                switch (itemNo)
                {
                    case 0:
                        itemPrice = 1700;
                        break;
                    case 1:
                        itemPrice = 890;
                        break;
                    case 2:
                        itemPrice = 1100;
                        break;
                    case 3:
                        itemPrice = 755;
                        break;
                    case 4:
                        itemPrice = 267;
                        break;
                    case 5:
                        itemPrice = 680;
                        break;
                }
                totalPrice += itemPrice;
                break;
            }

        }
        Console.Clear();
        Console.WriteLine($"\n------------ALIŞVERİŞ SONUCU-----------------");

        Console.WriteLine($"\nÜRÜN LİSTESİ**********************************");

        for (int i = 0; i < addedItems.Count; i++) 
        {
            Console.WriteLine($"{(i + 1)}. {addedItems[i]}");
        }
        Console.WriteLine($"\n**********************************************");
        Console.WriteLine($"Toplam Alışveriş tutarınız: {totalPrice} TL");
        Console.WriteLine($"Tobeto AVM'yi tercih ettiğiniz için teşekkürler!");
        Console.WriteLine($"_____________________________________________________");
    }

}

