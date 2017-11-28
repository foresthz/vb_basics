
Option Explicit On


Public Class hello_gui


    Private Sub btn_one_Click(sender As Object, e As EventArgs) Handles btn_one.Click
        Dim aa = 1
        'MessageBox.Show("eee", , "标题啊")
        MsgBox("所以你们学佛打坐的妄想，妄想有什么关系", , "标题啊啊啊")
        MessageBox.Show("莫等闲白了少年头", "这个是标题")
        Dim msg1 As String
        Dim title As String
        msg1 = "彩笔描空，笔不落色，而空亦不受染"
        title = "菜根谭"
        MsgBox(msg1, , title)
        MsgBox("nihao", vbOKCancel, "标题")

        Dim a = 1


    End Sub

End Class
