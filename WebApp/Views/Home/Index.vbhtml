@Code
    ViewData("Title") = "Home Page"
End Code

<script type="text/javascript" src="../Scripts/jquery-3.3.1.js"></script>
<script type="text/javascript" src="../Scripts/jquery.validate.min.js"></script>
@*<script type="text/javascript" src="../Scripts/val.js"></script>*@
<script type="text/javascript" src="../Scripts/common.js"></script>
<form>
    <h3 id="topixTitle">@ViewData("Message")</h3> <input type="button" value="赤文字" onclick="chgColor()">
</form>

<!--検索部-->
@Using Html.BeginForm("Search", "Home", FormMethod.Post, New With {.class = "form-inline"})
    @Html.Label("keyword", "ID:", New With {.class = "control-label"})
    @Html.TextBox("keyword", "", New With {.class = "form-control"})
    @<br />
    @Html.Label("keyword1", "Name:", New With {.class = "control-label"})
    @Html.TextBox("keyword1", "", New With {.class = "form-control"})
    @<text>
        <br />
        <input type="submit" value="検索" class="btn" name="SearchBtn" />
        <!--input type="submit" value="検索" class="btn btn-link" name="btn" /-->
    </text>
End Using
<div id = "time" ></div>
                        
<!--
<div Class="jumbotron">
        <h1> ASP.NET</h1>
        <p Class="lead">ASP.NET Is a free web framework for building great Web sites And Web applications using HTML, CSS And JavaScript.</p>
        <p> <a href = "https://asp.net" Class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
</div>

<div Class="row">
        <div Class="col-md-4">
            <h2> Getting started</h2>
            <p>
                ASP.NET MVC gives you a powerful, patterns-based way To build dynamic websites that
                enables a clean separation Of concerns And gives you full control over markup
                For enjoyable, agile development.
            </p>
            <p> <a Class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301865">Learn more &raquo;</a></p>
        </div>
        <div Class="col-md-4">
            <h2> Get more libraries</h2>
            <p> NuGet Is a free Visual Studio extension that makes it easy To add, remove, And update libraries And tools In Visual Studio projects.</p>
            <p> <a Class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301866">Learn more &raquo;</a></p>
        </div>
        <div Class="col-md-4">
            <h2> Web Hosting</h2>
            <p> You can easily find a web hosting company that offers the right mix Of features And price For your applications.</p>
            <p> <a Class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301867">Learn more &raquo;</a></p>
        </div>
</div>
-->
