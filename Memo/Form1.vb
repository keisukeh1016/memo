Option Explicit On
Option Strict On

Imports System.Data.SqlClient

Public Class Form1
    Private memoData As New MemoData

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        memoData.Read()

        lstMemoTitle.DataSource = memoData.memos
        lstMemoTitle.DisplayMember = "Title"

        ClearListSelection()
    End Sub

    Private Sub showMemo(memo As Memo)
        txtMemoTitle.Text = memo.Title
        txtMemoDetail.Text = memo.Detail
    End Sub

    Public Sub ClearListSelection()
        lstMemoTitle.SelectedIndex = -1

        txtMemoTitle.Clear()
        txtMemoDetail.Clear()
    End Sub

    'イベント処理
    Private Sub lstMemoTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMemoTitle.SelectedIndexChanged
        If lstMemoTitle.SelectedIndex = -1 Then
            ClearListSelection()
        Else
            showMemo( memoData.memos(lstMemoTitle.SelectedIndex) )
        End If
    End Sub
End Class


Public Class Memo
    Public Property Id As Integer
    Public Property Title As String
    Public Property Detail As String

    Public Sub New(datarow As DataRow)
        Id     = CInt( datarow("id") )
        Title  = CStr( datarow("title") )
        Detail = CStr( datarow("detail") )
    End Sub
End Class

Public Class MemoData
    Public connection As String = "Data Source=INSPIRON5505;Initial Catalog=memo;Integrated Security=True"
    Public query As String = "SELECT * FROM memo.dbo.memo ORDER BY memo.dbo.memo.id asc"
    Public adapter As New SqlDataAdapter(query, connection)
    Public dataset As New DataSet
    Public memos As Memo()

    Public Sub Read() 
        adapter.Fill(dataset, "memo")
        ReDim memos(dataset.Tables("memo").Rows.Count - 1)

        For index = 0 To dataset.Tables("memo").Rows.Count - 1
            memos(index) = New Memo(dataset.Tables("memo").Rows(index))
        Next
    End Sub
End Class
