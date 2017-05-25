using System;

namespace REPLEx1
{
	public class ParsedInput
	{

		public string[] parsedData{ get; set;}

		public ParsedInput (string command){

			parsedData = SplitStringToParts (2, command);

		}

		public ParsedInput (string command,char del){
		
			parsedData = SplitStringByDelimiter (del, command);
		
		}




		/// <summary>
		/// Splits the string by delimiter.
		/// 
		/// <returns>array of strings.</returns>
		/// <param name="delimiter">Delimiter.</param>
		/// 
		///EX-  string s = "a,b, b, c";
		///		string[] val =	io.SplitStringByDelimiter (',', s);
		///		for (int i = 0; i < 4; i++) {
		///			Console.Write (val [i] + " ");
		///		}
		/// 
		/// </summary>
		/// 
		public string[] SplitStringByDelimiter(char delimiter ,string stringToSplit){

			string[] values = stringToSplit.Split(delimiter);
			for(int i = 0; i < values.Length; i++){
				values[i] = values[i].Trim();
			}
			return values;
		}


		/// <summary>
		/// Splits the string to parts.
		///
		/// <returns> an array with splited to X parts .</returns>
		/// <param name="parts"> integer .</param>
		/// <param name="text"> a string .</param>
		/// 
		/// Ex-
		/// InputOutput io = new InputOutput ();
		/// string[] val = io.SplitStringToParts (2, "Hello my name is");
		///  Console.Write (val[0]);
		///  Console.WriteLine (" ");	
		///  Console.Write (val[1]);
		/// 
		///  </summary>
		public string[] SplitStringToParts(int parts , string text){

			string[] splitedArray = text.Split(new char[]{' '},parts);

			return splitedArray;

		}






	}
}

