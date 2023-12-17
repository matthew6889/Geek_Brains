﻿//Дан класс(ниже), создать методы создающий этот класс вызывая один из его конструкторов (по одному конструктору на метод).
//Задача не очень сложна и служит больше для разогрева перед следующей задачей.


//Напишите 2 метода использующие рефлексию
//1 - сохраняет информацию о классе в строку
//2- позволяет восстановить класс из строки с информацией о методе
//В качестве примере класса используйте класс TestClass.
//Шаблоны методов для реализации:
//static object StringToObject(string s) { }
//static string ObjectToString(object o) { }
//Подсказка:
//Строка должна содержать название класса, полей и значений
//Ограничьтесь диапазоном значений представленном в классе
//Если класс находится в тоже сборке (наш вариант) то можно не указывать имя сборки в паремтрах активатора.
//Activator.CreateInstance(null, “TestClass”) -сработает;
//Для простоты представьте что есть только свойства. Не анализируйте поля класса.
//Пример того как мог быть выглядеть сохраненный в строку объект:
//“TestClass, test2, Version = 1.0.0.0, Culture = neutral, PublicKeyToken = null:TestClass | I:1 | S:STR | D:2.0 |”
//Ключ - значения разделяются двоеточием а сами пары - вертикальной чертой.
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace Home_work
{
    internal class Program
    {
        public static TestClass MakeTrstclass()
        {
            Type testclass = typeof(TestClass);
            return Activator.CreateInstance(testclass) as TestClass;
        }

        public static TestClass MakeTrstclass(int i)
        {
            Type testclass = typeof(TestClass);
            return Activator.CreateInstance(testclass, new object[] {i}) as TestClass;
        }

        public static TestClass MakeTrstclass(int i, string s, decimal d, char[] c)
        {
            Type testclass = typeof(TestClass);
            return Activator.CreateInstance(testclass, new object[] {i, s, d, c}) as TestClass;
        }

        public static string ObjectToString(object o)
        {
            Type type = o.GetType();
            StringBuilder res = new StringBuilder();
            res.Append(type.AssemblyQualifiedName + ";");
            res.Append(type.Name + '|');
            var prop = type.GetProperties();
            foreach (var item in prop)
            {
                var temp = item.GetValue(o);
                res.Append(item.Name + ':');
                if (item.PropertyType == typeof(char[]))
                {
                    res.Append(new string(temp as char[]) + '|');
                }
                else
                {
                    res.Append(temp);
                    res.Append('|');
                }

            }
            return res.ToString();
        }

        static object StringToObject(string s)
        {
            string[] arr = s.Split("|");
            string[] arr1 = arr[0].Split(":");
            //var assembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(a => a.FullName == arr1[0]);
            //var type = assembly.GetTypes().FirstOrDefault(t => t.FullName == arr1[1]);
            object some = Activator.CreateInstance(null, arr1[0].Split(",")[0]);
            if (arr.Length > 1 && some != null)
            {
                var type = some.GetType();
                for (int i = 1; i < arr.Length; i++)
                {
                    string[] nameAndValue = arr[i].Split(":");
                    var p = type.GetProperty(nameAndValue[0]);
                    if(p == null) 
                    {
                        continue;
                    }
                    if (p.PropertyType == typeof(int))
                    {
                        p.SetValue(some, int.Parse(nameAndValue[1]));
                    }
                    else if (p.PropertyType == typeof(string))
                    {
                        p.SetValue(some, nameAndValue[1]);
                    }
                    else if (p.PropertyType == typeof(decimal))
                    {
                        p.SetValue(some, decimal.Parse(nameAndValue[1]));
                    }
                    else if (p.PropertyType == typeof(char[]))
                    {
                        p.SetValue(some, nameAndValue[1].ToCharArray());
                    }
                }
            }
            return some;
        }


        static void Main(string[] args)
        {
            //var n1 = MakeTrstclass();

            //var n2 = MakeTrstclass(5);

            char[] somearr = new char[] { 'a', 'g', 'f'};

            var n3 = MakeTrstclass(6, "что-то", 1, somearr);

            string some = ObjectToString(n3);
            Console.WriteLine(some);

            var some1  = StringToObject(some);
            Console.WriteLine(some1);

        }
    }
}