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
        Me.memoTitles = New System.Windows.Forms.ListBox()
        Me.memoDetail = New System.Windows.Forms.TextBox()
        Me.memoTitle = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.memoUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.memoDelete = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.memoCreate = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.SuspendLayout
        '
        'memoTitles
        '
        Me.memoTitles.BackColor = System.Drawing.Color.Silver
        Me.memoTitles.Font = New System.Drawing.Font("MS UI Gothic", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.memoTitles.FormattingEnabled = true
        Me.memoTitles.ItemHeight = 40
        Me.memoTitles.Location = New System.Drawing.Point(10, 70)
        Me.memoTitles.Name = "memoTitles"
        Me.memoTitles.Size = New System.Drawing.Size(280, 484)
        Me.memoTitles.TabIndex = 0
        '
        'memoDetail
        '
        Me.memoDetail.BackColor = System.Drawing.Color.LightGray
        Me.memoDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.memoDetail.Font = New System.Drawing.Font("MS UI Gothic", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.memoDetail.Location = New System.Drawing.Point(9, 90)
        Me.memoDetail.Multiline = true
        Me.memoDetail.Name = "memoDetail"
        Me.memoDetail.Size = New System.Drawing.Size(900, 400)
        Me.memoDetail.TabIndex = 2
        Me.memoDetail.Text = "内容"
        '
        'memoTitle
        '
        Me.memoTitle.BackColor = System.Drawing.Color.LightGray
        Me.memoTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.memoTitle.Font = New System.Drawing.Font("MS UI Gothic", 36!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.memoTitle.Location = New System.Drawing.Point(9, 10)
        Me.memoTitle.Name = "memoTitle"
        Me.memoTitle.Size = New System.Drawing.Size(900, 60)
        Me.memoTitle.TabIndex = 3
        Me.memoTitle.Text = "タイトル"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.memoUpdate)
        Me.Panel1.Controls.Add(Me.memoTitle)
        Me.Panel1.Controls.Add(Me.memoDetail)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(300, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(920, 673)
        Me.Panel1.TabIndex = 4
        '
        'memoUpdate
        '
        Me.memoUpdate.Font = New System.Drawing.Font("MS UI Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.memoUpdate.Location = New System.Drawing.Point(399, 570)
        Me.memoUpdate.Name = "memoUpdate"
        Me.memoUpdate.Size = New System.Drawing.Size(120, 50)
        Me.memoUpdate.TabIndex = 4
        Me.memoUpdate.Text = "更新"
        Me.memoUpdate.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 50)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "メモリスト"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'memoDelete
        '
        Me.memoDelete.Font = New System.Drawing.Font("MS UI Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.memoDelete.Location = New System.Drawing.Point(161, 570)
        Me.memoDelete.Name = "memoDelete"
        Me.memoDelete.Size = New System.Drawing.Size(120, 50)
        Me.memoDelete.TabIndex = 6
        Me.memoDelete.Text = "削除"
        Me.memoDelete.UseVisualStyleBackColor = true
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.memoCreate)
        Me.Panel2.Controls.Add(Me.memoDelete)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.memoTitles)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 673)
        Me.Panel2.TabIndex = 5
        '
        'memoCreate
        '
        Me.memoCreate.Font = New System.Drawing.Font("MS UI Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.memoCreate.Location = New System.Drawing.Point(20, 570)
        Me.memoCreate.Name = "memoCreate"
        Me.memoCreate.Size = New System.Drawing.Size(120, 50)
        Me.memoCreate.TabIndex = 7
        Me.memoCreate.Text = "追加"
        Me.memoCreate.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents memoTitles As ListBox
    Friend WithEvents memoDetail As TextBox
    Friend WithEvents memoTitle As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents memoUpdate As Button
    Friend WithEvents memoDelete As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents memoCreate As Button
End Class
