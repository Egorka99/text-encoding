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

             HuffmanTree huffmanTree = new HuffmanTree(); 

              // Build the Huffman tree
              huffmanTree.Build(input);

              // Encode
              BitArray encoded = huffmanTree.Encode(input);


              foreach (bool bit in encoded)
              {
                  Console.Write((bit ? 1 : 0) + "");
              } 
              Console.WriteLine();


              // Decode
              string decoded = huffmanTree.Decode(encoded);

              Console.WriteLine("Decoded: " + decoded);

             
            // Arithmetic Coding test


            Console.WriteLine("Арифметическое кодирование");
            Console.WriteLine();

             
           
            ArithmeticCoding text = new ArithmeticCoding();

            double code = text.Encode("abracadabra");

            string txt = text.Decode("abracadabra"); 

            Console.WriteLine(code);  
              
            Console.WriteLine(txt); 
             
            Console.WriteLine("--------------");

            Console.WriteLine("LZ кодирование");
            Console.WriteLine( );
             
              
            //LZ coding test 
            LZCoding lz = new LZCoding("abracadabra");

            List<LZCoding.Node> list = lz.EncodeLZ78();
             
            foreach (var item in list)
            {  
                Console.WriteLine("(" + item.pos +";"+ item.next + ")");
            }

            string decode = lz.DecodeLZ78(list); 
             
            Console.WriteLine(decode); 
             
             /* Huffman huff = new Huffman(); 
              
               List<double> list = huff.GetTree();
             
              Console.WriteLine("0 11  101  1000  1001");
              //Console.WriteLine(code);*/ 

             
            Console.ReadKey();     
        }       
    }    
} 
