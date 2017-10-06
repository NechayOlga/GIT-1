using System.Collections.Generic;

namespace TranslitLinesTransformation
{
    /// <summary>
    /// enum LanguageChoice contains
    /// markers of language
    /// </summary>
    public enum LanguageChoice
    {
        Latin,
        Cyrillics,
        NonExactlyLanguage,
        EmptyLine
    }
    /// <summary>
    /// Class is for creating the result line
    /// with relaced symbols.
    /// </summary>
    class ResultLineCreator
    {
        public string InputedLine
        { get; private set; }
        public ResultLineCreator(string inputedLine)
        {
            InputedLine = inputedLine;
        }
        /// <summary>
        /// Method is for choose the rigth language.
        /// </summary>
        /// <param name="CyrillicsToLatin">is dictionary contains cyrrillics symbols as keys and latin as values</param>
        /// <param name="LatinToCyrillics">is dictionary contains latin symbols as keys and cyrillics as values</param>
        /// <returns>marker of relevant language</returns>
        public LanguageChoice Language(Dictionary<string , string> CyrillicsToLatin, Dictionary<string, string> LatinToCyrillics)
        {
            LanguageChoice language = LanguageChoice.Latin;
            foreach (KeyValuePair<string, string> cyrillicsToLatin in CyrillicsToLatin)
            {
                if (InputedLine.Contains(cyrillicsToLatin.Key))
                {
                    language = LanguageChoice.Cyrillics;
                }
                foreach (KeyValuePair<string, string> latinToCyrillics in LatinToCyrillics)
                {
                    if (InputedLine.Contains(latinToCyrillics.Key)&&InputedLine.Contains(cyrillicsToLatin.Key))
                    {
                        language = LanguageChoice.NonExactlyLanguage;
                    }
                }
            }
             return language;
        }

        /// <summary>
        /// Method replaces symbols in inputed line.
        /// </summary>
        /// <param name="transformatedSymbols">dictionary of transformated symbols</param>
        /// <returns>line with replaced simbols</returns>
        public string ReplacedLine(Dictionary<string, string> transformatedSymbols)
        {
            foreach(KeyValuePair<string, string> kvp in transformatedSymbols)
            {
                InputedLine = InputedLine.Replace(kvp.Key, kvp.Value);
            }
            return InputedLine;
        }
    }
}
