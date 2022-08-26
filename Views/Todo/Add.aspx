<%@ Page Inherits="Layouts.Default" %>
    <form method="post">
        <div>
            <label>Item</label><br>
            <input type="text" name="Item" value="<%= Context.Data.Values.Item %>"></input><br>
            <% if(Context.Data.Errors?.Item!=null) { %>
                <span>
                    <%= Context.Data.Errors.Item %>
                </span><br>
                <% } %>
                    <input type="submit" value="Add" />
        </div>
    </form>