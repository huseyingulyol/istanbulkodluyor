/*
    6) Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.
*/

//Replace
string name = "Hüseyin G.";
name = name.Replace("G.", "GÜLYOL");
Console.WriteLine(name.Replace("G.","GÜLYOL"));


//Replace
Console.WriteLine("n harfi " + (name.IndexOf('n') + 1) + ". sıradadır.");


//Substring
Console.WriteLine("Soyadı: " + name.Substring(7));


//ToUpper
Console.WriteLine("Büyük Harfli: " + name.ToUpper());

//ToLower
Console.WriteLine("Küçük Harfli: " + name.ToLower());