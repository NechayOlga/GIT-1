using System.IO;
using System.Collections.Generic;
using System.Text;

namespace TranslitLinesTransformation
{
  /// <summary>
  /// Class is for filling dictionary.
  /// </summary>
  class SymbolsStorageCreator
  {
    /// <summary>
    /// Method fills dictionatry with relevant symbols.
    /// </summary>
    /// <param name="transformatedSymbols">line of symbols that should be transformated</param>
    /// <param name="transformatingSymbols">line of symbols that should be transformating</param>
    /// <returns></returns>
    public Dictionary<string, string> CreateSymbolsStorage(string transformatedSymbols, string transformatingSymbols)
    {
      Dictionary<string,string> SymbolsStorage = new Dictionary<string, string>();
      Encoding enc = Encoding.GetEncoding(1251);
      using (StreamReader transformatedSymbol = new StreamReader(transformatedSymbols, enc),
                        transformatingSymbol = new StreamReader(transformatingSymbols, enc))
      {
        while ((!transformatedSymbol.EndOfStream) || (!transformatingSymbol.EndOfStream))
        {
          SymbolsStorage.Add(transformatedSymbol.ReadLine(), transformatingSymbol.ReadLine());
        }
      }
      return SymbolsStorage;
    }
  }
}
