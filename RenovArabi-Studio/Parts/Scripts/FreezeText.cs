using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Vars file...
var Harakat = "ﱠﳲﱠﳳﱢﳴﱞﱟﹰﹱﹲﹴﹶﹷﹸﹹﹺﹻﹼﹽﹾﹿًٌٍَُِّْ";
var CharsConnectsBack = "آأؤإاةدذرزوىٱڍڌڎڈژڑۀےۓۇۆۈۋۅۉ";
var CharsConnectsBoth = "ئبتثجحخسشصضطظعغفقكلمنهيـٻپڀٺٿٹڤڦڄڃچڇکگڳڱںڻہھڭېی";
var LaDict = new Dictionary<string, string>() {
    { "ﻟﺂ", "ﻵ" }, { "ﻠﺂ", "ﻶ" },
    { "ﻟﺄ", "ﻷ" }, { "ﻠﺄ", "ﻸ" },
    { "ﻟﺈ", "ﻹ" }, { "ﻠﺈ", "ﻺ" },
    { "ﻟﺎ", "ﻻ" }, { "ﻠﺎ", "ﻼ" }
};

var FreezedLettersDict = new Dictionary<string, List<string>>() {
            //<initial><medial><final><isolated>
            { "ء", new List<string>() { "ﺀ", "ﺀ", "ﺀ", "ﺀ" } },
            { "آ", new List<string>() { "ﺁ", "ﺂ", "ﺂ", "ﺁ" } },
            { "أ", new List<string>() { "ﺃ", "ﺄ", "ﺄ", "ﺃ" } },
            { "ؤ", new List<string>() { "ﺅ", "ﺆ", "ﺆ", "ﺅ" } },
            { "إ", new List<string>() { "ﺇ", "ﺈ", "ﺈ", "ﺇ" } },
            { "ئ", new List<string>() { "ﺋ", "ﺌ", "ﺊ", "ﺉ" } },
            { "ا", new List<string>() { "ﺍ", "ﺎ", "ﺎ", "ﺍ" } },
            { "ب", new List<string>() { "ﺑ", "ﺒ", "ﺐ", "ﺏ" } },
            { "ة", new List<string>() { "ﺓ", "ﺔ", "ﺔ", "ﺓ" } },
            { "ت", new List<string>() { "ﺗ", "ﺘ", "ﺖ", "ﺕ" } },
            { "ث", new List<string>() { "ﺛ", "ﺜ", "ﺚ", "ﺙ" } },
            { "ج", new List<string>() { "ﺟ", "ﺠ", "ﺞ", "ﺝ" } },
            { "ح", new List<string>() { "ﺣ", "ﺤ", "ﺢ", "ﺡ" } },
            { "خ", new List<string>() { "ﺧ", "ﺨ", "ﺦ", "ﺥ" } },
            { "د", new List<string>() { "ﺩ", "ﺪ", "ﺪ", "ﺩ" } },
            { "ذ", new List<string>() { "ﺫ", "ﺬ", "ﺬ", "ﺫ" } },
            { "ر", new List<string>() { "ﺭ", "ﺮ", "ﺮ", "ﺭ" } },
            { "ز", new List<string>() { "ﺯ", "ﺰ", "ﺰ", "ﺯ" } },
            { "س", new List<string>() { "ﺳ", "ﺴ", "ﺲ", "ﺱ" } },
            { "ش", new List<string>() { "ﺷ", "ﺸ", "ﺶ", "ﺵ" } },
            { "ص", new List<string>() { "ﺻ", "ﺼ", "ﺺ", "ﺹ" } },
            { "ض", new List<string>() { "ﺿ", "ﻀ", "ﺾ", "ﺽ" } },
            { "ط", new List<string>() { "ﻃ", "ﻄ", "ﻂ", "ﻁ" } },
            { "ظ", new List<string>() { "ﻇ", "ﻈ", "ﻆ", "ﻅ" } },
            { "ع", new List<string>() { "ﻋ", "ﻌ", "ﻊ", "ﻉ" } },
            { "غ", new List<string>() { "ﻏ", "ﻐ", "ﻎ", "ﻍ" } },
            { "ف", new List<string>() { "ﻓ", "ﻔ", "ﻒ", "ﻑ" } },
            { "ق", new List<string>() { "ﻗ", "ﻘ", "ﻖ", "ﻕ" } },
            { "ك", new List<string>() { "ﻛ", "ﻜ", "ﻚ", "ﻙ" } },
            { "ل", new List<string>() { "ﻟ", "ﻠ", "ﻞ", "ﻝ" } },
            { "م", new List<string>() { "ﻣ", "ﻤ", "ﻢ", "ﻡ" } },
            { "ن", new List<string>() { "ﻧ", "ﻨ", "ﻦ", "ﻥ" } },
            { "ه", new List<string>() { "ﻫ", "ﻬ", "ﻪ", "ﻩ" } },
            { "و", new List<string>() { "ﻭ", "ﻮ", "ﻮ", "ﻭ" } },
            { "ى", new List<string>() { "ﻯ", "ﻰ", "ﻰ", "ﻯ" } },
            { "ي", new List<string>() { "ﻳ", "ﻴ", "ﻲ", "ﻱ" } },
            { "لآ", new List<string>() { "ﻵ", "ﻶ", "ﻶ", "ﻵ" } },
            { "لأ", new List<string>() { "ﻷ", "ﻸ", "ﻸ", "ﻷ" } },
            { "لإ", new List<string>() { "ﻹ", "ﻺ", "ﻺ", "ﻹ" } },
            { "لا", new List<string>() { "ﻻ", "ﻼ", "ﻼ", "ﻻ" } },
            { "پ", new List<string>() { "ﭘ", "ﭙ", "ﭗ", "ﭖ" } },
            { "چ", new List<string>() { "ﭼ", "ﭽ", "ﭻ", "ﭺ" } },
            { "ڤ", new List<string>() { "ﭬ", "ﭭ", "ﭫ", "ﭪ" } },
            { "ـ", new List<string>() { "ـ", "ـ", "ـ", "ـ" } },
            { "ً", new List<string>() { "ﹰ", "ﹰ", "ﹰ", "ﹰ" } },
            { "ٌ", new List<string>() { "ﹲ", "ﹲ", "ﹲ", "ﹲ" } },
            { "ٍ", new List<string>() { "ﹴ", "ﹴ", "ﹴ", "ﹴ" } },
            { "َ", new List<string>() { "ﹶ", "ﹶ", "ﹶ", "ﹶ" } },
            { "ُ", new List<string>() { "ﹸ", "ﹸ", "ﹸ", "ﹸ" } },
            { "ِ", new List<string>() { "ﹺ", "ﹺ", "ﹺ", "ﹺ" } },
            { "ّ", new List<string>() { "ﹼ", "ﹼ", "ﹼ", "ﹼ" } },
            { "ْ", new List<string>() { "ﹾ", "ﹾ", "ﹾ", "ﹾ" } },
            { "ٱ", new List<string>() { "ﭐ", "ﭑ", "ﭑ", "ﭐ" } },
            { "ٻ", new List<string>() { "ﭔ", "ﭕ", "ﭓ", "ﭒ" } },
            { "پ", new List<string>() { "ﭘ", "ﭙ", "ﭗ", "ﭖ" } },
            { "ڀ", new List<string>() { "ﭜ", "ﭝ", "ﭛ", "ﭚ" } },
            { "ٺ", new List<string>() { "ﭠ", "ﭡ", "ﭟ", "ﭞ" } },
            { "ٿ", new List<string>() { "ﭤ", "ﭥ", "ﭣ", "ﭢ" } },
            { "ٹ", new List<string>() { "ﭨ", "ﭩ", "ﭧ", "ﭦ" } },
            { "ڤ", new List<string>() { "ﭬ", "ﭭ", "ﭫ", "ﭪ" } },
            { "ڦ", new List<string>() { "ﭰ", "ﭱ", "ﭯ", "ﭮ" } },
            { "ڄ", new List<string>() { "ﭴ", "ﭵ", "ﭳ", "ﭲ" } },
            { "ڃ", new List<string>() { "ﭸ", "ﭹ", "ﭷ", "ﭶ" } },
            { "چ", new List<string>() { "ﭼ", "ﭽ", "ﭻ", "ﭺ" } },
            { "ڇ", new List<string>() { "ﮀ", "ﮁ", "ﭿ", "ﭾ" } },
            { "ڍ", new List<string>() { "ﮂ", "ﮃ", "ﮃ", "ﮂ" } },
            { "ڌ", new List<string>() { "ﮄ", "ﮅ", "ﮅ", "ﮄ" } },
            { "ڎ", new List<string>() { "ﮆ", "ﮇ", "ﮇ", "ﮆ" } },
            { "ڈ", new List<string>() { "ﮈ", "ﮉ", "ﮉ", "ﮈ" } },
            { "ژ", new List<string>() { "ﮊ", "ﮋ", "ﮋ", "ﮊ" } },
            { "ڑ", new List<string>() { "ﮌ", "ﮍ", "ﮍ", "ﮌ" } },
            { "ک", new List<string>() { "ﮐ", "ﮑ", "ﮏ", "ﮎ" } },
            { "گ", new List<string>() { "ﮔ", "ﮕ", "ﮓ", "ﮒ" } },
            { "ڳ", new List<string>() { "ﮘ", "ﮙ", "ﮗ", "ﮖ" } },
            { "ڱ", new List<string>() { "ﮜ", "ﮝ", "ﮛ", "ﮚ" } },
            { "ں", new List<string>() { "ﯨ", "ﯩ", "ﮟ", "ﮞ" } },
            { "ڻ", new List<string>() { "ﮢ", "ﮣ", "ﮡ", "ﮠ" } },
            { "ۀ", new List<string>() { "ﮤ", "ﮥ", "ﮥ", "ﮤ" } },
            { "ہ", new List<string>() { "ﮨ", "ﮩ", "ﮧ", "ﮦ" } },
            { "ھ", new List<string>() { "ﮬ", "ﮭ", "ﮫ", "ﮪ" } },
            { "ے", new List<string>() { "ﮮ", "ﮯ", "ﮯ", "ﮮ" } },
            { "ۓ", new List<string>() { "ﮰ", "ﮱ", "ﮱ", "ﮰ" } },
            { "ڭ", new List<string>() { "ﯕ", "ﯖ", "ﯔ", "ﯓ" } },
            { "ۇ", new List<string>() { "ﯗ", "ﯘ", "ﯘ", "ﯗ" } },
            { "ۆ", new List<string>() { "ﯙ", "ﯚ", "ﯚ", "ﯙ" } },
            { "ۈ", new List<string>() { "ﯛ", "ﯜ", "ﯜ", "ﯛ" } },
            { "ۋ", new List<string>() { "ﯞ", "ﯟ", "ﯟ", "ﯞ" } },
            { "ۅ", new List<string>() { "ﯠ", "ﯡ", "ﯡ", "ﯠ" } },
            { "ۉ", new List<string>() { "ﯢ", "ﯣ", "ﯣ", "ﯢ" } },
            { "ې", new List<string>() { "ﯦ", "ﯧ", "ﯥ", "ﯤ" } },
            { "ی", new List<string>() { "ﯾ", "ﯿ", "ﯽ", "ﯼ" } }
        };

