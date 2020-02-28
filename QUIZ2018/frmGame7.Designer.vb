<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGame7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame7))
        Me.t1 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.t2 = New System.Windows.Forms.Label()
        Me.lAnswer = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        't1
        '
        Me.t1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.t1.BackColor = System.Drawing.Color.Transparent
        Me.t1.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.ForeColor = System.Drawing.Color.Maroon
        Me.t1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.t1.Location = New System.Drawing.Point(33, 50)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(1224, 199)
        Me.t1.TabIndex = 9
        Me.t1.Text = resources.GetString("t1.Text")
        Me.t1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Maroon
        Me.lblTitle.Location = New System.Drawing.Point(33, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(217, 23)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "Game 7: Probable Passage"
        '
        't2
        '
        Me.t2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.t2.BackColor = System.Drawing.Color.Transparent
        Me.t2.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t2.ForeColor = System.Drawing.Color.Black
        Me.t2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.t2.Location = New System.Drawing.Point(33, 261)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(1224, 324)
        Me.t2.TabIndex = 10
        Me.t2.Text = "Victor/the death of his mother/M. Krempe and M. Waldman/the deepest mysteries of " &
    "creation/abandon/escape/Henry Clerval/ill" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.t2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lAnswer
        '
        Me.lAnswer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lAnswer.BackColor = System.Drawing.Color.Transparent
        Me.lAnswer.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lAnswer.ForeColor = System.Drawing.Color.Black
        Me.lAnswer.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lAnswer.Location = New System.Drawing.Point(33, 50)
        Me.lAnswer.Name = "lAnswer"
        Me.lAnswer.Size = New System.Drawing.Size(1224, 677)
        Me.lAnswer.TabIndex = 11
        Me.lAnswer.Text = resources.GetString("lAnswer.Text")
        Me.lAnswer.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.QUIZ2018.My.Resources.Resources.frk4
        Me.PictureBox1.Location = New System.Drawing.Point(1158, 588)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 158)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'frmGame7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QUIZ2018.My.Resources.Resources.bcg2
        Me.ClientSize = New System.Drawing.Size(1287, 758)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lAnswer)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGame7"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents t1 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents t2 As Label
    Friend WithEvents lAnswer As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
