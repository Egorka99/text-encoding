using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTextCoding
{
    public class ArithmeticCoding
    {

        /// <summary> 
        /// Структура "Символ" - "Его вероятность"  
        /// </summary> 
        public struct Struct
        {
            public char Sym;
            public double SymProbability;
        }

        /// <summary>
        /// Отрезок для символа
        /// </summary>
        public struct Segment
        {
            public double left;
            public double right;
            public char symb;
        }

        /// <summary>
        /// Поиск отрезка для символа
        /// </summary>
        /// <returns></returns>
        public Segment[] defineSegment(string text, int m, int n, char[] letters, double[] probability)
        {
            Segment[] segment = new Segment[m];

            List<Struct> nodes = new List<Struct>(); //список с вероятностями символов

            Segment[] textsegments = new Segment[n]; //массив сегментов каждого символа текста 

            for (int i = 0; i < letters.Length; i++) //заполняем список из массивов символов и вероятностей
            {
                Struct node = new Struct();
                node.Sym = letters[i];
                node.SymProbability = probability[i];
                nodes.Add(node);
            }

            List<Struct> Orderednodes = nodes.OrderByDescending(node => node.SymProbability).ToList(); //сортируем список с вероятностями

            double l = 0;

            for (int i = 0; i < m; i++) //ищем сегмент для каждого из массива символов   
            {
                segment[i].left = l;
                segment[i].right = l + Orderednodes[i].SymProbability;
                segment[i].symb = Orderednodes[i].Sym;
                l = segment[i].right;
            }

            for (int i = 0; i < n; i++) //сегмент для каждого символа текста 
            {
                char[] textchars = text.ToCharArray();

                for (int j = 0; j < m; j++)
                {
                    if (segment[j].symb == textchars[i])
                    { 
                        textsegments[i].left = segment[j].left;
                        textsegments[i].right = segment[j].right;
                        textsegments[i].symb = segment[j].symb;

                    }
                }
            }

            /* for (int i = 0; i < textsegments.Length; i++)
             {
                 Console.WriteLine( textsegments[i].symb + " - " + "{" + textsegments[i].left + ";" + textsegments[i].right + "}"); 
             }*/


            return textsegments;
        }

        /// <summary> 
        /// Кодирование текста 
        /// </summary>
        /// <returns> Код - середина сегмента</returns>
        public double Encode(string text)
        {
            SourceProp txt = new SourceProp(text);

            char[] letters = txt.Symbols;
            double[] probability = txt.Probabilities;
            int m = txt.ArraysLength;
            int n = txt.TextLength;

            Segment[] segment = defineSegment(text, m, n, letters, probability); //массив сегментов

            double left = 0;  //левая граница отрезка
            double right = 1;  //правая
            for (int i = 0; i < n; i++)
            {
                char symb = text[i];
                double newRight = left + (right - left) * segment[i].right;
                double newLeft = left + (right - left) * segment[i].left;
                left = newLeft;
                right = newRight;
            }
            return (left + right) / 2;
        }

        /// <summary> 
        /// Декодирование текста 
        /// </summary>  
        /// <returns></returns>
        public string Decode(string text)
        {
            SourceProp txt = new SourceProp(text);

            char[] letters = txt.Symbols;
            double[] probability = txt.Probabilities;
            int m = txt.ArraysLength;
            int n = txt.TextLength;

            Segment[] segment = defineSegment(text, m, n, letters, probability); //массив сегментов

            double code = Encode(text); //код текста  

            string s = ""; //текст 

            for (int i = 0; i < segment.Length; i++) //если код входит в отрезок символа - в текст записывается этот символ
            {
                if ((code >= segment[i].left) & (code < segment[i].right))
                {
                    s += segment[i].symb;
                    code = (code - segment[i].left) / (segment[i].right - segment[i].left);
                }
            }
            return s;
        }
    }
}