namespace RenovArabi_Studio.Parts
{
    internal class FreezeText
    {
        public static string FreezeArabic(string text, bool mergLa = true, bool Switch = true)
        {
            string T = " " + text + " ";

            if (Switch)
            {
                foreach (int i in Enumerable.Range(1, T.Length - 1)) {
                    bool connectsBack, connectsNext = CheckNeighbors(T, i);
                    
                    if ( !FreezedLettersDict.ContainsKey(T[i]) ) {
                        continue;
                    }

                    if (!connectsBack && connectsNext ) {
                        text = text.Replace(T[i], FreezedLettersDict[T[i]][0]);
                    }
                    else if ( connectsBack && connectsNext ) {
                        text = text.Replace(T[i], FreezedLettersDict[T[i]][1]);
                    }
                    else if ( connectsBack && !connectsNext ) {
                        text = text.Replace(T[i], FreezedLettersDict[T[i]][2]);
                    }
                    else if ( !connectsBack && !connectsNext ) {
                        text = text.Replace(T[i], FreezedLettersDict[T[i]][3]);
                    }
                }

                return text;
            }
            else
            {
                foreach ( KeyValuePair<string, object> kvp in FreezedLettersDict ) {
                    foreach ( char c in kvp.Value) ) {
                        text = text.Replace(c, kvp.Key);
                    }
                }
                return text;
            }
        }

        public static bool CheckNeighbors(string text, int index)
        {
            int toPreviousChar = 1;
            while ( Harakat.Contains(text[index - toPreviousChar]) ) {
                toPreviousChar++;
            }
            if ( CharsConnectsBoth.Contains(text[index - toPreviousChar]) ) {
                bool connectsBack = true;
            }
            else {
                bool connectsBack = false;
            }

            int toNextChar = 1;
            while ( Harakat.Contains(text[index + toNextChar]) ) {
                toNextChar++;
            }
            if ( CharsConnectsBoth.Contains(text[index]) && (CharsConnectsBoth.Contains(text[index + toNextChar]) || CharsConnectsBack.Contains(text[index + toNextChar])) ) {
                bool connectsNext = true;
            }
            else {
                bool connectsNext = false;
            }

            return connectsBack, connectsNext;
        }
    }
}
