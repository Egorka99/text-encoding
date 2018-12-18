using System;
using System.Collections.Generic;
using System.Linq;

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

            char[] symbols = new char[dict.Count]; //нужный массив

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
        private int[] GetFreqArray()
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

        public int[] GetUtfCodes()
        {
            int[] UtfCodes = new int[SourceText.Length];

            int k = 0;
            foreach (char ccc in SourceText)
            {
                UtfCodes[k] = ccc;
                k++;
            }

            return UtfCodes;

        }

    }
}
