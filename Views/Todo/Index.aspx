<%@ Page Inherits="Layouts.Default" %>
<ul>
	<% foreach (string item in Context.Session.Items) { %>
	<li>
		<%= item %>
	</li>
	<% } %>
</ul>
<a href="/Todo/Add">Add</a>