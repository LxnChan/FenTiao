<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDevTools
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
        Me.BtnDevCode = New System.Windows.Forms.Button()
        Me.LbDevCode = New System.Windows.Forms.Label()
        Me.TbDevCode = New System.Windows.Forms.TextBox()
        Me.GbCloudControl = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblNowExp = New System.Windows.Forms.Label()
        Me.BtnGDNo = New System.Windows.Forms.Button()
        Me.LblNextExp = New System.Windows.Forms.Label()
        Me.BtnGDN = New System.Windows.Forms.Button()
        Me.LblTotalExp = New System.Windows.Forms.Label()
        Me.BtnGDT = New System.Windows.Forms.Button()
        Me.TbData0 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblHash = New System.Windows.Forms.Label()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.LblAttr = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GbCloudControl.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnDevCode
        '
        Me.BtnDevCode.Location = New System.Drawing.Point(225, 12)
        Me.BtnDevCode.Name = "BtnDevCode"
        Me.BtnDevCode.Size = New System.Drawing.Size(68, 21)
        Me.BtnDevCode.TabIndex = 14
        Me.BtnDevCode.Text = "Act"
        Me.BtnDevCode.UseVisualStyleBackColor = True
        '
        'LbDevCode
        '
        Me.LbDevCode.AutoSize = True
        Me.LbDevCode.Location = New System.Drawing.Point(10, 16)
        Me.LbDevCode.Name = "LbDevCode"
        Me.LbDevCode.Size = New System.Drawing.Size(47, 12)
        Me.LbDevCode.TabIndex = 13
        Me.LbDevCode.Text = "DevCode"
        '
        'TbDevCode
        '
        Me.TbDevCode.Location = New System.Drawing.Point(69, 12)
        Me.TbDevCode.Name = "TbDevCode"
        Me.TbDevCode.Size = New System.Drawing.Size(150, 21)
        Me.TbDevCode.TabIndex = 12
        '
        'GbCloudControl
        '
        Me.GbCloudControl.Controls.Add(Me.Button1)
        Me.GbCloudControl.Controls.Add(Me.Label1)
        Me.GbCloudControl.Controls.Add(Me.TextBox1)
        Me.GbCloudControl.Controls.Add(Me.CheckBox1)
        Me.GbCloudControl.Location = New System.Drawing.Point(12, 62)
        Me.GbCloudControl.Name = "GbCloudControl"
        Me.GbCloudControl.Size = New System.Drawing.Size(356, 123)
        Me.GbCloudControl.TabIndex = 15
        Me.GbCloudControl.TabStop = False
        Me.GbCloudControl.Text = "云控"
        Me.GbCloudControl.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(213, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 21)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Act"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "服务器"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(57, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(150, 21)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Text = "cloud.arlxn.top"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(9, 23)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "云控开关"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblNowExp)
        Me.GroupBox1.Controls.Add(Me.BtnGDNo)
        Me.GroupBox1.Controls.Add(Me.LblNextExp)
        Me.GroupBox1.Controls.Add(Me.BtnGDN)
        Me.GroupBox1.Controls.Add(Me.LblTotalExp)
        Me.GroupBox1.Controls.Add(Me.BtnGDT)
        Me.GroupBox1.Controls.Add(Me.TbData0)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 247)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "数据板"
        Me.GroupBox1.Visible = False
        '
        'LblNowExp
        '
        Me.LblNowExp.AutoSize = True
        Me.LblNowExp.Location = New System.Drawing.Point(193, 181)
        Me.LblNowExp.Name = "LblNowExp"
        Me.LblNowExp.Size = New System.Drawing.Size(41, 12)
        Me.LblNowExp.TabIndex = 6
        Me.LblNowExp.Text = "nowExp"
        '
        'BtnGDNo
        '
        Me.BtnGDNo.Location = New System.Drawing.Point(193, 196)
        Me.BtnGDNo.Name = "BtnGDNo"
        Me.BtnGDNo.Size = New System.Drawing.Size(88, 24)
        Me.BtnGDNo.TabIndex = 5
        Me.BtnGDNo.Text = "Now Exp."
        Me.BtnGDNo.UseVisualStyleBackColor = True
        '
        'LblNextExp
        '
        Me.LblNextExp.AutoSize = True
        Me.LblNextExp.Location = New System.Drawing.Point(100, 181)
        Me.LblNextExp.Name = "LblNextExp"
        Me.LblNextExp.Size = New System.Drawing.Size(47, 12)
        Me.LblNextExp.TabIndex = 4
        Me.LblNextExp.Text = "nextExp"
        '
        'BtnGDN
        '
        Me.BtnGDN.Location = New System.Drawing.Point(100, 196)
        Me.BtnGDN.Name = "BtnGDN"
        Me.BtnGDN.Size = New System.Drawing.Size(88, 24)
        Me.BtnGDN.TabIndex = 3
        Me.BtnGDN.Text = "Next Exp."
        Me.BtnGDN.UseVisualStyleBackColor = True
        '
        'LblTotalExp
        '
        Me.LblTotalExp.AutoSize = True
        Me.LblTotalExp.Location = New System.Drawing.Point(6, 181)
        Me.LblTotalExp.Name = "LblTotalExp"
        Me.LblTotalExp.Size = New System.Drawing.Size(59, 12)
        Me.LblTotalExp.TabIndex = 2
        Me.LblTotalExp.Text = "totalExp."
        '
        'BtnGDT
        '
        Me.BtnGDT.Location = New System.Drawing.Point(6, 196)
        Me.BtnGDT.Name = "BtnGDT"
        Me.BtnGDT.Size = New System.Drawing.Size(88, 24)
        Me.BtnGDT.TabIndex = 1
        Me.BtnGDT.Text = "Total Exp."
        Me.BtnGDT.UseVisualStyleBackColor = True
        '
        'TbData0
        '
        Me.TbData0.Location = New System.Drawing.Point(6, 20)
        Me.TbData0.Multiline = True
        Me.TbData0.Name = "TbData0"
        Me.TbData0.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TbData0.Size = New System.Drawing.Size(344, 158)
        Me.TbData0.TabIndex = 0
        Me.TbData0.Text = "Data Initial..."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblHash)
        Me.GroupBox2.Controls.Add(Me.LblTime)
        Me.GroupBox2.Controls.Add(Me.LblAttr)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(374, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(217, 72)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "测试api返回值"
        Me.GroupBox2.Visible = False
        '
        'LblHash
        '
        Me.LblHash.AutoSize = True
        Me.LblHash.Location = New System.Drawing.Point(56, 50)
        Me.LblHash.Name = "LblHash"
        Me.LblHash.Size = New System.Drawing.Size(29, 12)
        Me.LblHash.TabIndex = 5
        Me.LblHash.Text = "null"
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.Location = New System.Drawing.Point(56, 35)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(29, 12)
        Me.LblTime.TabIndex = 4
        Me.LblTime.Text = "null"
        '
        'LblAttr
        '
        Me.LblAttr.AutoSize = True
        Me.LblAttr.Location = New System.Drawing.Point(56, 23)
        Me.LblAttr.Name = "LblAttr"
        Me.LblAttr.Size = New System.Drawing.Size(29, 12)
        Me.LblAttr.TabIndex = 3
        Me.LblAttr.Text = "null"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(9, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "hash"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(9, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(9, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "attribs"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(374, 142)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(216, 182)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "WebSocket"
        Me.GroupBox3.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(11, 35)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(126, 21)
        Me.TextBox2.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(11, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 43)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmDevTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GbCloudControl)
        Me.Controls.Add(Me.BtnDevCode)
        Me.Controls.Add(Me.LbDevCode)
        Me.Controls.Add(Me.TbDevCode)
        Me.Name = "FrmDevTools"
        Me.Text = "DevTools"
        Me.GbCloudControl.ResumeLayout(False)
        Me.GbCloudControl.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDevCode As Button
    Friend WithEvents LbDevCode As Label
    Friend WithEvents TbDevCode As TextBox
    Friend WithEvents GbCloudControl As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TbData0 As TextBox
    Friend WithEvents BtnGDT As Button
    Friend WithEvents LblNowExp As Label
    Friend WithEvents BtnGDNo As Button
    Friend WithEvents LblNextExp As Label
    Friend WithEvents BtnGDN As Button
    Friend WithEvents LblTotalExp As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LblHash As Label
    Friend WithEvents LblTime As Label
    Friend WithEvents LblAttr As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
End Class
