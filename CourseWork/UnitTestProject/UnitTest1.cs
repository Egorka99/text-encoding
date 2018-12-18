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
        public void TestMethod_EncodeLZ78() 
        {
            string input = "abacababacabc";
            string expected_output = " {0,a} {0,b} {1,c} {1,b} {4,a} {0,c} {4,c}";

              
            LZCoding lz = new LZCoding(input); 
            List<LZCoding.Struct> list = lz.EncodeLZ78();
            string output = lz.ToString(list);  

            Assert.AreEqual(output, expected_output);

        }


        [TestMethod]
        public void TestMethod_DecodeLZ78()
        {
            string input = "abacababacabc";
            string expected_output = "abacababacabc";

             
            LZCoding lz = new LZCoding(input); 

            var list = lz.EncodeLZ78(); 

            string output = lz.DecodeLZ78(list); 
             
            Assert.AreEqual(output, expected_output);

        }

        [TestMethod]
        public void TestMethod_EncodeArithm() 
        { 
            string input = "abacaba";

            ArithmeticCoding text = new ArithmeticCoding();
            double output = text.Encode(input); 
 
            Assert.IsTrue( Math.Round(output,6) == 0.411471);
        }

        [TestMethod]
        public void TestMethod_DecodeArithm()
        {
            string input = "abacaba";
            string expected_output = "abacaba";

            ArithmeticCoding text = new ArithmeticCoding(); 
            string output = text.Decode(input);
             
            Assert.AreEqual(output, expected_output);
        }
         

        [TestMethod] 
        public void TestMethod_EncodeHuffman() 
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
        public void TestMethod_DecodeHuffman()
        {
            string input = "случайный текст с пробелами ";
            string expected_output = "случайный текст с пробелами ";
    
            HuffmanTree huffmanTree = new HuffmanTree();
            huffmanTree.Build(input);
            BitArray encoded = huffmanTree.Encode(input);
            string output = huffmanTree.Decode(encoded);  
             
            Assert.AreEqual(output, expected_output);

        }

    }  
}
