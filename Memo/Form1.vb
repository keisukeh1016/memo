Option Explicit On
Option Strict On

Public Class Form1
    'Private sConnect As String = "Data Source=INSPIRON5505;Initial Catalog=memo;Integrated Security=True"

    Private sTitle() As String = {"aaa", "bbb", "ccc"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each item As String In sTitle
            lstTitle.Items.Add(item)
        Next
    End Sub

End Class

Public Class Memo


End Class