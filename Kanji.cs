using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiTester
{
    class Kanji
    {
        private char _kanji;
        private string _meaning;
        private string _kunyomi;
        private string _onyomi;

        public Kanji(char kanji, string meaning, string kunyomi, string onyomi)
        {
            _kanji = kanji;
            _meaning = meaning;
            _kunyomi = kunyomi;
            _onyomi = onyomi;
        }

        public char GetKanji()
        {
            return _kanji;
        }

        public string GetMeaning()
        {
            return _meaning;
        }

        public string GetKunyomi()
        {
            return _kunyomi;
        }

        public string GetOnyomi()
        {
            return _onyomi;
        }
    }
}
