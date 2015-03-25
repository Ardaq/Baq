using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Baq_Sozdik.Classes
{
    class HtmlBuilder
    {
        public static String GetDict(String word, String lang)
        {
            List<String> gramerType = SQLiteHelper.GetWordGrammarType(word).GrammerTypeName;
            String dictionary = string.Empty;
            dictionary += HtmlHelper.head + word + HtmlHelper.headtitle;
            if(lang == "kk-cn" | lang == "kk-arab")
            {
                dictionary += HtmlHelper.bodyhead + " dir=\"rtl\">" + HtmlHelper.containerhead;
            }
            else
            {
                dictionary += HtmlHelper.bodyhead + ">" + HtmlHelper.containerhead;
            }
            
            dictionary += HtmlHelper.bodyheadh1 + Converter.Convert( word,lang).ToUpper() + HtmlHelper.bodyendh1;
            if (gramerType[0] != "")
            {
                dictionary += HtmlHelper.dictcontainerhead;
                foreach (string gt in gramerType)
                {
                    List<Int64> wordId = SQLiteHelper.GetWordIds(word, gt).Id;
                    dictionary += HtmlHelper.wordtabshead + Converter.Convert(gt, lang) + HtmlHelper.wordtabsend;
                    int idcnt = 0;
                    foreach (Int64 id in wordId)
                    {
                        String examples = Converter.Convert(SQLiteHelper.GetWordExample(id).Example,lang);
                        idcnt++;

                        dictionary += HtmlHelper.definitionhead;
                        dictionary += HtmlHelper.definitionpanelshead;
                        dictionary += HtmlHelper.definitionpanelsh4head;
                        dictionary += HtmlHelper.definitionpanelsh4ahead + gt.Replace(" ", "") + idcnt + HtmlHelper.definitionpanelsh4ahrefend;
                        dictionary += HtmlHelper.definitionpanelsh4abadgehead + idcnt + HtmlHelper.definitionpanelsh4abadgeend;
                        dictionary += HtmlHelper.definitionpanelsh4aspanhead + Converter.Convert(SQLiteHelper.GetWordDefinition(id).Definition,lang) + HtmlHelper.definitionpanelsh4aspanend;
                        dictionary += HtmlHelper.definitionpanelsh4aend;
                        dictionary += HtmlHelper.definitionpanelsh4end;
                        dictionary += HtmlHelper.definitionpanelsend;

                        dictionary += HtmlHelper.defcollapsehead + gt.Replace(" ", "") + idcnt + HtmlHelper.defcollapseheadin;
                        dictionary += HtmlHelper.definitionbodyhead;
                        dictionary += HtmlHelper.definitionbodydivhead;
                        if (SQLiteHelper.GetWordRelation(id).Relation != "")
                        {
                            dictionary += HtmlHelper.divrelationhead + Converter.Convert(SQLiteHelper.GetWordRelation(id).Relation,lang) + HtmlHelper.divrelationend + HtmlHelper.divrelationwhead + Converter.Convert(SQLiteHelper.GetWordRelation(id).Word,lang) + HtmlHelper.divrelationwend;
                        }
                        if (SQLiteHelper.GetWordCategory(id).Category[0] != "")
                        {
                            foreach (String category in SQLiteHelper.GetWordCategory(id).Category)
                            {
                                dictionary += HtmlHelper.divcatetoryhead + Converter.Convert(category,lang) + HtmlHelper.divcatetoryend;
                            }
                        }
                        if (SQLiteHelper.GetWordForeign(id).ForeignLanguage[0] != "")
                        {
                            foreach (String language in SQLiteHelper.GetWordForeign(id).ForeignLanguage)
                            {
                                dictionary += HtmlHelper.divlanguageshead + Converter.Convert(language,lang) + HtmlHelper.divlanguagesend;
                            }
                        }
                        dictionary += HtmlHelper.definitionbodydivend;
                        if (examples != "")
                        {
                            dictionary += HtmlHelper.examplepanelhead;
                            dictionary += HtmlHelper.example;
                            dictionary += HtmlHelper.examplebodyhead + examples + HtmlHelper.examplebodyend;
                            dictionary += HtmlHelper.examplepanelend;
                        }
                        dictionary += HtmlHelper.definitionbodyend;
                        dictionary += HtmlHelper.defcollapseend;
                        dictionary += HtmlHelper.definitionend;
                    }
                }
                dictionary += HtmlHelper.dictcontainerend;
            }
            else
            {
                dictionary += HtmlHelper.worning;
            }
            dictionary += HtmlHelper.containerend;
            dictionary += HtmlHelper.wikihead;
            dictionary += getWikiWebSource(word,lang);
            dictionary += HtmlHelper.wikiend;
            dictionary += HtmlHelper.bodyend;
            dictionary += HtmlHelper.end;

            return dictionary;
        }

        private static String getWikiWebSource(String word,String lang)
        {
            String urls = Links.Wikipediaurl + word + "&variant=" +lang;
            Uri url = new Uri(urls);

            HttpWebRequest HttpWReq = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse HttpWResp;
            Stream resStream;
            try
            {
                HttpWResp = (HttpWebResponse)HttpWReq.GetResponse();
            }
            catch (WebException ex)
            {
                HttpWResp = (HttpWebResponse)ex.Response;
            }
            try
            {
                resStream = HttpWResp.GetResponseStream();
            }
            catch (NullReferenceException)
            {
                return "<div>Сіздің компьютеріңіз интернетке жалғанбаған</div>";
            }
            
            Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader readStream = new StreamReader(resStream, encode);
            String sourcecode = readStream.ReadToEnd();
            HttpWResp.Close();
            readStream.Close();////kk.wikipedia.org/
            sourcecode = sourcecode.Replace("//upload.wikimedia.org", "https://upload.wikimedia.org");
            sourcecode = sourcecode.Replace("//kk.wikipedia.", "#");
            return sourcecode;
        }
    }
}
