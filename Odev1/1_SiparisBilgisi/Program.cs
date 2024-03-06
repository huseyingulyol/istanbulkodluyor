/*
    1) Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.
*/

while (true) //Projeye işlemden sonra tekrar başlaması için while döngüsü dahil ettim.
{
    Console.WriteLine("Çıkış yapmak için 'k'  yazınız! ");
    Console.Write("Sipariş numarasını giriniz: ");
    string? input = Console.ReadLine();
    int orderNo = -1;

    if (string.IsNullOrEmpty(input) || !int.TryParse(input, out orderNo)) //Eğer boşsa veya sayı girilmemişse;
    {
        if (input?.ToLower() == "k") break; //Eğer k girilmişse; Çıkış yap.
        Console.WriteLine("Hatalı giriş, lütfen bir numara belirtiniz!");
    }
    else
    {
        if (orderNo < 0) //Sipariş No. 0 dan küçük ise;
        {
            Console.WriteLine("Sipariş numarasını negatif olamaz!");

        } 
        else 
        {
            string itemName = string.Empty;
            switch (orderNo)
            {
                case 0:
                    itemName = "JBLT560bt Kulak Üstü Bluetooth Kulaklık";
                    break;
                case 1:
                    itemName = "Xiaomi Redmi Buds 3 Bluetooth Kulaklık Beyaz";
                    break;
                case 2:
                    itemName = "Xiaomi Redmi Watch 3 Active Akıllı Saat";
                    break;
                case 3:
                    itemName = "Mavi Logo Baskılı Siyah Tişört Slim Fit / Dar Kesim";
                    break;
                case 4:
                    itemName = "Parodontax Diş Eti + Diş Macunu 75 ml";
                    break;
                case 5:
                    itemName = "Puma Skye Clean";
                    break;
                default:
                    itemName = "Bu sipariş numarasına ait ürün yok!";
                    break;

            }

            Console.WriteLine($"\n------------SİPARİŞ SONUCU-----------------");
            Console.WriteLine($"Sipariş No:  {orderNo}\nÜrün Adı:  {itemName}");
            Console.WriteLine($"\nSipariş başarıyla tamamlandı!");
            Console.WriteLine($"---------------------------------------------");
        }

    }

    Console.WriteLine($"_____________________________________________________");

}

