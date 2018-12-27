Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "Please enter your search criteria."
        Return View()
    End Function
    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Check() As ActionResult
        ViewData("Message") = "Check."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
    Function Search(ByVal keyword As String, ByVal keyword1 As String)
        'Dim db As New 

        'Return View(db.TEST01.Where(Function(b) b.column01 = keyword))
        Dim MB As String
        If keyword <> "" Then
            MB = ""
            Try
                Using con As New SqlConnection
                    Using cmd As New SqlCommand
                        ' 接続文字列の設定（SQL Server 2008 Express Edition）
                        con.ConnectionString =
                              "Data Source=DESKTOP-HMSGQGP\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True"

                        ' SqlCommand.Connectionプロパティの設定
                        cmd.Connection = con

                        ' DB接続
                        con.Open()

                        ' SQL文の設定
                        cmd.CommandText = "SELECT * FROM MEMBERS "
                        cmd.CommandText += "WHERE ID = " + keyword

                        ' 商品マスター表からレコード読込
                        Using dr As SqlDataReader = cmd.ExecuteReader()
                            ' 取得レコード有無チェック
                            If dr.HasRows = True Then
                                ' レコードが取得できた時の処理
                                While dr.Read()
                                    ' セルのテンプレートを設定
                                    'Dim row As New DataGridViewRow
                                    'row.CreateCells(Me.DataGridView1)
                                    ' セルに値をセット
                                    'Row.Cells(0).Value = CStr(dr("商品コード"))
                                    'row.Cells(1).Value = CStr(dr("商品名称"))
                                    'row.Cells(2).Value = CInt(dr("販売単価"))
                                    ' データグリッドビューに行を追加
                                    'Me.DataGridView1.Rows.Add(row)
                                    MB = CStr(dr("NAME"))
                                End While
                            Else
                                ' レコードが取得できなかった時の処理
                                MB = "レコードはありませんでした。"
                            End If
                        End Using

                    End Using
                End Using

            Catch ex As Exception
                ' 例外が発生した時の処理
                MB = ex.ToString

            End Try

            ViewData("Message") = MB

            'Else
            '    ViewData("Message") = "値を入れていください。"
        End If
        If keyword1 <> "" Then
            Dim r As New System.Text.RegularExpressions.Regex("[\uFF61-\uFF9F]")

            '半角カナ文字が含まれているか調べる 
            If r.IsMatch(keyword1) Then
                ViewData("Message") = "半角カナ文字が含まれています"
            End If
        End If


        Return View()

    End Function
    Function date_select() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()

    End Function
End Class
