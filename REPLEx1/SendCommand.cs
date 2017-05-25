using System;
using System.Collections.Generic;

namespace REPLEx1
{
	public class SendCommand:ICommand
	{
		public string Name{ get; set;}
		public SendCommand (string name){
			this.Name = name;
		}


		public string Execute(string[] parameters,State state){

			if (state.VerifyState () == true) {
				Console.WriteLine ("Ready to send mail !");

				//send Method goes here
				Send (state.recipiants,state.Subject,state.Body);

				return string.Join (" ","Command output:Sent :", state.Body);
			
			}
			
			return "not ready to send mail !";

		}
			
		void Send(List<string> recipiants,string subject,string body){
            
            //fill in the account & password 
			var emailClient = new EmailClient ("acountName","Password" );

			foreach (string recipiant in recipiants) {
				emailClient.Send(recipiant,subject,body);
			}
				







		}



	}
}

