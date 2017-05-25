using System;

namespace REPLEx1
{
	public class SubjectCommand:ICommand
	{

		public string Name{ get; set;}

		public SubjectCommand (string name){
			this.Name = name;
		}

		public string Execute(string[] parameters,State state){
		
			state.Subject = parameters [1];
			return string.Join (" ","Command Output: ",Name,"Succesfuly updated:","'",parameters[1],"'");
		
		}

	}
}

