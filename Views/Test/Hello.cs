/**
 * WARNING: Generated file, do not edit, changes will be lost!
 **/

using System;

namespace Acme.Example.Views.Test
{
	public class Hello<TSession>: Maussoft.Mvc.View<TSession> where TSession : new()
	{
		public override void Content()
		{
			Write(@"{0}",  Context.Data.Html );
		}
	}
}