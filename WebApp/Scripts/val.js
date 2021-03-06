﻿(function () {
    //標準エラーメッセージの変更
    $.extend($.validator.messages, {
        email: '*正しいメールアドレスの形式で入力して下さい',
        required: '*入力必須です',

        phone: "*正しい電話番号の形式で入力してください"
    });

    //追加ルールの定義
    var methods = {
        phone: function (value, element) {
            return this.optional(element) || /^\d{11}$|^\d{3}-\d{4}-\d{4}$/.test(value);
        }
    };

    //メソッドの追加
    $.each(methods, function (key) {
        $.validator.addMethod(key, this);
    });

    //入力項目の検証ルール定義
    var rules = {
        myname: { required: true },
        num: "phone",
        address: { required: true, email: true },
        gender: { required: true }
    };

    //入力項目ごとのエラーメッセージ定義
    var messages = {
        myname: {
            required: "*名前を入力してください"
        },
        address: {
            required: "*メアドを入力してください"
        },
        gender: {
            required: "*性別を選択してください"
        }
    };

    $(function () {
        $('#testform').validate({
            rules: rules,
            messages: messages,

            //エラーメッセージ出力箇所調整
            errorPlacement: function (error, element) {
                if (element.is(':radio')) {
                    error.appendTo(element.parent());
                } else {
                    error.insertAfter(element);
                }
            }
        });
    });

})();