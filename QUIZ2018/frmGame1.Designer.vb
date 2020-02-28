<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGame1
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblQuestionNumber = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.la = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lKey = New System.Windows.Forms.Label()
        Me.lKey2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Maroon
        Me.lblTitle.Location = New System.Drawing.Point(37, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(202, 23)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Game 1: Multiple choice"
        '
        'lblQuestionNumber
        '
        Me.lblQuestionNumber.AutoSize = True
        Me.lblQuestionNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestionNumber.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionNumber.ForeColor = System.Drawing.Color.Black
        Me.lblQuestionNumber.Location = New System.Drawing.Point(37, 74)
        Me.lblQuestionNumber.Name = "lblQuestionNumber"
        Me.lblQuestionNumber.Size = New System.Drawing.Size(291, 45)
        Me.lblQuestionNumber.TabIndex = 1
        Me.lblQuestionNumber.Text = "Question number"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.BackColor = System.Drawing.Color.Transparent
        Me.lblNum.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.ForeColor = System.Drawing.Color.Black
        Me.lblNum.Location = New System.Drawing.Point(334, 74)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(39, 45)
        Me.lblNum.TabIndex = 2
        Me.lblNum.Text = "0"
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.Color.Transparent
        Me.lblText.Font = New System.Drawing.Font("Calibri", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.Maroon
        Me.lblText.Location = New System.Drawing.Point(37, 148)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(1228, 184)
        Me.lblText.TabIndex = 3
        Me.lblText.Text = " "
        '
        'la
        '
        Me.la.BackColor = System.Drawing.Color.Transparent
        Me.la.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.la.ForeColor = System.Drawing.Color.Black
        Me.la.Location = New System.Drawing.Point(37, 350)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(1000, 388)
        Me.la.TabIndex = 4
        Me.la.Text = "A:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.QUIZ2018.My.Resources.Resources.frk1
        Me.PictureBox1.Location = New System.Drawing.Point(1043, 401)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(270, 320)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'lKey
        '
        Me.lKey.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lKey.BackColor = System.Drawing.Color.Transparent
        Me.lKey.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lKey.ForeColor = System.Drawing.Color.Maroon
        Me.lKey.Location = New System.Drawing.Point(37, 47)
        Me.lKey.Name = "lKey"
        Me.lKey.Size = New System.Drawing.Size(455, 702)
        Me.lKey.TabIndex = 9
        Me.lKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lKey.Visible = False
        '
        'lKey2
        '
        Me.lKey2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lKey2.BackColor = System.Drawing.Color.Transparent
        Me.lKey2.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lKey2.ForeColor = System.Drawing.Color.Maroon
        Me.lKey2.Location = New System.Drawing.Point(508, 47)
        Me.lKey2.Name = "lKey2"
        Me.lKey2.Size = New System.Drawing.Size(455, 702)
        Me.lKey2.TabIndex = 10
        Me.lKey2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lKey2.Visible = False
        '
        'frmGame1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.QUIZ2018.My.Resources.Resources.bcg2
        Me.ClientSize = New System.Drawing.Size(1287, 758)
        Me.Controls.Add(Me.lKey2)
        Me.Controls.Add(Me.la)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.lblQuestionNumber)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lKey)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGame1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblQuestionNumber As Label
    Friend WithEvents lblNum As Label
    Friend WithEvents lblText As Label
    Friend WithEvents la As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lKey As Label
    Friend WithEvents lKey2 As Label
End Class
