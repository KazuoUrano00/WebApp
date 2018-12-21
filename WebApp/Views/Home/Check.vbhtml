@Code
    ViewData("Title") = "Check"
End Code

<h3>@ViewData("Message")</h3>

<script type="text/javascript" src="../Scripts/jquery-3.3.1.js"></script>
<script type="text/javascript" src="../Scripts/jquery.validate.min.js"></script>

<script>
    var dt = "test"
    $('#time').text(dt.toString());
</script>
<div>
    <form id="testForm" method="post">
        <p>
            <lable for="name">
                ユーザID
            </lable>
                <input name="name" type="text" />
        </p>

        <p>
            <label for="password">パスワード</label>
            <input name="password" id="password" type="password" />
        </p>

        <p>
            <input type="submit" name="Submit" value="送信" />
        </p>
    </form>
</div>
<div id="time"></div>

<script>
    $("#testForm").validate({
        rules: {
            name: {
                required: true,
                CustomValidateUserID: true
            },
            password: {
                required: true
            }
        },
        messages: {
            name: {
                required: '名前を入力してください',
            },
            password: {
                required: 'パスワードを入力してください'
            }
        }
    });
    jQuery.validator.addMethod(
        "CustomValidateUserID",
        function (val, elem) {
            reg = new RegExp("^[0-9a-zA-Z]+$");
            return this.optional(elem) || reg.test(val);
        },
        "ユーザIDは0-9,a-z,A-Zを使用してください"
    );
</script>
