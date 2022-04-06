<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmViewer
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmViewer))
        Me.LblLevel = New System.Windows.Forms.Label()
        Me.LblNow = New System.Windows.Forms.Label()
        Me.LblNext = New System.Windows.Forms.Label()
        Me.PbBlueTop = New System.Windows.Forms.PictureBox()
        Me.PbBlueBottom = New System.Windows.Forms.PictureBox()
        Me.PbTop = New System.Windows.Forms.PictureBox()
        Me.PbBottom = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PbBlueTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbBlueBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblLevel
        '
        Me.LblLevel.BackColor = System.Drawing.Color.White
        Me.LblLevel.Font = New System.Drawing.Font("Exo 2.0", 27.0!)
        Me.LblLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblLevel.Location = New System.Drawing.Point(14, 14)
        Me.LblLevel.Name = "LblLevel"
        Me.LblLevel.Size = New System.Drawing.Size(63, 49)
        Me.LblLevel.TabIndex = 3
        Me.LblLevel.Text = "99"
        Me.LblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNow
        '
        Me.LblNow.AutoSize = True
        Me.LblNow.Font = New System.Drawing.Font("Exo 2.0", 37.0!)
        Me.LblNow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.LblNow.Location = New System.Drawing.Point(664, 18)
        Me.LblNow.Name = "LblNow"
        Me.LblNow.Size = New System.Drawing.Size(165, 60)
        Me.LblNow.TabIndex = 4
        Me.LblNow.Text = "23333"
        Me.LblNow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNext
        '
        Me.LblNext.AutoSize = True
        Me.LblNext.Font = New System.Drawing.Font("Exo 2.0", 19.0!)
        Me.LblNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.LblNext.Location = New System.Drawing.Point(810, 25)
        Me.LblNext.Name = "LblNext"
        Me.LblNext.Size = New System.Drawing.Size(71, 31)
        Me.LblNext.TabIndex = 5
        Me.LblNext.Text = "2333"
        Me.LblNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PbBlueTop
        '
        Me.PbBlueTop.Image = Global.WindowsApp1.My.Resources.Resources.bluebarTop
        Me.PbBlueTop.Location = New System.Drawing.Point(110, 12)
        Me.PbBlueTop.Name = "PbBlueTop"
        Me.PbBlueTop.Size = New System.Drawing.Size(354, 12)
        Me.PbBlueTop.TabIndex = 7
        Me.PbBlueTop.TabStop = False
        '
        'PbBlueBottom
        '
        Me.PbBlueBottom.Image = Global.WindowsApp1.My.Resources.Resources.bluebarBottomN
        Me.PbBlueBottom.Location = New System.Drawing.Point(110, 12)
        Me.PbBlueBottom.Name = "PbBlueBottom"
        Me.PbBlueBottom.Size = New System.Drawing.Size(555, 12)
        Me.PbBlueBottom.TabIndex = 6
        Me.PbBlueBottom.TabStop = False
        '
        'PbTop
        '
        Me.PbTop.Image = Global.WindowsApp1.My.Resources.Resources.PingkbarTop
        Me.PbTop.Location = New System.Drawing.Point(110, 33)
        Me.PbTop.Name = "PbTop"
        Me.PbTop.Size = New System.Drawing.Size(398, 40)
        Me.PbTop.TabIndex = 2
        Me.PbTop.TabStop = False
        '
        'PbBottom
        '
        Me.PbBottom.Image = Global.WindowsApp1.My.Resources.Resources.PingkbarBottom
        Me.PbBottom.Location = New System.Drawing.Point(110, 33)
        Me.PbBottom.Name = "PbBottom"
        Me.PbBottom.Size = New System.Drawing.Size(550, 40)
        Me.PbBottom.TabIndex = 1
        Me.PbBottom.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.LeftFrameN
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FrmViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(984, 107)
        Me.Controls.Add(Me.PbBlueTop)
        Me.Controls.Add(Me.PbBlueBottom)
        Me.Controls.Add(Me.LblNext)
        Me.Controls.Add(Me.LblNow)
        Me.Controls.Add(Me.LblLevel)
        Me.Controls.Add(Me.PbTop)
        Me.Controls.Add(Me.PbBottom)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Progessbar Main"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.PbBlueTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbBlueBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PbBottom As PictureBox
    Friend WithEvents PbTop As PictureBox
    Friend WithEvents LblLevel As Label
    Friend WithEvents LblNow As Label
    Friend WithEvents LblNext As Label
    Friend WithEvents PbBlueBottom As PictureBox
    Friend WithEvents PbBlueTop As PictureBox
End Class
