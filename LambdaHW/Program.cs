using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaHW
{
    delegate string StrColDel (Color colour);
    class Program
    {
        enum Colours {White = 1, Black, Red, Green, Blue,Yellow,Purple};
        delegate void VoidVoidDel();
        delegate void ArrVoidDel(int[] arr);
        delegate int ArrIntDel(int[] arr);
        delegate bool StrBoolDel(string str, string substring);
        static void Main(string[] args)
        {
            #region #1  Создайте анонимный метод для получения RGB значения для цвета радуги. Цвет радуги передаётся в качестве параметра.Напишите код для тестирования работы метода
            //StrColDel mydel = delegate (Color colour)
            //{
            //    string rgb = "";
            //    rgb += colour.R.ToString();
            //    rgb += ",";
            //    rgb += colour.G.ToString();
            //    rgb += ",";
            //    rgb += colour.B.ToString();
            //    return rgb;
            //};

            //Console.WriteLine(mydel(Color.DarkCyan));
            #endregion
            #region #2
            //try
            //{
            //    VoidVoidDel mydel = delegate ()
            //    {
            //        Console.WriteLine("\nEvent: Object was added!\n");
            //    };
            //    Backpack backpack = new Backpack();
            //    backpack.AddItem += new Delegate(mydel);
            //    backpack.Print();
            //    backpack.AddAnItem(new BackPackObject("Phone", 0.8));
            //    backpack.Print();
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion
            #region #3 Создайте лямбда-выражение для подсчёта количества чисел в массиве, кратных семи. Напишите код для тестирования работы лямбды
            //int[] array = { 1, 2, 3,7,14,15,21,28 };
            //ArrVoidDel mulSeven = arr =>
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] % 7 == 0)
            //            Console.Write(arr[i] + "\t");
            //    }
            //};
            //mulSeven(array);
            #endregion
            #region #4
            //int[] array = { -1, 2, 5, 6, 1, -85, -81 };
            //ArrIntDel positive = arr => arr.Count(x => x > 0);
            //Console.WriteLine(positive(array));
            #endregion
            #region #5 Создайте лямбда-выражение для отображения уникальных отрицательных чисел в массиве. Напишите код для тестирования работы лямбды
            //int[] array = { -1, 2, 5, 6, 1, -85, -81,-81,-81,-12 };
            //ArrIntDel negativeunique = arr => arr.Distinct().ToArray().Count(x => x < 0);
            //Console.WriteLine(negativeunique(array));
            #endregion
            #region #6 Создайте лямбда-выражение для проверки есть ли в  тексте заданное слово.Напишите код для тестированияработы лямбды
            //string text = "The Universe has a beginning, but no end. The stars have a beginning, too, but they die of their own power.";
            //StrBoolDel IsContaining = (str, substr) => str.Contains(substr);
            //Console.WriteLine(IsContaining(text,"but"));
            #endregion
        }
    }
}
