using System;
using System.Collections.Generic;

namespace REPLEx1
{

	//This Class defines the data of the REPL such as the Recipiants, Subject, & the Body of the mail.

	public class State
	{
		//Properties

		//List of all recipients 
		public List<string> recipiants  = new List<string> ();

		//Subject of mail
		private string subject;
		public string Subject{
			get{ return subject;}
			set{ subject = value;}
		}

		//Body of Mail
		private string body;
		public string Body{
			get{return body;}
			set{ body = value;}
		}

		//verifies that all of the data in the State class is complete.
		public bool VerifyState(){
		
			if((recipiants.Count > 0) && (subject != null) && (body!= null) ){
				return true;
			}
			return false;
		
		
		}
			
	

	}
}

