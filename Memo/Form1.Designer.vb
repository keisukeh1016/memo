<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstMemoTitle = New System.Windows.Forms.ListBox()
        Me.txtMemoDetail = New System.Windows.Forms.TextBox()
        Me.txtMemoTitle = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'lstMemoTitle
        '
        Me.lstMemoTitle.BackColor = System.Drawing.Color.Silver
        Me.lstMemoTitle.Font = New System.Drawing.Font("MS UI Gothic", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.lstMemoTitle.FormattingEnabled = true
        Me.lstMemoTitle.ItemHeight = 40
        Me.lstMemoTitle.Location = New System.Drawing.Point(0, 50)
        Me.lstMemoTitle.Name = "lstMemoTitle"
        Me.lstMemoTitle.Size = New System.Drawing.Size(300, 644)
        Me.lstMemoTitle.TabIndex = 0
        '
        'txtMemoDetail
        '
        Me.txtMemoDetail.BackColor = System.Drawing.Color.LightGray
        Me.txtMemoDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMemoDetail.Font = New System.Drawing.Font("MS UI Gothic", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.txtMemoDetail.Location = New System.Drawing.Point(9, 90)
        Me.txtMemoDetail.Multiline = true
        Me.txtMemoDetail.Name = "txtMemoDetail"
        Me.txtMemoDetail.Size = New System.Drawing.Size(900, 400)
        Me.txtMemoDetail.TabIndex = 2
        Me.txtMemoDetail.Text = "内容"
        '
        'txtMemoTitle
        '
        Me.txtMemoTitle.BackColor = System.Drawing.Color.LightGray
        Me.txtMemoTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMemoTitle.Font = New System.Drawing.Font("MS UI Gothic", 36!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.txtMemoTitle.Location = New System.Drawing.Point(9, 10)
        Me.txtMemoTitle.Name = "txtMemoTitle"
        Me.txtMemoTitle.Size = New System.Drawing.Size(900, 60)
        Me.txtMemoTitle.TabIndex = 3
        Me.txtMemoTitle.Text = "タイトル"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.txtMemoTitle)
        Me.Panel1.Controls.Add(Me.txtMemoDetail)
        Me.Panel1.Location = New System.Drawing.Point(320, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(920, 600)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 50)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "メモリスト"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("MS UI Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnSave.Location = New System.Drawing.Point(399, 520)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 50)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "保存"
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.lstMemoTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents lstMemoTitle As ListBox
    Friend WithEvents txtMemoDetail As TextBox
    Friend WithEvents txtMemoTitle As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
End Class
