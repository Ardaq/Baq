using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Baq_Sozdik.Classes
{
    class Converter
    {
        private const String KK_C_UC = "АӘБВГҒДЕЁЖЗИЙКҚЛМНҢОӨПРСТУҰҮФХҺЦЧШЩЪЫІЬЭЮЯ";
        private const String KK_C_LC = "аәбвгғдеёжзийкқлмнңоөпрстуұүфхһцчшщъыіьэюя";
        private const String KK_L_UC = "AÄBCÇDEÉFGĞHIİÏJKLMNÑOÖPQRSŞTUÜVWXYÝZ";
        private const String KK_L_LC = "aäbcçdeéfgğhıiïjklmnñoöpqrsştuüvwxyýz";
        private const String KK_A = "[ءابپتجحدرزسشعفقكلمنڭەوۇۋۆىيچھ]";
        private const String H_HAMZA = "ء";

        public static String Convert(String text, String variant)
        {
            const String letters = KK_C_LC + KK_C_UC;//KK_L_LC + KK_L_UC
            Regex front = new Regex("[әөүіӘӨҮІ]");// äöüiÄÖÜİ 
            Regex excludes = new Regex("[еэгғкқЕЭГҒКҚ]");// eégğkqEÉGĞKQ 
            Regex siziqsha = new Regex("[-]");
            if (text == "")
            {
                return text;
            }
            switch (variant)
            {
                case "kk-arab":
                case "kk-cn":
                    StringBuilder newtext = new StringBuilder();
                    String[] paragraphs = text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                    foreach(String paragraph in paragraphs)
                    {
                        StringBuilder newparagraph = new StringBuilder();
                        String[] words = Regex.Split(paragraph, @"[\b\s]+");
                        foreach (String word in words)
                        {
                            if (siziqsha.IsMatch(word))
                            {
                                StringBuilder newkossozb = new StringBuilder();
                                String[] kossoz = Regex.Split(word, "-");
                                foreach (String soz in kossoz)
                                {
                                    if (front.IsMatch(soz) & !excludes.IsMatch(soz))
                                    {
                                        String hamzaword = Regex.Replace(soz, "[" + letters + "]+", H_HAMZA + "$0");
                                        newkossozb.Append(CyrylictoArab(hamzaword) + "-");
                                    }
                                    else
                                    {
                                        newkossozb.Append(CyrylictoArab(soz) + "-");
                                    }
                                }
                                String newkossoz = newkossozb.ToString().Trim();
                                newkossoz = Regex.Replace(newkossoz, "-$", "");
                                newparagraph.Append(newkossoz + " ");
                            }
                            else
                            {
                                if (front.IsMatch(word) & !excludes.IsMatch(word))
                                {
                                    String hamzaword = Regex.Replace(word, "[" + letters + "]+", H_HAMZA + "$0");
                                    newparagraph.Append(CyrylictoArab(hamzaword) + " ");
                                }
                                else
                                {
                                    newparagraph.Append(CyrylictoArab(word) + " ");
                                }
                            }                            
                        }
                        newtext.Append(newparagraph.ToString().Trim() + "\r\n");
                    }
                    
                    text = newtext.ToString();
                    return text;
                case "kk-latn":
                case "kk":
                    text = CyrylictoLatin(text);
                    return text;
                case "latn-kk":
                    text = LatintoCyrylic(text);
                    return text;
                case "kk-cyrl":
                case "kk-kz":
                    return text;
                default:
                    return text;

            }
        }

        private static String CyrylictoLatin(string word)
        {
            word = Regex.Replace(word, "([АӘЕЁИОӨҰҮЭЮЯЪЬ])Е", "$1YE");
            word = Regex.Replace(word, "([АӘЕЁИОӨҰҮЭЮЯЪЬ])еi", "$1ye");
            word = Regex.Replace(word, "^Ё([" + KK_C_UC + "]|$)", "YO$1");
            word = Regex.Replace(word, "^Ё([" + KK_C_LC + "]|$)", "Yo$1");
            word = Regex.Replace(word, "^Ю([" + KK_C_UC + "]|$)", "YU$1");
            word = Regex.Replace(word, "^Ю([" + KK_C_LC + "]|$)", "Yu$1");
            word = Regex.Replace(word, "^Я([" + KK_C_UC + "]|$)", "YA$1");
            word = Regex.Replace(word, "^Я([" + KK_C_LC + "]|$)", "Ya$1");
            word = Regex.Replace(word, "^Щ([" + KK_C_UC + "]|$)", "ŞÇ$1");
            word = Regex.Replace(word, "^Щ([" + KK_C_LC + "]|$)", "Şç$1");
            word = Regex.Replace(word, "Ё", "YO");
            word = Regex.Replace(word, "ё", "yo");
            word = Regex.Replace(word, "Ю", "YU");
            word = Regex.Replace(word, "ю", "yu");
            word = Regex.Replace(word, "Я", "YA");
            word = Regex.Replace(word, "я", "ya");
            word = Regex.Replace(word, "Щ", "ŞÇ");
            word = Regex.Replace(word, "щ", "şç");
            word = Regex.Replace(word, "[ъЪ]", "ʺ");
            word = Regex.Replace(word, "[ьЬ]", "ʹ");
            word = Regex.Replace(word, "А", "A");
            word = Regex.Replace(word, "а", "a");
            word = Regex.Replace(word, "Ә", "Ä");
            word = Regex.Replace(word, "ә", "ä");
            word = Regex.Replace(word, "Б", "B");
            word = Regex.Replace(word, "б", "b");
            word = Regex.Replace(word, "В", "V");
            word = Regex.Replace(word, "в", "v");
            word = Regex.Replace(word, "Г", "G");
            word = Regex.Replace(word, "г", "g");
            word = Regex.Replace(word, "Ғ", "Ğ");
            word = Regex.Replace(word, "ғ", "ğ");
            word = Regex.Replace(word, "Д", "D");
            word = Regex.Replace(word, "д", "d");
            word = Regex.Replace(word, "Е", "E");
            word = Regex.Replace(word, "е", "e");
            word = Regex.Replace(word, "Ж", "J");
            word = Regex.Replace(word, "ж", "j");
            word = Regex.Replace(word, "З", "Z");
            word = Regex.Replace(word, "з", "z");
            word = Regex.Replace(word, "И", "Ï");
            word = Regex.Replace(word, "и", "ï");
            word = Regex.Replace(word, "Й", "Y");
            word = Regex.Replace(word, "й", "y");
            word = Regex.Replace(word, "К", "K");
            word = Regex.Replace(word, "к", "k");
            word = Regex.Replace(word, "Қ", "Q");
            word = Regex.Replace(word, "қ", "q");
            word = Regex.Replace(word, "Л", "L");
            word = Regex.Replace(word, "л", "l");
            word = Regex.Replace(word, "М", "M");
            word = Regex.Replace(word, "м", "m");
            word = Regex.Replace(word, "Н", "N");
            word = Regex.Replace(word, "н", "n");
            word = Regex.Replace(word, "Ң", "Ñ");
            word = Regex.Replace(word, "ң", "ñ");
            word = Regex.Replace(word, "О", "O");
            word = Regex.Replace(word, "о", "o");
            word = Regex.Replace(word, "Ө", "Ö");
            word = Regex.Replace(word, "ө", "ö");
            word = Regex.Replace(word, "П", "P");
            word = Regex.Replace(word, "п", "p");
            word = Regex.Replace(word, "Р", "R");
            word = Regex.Replace(word, "р", "r");
            word = Regex.Replace(word, "С", "S");
            word = Regex.Replace(word, "с", "s");
            word = Regex.Replace(word, "Т", "T");
            word = Regex.Replace(word, "т", "t");
            word = Regex.Replace(word, "У", "W");
            word = Regex.Replace(word, "у", "w");
            word = Regex.Replace(word, "Ұ", "U");
            word = Regex.Replace(word, "ұ", "u");
            word = Regex.Replace(word, "Ү", "Ü");
            word = Regex.Replace(word, "ү", "ü");
            word = Regex.Replace(word, "Ф", "F");
            word = Regex.Replace(word, "ф", "f");
            word = Regex.Replace(word, "Х", "X");
            word = Regex.Replace(word, "х", "x");
            word = Regex.Replace(word, "Һ", "H");
            word = Regex.Replace(word, "һ", "h");
            word = Regex.Replace(word, "Ц", "C");
            word = Regex.Replace(word, "ц", "c");
            word = Regex.Replace(word, "Ч", "Ç");
            word = Regex.Replace(word, "ч", "ç");
            word = Regex.Replace(word, "Ш", "Ş");
            word = Regex.Replace(word, "ш", "ş");
            word = Regex.Replace(word, "Ы", "I");
            word = Regex.Replace(word, "ы", "ı");
            word = Regex.Replace(word, "І", "İ");
            word = Regex.Replace(word, "і", "i");
            word = Regex.Replace(word, "Э", "É");
            word = Regex.Replace(word, "э", "é");

            return word;
        }

        private static String LatintoCyrylic(string word)
        {
            word = Regex.Replace(word, "ŞÇʹ", "ЩЬ");
            word = Regex.Replace(word, "Şçʹ", "Щь");
            word = Regex.Replace(word, "Ş[Çç]", "Щ");
            word = Regex.Replace(word, "şç", "щ");
            word = Regex.Replace(word, "([" + KK_L_UC + "])ʺ([" + KK_L_UC + "])", "$1Ъ$2");
            word = Regex.Replace(word, "ʺ([" + KK_L_LC + "])", "ъ$1");
            word = Regex.Replace(word, "([" + KK_L_UC + "])ʹ([" + KK_L_UC + "])", "$1Ь$2");
            word = Regex.Replace(word, "ʹ([" + KK_L_LC + "])", "ь$1");
            word = Regex.Replace(word, "ʺ", "ъ");
            word = Regex.Replace(word, "ʹ", "ь");
            word = Regex.Replace(word, "Y[Ee]", "Е");
            word = Regex.Replace(word, "ye", "е");
            word = Regex.Replace(word, "Y[Oo]", "Ё");
            word = Regex.Replace(word, "yo", "ё");
            word = Regex.Replace(word, "Y[UWuw]", "Ю");
            word = Regex.Replace(word, "y[uw]", "ю");
            word = Regex.Replace(word, "Y[Aa]", "Я");
            word = Regex.Replace(word, "ya", "я");
            word = Regex.Replace(word, "A", "А");
            word = Regex.Replace(word, "a", "а");
            word = Regex.Replace(word, "Ä", "Ә");
            word = Regex.Replace(word, "ä", "ә");
            word = Regex.Replace(word, "B", "Б");
            word = Regex.Replace(word, "b", "б");
            word = Regex.Replace(word, "C", "Ц");
            word = Regex.Replace(word, "c", "ц");
            word = Regex.Replace(word, "Ç", "Ч");
            word = Regex.Replace(word, "ç", "ч");
            word = Regex.Replace(word, "D", "Д");
            word = Regex.Replace(word, "d", "д");
            word = Regex.Replace(word, "E", "Е");
            word = Regex.Replace(word, "e", "е");
            word = Regex.Replace(word, "É", "Э");
            word = Regex.Replace(word, "é", "э");
            word = Regex.Replace(word, "F", "Ф");
            word = Regex.Replace(word, "f", "ф");
            word = Regex.Replace(word, "G", "Г");
            word = Regex.Replace(word, "g", "г");
            word = Regex.Replace(word, "Ğ", "Ғ");
            word = Regex.Replace(word, "ğ", "ғ");
            word = Regex.Replace(word, "H", "Һ");
            word = Regex.Replace(word, "h", "һ");
            word = Regex.Replace(word, "I", "Ы");
            word = Regex.Replace(word, "ı", "ы");
            word = Regex.Replace(word, "İ", "І");
            word = Regex.Replace(word, "i", "і");
            word = Regex.Replace(word, "Ï", "И");
            word = Regex.Replace(word, "ï", "и");
            word = Regex.Replace(word, "J", "Ж");
            word = Regex.Replace(word, "j", "ж");
            word = Regex.Replace(word, "K", "К");
            word = Regex.Replace(word, "k", "к");
            word = Regex.Replace(word, "L", "Л");
            word = Regex.Replace(word, "l", "л");
            word = Regex.Replace(word, "M", "М");
            word = Regex.Replace(word, "m", "м");
            word = Regex.Replace(word, "N", "Н");
            word = Regex.Replace(word, "n", "н");
            word = Regex.Replace(word, "Ñ", "Ң");
            word = Regex.Replace(word, "ñ", "ң");
            word = Regex.Replace(word, "O", "О");
            word = Regex.Replace(word, "o", "о");
            word = Regex.Replace(word, "Ö", "Ө");
            word = Regex.Replace(word, "ö", "ө");
            word = Regex.Replace(word, "P", "П");
            word = Regex.Replace(word, "p", "п");
            word = Regex.Replace(word, "Q", "Қ");
            word = Regex.Replace(word, "q", "қ");
            word = Regex.Replace(word, "R", "Р");
            word = Regex.Replace(word, "r", "р");
            word = Regex.Replace(word, "S", "С");
            word = Regex.Replace(word, "s", "с");
            word = Regex.Replace(word, "Ş", "Ш");
            word = Regex.Replace(word, "ş", "ш");
            word = Regex.Replace(word, "T", "Т");
            word = Regex.Replace(word, "t", "т");
            word = Regex.Replace(word, "U", "Ұ");
            word = Regex.Replace(word, "u", "ұ");
            word = Regex.Replace(word, "Ü", "Ү");
            word = Regex.Replace(word, "ü", "ү");
            word = Regex.Replace(word, "V", "В");
            word = Regex.Replace(word, "v", "в");
            word = Regex.Replace(word, "W", "У");
            word = Regex.Replace(word, "w", "у");
            word = Regex.Replace(word, "Ý", "Й");
            word = Regex.Replace(word, "ý", "й");
            word = Regex.Replace(word, "X", "Х");
            word = Regex.Replace(word, "x", "х");
            word = Regex.Replace(word, "Z", "З");
            word = Regex.Replace(word, "z", "з");
            return word;
        }

        private static String CyrylictoArab(string word)
        {
            word = Regex.Replace(word, ",", "،");
            word = Regex.Replace(word, ";", "؛");
            word = Regex.Replace(word, @"\?", "؟");
            word = Regex.Replace(word, "Аллаһ", "ﷲ");
            word = Regex.Replace(word, @"([АӘЕЁИОӨҰҮЭЮЯЪЬ])е", "$1يە");
            word = Regex.Replace(word, "[ЕеЭэ]", "ە");
            word = Regex.Replace(word, "[ЪъЬь]", "");
            word = Regex.Replace(word, "[АаӘә]", "ا");
            word = Regex.Replace(word, "[ОоӨө]", "و");
            word = Regex.Replace(word, "[ҰұҮү]", "ۇ");
            word = Regex.Replace(word, "[ЫыІі]", "ى");
            word = Regex.Replace(word, "[Ии]", "ىي");
            word = Regex.Replace(word, "[Ёё]", "يو");
            word = Regex.Replace(word, "[Юю]", "يۋ");
            word = Regex.Replace(word, "[Яя]", "يا");
            word = Regex.Replace(word, "[Йй]", "ي");
            word = Regex.Replace(word, "[Цц]", "تس");
            word = Regex.Replace(word, "[Щщ]", "شش");
            //word = Regex.Replace(word, "[Һһ]", "ح");әлі жеттi
            //word = Regex.Replace(word, "[Чч]", "تش");
            word = Regex.Replace(word, "[Һһ]", "ھ");
            word = Regex.Replace(word, "[Чч]", "چ");
            word = Regex.Replace(word, "[Бб]", "ب");
            word = Regex.Replace(word, "[Вв]", "ۆ");
            word = Regex.Replace(word, "[Гг]", "گ");
            word = Regex.Replace(word, "[Ғғ]", "ع");
            word = Regex.Replace(word, "[Дд]", "د");
            word = Regex.Replace(word, "[Жж]", "ج");
            word = Regex.Replace(word, "[Зз]", "ز");
            word = Regex.Replace(word, "[Кк]", "ك");
            word = Regex.Replace(word, "[Ққ]", "ق");
            word = Regex.Replace(word, "[Лл]", "ل");
            word = Regex.Replace(word, "[Мм]", "م");
            word = Regex.Replace(word, "[Нн]", "ن");
            word = Regex.Replace(word, "[Ңң]", "ڭ");
            word = Regex.Replace(word, "[Пп]", "پ");
            word = Regex.Replace(word, "[Рр]", "ر");
            word = Regex.Replace(word, "[Сс]", "س");
            word = Regex.Replace(word, "[Тт]", "ت");
            word = Regex.Replace(word, "[Уу]", "ۋ");
            word = Regex.Replace(word, "[Фф]", "ف");
            word = Regex.Replace(word, "[Хх]", "ح");
            word = Regex.Replace(word, "[Шш]", "ش");
            return word;
        }
    }
}
