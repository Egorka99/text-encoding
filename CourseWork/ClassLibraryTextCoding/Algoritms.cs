using System;
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
         
        public static char[] symbols = text.GetSymbolsArray();  

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
        private static void Sort(int[] Elements)
        {
            for (int i = 0; i < Elements.Length; i++)
            {
                for (int j = 0; j < Elements.Length - 1; j++)
                {
                    if (Elements[j] > Elements[j + 1])
                    {
                        int temp = Elements[j];
                        Elements[j] = Elements[j + 1];
                        Elements[j + 1] = temp;
                    }
                }
            } 
        }

        private static string GetSymCode(int[] Elements, int Element)
        {
            Sort(Elements);
             
                int left = 0;
                int right = Elements.Length;
                string symcode="";  
              
                while (left < right) //пока слева и справа от середины есть элементы
                {
                    int mid = (left + right) / 2; //определяем середину

                    if (Element <= Elements[mid]) //если элемент меньше или равен элементу в середине
                    {
                        right = mid; //перемещаем правую границу
                        symcode += "1";
                    }     
                    else 
                    {
                        left = mid + 1; //иначе левую
                        symcode += "0";
                    }   
                }
                    return symcode; 
        } 

        public static void /*double[]*/ GetCode( List<Node> Nodes)
        {
            int n = Nodes.Count(); // заменить !!! text.TextLength 

            int[] tree = new int[n*2];

            string code="";

            int maxLength = 17;
             
            double[] a = new double[maxLength]; // массив частот с макс длиной , пустота заполняется бесконечностью

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
             
           // return a;   
        }
     
    } 

    /*public class ArithmeticCoding 
    {
        private static SourceProp text = new SourceProp("abracadabra"); 
           
        private char[] letters = text.GetSymbolsArray(); 
        private static int[] frequency = text.GetFreqArray();
        private double[] probability = text.GetProbalility(frequency);
        private int m = text.GetArraysLength(); 
        private int n = text.GetTextLength();    
           
                
        public ArithmeticCoding(SourceProp src) 
        {
            text = src; 
        }
         
        public struct Segment
        {
            public double left; 
            public double right;
        } 

        public Segment[] defineSegment()
        {
            Segment[] segment = new Segment[m]; 

            double l = 0; 
            for (int i = 0; i < m-1; i++)  
            { 
                segment[letters[i]].left = l;
                segment[letters[i]].right = l + probability[i]; 
                l = segment[letters[i]].right;
            } 
            return segment;
        }

        public double Encode()
        { 
              
            Segment[] segment = defineSegment();

            double left = 0; 
            double right = 1;  
            for (int i = 0; i < n-1; i++)  
            {  
                char symb = text.SourceText[i]; 
                double newRight = left + (right - left) * segment[symb].right;
                double newLeft = left + (right - left) * segment[symb].left;
                left = newLeft;
                right = newRight;


            } 
            return (left + right) / 2;
        }      
    }*/
    
     
    public class Algoritms
    {
        private string text;
        private string code; 
    }
}
