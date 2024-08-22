using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula1408
{
    public class TipoEnum
    {
        public enum Language 
        {
            PTBR, EN, RU
        }

        public Language _language = Language.PTBR;

        public TipoEnum()
        {
            // default constructor
        }
/*        public TipoEnum(Language language)
        {
            _language = language;
        }
*/
        public Language GetLanguageEnum(string lang)
        {
            switch (lang.ToLower())
            {
                case "portugues":
                    return Language.PTBR;
                case "ingles":
                    return Language.EN;
                case "russo":
                    return Language.RU;
                default:
                    return Language.PTBR;
            }
        }
    }
}