﻿using System;
using System.Collections.Generic;
using System.Linq; 
using System.Collections; 

namespace ClassLibraryTextCoding
{
      

    public class SourceProp 
    { 
        public string SourceText { get; } //текст 

        public char[] Symbols { get { return GetSymbolsArray(); } } //алфавит текста 

        public int[] Frequencies { get { return GetFreqArray(); } } //массив частот появления символов в тексте

        public double[] Probabilities { get { return GetProbalility(); } } //массив вероятностей  появления символов в тексте 

        public int TextLength { get { return SourceText.Length; } } //длина текста 
              
        public int ArraysLength { get { return Symbols.Length; } } //длина массивов Symbols, Frequencies, Probabilities 
         
        public SourceProp(string source)  
        {
            SourceText = source;
        }

        /// <summary>   
        /// Структура для символа 
        /// </summary> 
        public struct Struct
        { 

            public char Symbol { get; set; }
            public int Frequency { get; set; }
        }

        /// <summary>
        /// Создание словаря "Символ" - "Частота вхождения"
        /// </summary>
        /// <param name="source"></param> 
        /// <returns></returns> 
        private Dictionary<char, int> ToFrequencyDictionary()
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (char symbol in SourceText)  
            {
                if (result.ContainsKey(symbol))
                    result[symbol]++;
                else 
                    result[symbol] = 1;
            }
            return result; 
        }  

        /// <summary>
        /// Получить массив символов
        /// </summary>
        /// <returns></returns>
        private char[] GetSymbolsArray()
        {
            var dict = ToFrequencyDictionary(); 
              
            List<Struct> nodes = new List<Struct>(); //лист для хранения символов и частот
 
            foreach (KeyValuePair<char, int> symbol in dict) //заполняем лист из словаря 
            {
                nodes.Add(new Struct() { Symbol = symbol.Key, Frequency = symbol.Value });
            }

            List<Struct> orderedNodes = nodes.OrderBy(node => node.Frequency).ToList(); 

            char[] symbols = new char [dict.Count]; //нужный массив

            for (int i = 0; i < orderedNodes.Count; i++) //заполняем его с листа
            {
                symbols[i] = orderedNodes[i].Symbol;  
            }

            return symbols;    
                
        }    
          
        /// <summary>
        /// Получить массив частот текста 
        /// </summary>
        /// <returns></returns>
        private int [] GetFreqArray() 
        {  
            var dict = ToFrequencyDictionary();

            List<Struct> nodes = new List<Struct>(); //лист для хранения символов и частот

            foreach (KeyValuePair<char, int> symbol in dict) //заполняем лист из словаря 
            {
                nodes.Add(new Struct() { Symbol = symbol.Key, Frequency = symbol.Value });
            }

            List<Struct> orderedNodes = nodes.OrderBy(node => node.Frequency).ToList();  

            int[] symbols = new int[dict.Count]; //нужный массив

            for (int i = 0; i < orderedNodes.Count; i++) //заполняем его с листа
            {
                symbols[i] = orderedNodes[i].Frequency;
            } 
              
            return symbols;
        } 

        /// <summary>
        /// Сумма частот символов
        /// </summary>
        /// <param name="FreqArray"></param>
        /// <returns></returns>
        private int GetSum(int[] FreqArray)
        { 
            int sum = 0;
            for (int i = 0; i < FreqArray.Length; i++)
            {
                sum += FreqArray[i];
            }
            return sum; 
        }  

