using System;
using System.Collections.Generic;
using System.IO;

namespace TranslitLinesTransformation
{
  /// <summary>
  /// The entry point of programm.
  /// </summary>
  class EntryPoint
  {
    private const string cyrillicsToLatin = @"e:\TAT\GIT-1\DEV-11\TranslitLinesTransformation\CyrillicsToLatin.txt";
    private const string latinFromCyrillic = @"e:\TAT\GIT-1\DEV-11\TranslitLinesTransformation\LatinFromCyrillics.txt";
    private const string latinToCyrillics = @"e:\TAT\GIT-1\DEV-11\TranslitLinesTransformation\LatinToCyrillics.txt";
    private const string cyrillicsFromLatin = @"e:\TAT\GIT-1\DEV-11\TranslitLinesTransformation\CyrillicsFromLatin.txt";

    const string INVALIDLINE = "Line is invalid. Line must be olny cyrillics or only latin";
    const string FILENOTFOUND = "The text file isn't found.";
    const string NONTRASLITLINE = "This line can't be transformed to translit";
    
    /// <summary>
    /// The inputed line is created.
    /// The object of SymbolsStorageCreator is created,
    /// method CreateSumbolsStorage is called and then dictionaries are filled.
    /// The object of ResultLineCreator is created, 
    /// method symbolsReplacer is called and symbols in inputed line are replaced.
    /// </summary>
    static void Main(string[] args)
    {
      try
      {
        string inputedLine = Console.ReadLine();

        SymbolsStorageCreator cyrillicsStorage = new SymbolsStorageCreator();
        Dictionary<string, string> CyrillicsToLatin = cyrillicsStorage.CreateSymbolsStorage(cyrillicsToLatin, latinFromCyrillic);
        SymbolsStorageCreator latinStorage = new SymbolsStorageCreator();
        Dictionary<string, string> LatinToCyrillics = latinStorage.CreateSymbolsStorage(latinToCyrillics, cyrillicsFromLatin);

        ResultLineCreator symbolsReplacer = new ResultLineCreator(inputedLine);
      
        if (symbolsReplacer.Language(CyrillicsToLatin, LatinToCyrillics) == LanguageChoice.Cyrillics)
        {
          inputedLine = symbolsReplacer.ReplacedLine(CyrillicsToLatin);
        }
        else if (symbolsReplacer.Language(CyrillicsToLatin, LatinToCyrillics) == LanguageChoice.Latin)
        {
          inputedLine = symbolsReplacer.ReplacedLine(LatinToCyrillics);
        }
        else if (symbolsReplacer.Language(CyrillicsToLatin, LatinToCyrillics) == LanguageChoice.NonExactlyLanguage)
        {
          throw new InvalidLineException(INVALIDLINE);
        }
        else if((symbolsReplacer.Language(CyrillicsToLatin, LatinToCyrillics)) == LanguageChoice.InvalidLine ||
                (symbolsReplacer.Language(CyrillicsToLatin, LatinToCyrillics)) == LanguageChoice.DefaultValue)
        {
          throw new FormatException();
        }
        Console.WriteLine(inputedLine);
        Console.ReadKey();
      }
      catch (InvalidLineException message)
      {
       Console.WriteLine(message);
      }
      catch (FileNotFoundException)
      {
       Console.WriteLine(FILENOTFOUND);
      }
      catch (FormatException)
      {
       Console.WriteLine(NONTRASLITLINE);
      }
      Console.ReadKey();
    }
  }
}
