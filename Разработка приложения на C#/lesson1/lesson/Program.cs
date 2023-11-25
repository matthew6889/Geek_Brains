/*Доработать предыдущий класс реализовав методы вывода родителей, детей, братьев/сестер (включая двоюродных), бабушеки дедушек.
  Подумайте как лучше реализовать данные методы.*/
using lesson;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        FamelyMambers GrandFatherOne = new FamelyMambers()
        {
            FullName = "Петров Василий Иванович",
            Age = 74,
            Gender = Gender.men
        };
        FamelyMambers GrandFatherTwo = new FamelyMambers()
        {
            FullName = "Попов Валерий Владимирович",
            Age = 72,
            Gender = Gender.men
        };
        FamelyMambers GrandMotherOne = new FamelyMambers()
        {
            FullName = "Петрова Валентина Степанова",
            Age = 62,
            Gender = Gender.woman
        };
        FamelyMambers GrandMotherTwo = new FamelyMambers()
        {
            FullName = "Попова Анна Станиславовна",
            Age = 59,
            Gender = Gender.woman
        };
        FamelyMambers Father = new FamelyMambers()
        {
            FullName = "Петров Антон Василевич",
            Age = 50,
            Gender = Gender.men,
            Mother = GrandMotherOne,
            Father = GrandFatherOne
        };
        FamelyMambers Mother = new FamelyMambers()
        {
            FullName = "Попова Светлана Валерьевна",
            Age = 45,
            Gender = Gender.woman,
            Mother = GrandMotherTwo,
            Father = GrandFatherTwo
        };
        FamelyMambers Son = new FamelyMambers()
        {
            FullName = "Петров Михаил Антнович",
            Age = 25,
            Gender = Gender.men,
            Mother = Mother,
            Father = Father
        };

        var FatherParents = Son.GetFatherParentsName();
        var FatherMother = Son.GetMotherParentsName();
        var Parents = Son.GetSonParentsName();

        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine($"{FatherParents[0]?.FullName} + {FatherParents[1]?.FullName}  |  {FatherMother[0]?.FullName} + {FatherMother[1]?.FullName}");
        Console.WriteLine("            |                     |                                  |                            |");
        Console.WriteLine("            |----------|----------|                                  |---------------|------------|");
        Console.WriteLine("                       |                                                             |              ");
        Console.WriteLine($"             {Parents[0]?.FullName}                                     {Parents[1]?.FullName}");
        Console.WriteLine("                       |                                                             |");
        Console.WriteLine("                       |-------------------------------|-----------------------------|");
        Console.WriteLine("                                                       |");
        Console.WriteLine($"                                             {Son.FullName}\u263A");



        //Console.Write(FatherParents[0]?.FullName);
        //Console.Write(FatherParents[1]?.FullName);
        //Console.WriteLine(FatherMother[0]?.FullName);
        //Console.WriteLine(FatherMother[1]?.FullName);
        //Console.WriteLine(Parents[0]?.FullName);
        //Console.WriteLine(Parents[1]?.FullName);
        //Console.WriteLine(Son.FullName);



    }
}