﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections; 

namespace ClassLibraryTextCoding
{
    public class Node
    {
        public char Symbol { get; set; }
        public int Frequency { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }

        public List<bool> Traverse(char symbol, List<bool> data)
        {
            // Leaf
            if (Right == null && Left == null)
            {
                if (symbol.Equals(this.Symbol))
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
        private List<Node> nodes = new List<Node>();
        public Node Root { get; set; }
        public Dictionary<char, int> Frequencies = new Dictionary<char, int>();

        public void Build(string source)
        {
            for (int i = 0; i < source.Length; i++) 
            {
                if (!Frequencies.ContainsKey(source[i]))
                {
                    Frequencies.Add(source[i], 0);
                }

                Frequencies[source[i]]++;
            } 

            foreach (KeyValuePair<char, int> symbol in Frequencies)
            {
                nodes.Add(new Node() { Symbol = symbol.Key, Frequency = symbol.Value });
            }
             
            while (nodes.Count > 1)
            {
                List<Node> orderedNodes = nodes.OrderBy(node => node.Frequency).ToList();

                if (orderedNodes.Count >= 2)
                { 
                    // Take first two items 
                    List<Node> taken = orderedNodes.Take(2).ToList();

                    // Create a parent node by combining the frequencies
                    Node parent = new Node()
                    {
                        Symbol = '*',
                        Frequency = taken[0].Frequency + taken[1].Frequency,
                        Left = taken[0],
                        Right = taken[1]
                    };

                    nodes.Remove(taken[0]);
                    nodes.Remove(taken[1]);
                    nodes.Add(parent); 
                }

                Root = nodes.FirstOrDefault();

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

        public string Decode(BitArray bits)
        {
            Node current = this.Root;
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

        public bool IsLeaf(Node node)
        {
            return (node.Left == null && node.Right == null);
        }

    }

    public class SourceProp
    {
        public string SourceText;

        public SourceProp(string source) 
        {
            SourceText = source;
        }

        /// <summary>   
        /// Структура для символа
        /// </summary>
        public struct Node
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

            foreach (var symbol in SourceText)  
            {
                if (result.ContainsKey(symbol))
                    result[symbol]++;
                else 
                    result[symbol] = 1;
            }
            return result; 
        }  

        public char[] GetSymbolsArray()
        {
            var dict = ToFrequencyDictionary();
              
            List<Node> nodes = new List<Node>(); //лист для хранения символов и частот
 
            foreach (KeyValuePair<char, int> symbol in dict) //заполняем лист из словаря 
            {
                nodes.Add(new Node() { Symbol = symbol.Key, Frequency = symbol.Value });
            }

            List<Node> orderedNodes = nodes.OrderBy(node => node.Frequency).ToList(); 

            char[] symbols = new char [dict.Count]; //нужный массив

            for (int i = 0; i < orderedNodes.Count; i++) //заполняем его с листа
            {
                symbols[i] = orderedNodes[i].Symbol;  
            }

            return symbols;    
                
        }    
         
        public int [] GetFreqArray() 
        {  
            var dict = ToFrequencyDictionary();

            List<Node> nodes = new List<Node>(); //лист для хранения символов и частот

            foreach (KeyValuePair<char, int> symbol in dict) //заполняем лист из словаря 
            {
                nodes.Add(new Node() { Symbol = symbol.Key, Frequency = symbol.Value });
            }

            List<Node> orderedNodes = nodes.OrderBy(node => node.Frequency).ToList();  

            int[] symbols = new int[dict.Count]; //нужный массив

            for (int i = 0; i < orderedNodes.Count; i++) //заполняем его с листа
            {
                symbols[i] = orderedNodes[i].Frequency;
            } 
              
            return symbols;
        } 

        private int GetSum(int[] FreqArray)
        {
            int sum = 0;
            for (int i = 0; i < FreqArray.Length; i++)
            {
                sum += FreqArray[i];
            }
            return sum;
        }  

        public double[] GetProbalility(int [] FreqArray)
        {
            double[] probalility = new double[FreqArray.Length];

            for (int i = 0; i < FreqArray.Length; i++)
            {
                probalility[i] = Convert.ToDouble(FreqArray[i]) / Convert.ToDouble(GetSum(FreqArray));
            } 
               
            return probalility;     
        }     
             
        public int GetTextLength()
        {
            return SourceText.Length; 
        } 

        public int GetArraysLength()
        {
            return GetFreqArray().Length;
        }

          
    }
 

    public class Huffman
    {

        /// <summary>
        ///  !!! Разобраться со структурой данных
        /// </summary>

        public static SourceProp text = new SourceProp("abracadabra");
         
        public static char[] symbols = text.SourceText.ToCharArray();

        public static int[] freq = text.GetFreqArray(); //массив частот (потом заменить freq Length на text.ArraysLength)

        int maxLength = 17;  //максимальная длина вводимого текста 
            
        /// <summary> 
        /// Количество бит необходимых для кодирования
        /// </summary>
        /// <returns></returns>
        public double GetCountBites()     
        {
            double[] a = new double [maxLength]; // массив частот с макс длиной , пустота заполняется бесконечностью

            //Заполняем массив частотами 
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

            int i = 0, j = 0; 
            double ans = 0;
              
            //Заполняем второй массив 
            for (int k = 0; k < maxLength; k++)
            {
                b[k] = double.PositiveInfinity;
            }

            for (int k = 0; k < freq.Length - 1; k++)
            {
                if ( (a[i] + a[i + 1] <= a[i] + b[j]) & (a[i] + a[i + 1] <= b[j] + b[j + 1]) )
                {
                    b[k] = a[i] + a[i + 1]; 
                    ans += b[k];
                    i += 2;
                    continue;
                }
                if ((a[i] + b[j] <= a[i] + a[i + 1]) & (a[i] +b[j] <= b[j] + b[j + 1]))
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
        // Сортировка массива    
        /// </summary>
        /// <param name="Elements"></param>
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
            int n = text.GetTextLength(); // заменить !!! text.TextLength 

            List<double> TreeList = new List<double>();
              
            string code="";    
              
            int maxLength = 17;  
              
            double[] a = new double[maxLength];  // массив частот с макс длиной , пустота заполняется бесконечностью
             
            //Заполняем массив частотами   
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
             
            //Заполняем второй массив  
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

            List<double> OrderedTreeList = TreeList.OrderByDescending(node => node).ToList() ;

             double[] tree = OrderedTreeList.ToArray();     


             for (int k = 0; k < tree.Length; k++) 
             {
                 Console.WriteLine(tree[k]);
             }
            
             return tree;      
        }    
        
        
      
    }  
     
    public class ArithmeticCoding 
    {
        private static SourceProp text = new SourceProp("abracadabra"); 

          
        private char[] letters = text.GetSymbolsArray(); 
        private static int[] frequency = text.GetFreqArray();
        private double[] probability = text.GetProbalility(frequency);
        private int m = text.GetArraysLength(); 
        private int n = text.GetTextLength();    
           
                 
        /*public ArithmeticCoding(SourceProp src) 
        {
            text = src; 
        }*/

        /// <summary>
        // Структура "Символ" - "Его вероятность"  
        /// </summary>
        public struct Node
        {
            public char Sym;
            public double SymProbability;
        }


        public struct Segment
        {
            public double left; 
            public double right;
            public char symb;
        }  

        public Segment[] defineSegment()
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

            List<Node> Orderednodes = nodes.OrderByDescending(node => node.SymProbability).ToList();

            double l = 0;  
              
            for (int i = 0; i < m; i++)   
            { 
                segment[i].left = l;
                segment[i].right = l + Orderednodes[i].SymProbability;
                segment[i].symb = Orderednodes[i].Sym;
                l = segment[i].right; 
            } 

            for (int i = 0; i < n; i++)
            {
                char[] textchars = text.SourceText.ToCharArray();
                 
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
           
        public double Encode()
        {  
            Segment[] segment = defineSegment();
               
            double left = 0;  
            double right = 1;     
            for (int i = 0; i < n; i++)    
            {    
                char symb = text.SourceText[i];  
                double newRight = left + (right - left) * segment[i].right;
                double newLeft = left + (right - left) * segment[i].left;
                left = newLeft; 
                right = newRight; 
            }  
            return (left + right) / 2; 
        }    
        
       /* public string Decode() 
        {
            Segment[] segment = defineSegment();

            double code = Encode();

            string s = ""; 
            for (int i = 0; i < n-1; i++)
            { 
                for (int j = 0; j < m-1; j++)
                {
                    if ( (code >= segment[j].left) & (code < segment[j].right) )
                    {
                        s += segment[j].symb; 
                        code = (code - segment[j].left) / (segment[j].right - segment[j].left);
                        break;
                    }
                }   
            } 
            return s;     
        } */

        public string Decode ()
        {
            Segment[] segment = defineSegment();

            double code = Encode();

            string s = "";

            for (int i = 0; i < segment.Length; i++)
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
        SourceProp text = new SourceProp("abacababacabc");


        public struct Node
        { 
            public int pos;
            public char next;
        }

        public List<Node> EncodeLZ78 ()
        {
            string buffer = "";
              
            string s = text.SourceText;

            Dictionary<string, int> dict = new Dictionary<string, int>();

            List<Node> ans = new List<Node>();

            for (int i = 0; i < s.Length; i++) 
            {
                if (dict.ContainsKey(buffer + s[i])) 
                    buffer += s[i];
                else
                {
                    int num = 0; //номер буфера в словаре
                    foreach (KeyValuePair<string, int> p in dict)
                    {
                        if (p.Key == buffer) num = p.Value;
                    }  
                    ans.Add(new Node() { pos = num, next = s[i] });

                    dict.Add(buffer + s[i], dict.Count + 1);

                    buffer = "";  
                } 
            } 
            return ans;

        }      

        public string DecodeLZ78 (List<Node> encoded)
        {
            List<string> dict = new List<string>();

            string ans = "";

            string word="";

             
            dict.Add(word);

            foreach (var node in encoded)
            {
                word = dict[node.pos] + node.next;
                ans += word;
                dict.Add(word);
            }
            return ans;   
        }
         
         
 


    }
      
      
    public class Algoritms 
    { 
        private string text; 
        private string code;  
    }
}
