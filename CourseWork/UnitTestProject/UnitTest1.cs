using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTextCoding;
using System.Collections;
using System.Collections.Generic; 

namespace UnitTestProject
{
    [TestClass]  
    public class UnitTest1
    { 
        [TestMethod]
        public void TestMethod1LZ78() 
        {
            string input = "abacababacabc";
            string expected_output = " {0,a} {0,b} {1,c} {1,b} {4,a} {0,c} {4,c}";

              
            LZCoding lz = new LZCoding(input);
            List<LZCoding.Struct> list = lz.EncodeLZ78();

            string output = lz.ToString(list); 

            Assert.AreEqual(output, expected_output);

        }

        [TestMethod]
        public void TestMethod1Arithm() 
        { 
            string input = "abacaba";
            double expected_output = 0.411471;
             

            ArithmeticCoding text = new ArithmeticCoding();
            double output = text.Encode(input); 
 
            Assert.AreEqual(output, expected_output);

        }


        [TestMethod] 
        public void TestMethodHuffman1() 
        {
            string input = "abracadabra";
            string expected_output = "01101110100010101101110";     

             
            HuffmanTree huffmanTree = new HuffmanTree();
            huffmanTree.Build(input);
            BitArray encoded = huffmanTree.Encode(input);     
            string output = HuffmanTree.ToString(encoded);


            Assert.AreEqual(output, expected_output); 

        }

        [TestMethod] 
        public void TestMethodHuffman2() 
        {
            string input = "случайный текст";
            string expected_output = "00110001001101010110101100110101011100111111000001011";


            HuffmanTree huffmanTree = new HuffmanTree();
            huffmanTree.Build(input);
            BitArray encoded = huffmanTree.Encode(input); 
            string output = HuffmanTree.ToString(encoded);


            Assert.AreEqual(output, expected_output);

        }


    } 
}
