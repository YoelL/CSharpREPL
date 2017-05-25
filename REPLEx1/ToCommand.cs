using System;

namespace REPLEx1
{
	public class ToCommand:ICommand
	{
		InputOutput io = new InputOutput();

		public string Name{ get; set;}

		public ToCommand (string name){
			this.Name = name;
		}



		public string Execute(string[] parameters,State state){
			
			//parsing the recipiants and copy them to a List<string>
			ParsedInput parsedInput = new ParsedInput (parameters [1],',');

			for (int i = 0; i < parsedInput.parsedData.Length; i++) {
				if (io.emailIsValid (parsedInput.parsedData [i]) == true) {
					//Console.WriteLine ("email : " + parsedInput.parsedData [i] + "was added");
					state.recipiants.Add (parsedInput.parsedData [i]);
				} else {
					Console.WriteLine (" The email : " + parsedInput.parsedData[i] + "is not a valid email");
				}

			}
				
			return string.Join (" ","Command Output: ",Name,"Succesfuly updated, sending to  :","'",state.recipiants.Count,"recipiants","'");

		}


	}
}

