Option Explicit On
Option Strict On

Imports System.Data.SqlClient

Public Class Form1
    Private memoData As New MemoData

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        memoTitles.DataSource = memoData.Table
        memoTitles.DisplayMember = "Title"

        ClearMemo()
    End Sub

    Private Sub ClearMemo()
        memoTitles.SelectedIndex = -1

        memoTitle.Clear()
        memoDetail.Clear()
    End Sub

    Private Sub ShowMemo(datarow As DataRow)
        memoTitle.Text = datarow("title").ToString
        memoDetail.Text = datarow("detail").ToString
    End Sub


    'イベント処理
    Private Sub lstMemoTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles memoTitles.SelectedIndexChanged
        If memoTitles.SelectedIndex = -1 Then
            ClearMemo()
        Else
            ShowMemo( memoData.TableRows(memoTitles.SelectedIndex) )
        End If
    End Sub
End Class

Public Class MemoData
    Private _connection As New SqlConnection("Data Source=INSPIRON5505;Initial Catalog=memo;Integrated Security=True")
    Private _dataSet As New DataSet

    Public ReadOnly Property Table() As DataTable
        Get
            Return _dataSet.Tables(0)
        End Get
    End Property

    Public ReadOnly Property TableRows() As DataRowCollection
        Get
            Return _dataSet.Tables(0).Rows
        End Get
    End Property

    Public Sub New()
        Read()
    End Sub

    Public Sub Read()
        Dim queryString As String = "SELECT * FROM memo.dbo.memo ORDER BY memo.dbo.memo.id asc"
        Dim adapter As New SqlDataAdapter(queryString, _connection)

        _dataSet.Clear()
        adapter.Fill(_dataSet)
    End Sub
End Class
