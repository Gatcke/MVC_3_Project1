<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>ASPXDemo</title>
</head>
<body>
    <div>
     <p> <%: ViewBag.test %></p>  
        <ul>
            <% foreach (string myCountries in ViewBag.Countries){%>
           <li><%:myCountries %></li> 
            <% } %>
        </ul>
    </div>
</body>
</html>
