using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ClassLibraryTextCoding;
 
namespace ConsoleAppTest
{ 
    class Program
    { 
        static void Main(string[] args)  
        {
            string input = "abacaba";
             
            /* HuffmanTree huffmanTree = new HuffmanTree();

              // Build the Huffman tree
              huffmanTree.Build(input);

              // Encode
              BitArray encoded = huffmanTree.Encode(input);

              Console.Write("Encoded: ");
              foreach (bool bit in encoded)
              {
                  Console.Write((bit ? 1 : 0) + "");
              }
              Console.WriteLine();

              // Decode
              string decoded = huffmanTree.Decode(encoded);

              Console.WriteLine("Decoded: " + decoded);

              Console.ReadLine(); */



           /*  SourceProp source = new SourceProp(input);

             char [] m = source.GetSymbolsArray();
             int [] n = source.GetFreqArray();
             double [] p = source.GetProbalility(n);
             Console.WriteLine("Длина массивов: " + source.GetArraysLength() );

            Array.Sort(p);
            Array.Reverse(p); 

            for (int i = 0; i < p.Length; i++) 
             {  
                 Console.WriteLine(p[i]);  
             }  */


              
            ArithmeticCoding text = new ArithmeticCoding();

            

             double code = text.Encode();  
             
              Console.WriteLine(code); 

              



            /*  Huffman huff = new Huffman(); 

              string code = huff.GetCode();

              Console.WriteLine("0 11  101  1000  1001");
              Console.WriteLine(code);*/


            Console.ReadKey();     
        }      
    }    
} 
