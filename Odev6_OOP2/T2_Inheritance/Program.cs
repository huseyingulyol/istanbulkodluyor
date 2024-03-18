//  2- inheritance ile ilgili 3 ayrı örnek yapınız.
//  Inheritance (kalıtım) bir sınıftan alt bir sınıf türetmektir. 

using T2_Inheritance;

#region Inheritance 1.Örnek
//  Aşağıdaki örnekte hayvan sınıfından cat ve fish sınıfı kalıtılmıştır.
//  Anlatılmak istenen: Hayvanların farklı özellikleri olduğundan ayrı sınıflar halinde türetebiliriz.
Cat cat = new Cat();
cat.Eat();
cat.Purr();
cat.Sleep();

Fish fish = new Fish();
fish.Eat();
fish.Swim();
fish.Sleep();
#endregion


#region Inheritance 2.Örnek
//  Aşağıdaki örnekte silah sınıfından sword ve gun sınıfları türetilmiştir.
//  Anlatılmak istenen: grafik oyunu yapıldığını düşünürsek karakterimizin silah seçebilme kabiliyetini bu şekilde belirleyebiliriz.
Sword sword = new Sword();
sword.Equip();
sword.Swing();

Gun gun = new Gun();
gun.Equip();
gun.Fire();
#endregion


#region Inheritance 3.Örnek
//  Aşağıdaki örnekte lesson sınıfından Mathematics, Science ve English sınıfları türetilmiştir.
// Anlatılmak istenen: Bir eğitim platformu tasarlanabilir ve bu şekilde dersler ayrılarak kod yazımı daha iyi hale getirilebilir.

Mathematics mathematics = new Mathematics();
mathematics.Listen();
mathematics.PrintMathQuestion();

Science science = new Science();
science.Listen();
science.PrintScienceQuestion();

English english = new English();
english.Listen();
english.PrintEnglishQuestion();

#endregion