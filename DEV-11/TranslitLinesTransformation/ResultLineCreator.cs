using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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
    InvalidLine,
    DefaultValue
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
    public LanguageChoice Language(Dictionary<string, string> CyrillicsToLatin, Dictionary<string, string> LatinToCyrillics)
    {
			LanguageChoice language = LanguageChoice.DefaultValue;
      if (!(Regex.IsMatch(InputedLine, "[sh, shch,kh,zh,ch,SH,SHCH,KH,ZH,CH]+")) &&
						(Regex.IsMatch(InputedLine, "[x, q, j, w, h, X, Q, J, W, H]")))
      {
				language = LanguageChoice.InvalidLine;
      }
      else if ((Regex.IsMatch(InputedLine, "[sh, shch,kh,zh,ch,SH,SHCH,KH,ZH,CH]+"))||
                (!(Regex.IsMatch(InputedLine, "[x,q,j,w,h,X,Q,J,W,H]+"))) && 
								(Regex.IsMatch(InputedLine, "[a-zA-Z]+")))
			{
				language = LanguageChoice.Latin;

        if (Regex.IsMatch(InputedLine, "[а-яА-Я]+"))
				{
					language = LanguageChoice.NonExactlyLanguage;
        }
			}          
      else if (Regex.IsMatch(InputedLine, "[а-яА-Я]+"))
      {
				language = LanguageChoice.Cyrillics;
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
			foreach (KeyValuePair<string, string> kvp in transformatedSymbols)
			{
				InputedLine = InputedLine.Replace(kvp.Key, kvp.Value);
			}
      return InputedLine;
    }
  }
}
