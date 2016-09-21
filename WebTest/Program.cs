using System;
using System.Net;
namespace WebTest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			WebClient client = new WebClient ();
			string htmlCode = client.DownloadString("http://debian.org");
			Console.WriteLine (htmlCode);
		}
	}
}
