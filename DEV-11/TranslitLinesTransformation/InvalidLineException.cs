using System;

namespace TranslitLinesTransformation
{
	/// <summary>
  ///This class is for exception situation
  ///when the inputed line cant't be traslated 
  /// </summary>
	class InvalidLineException:Exception
  {
		public InvalidLineException(string message) : base(message) { }
	}
}
