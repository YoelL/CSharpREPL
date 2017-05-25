using System;

namespace REPLEx1
{
	public class BodyCommand:ICommand
	{
		public string Name{ get; set;}

		public BodyCommand (string name){
			this.Name = name;
		}
			
		public string Execute(string[] parameters,State state){
			state.Body = parameters [1];
			return string.Join (" ","Command Output: ",Name,"Succesfuly updated:","'",parameters[1],"'");

		}

	}
}

