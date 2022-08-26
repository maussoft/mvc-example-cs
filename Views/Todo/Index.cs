/**
 * WARNING: Generated file, do not edit, changes will be lost!
 **/

using System;

namespace Acme.Example.Views.Todo
{
	public class Index: Layouts.Default
	{
		public override void Content()
		{
			WriteLine();
			WriteLine(@"    <ul>");
			Write(@"        ");foreach (string item in Context.Session.Items) { WriteLine();
			WriteLine(@"            <li>");
			WriteLine(@"                {0}",  item );
			WriteLine(@"            </li>");
			Write(@"            ");} WriteLine();
			WriteLine(@"    </ul>");
			Write(@"    <a href=""/Todo/Add"">Add</a>");
		}
	}
}