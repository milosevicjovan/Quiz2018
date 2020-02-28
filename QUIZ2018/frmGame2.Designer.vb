<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGame2
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
        Me.lblNum = New System.Windows.Forms.Label()
        Me.t1 = New System.Windows.Forms.Label()
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
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(37, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(241, 23)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Game 2: Guess The Character"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.BackColor = System.Drawing.Color.Transparent
        Me.lblNum.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.ForeColor = System.Drawing.Color.Maroon
        Me.lblNum.Location = New System.Drawing.Point(37, 62)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(65, 78)
        Me.lblNum.TabIndex = 2
        Me.lblNum.Text = "0"
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        't1
        '
        Me.t1.BackColor = System.Drawing.Color.Transparent
        Me.t1.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.ForeColor = System.Drawing.Color.Black
        Me.t1.Location = New System.Drawing.Point(37, 180)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(1228, 541)
        Me.t1.TabIndex = 4
        Me.t1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.QUIZ2018.My.Resources.Resources.frk2
        Me.PictureBox1.Location = New System.Drawing.Point(1075, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(252, 224)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lKey
        '
        Me.lKey.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lKey.BackColor = System.Drawing.Color.Transparent
        Me.lKey.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lKey.ForeColor = System.Drawing.Color.Black
        Me.lKey.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lKey.Location = New System.Drawing.Point(35, 62)
        Me.lKey.Name = "lKey"
        Me.lKey.Size = New System.Drawing.Size(507, 699)
        Me.lKey.TabIndex = 10
        Me.lKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lKey.Visible = False
        '
        'lKey2
        '
        Me.lKey2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lKey2.BackColor = System.Drawing.Color.Transparent
        Me.lKey2.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lKey2.ForeColor = System.Drawing.Color.Black
        Me.lKey2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lKey2.Location = New System.Drawing.Point(562, 62)
        Me.lKey2.Name = "lKey2"
        Me.lKey2.Size = New System.Drawing.Size(507, 699)
        Me.lKey2.TabIndex = 11
        Me.lKey2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lKey2.Visible = False
        '
        'frmfrmGame2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QUIZ2018.My.Resources.Resources.bcg2
        Me.ClientSize = New System.Drawing.Size(1287, 758)
        Me.Controls.Add(Me.lKey2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lKey)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmfrmGame2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblNum As Label
    Friend WithEvents t1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lKey As Label
    Friend WithEvents lKey2 As Label
End Class
