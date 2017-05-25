using System;

namespace REPLEx1
{
	public class Repl{

		//Properties
		private readonly ICommand[] commands;
		public InputOutput io;
		public State state;

		//C'tor
		public Repl (){

			//init thr data members 
			io = new InputOutput ();
			state = new State ();

			//init the commands
			commands = new ICommand[4];
			commands[0] = new ToCommand("to");
			commands[1] = new SubjectCommand("subject");
			commands[2] = new BodyCommand("body");
			commands[3] = new SendCommand("send");

		}


		//Methods


		public void Start(){

			this.DisplayReplOptions ();

			do{
				
				//gets user command.
				var userInput = io.ReadLine();

				this.Execute (this.ParseCommand (userInput));

			}while(true);
		
		
		}
			
		private void Execute(ParsedInput parseInput){
			
			Boolean flag = false;
			//checks if the command exists in ICommand array and executs the command.
			for (int i = 0; i < commands.Length; i++) {

				//checks the command entered by the user.
				if (commands [i].Name == parseInput.parsedData [0]) {

					Console.WriteLine (commands [i].Execute (parseInput.parsedData, state));
					flag = true;
				}

				//exit the program.
				if ((parseInput.parsedData [0].ToLower ()) == "exit") {
					Console.WriteLine ("Bye Bye");
					Environment.Exit (0);
				}
			}

			//if command does not exists.
			if (!flag) {
				Console.WriteLine ("Bad comand "+"'"+parseInput.parsedData [0]+"'");
			}
		

		}
			//returns a ParsedInput Object.
		private ParsedInput ParseCommand(string text){
		
			ParsedInput pi = new ParsedInput (text);
			return pi;
		}
			



	public void DisplayReplOptions(){

			io.Prompt ("Welcome To Email REPL");
			io.PromptUnderLine (15);

			io.Prompt ("\nUse the following command to send email:" +
				"\nsubject <subject> - Update the message subject" +
				"\nbody <body> - update the message body" +
				"\nto <email>[,<email>]* - update the message recipient list" +
				"\nsend - send the email using the current subject, body and recipient list " +
				"\n\n Type 'exit' to exit");
	
	}

	}//class

}//namespace

