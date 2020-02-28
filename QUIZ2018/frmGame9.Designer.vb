<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGame9
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.t1 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tA = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.lblQuestionNumber = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        't1
        '
        Me.t1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.t1.BackColor = System.Drawing.Color.Transparent
        Me.t1.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.ForeColor = System.Drawing.Color.Black
        Me.t1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.t1.Location = New System.Drawing.Point(33, 107)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(1225, 282)
        Me.t1.TabIndex = 9
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Maroon
        Me.lblTitle.Location = New System.Drawing.Point(37, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(181, 23)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "Game 9: Who Knows?"
        '
        'tA
        '
        Me.tA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tA.BackColor = System.Drawing.Color.Transparent
        Me.tA.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tA.ForeColor = System.Drawing.Color.Maroon
        Me.tA.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.tA.Location = New System.Drawing.Point(33, 407)
        Me.tA.Name = "tA"
        Me.tA.Size = New System.Drawing.Size(1225, 328)
        Me.tA.TabIndex = 10
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.BackColor = System.Drawing.Color.Transparent
        Me.lblNum.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.ForeColor = System.Drawing.Color.Black
        Me.lblNum.Location = New System.Drawing.Point(329, 48)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(39, 45)
        Me.lblNum.TabIndex = 12
        Me.lblNum.Text = "0"
        '
        'lblQuestionNumber
        '
        Me.lblQuestionNumber.AutoSize = True
        Me.lblQuestionNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestionNumber.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionNumber.ForeColor = System.Drawing.Color.Black
        Me.lblQuestionNumber.Location = New System.Drawing.Point(32, 48)
        Me.lblQuestionNumber.Name = "lblQuestionNumber"
        Me.lblQuestionNumber.Size = New System.Drawing.Size(291, 45)
        Me.lblQuestionNumber.TabIndex = 11
        Me.lblQuestionNumber.Text = "Question number"
        '
        'frmGame9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QUIZ2018.My.Resources.Resources.bcg2
        Me.ClientSize = New System.Drawing.Size(1287, 758)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.lblQuestionNumber)
        Me.Controls.Add(Me.tA)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.lblTitle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGame9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents t1 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents tA As Label
    Friend WithEvents lblNum As Label
    Friend WithEvents lblQuestionNumber As Label
End Class