        /// <summary>
        /// Получить вероятности символов 
        /// </summary>
        /// <returns></returns>
        private double[] GetProbalility()
        {
            double[] probalility = new double[Frequencies.Length];

            for (int i = 0; i < Frequencies.Length; i++)
            {
                probalility[i] = Convert.ToDouble(Frequencies[i]) / Convert.ToDouble(GetSum(Frequencies));
            } 
               
            return probalility;      
        }     
     
    }


    public class ArithmeticCoding  
    {
               
        /// <summary> 
        /// Структура "Символ" - "Его вероятность"  
        /// </summary> 
        public struct Node
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
        public Segment[] defineSegment(string text, int m , int n, char[]letters ,double[] probability)
        {
            Segment[] segment = new Segment[m];   

            List<Node> nodes = new List<Node>(); //список с вероятностями символов

            Segment[] textsegments = new Segment[n]; //массив сегментов каждого символа текста 

            for (int i = 0; i < letters.Length; i++) //заполняем список из массивов символов и вероятностей
            {
                Node node = new Node();
                node.Sym = letters[i];  
                node.SymProbability = probability[i];
                nodes.Add(node);
            }

            List<Node> Orderednodes = nodes.OrderByDescending(node => node.SymProbability).ToList(); //сортируем список с вероятностями

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

            Segment[] segment = defineSegment(text , m, n,letters,probability); //массив сегментов

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
            return Math.Round( (left + right) / 2 , 6 ); 
        }     
       
        /// <summary> 
        /// Декодирование текста 
        /// </summary>  
        /// <returns></returns>
        public string Decode (string text)
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
                if ( (code >= segment[i].left) & (code < segment[i].right) )
                {
                    s += segment[i].symb;
                    code = (code - segment[i].left) / (segment[i].right - segment[i].left);
                }
            } 
            return s; 
        }
    }   

    public class LZCoding
    {
        private string text; 

        public LZCoding(string _src)
        {
            text = _src;  
        }   
         
          
        /// <summary> 
        /// Структура "Позиция" - "Следующий символ"
        /// </summary>
        public struct Struct
        {  
            public int pos;
            public char next;
        }
         
        public List<Struct> EncodeLZ78 ()
        {
            string buffer = "";  //хранение в памяти 
              
            string s = text; //входной текст  

            Dictionary<string, int> dict = new Dictionary<string, int>(); //Словарь "Слово" - "Позиция"

            List<Struct> ans = new List<Struct>(); //код в виде {позиция в словаре,следующий символ}

            for (int i = 0; i < s.Length; i++)  
            {
                if (dict.ContainsKey(buffer + s[i]))  //если слово есть в словаре - обновляем буфер
                    buffer += s[i];
                else 
                {
                    int num = 0; //номер буфера в словаре
                    foreach (KeyValuePair<string, int> p in dict)
                    {
                        if (p.Key == buffer) num = p.Value;
                    }  
                    ans.Add(new Struct() { pos = num, next = s[i] }); //добавляем пару в ответ

                    dict.Add(buffer + s[i], dict.Count + 1); //добавляем слово в словарь

                    buffer = "";  //сбрасываем буфер 
                } 
            } 
            return ans; 

        }      

        public string DecodeLZ78 (List<Struct> encoded)
        {
            List<string> dict = new List<string>(); // словарь, слово с номером 0 — пустая строка

            string ans = ""; // ответ

            string word="";

             
            dict.Add(word);

            foreach (var node in encoded)
            {
                word = dict[node.pos] + node.next; // составляем слово из уже известного из словаря и новой буквы
                ans += word; // приписываем к ответу
                dict.Add(word); // добавляем в словарь 
            }
            return ans;   
        }
         
        public string ToString (List<Struct> encoded)
        {
            string code = "";

            foreach (var item in encoded)
            {
               code += " {" + item.pos + "," + item.next + "}" ;
            }
             
            return code;    
        }       
          
    } 

    public class Node
    {
        public char Symbol { get; set; } //символ
        public int Frequency { get; set; } //частота
        public Node Right { get; set; } // правая ветка
        public Node Left { get; set; } // левая ветка

        public List<bool> Traverse(char symbol, List<bool> data) //нахождение кода символа  
        {
            if (Right == null && Left == null)  
            {
                if (symbol.Equals(Symbol))
                {  
                    return data;
                }
                else
                {
                    return null; 
                }
            }
            else
            {
                List<bool> left = null;
                List<bool> right = null;

                if (Left != null)
                {
                    List<bool> leftPath = new List<bool>();
                    leftPath.AddRange(data);
                    leftPath.Add(false);

                    left = Left.Traverse(symbol, leftPath);
                }

                if (Right != null)
                {
                    List<bool> rightPath = new List<bool>();
                    rightPath.AddRange(data);
                    rightPath.Add(true);
                    right = Right.Traverse(symbol, rightPath);
                }
                 
                if (left != null)
                {
                    return left;
                }
                else
                { 
                    return right;
                }
            }
        }
    }

    public class HuffmanTree 
    {
        private List<Node> nodes = new List<Node>(); //лист с структурой выше
        public Node Root { get; set; } //корневой элемент
        public Dictionary<char, int> Frequencies = new Dictionary<char, int>();  //словарь "Символ - частота"

        public void Build(string source) //строим дерево
        { 
            for (int i = 0; i < source.Length; i++) //заполняем словарь частот 
            {
                if (!Frequencies.ContainsKey(source[i])) 
                {
                    Frequencies.Add(source[i], 0);
                }

                Frequencies[source[i]]++;
            }

            foreach (KeyValuePair<char, int> symbol in Frequencies) //заполнение листа из словаря
            {
                nodes.Add(new Node() { Symbol = symbol.Key, Frequency = symbol.Value });
            }

            while (nodes.Count > 1) 
            {
                List<Node> orderedNodes = nodes.OrderBy(node => node.Frequency).ToList(); //отсортированный лист по частотам

                if (orderedNodes.Count >= 2)  
                {

                    List<Node> taken = orderedNodes.Take(2).ToList();  //берем два первых элемента с листа

                    Node parent = new Node() // родительский узел, с суммой частот левого и правого элемента 
                    {
                        Symbol = '*', 
                        Frequency = taken[0].Frequency + taken[1].Frequency,
                        Left = taken[0],
                        Right = taken[1]
                    };

                    nodes.Remove(taken[0]); //удаляем левый и правый элемент
                    nodes.Remove(taken[1]);
                    nodes.Add(parent); //добавляем родительский 
                } 

                Root = nodes.FirstOrDefault(); //делаем его корневым 

            }

        }
          
        public BitArray Encode(string source) 
        { 
            List<bool> encodedSource = new List<bool>(); 
             
            for (int i = 0; i < source.Length; i++) 
            { 
                List<bool> encodedSymbol = Root.Traverse(source[i], new List<bool>()); 
                encodedSource.AddRange(encodedSymbol); 
            } 
             
            BitArray bits = new BitArray(encodedSource.ToArray());  
             
            return bits;
        }

        public static string ToString(BitArray code)
        {
            string s = String.Empty;
            foreach (bool bit in code)
            {
                s += ((bit ? 1 : 0) + "");
            }

            return s; 
        }

        public string Decode(BitArray bits)
        {
            Node current = Root;
            string decoded = "";

            foreach (bool bit in bits)
            {
                if (bit) 
                {
                    if (current.Right != null)
                    {
                        current = current.Right;
                    }
                }
                else
                {
                    if (current.Left != null)
                    {
                        current = current.Left;
                    }
                }

                if (IsLeaf(current))
                {
                    decoded += current.Symbol;
                    current = this.Root;
                }
            }

            return decoded;
        } 

        private bool IsLeaf(Node node)
        {
            return (node.Left == null && node.Right == null);
        }

    }

    /*public class Huffman
   { 

       /// <summary>
       ///  !!! Разобраться со структурой данных
       /// </summary>

       public static SourceProp text = new SourceProp("abracadabra");

       public static char[] symbols = text.SourceText.ToCharArray();

       public static int[] freq = text.Frequencies; //массив частот (потом заменить freq Length на text.ArraysLength)

       int maxLength = 17;  //максимальная длина вводимого текста 

       /// <summary> 
       /// Количество бит необходимых для кодирования
       /// </summary>
       /// <returns></returns>
       public double GetCountBites()
       {
           double[] a = new double[maxLength]; // массив частот с макс длиной , пустота заполняется бесконечностью

          /// Заполняем массив частотами
           for (int k = 0; k < freq.Length; k++)
           {
               a[k] = freq[k];
           }
          /// Заполняем пустоты бесконечностью
           for (int k = freq.Length; k < maxLength; k++)
           {
               a[k] = double.PositiveInfinity;
           }

           double[] b = new double[maxLength];

           int i = 0, j = 0;
           double ans = 0;

          // Заполняем второй массив
           for (int k = 0; k < maxLength; k++)
           {
               b[k] = double.PositiveInfinity;
           }

           for (int k = 0; k < freq.Length - 1; k++)
           {
               if ((a[i] + a[i + 1] <= a[i] + b[j]) & (a[i] + a[i + 1] <= b[j] + b[j + 1]))
               {
                   b[k] = a[i] + a[i + 1];
                   ans += b[k];
                   i += 2;
                   continue;
               }
               if ((a[i] + b[j] <= a[i] + a[i + 1]) & (a[i] + b[j] <= b[j] + b[j + 1]))
               {
                   b[k] = a[i] + b[j];
                   ans += b[k];
                   i++;
                   j++;
                   continue;
               }
               if ((b[j] + b[j + 1] <= a[i] + a[i + 1]) & (b[j] + b[j + 1] <= a[i] + b[j]))
               {
                   b[k] = b[j] + b[j + 1];
                   ans += b[k];
                   j += 2;
               }
           }

           return ans;
       }

       /// <summary>
       /// Сортировка массива    
       /// </summary>
       /// <param name = "Elements" ></ param >
       private static void Sort(double[] Elements)
       {
           for (int i = 0; i < Elements.Length; i++)
           {
               for (int j = 0; j < Elements.Length - 1; j++)
               {
                   if (Elements[j] > Elements[j + 1])
                   {
                       double temp = Elements[j];
                       Elements[j] = Elements[j + 1];
                       Elements[j + 1] = temp;
                   }
               }
           }
       }



       public double[] GetTree() 
       {
           int n = text.TextLength; // заменить !!! text.TextLength 

           List<double> TreeList = new List<double>();

           string code = "";

           int maxLength = 17;

           double[] a = new double[maxLength];  // массив частот с макс длиной , пустота заполняется бесконечностью

          // Заполняем массив частотами
           for (int k = 0; k < freq.Length; k++)
           {
               a[k] = freq[k];
           }
           //Заполняем пустоты бесконечностью
           for (int k = freq.Length; k < maxLength; k++)
           {
               a[k] = double.PositiveInfinity;
           }

           double[] b = new double[maxLength];

           int i = 0, j = 0; //указатели   

          // Заполняем второй массив
           for (int k = 0; k < maxLength; k++)
           {
               b[k] = double.PositiveInfinity;
           }


           for (int k = 0; k < freq.Length - 1; k++)
           {
               if ((a[i] + a[i + 1] <= a[i] + b[j]) & (a[i] + a[i + 1] <= b[j] + b[j + 1]))
               {
                   b[k] = a[i] + a[i + 1];
                   i += 2;
                   continue;
               }
               if ((a[i] + b[j] <= a[i] + a[i + 1]) & (a[i] + b[j] <= b[j] + b[j + 1]))
               {
                   b[k] = a[i] + b[j];
                   i++;
                   j++;
                   continue;
               }
               if ((b[j] + b[j + 1] <= a[i] + a[i + 1]) & (b[j] + b[j + 1] <= a[i] + b[j]))
               {
                   b[k] = b[j] + b[j + 1];
                   j += 2;
               }
           }

           for (int it = 0; it < freq.Length; it++)
           {
               TreeList.Add(a[it]);
           }

           for (int k = 0; k < maxLength; k++)
           {
               if (b[k] != double.PositiveInfinity)
                   TreeList.Add(b[k]);
           }


           for (int k = 0; k < b.Length; k++)
           {
               Console.WriteLine(b[k]);
           }
           Console.WriteLine("---------");

           List<double> OrderedTreeList = TreeList.OrderByDescending(node => node).ToList();

           double[] tree = OrderedTreeList.ToArray();


           for (int k = 0; k < tree.Length; k++)
           {
               Console.WriteLine(tree[k]);
           }

           return tree;
       }



   }*/


}
