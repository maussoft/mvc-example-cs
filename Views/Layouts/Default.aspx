<%@ Master %>
  <!DOCTYPE html>
  <html>

  <head>
    <title>
      <%= Context.Session.Items.Count %>
    </title>
  </head>

  <body>
    <% RenderViewContent(); %>
  </body>

  </html>