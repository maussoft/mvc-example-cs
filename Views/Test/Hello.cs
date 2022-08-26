/**
 * WARNING: Generated file, do not edit, changes will be lost!
 **/

using System;

namespace Acme.Example.Views.Test
{
	public class Hello: Maussoft.Mvc.View<Acme.Example.Session>
	{
		public override void Content()
		{
			Context.Session.Names.Add("test"); Write(@"{0}",  Context.Data.Html );
		}
	}
}