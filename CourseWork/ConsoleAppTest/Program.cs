using System;
using System.Collections.Generic;
using System.Collections;
using ClassLibraryTextCoding;
using System.Text;

namespace ConsoleAppTest
{ 
    class Program 
    { 
        static void Main(string[] args)   
        {
             string input = "abracadabra";

            byte[] bytes = Encoding.UTF8.GetBytes(input);

            for (int i = 0; i < bytes.Length; i++)
            {
                Console.WriteLine(bytes[i]);
            }
           
               
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


            double code = text.Encode("рыба phora");

            string txt = text.Decode("рыба phora");   

            Console.WriteLine(code);    
              
            Console.WriteLine(txt);   
             
            Console.WriteLine("--------------"); 

            Console.WriteLine("LZ кодирование");
            Console.WriteLine( );
             
               
            //LZ coding test 
            LZCoding lz = new LZCoding("abracadabra");

            List<LZCoding.Struct> list = lz.EncodeLZ78();
             
            foreach (var item in list)
            {  
                Console.WriteLine("{" + item.pos +";"+ item.next + "}");
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
