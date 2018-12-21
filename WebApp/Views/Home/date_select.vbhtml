<!DOCTYPE html>
<html>
<head>
    <title>validate</title>
    <meta charset="utf-8">
</head>
<body>
    <h2>validate</h2>
    <form class="form-signin">
        <table class="usertable">
            <tr>
                <th>名前</th>
                <td><input name="myname" type="text" value="" /></td>
            </tr>
            <tr>
                <th>電話番号</th>
                <td><input name="num" type="text" value="" /></td>
            </tr>
            <tr>
                <th>メアド</th>
                <td><input name="address" type="text" value="" /></td>
            </tr>
            <tr>
                <th>性別</th>
                <td>
                    <input name="gender" type="radio" value="男性" /> 男姓　　
                    <input name="gender" type="radio" value="女性" /> 女姓
                </td>
            </tr>
        </table>
        <button id="button" class="btn btn-large btn-primary" type="submit">登録</button>
    </form>

    <script type="text/javascript" src="js/jquery.js"></script>
    <script type="text/javascript" src="js/jquery.validate.min.js"></script>
    <script type="text/javascript" src="../Scripts/val.js"></script>
</body>
</html>
