using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTextCoding
{ 
    public class LZCoding
    { 
        private string text;
         
        public LZCoding(string _src)
        {
            text = _src;
        }


        /// <summary> 
        /// Структура "Позиция" - "Следующий символ"
        /// </summary>
        public struct Struct
        {
            public int pos;
            public char next;
        }

        public List<Struct> EncodeLZ78()
        {
            string buffer = "";  //хранение в памяти 

            string s = text; //входной текст  

            Dictionary<string, int> dict = new Dictionary<string, int>(); //Словарь "Слово" - "Позиция"

            List<Struct> ans = new List<Struct>(); //код в виде {позиция в словаре,следующий символ}

            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(buffer + s[i]))  //если слово есть в словаре - обновляем буфер
                    buffer += s[i];
                else
                {
                    int num = 0; //номер буфера в словаре
                    foreach (KeyValuePair<string, int> p in dict)
                    {
                        if (p.Key == buffer) num = p.Value;
                    }
                    ans.Add(new Struct() { pos = num, next = s[i] }); //добавляем пару в ответ

                    dict.Add(buffer + s[i], dict.Count + 1); //добавляем слово в словарь

                    buffer = "";  //сбрасываем буфер 
                }
            }

            foreach (KeyValuePair<string, int> p in dict)
            {
                Console.WriteLine(p.Key);
            }
            return ans;
             
        }

        public string DecodeLZ78(List<Struct> encoded)
        {
            List<string> dict = new List<string>(); // словарь, слово с номером 0 — пустая строка

            string ans = ""; // ответ
             
            string word = "";


            dict.Add(word);

            foreach (var node in encoded)
            {
                word = dict[node.pos] + node.next; // составляем слово из уже известного из словаря и новой буквы
                ans += word; // приписываем к ответу
                dict.Add(word); // добавляем в словарь 
            }
            return ans;
        }

        public string ToString(List<Struct> encoded)
        {
            string code = "";

            foreach (var item in encoded)
            {
                code += " {" + item.pos + "," + item.next + "}";
            }

            return code;
        }

    }
}
