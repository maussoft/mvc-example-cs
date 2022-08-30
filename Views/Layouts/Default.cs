/**
 * WARNING: Generated file, do not edit, changes will be lost!
 **/

using System;

namespace Acme.Example.Views.Layouts
{
	public class Default: Maussoft.Mvc.View<Acme.Example.Session>
	{
		public override void Header()
		{
			WriteLine();
			WriteLine(@"<!DOCTYPE html>");
			WriteLine(@"<html>");
			WriteLine();
			WriteLine(@"<head>");
			WriteLine(@"	<title>");
			WriteLine(@"		{0}",  Context.Session.Items.Count );
			WriteLine(@"	</title>");
			WriteLine(@"</head>");
			WriteLine();
			WriteLine(@"<body>");
			Write(@"	");
		}

		public override void Footer()
		{
			WriteLine();
			WriteLine(@"</body>");
			WriteLine();
			Write(@"</html>");
		}
	}
}