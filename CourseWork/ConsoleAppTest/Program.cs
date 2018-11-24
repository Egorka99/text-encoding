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
            string input = "abracadabra";

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

            /* SourceProp source = new SourceProp(input);

             char [] m = source.GetSymbolsArray();
             int [] n = source.GetFreqArray();
             double [] p = source.GetProbalility(n);

             for (int i = 0; i < n.Length; i++) 
             {
                 Console.WriteLine(m[i]);  
             }  */

            Huffman huff = new Huffman();

            double cb = huff.GetCountBites();

            Console.WriteLine(cb);
             
            //SourceProp txt = new SourceProp(input);

            //ArithmeticCoding SourceData = new ArithmeticCoding();

          // Console.WriteLine( SourceData.Encode() );
             
            Console.ReadKey();     
        }     
    }   
}
