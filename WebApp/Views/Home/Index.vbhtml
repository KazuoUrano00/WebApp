@Code
    ViewData("Title") = "Home Page"
End Code

<script type="text/javascript" src="../Scripts/jquery-3.3.1.js"></script>
<script type="text/javascript" src="../Scripts/jquery.validate.min.js"></script>
@*<script type="text/javascript" src="../Scripts/val.js"></script>*@
<script type="text/javascript" src="../Scripts/common.js"></script>

<h3 id="topixTitle">@ViewData("Message")</h3>

<form>
    <input type="button" value="赤文字" onclick="chgColor()">
</form>

<!--検索部-->
@Using Html.BeginForm("Search", "Home", FormMethod.Post, New With {.class = "form-inline"})
    @Html.Label("keyword", "ID:", New With {.class = "control-label"})
    @Html.TextBox("keyword", "", New With {.class = "form-control"})
    @<text>
    <br />
        <input type="submit" value="検索" class="btn" name="SearchBtn" />
        <!--input type="submit" value="検索" class="btn btn-link" name="btn" /-->
    </text>
End Using
<div id="time"></div>

<!--
<div class="jumbotron">
    <h1>ASP.NET</h1>
    <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript.</p>
    <p><a href="https://asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
</div>

<div class="row">
    <div class="col-md-4">
        <h2>Getting started</h2>
        <p>
            ASP.NET MVC gives you a powerful, patterns-based way to build dynamic websites that
            enables a clean separation of concerns and gives you full control over markup
            for enjoyable, agile development.
        </p>
        <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301865">Learn more &raquo;</a></p>
    </div>
    <div class="col-md-4">
        <h2>Get more libraries</h2>
        <p>NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.</p>
        <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301866">Learn more &raquo;</a></p>
    </div>
    <div class="col-md-4">
        <h2>Web Hosting</h2>
        <p>You can easily find a web hosting company that offers the right mix of features and price for your applications.</p>
        <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301867">Learn more &raquo;</a></p>
    </div>
</div>
-->
