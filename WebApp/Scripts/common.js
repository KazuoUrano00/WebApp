

function chgColor() {
    if (document.getElementById) {
        document.getElementById("topixTitle").style.color = "red";

        //alert('jQuery10');
    }
}

$(document).ready(function () {
    //alert('jQuery20');
});

$(function () {
    ////$('#SearchBtn').click(function () {
    //$('#SearchBtn').on("click", function () {
    //    //
    //    // バリデーションチェックや、データの加工を行う。
    //    //
    //    alert('jQuery30');
    //    $('#Search').submit();
    //});

    $('form').on('submit', function () {
        alert('jQuery40');

        $("#Search").validate({
            rules: {
                keyword: {
                    required: true,
                    CustomValidateUserID: true
                }
            },
            messages: {
                keyword: {
                    required: '値を入力してください'
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
        //var error; // エラー用の変数を定義
        //if (error) {
        //    // エラーが見つかった場合
        //    //【エラーメッセージを表示する処理】
        //    return false;
        //} else {
        //    // エラーがなかった場合
        //    return true;
        //}
    });
})