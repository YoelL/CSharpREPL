using System;

namespace REPLEx1
{

	//Q2-B
	/// <summary>
	/// How To:
	/// 
	/// The ICommand interface represent the structure of the command to implement in a Repl program.
	/// To apply a new command it is neccesery to create a class that implements the ICommand Interface.
	/// 
	/// 1) The Name propertie reprsents the command name. you can set and get the Name (command).
	/// 2) The Execute method gets 2 parameters, a string[] parameter which holds the content of the 
	/// command and a State parameter which is passed to update 
	/// the state (all data such as mails,body,subject ex..)
	///
	/// </summary>
	public interface ICommand{
		//
		 string Name{ get; set;}
		 string Execute(string[] parameters,State state);

	}
}

