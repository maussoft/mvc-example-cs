/**
 * WARNING: Generated file, do not edit, changes will be lost!
 **/

using System;

namespace Acme.Example.Views.Todo
{
	public class Add: Layouts.Default
	{
		public override void Content()
		{
			WriteLine();
			WriteLine(@"<form method=""post"">");
			WriteLine(@"	<div>");
			WriteLine(@"		<label>Item</label><br>");
			WriteLine(@"		<input type=""text"" name=""Item"" value=""{0}"" /><br>",  Context.Data.Values.Item ?? "" );
			Write(@"		");if(Context.Data.Errors?.Item!=null) { WriteLine();
			WriteLine(@"		<span>");
			WriteLine(@"			{0}",  Context.Data.Errors.Item );
			WriteLine(@"		</span><br>");
			Write(@"		");} WriteLine();
			WriteLine(@"		<input type=""submit"" value=""Add"" />");
			WriteLine(@"	</div>");
			Write(@"</form>");
		}
	}
}