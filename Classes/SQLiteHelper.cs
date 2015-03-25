using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baq_Sozdik.Classes
{
    class SQLiteHelper
    {
        public static DataTable GetWordListInDictionaryWord(String word)
        {
            DataTable dt = new DataTable();
            if (word == "") word += 'а';
            String words = word + '%';
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Links.ConnectionStringSQLite))
                {
                    conn.Open();
                    //DbTransaction trans = conn.BeginTransaction();
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT [Word] FROM [DictionaryDefinition] WHERE Word LIKE @Word GROUP BY [Word] ;";
                    cmd.Parameters.Add(new SQLiteParameter("Word", words));
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dt.Load(dr);
                    }
                    else
                    {
                        //throw new NullReferenceException("No Record Available.");
                    }

                    //trans.Commit();
                    dr.Close();
                }
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message + " \n\n" + ae.Source + "\n\n" + ae.StackTrace);
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;
        }

        public static DataTable GetWordListInArabicWord(String word)
        {
            DataTable dt = new DataTable();
            if (word == "") word += 'ا';
            String words = word + '%';
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Links.ConnectionStringSQLite))
                {
                    conn.Open();
                    //DbTransaction trans = conn.BeginTransaction();
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT [ArabicWord] FROM [ArabicWords] WHERE [ArabicWord] LIKE @Word GROUP BY [ArabicWord] ;";
                    cmd.Parameters.Add(new SQLiteParameter("Word", words));
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dt.Load(dr);
                    }
                    else
                    {
                        //throw new NullReferenceException("No Record Available.");
                    }

                    //trans.Commit();
                    dr.Close();
                }
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message + " \n\n" + ae.Source + "\n\n" + ae.StackTrace);
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;
        }

        public static DictionaryDefinition GetWordDictArab(String word)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Links.ConnectionStringSQLite))
                {
                    conn.Open();
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT [DictionaryDefinition].[Word] FROM [DictionaryDefinition]  INNER JOIN [ArabicWords] ON [DictionaryDefinition].[Id] = [ArabicWords].[DefinitionId] WHERE [ArabicWords].[ArabicWord] = @word GROUP BY [ArabicWord];";
                    cmd.Parameters.Add(new SQLiteParameter("word", word));
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        DictionaryDefinition dictword = new DictionaryDefinition();
                        dictword.Word = dr.GetString(0);
                        return dictword;
                    }
                    else
                    {
                        DictionaryDefinition dictword = new DictionaryDefinition();
                        dictword.Word = "";
                        return dictword;
                    }
                }
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message + " \n\n" + ae.Source + "\n\n" + ae.StackTrace);
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DictionaryDefinition GetWordGrammarType(string word)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Links.ConnectionStringSQLite))
                {
                    conn.Open();
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT DISTINCT [DictionaryDefinition].[GrammerTypeName] FROM [DictionaryDefinition] WHERE Word = @Word;";
                    cmd.Parameters.Add(new SQLiteParameter("Word", word));
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        List<String> grammarType = new List<String>();
                        grammarType.Add(dr.GetString(0));

                        while (dr.Read())
                        {
                            grammarType.Add(dr.GetString(0));
                        }
                        DictionaryDefinition dictword = new DictionaryDefinition();
                        //dictword.GrammerTypeName[0] = dr.GetString(0);
                        dictword.GrammerTypeName = grammarType;
                        return dictword;
                    }
                    else
                    {
                        List<string> wordGT = new List<string>();
                        wordGT.Add("");
                        DictionaryDefinition dictword = new DictionaryDefinition();
                        dictword.GrammerTypeName = wordGT;
                        return dictword;
                    }
                }
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message + " \n\n" + ae.Source + "\n\n" + ae.StackTrace);
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DictionaryDefinition GetWordIds(string word, string gramtype)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Links.ConnectionStringSQLite))
                {
                    conn.Open();
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT [DictionaryDefinition].[Id] FROM [DictionaryDefinition] WHERE Word = @Word AND GrammerTypeName = @gramtype;";
                    cmd.Parameters.Add(new SQLiteParameter("Word", word));
                    cmd.Parameters.Add(new SQLiteParameter("gramtype", gramtype));
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        List<Int64> wordID = new List<Int64>();
                        wordID.Add(dr.GetInt64(0));

                        while (dr.Read())
                        {
                            wordID.Add(dr.GetInt64(0));
                        }
                        DictionaryDefinition dictword = new DictionaryDefinition();
                        //dictword.GrammerTypeName[0] = dr.GetString(0);
                        dictword.Id = wordID;
                        return dictword;
                    }
                    else
                    {
                        List<Int64> wordID = new List<Int64>();
                        wordID.Add(0);
                        DictionaryDefinition dictword = new DictionaryDefinition();
                        dictword.Id = wordID;
                        return dictword;
                    }
                }
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message + " \n\n" + ae.Source + "\n\n" + ae.StackTrace);
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static WordDefinitions GetWordDefinition(Int64 id)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Links.ConnectionStringSQLite))
                {
                    conn.Open();
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT [WordDefinitions].[Definition] FROM [WordDefinitions] WHERE [DefinitionId] = @id;";
                    cmd.Parameters.Add(new SQLiteParameter("id", id));
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        WordDefinitions dictword = new WordDefinitions();
                        dictword.Definition = dr.GetString(0);
                        return dictword;
                    }
                    else
                    {
                        WordDefinitions dictword = new WordDefinitions();
                        dictword.Definition = "";
                        return dictword;
                    }
                }
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message + " \n\n" + ae.Source + "\n\n" + ae.StackTrace);
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static WordFromForeign GetWordForeign(Int64 id)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Links.ConnectionStringSQLite))
                {
                    conn.Open();
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT [WordFromForeign].[ForeignLanguage] FROM [WordFromForeign] WHERE [DefinitionId] = @id;";
                    cmd.Parameters.Add(new SQLiteParameter("id", id));
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        List<String> wordID = new List<String>();
                        wordID.Add(dr.GetString(0));

                        while (dr.Read())
                        {
                            wordID.Add(dr.GetString(0));
                        }
                        WordFromForeign dictword = new WordFromForeign();
                        //dictword.GrammerTypeName[0] = dr.GetString(0);
                        dictword.ForeignLanguage = wordID;
                        return dictword;
                    }
                    else
                    {
                        List<String> wordID = new List<String>();
                        wordID.Add("");
                        WordFromForeign dictword = new WordFromForeign();
                        dictword.ForeignLanguage = wordID;
                        return dictword;
                    }
                }
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message + " \n\n" + ae.Source + "\n\n" + ae.StackTrace);
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static WordCategory GetWordCategory(Int64 id)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Links.ConnectionStringSQLite))
                {
                    conn.Open();
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT [WordCategory].[Category] FROM [WordCategory] WHERE [DefinitionId] = @id;";
                    cmd.Parameters.Add(new SQLiteParameter("id", id));
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        List<String> wordID = new List<String>();
                        wordID.Add(dr.GetString(0));

                        while (dr.Read())
                        {
                            wordID.Add(dr.GetString(0));
                        }
                        WordCategory dictword = new WordCategory();
                        //dictword.GrammerTypeName[0] = dr.GetString(0);
                        dictword.Category = wordID;
                        return dictword;
                    }
                    else
                    {
                        List<String> wordID = new List<String>();
                        wordID.Add("");
                        WordCategory dictword = new WordCategory();
                        dictword.Category = wordID;
                        return dictword;
                    }
                }
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message + " \n\n" + ae.Source + "\n\n" + ae.StackTrace);
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DefinitionWordRelation GetWordRelation(Int64 id)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Links.ConnectionStringSQLite))
                {
                    conn.Open();
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT [DefinitionWordRelation].[Relation], [DefinitionWordRelation].[Word] FROM [DefinitionWordRelation] WHERE [DefinitionId] = @id;";
                    cmd.Parameters.Add(new SQLiteParameter("id", id));
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        DefinitionWordRelation dictword = new DefinitionWordRelation();
                        dictword.Relation = dr.GetString(0);
                        dictword.Word = dr.GetString(1);
                        return dictword;
                    }
                    else
                    {
                        DefinitionWordRelation dictword = new DefinitionWordRelation();
                        dictword.Relation = "";
                        return dictword;
                    }
                }
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message + " \n\n" + ae.Source + "\n\n" + ae.StackTrace);
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DefinitionExample GetWordExample(Int64 id)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Links.ConnectionStringSQLite))
                {
                    conn.Open();
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT [DefinitionExample].[Example] FROM [DefinitionExample] WHERE [DefinitionId] = @id;";
                    cmd.Parameters.Add(new SQLiteParameter("id", id));
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        DefinitionExample dictword = new DefinitionExample();
                        dictword.Example = dr.GetString(0);
                        return dictword;
                    }
                    else
                    {
                        DefinitionExample dictword = new DefinitionExample();
                        dictword.Example = "";
                        return dictword;
                    }
                }
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message + " \n\n" + ae.Source + "\n\n" + ae.StackTrace);
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
    }
}
