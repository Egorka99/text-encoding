using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryTextCoding
{
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

    /* public class Huffman
     { 

        /// <summary>
        ///  !!! Разобраться со структурой данных
        /// </summary>

         public static SourceProp text = new SourceProp("abracadabra");

         public static char[] symbols = text.Symbols; 

         public static int[] freq = text.Frequencies; //массив частот (потом заменить freq Length на text.ArraysLength)

         int maxLength = 17;  //максимальная длина вводимого текста 


        public class Struct
        {
            public int Frequency;
            public string Value;
        } 

        public class Node 
        {
             public int Frequency;
             public string Value;
             public Node Left; 
             public Node Right;  
        }
         public void  GetTree() 
         { 
             List<Struct> SymAndFreq= new List<Struct>(); //лист со структурой "Символ" - "Частота"

             List<Node> nodes = new List<Node>(); //лист с узлами дерева 


             for (int i = 0; i < text.ArraysLength; i++) //заполняем лист 
             {
                 SymAndFreq.Add(new Struct()
                 {
                     Frequency = freq[i], 
                     Value = symbols[i].ToString()  
                 });
             }


             while(SymAndFreq.Count > 1)
             {
                 Node node = new Node() 
                 {
                     Frequency = SymAndFreq[0].Frequency + SymAndFreq[1].Frequency,
                     Value = (SymAndFreq[0].Value + SymAndFreq[1].Value).ToString(),
                     Left = new Node() { Frequency = SymAndFreq[0].Frequency, Value = SymAndFreq[0].Value.ToString() },
                     Right = new Node() { Frequency = SymAndFreq[1].Frequency, Value = SymAndFreq[1].Value.ToString() }
                 };
                 nodes.Add(node);

                 SymAndFreq.Add(new Struct() { Frequency = node.Frequency, Value = node.Value }); 

                 SymAndFreq.RemoveAt(0);  
                 SymAndFreq.RemoveAt(1);

                 SymAndFreq = SymAndFreq.OrderBy( item => item.Frequency).ToList();

             } 

             Console.WriteLine("Дерево");
             foreach (var item in nodes)
             {
                 Console.WriteLine("Root: " + item.Value + $" ({item.Frequency})");
                 Console.WriteLine("Left: " + item.Left.Value + $" ({item.Left.Frequency})");
                 Console.WriteLine("Right: " + item.Right.Value + $" ({item.Right.Frequency})");
                 Console.WriteLine("---");
             }

             //return nodes;  

         }

        /// <summary> 
        /// Количество бит необходимых для кодирования
        /// </summary>
        /// <returns></returns>
        public double GetCountBites() 
         {
             double[] a = new double[maxLength]; // массив частот с макс длиной , пустота заполняется бесконечностью

           // Заполняем массив частотами
            for (int k = 0; k < freq.Length; k++)
             {
                 a[k] = freq[k];
             }
           // Заполняем пустоты бесконечностью
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
         }*/
}
