using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baq_Sozdik.Classes
{
    public partial class DefinitionExample
    {
        public Int64 Id { get; set; }

        public Int64 DefinitionId { get; set; }

        public String Example { get; set; }
    }

    public partial class DefinitionWordRelation
    {
        public Int64 Id { get; set; }

        public Int64 DefinitionId { get; set; }

        public String Word { get; set; }

        public String Relation { get; set; }
    }

    public partial class DictionaryDefinition
    {
        public List<Int64> Id { get; set; }

        public Int64 IdI { get; set; }

        public String Definition { get; set; }

        public String Word { get; set; }

        public List<String> GrammerTypeName { get; set; }
    }

    public partial class GrammaType
    {
        public String Name { get; set; }

        public String LongName { get; set; }
    }

    public partial class WordCategory
    {
        public Int64 DefinitionId { get; set; }

        public List<String> Category { get; set; }
    }

    public partial class ArabicWords
    {
        public Int64 DefinitionId { get; set; }

        public String ArabicWord { get; set; }
    }

    public partial class WordFromForeign
    {
        public Int64 DefinitionId { get; set; }

        public List<String> ForeignLanguage { get; set; }
    }

    public partial class WordDefinitions
    {
        public Int64 DefinitionId { get; set; }

        public String Definition { get; set; }
    }
}
