<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblUpdData = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.BtnDeveloper = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ChangelogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EasterEggToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ccd = New System.Windows.Forms.ColorDialog()
        Me.Ni = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuNi = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.显示主界面ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.隐藏设置窗口ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CbBluepb = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnTimeout = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LllbkgColor = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAutoCorrection = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.CbAutoOc = New System.Windows.Forms.CheckBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btnFaded = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.LinkLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TbDataL = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TbColor = New System.Windows.Forms.TextBox()
        Me.TbTimeout = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TbOffsetVal = New System.Windows.Forms.TextBox()
        Me.Cbval1 = New System.Windows.Forms.ComboBox()
        Me.CbVal2 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TimerFaded = New System.Windows.Forms.Timer(Me.components)
        Me.CbNoLog = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblNowTime = New System.Windows.Forms.Label()
        Me.TimerUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.TmEasterEgg = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuNi.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 35)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(644, 27)
        Me.ProgressBar1.TabIndex = 0
        Me.ProgressBar1.Value = 20
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'LblUpdData
        '
        Me.LblUpdData.AutoSize = True
        Me.LblUpdData.Location = New System.Drawing.Point(95, 65)
        Me.LblUpdData.Name = "LblUpdData"
        Me.LblUpdData.Size = New System.Drawing.Size(95, 12)
        Me.LblUpdData.TabIndex = 3
        Me.LblUpdData.Text = "Data Initial..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "roomid"
        Me.ToolTip1.SetToolTip(Me.Label3, "b站房间号")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "DataRt"
        Me.ToolTip1.SetToolTip(Me.Label4, "数据存储点")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "MaxVal."
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(302, 301)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 30)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(225, 148)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 21)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Act"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(225, 176)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(68, 21)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Act"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(225, 203)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(68, 21)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Act"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(302, 265)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(114, 30)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "Hide"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'BtnDeveloper
        '
        Me.BtnDeveloper.Location = New System.Drawing.Point(302, 193)
        Me.BtnDeveloper.Name = "BtnDeveloper"
        Me.BtnDeveloper.Size = New System.Drawing.Size(114, 30)
        Me.BtnDeveloper.TabIndex = 17
        Me.BtnDeveloper.Text = "DevTools"
        Me.BtnDeveloper.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangelogToolStripMenuItem, Me.ToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(667, 25)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ChangelogToolStripMenuItem
        '
        Me.ChangelogToolStripMenuItem.Name = "ChangelogToolStripMenuItem"
        Me.ChangelogToolStripMenuItem.Size = New System.Drawing.Size(83, 21)
        Me.ChangelogToolStripMenuItem.Text = "Changelog"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EasterEggToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(82, 21)
        Me.ToolStripMenuItem1.Text = "v21041022"
        '
        'EasterEggToolStripMenuItem
        '
        Me.EasterEggToolStripMenuItem.Name = "EasterEggToolStripMenuItem"
        Me.EasterEggToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.EasterEggToolStripMenuItem.Text = "Easter Egg"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(55, 21)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(225, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 21)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Act"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ccd
        '
        Me.ccd.FullOpen = True
        Me.ccd.ShowHelp = True
        '
        'Ni
        '
        Me.Ni.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Ni.BalloonTipText = "文本"
        Me.Ni.BalloonTipTitle = "标题"
        Me.Ni.ContextMenuStrip = Me.MenuNi
        Me.Ni.Icon = CType(resources.GetObject("Ni.Icon"), System.Drawing.Icon)
        Me.Ni.Text = "Data Initial..."
        Me.Ni.Visible = True
        '
        'MenuNi
        '
        Me.MenuNi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.显示主界面ToolStripMenuItem, Me.隐藏设置窗口ToolStripMenuItem, Me.退出EToolStripMenuItem})
        Me.MenuNi.Name = "MenuNi"
        Me.MenuNi.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuNi.Size = New System.Drawing.Size(157, 70)
        '
        '显示主界面ToolStripMenuItem
        '
        Me.显示主界面ToolStripMenuItem.Name = "显示主界面ToolStripMenuItem"
        Me.显示主界面ToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.显示主界面ToolStripMenuItem.Text = "显示主界面(&M)"
        '
        '隐藏设置窗口ToolStripMenuItem
        '
        Me.隐藏设置窗口ToolStripMenuItem.Name = "隐藏设置窗口ToolStripMenuItem"
        Me.隐藏设置窗口ToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.隐藏设置窗口ToolStripMenuItem.Text = "隐藏设置(&H)"
        '
        '退出EToolStripMenuItem
        '
        Me.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem"
        Me.退出EToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.退出EToolStripMenuItem.Text = "退出(&E)"
        '
        'CbBluepb
        '
        Me.CbBluepb.AutoSize = True
        Me.CbBluepb.Checked = True
        Me.CbBluepb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbBluepb.Location = New System.Drawing.Point(12, 88)
        Me.CbBluepb.Name = "CbBluepb"
        Me.CbBluepb.Size = New System.Drawing.Size(60, 16)
        Me.CbBluepb.TabIndex = 24
        Me.CbBluepb.Text = "Topbar"
        Me.CbBluepb.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Interval"
        Me.ToolTip1.SetToolTip(Me.Label6, "若提示错误412则适当增大时延")
        '
        'BtnTimeout
        '
        Me.BtnTimeout.Location = New System.Drawing.Point(225, 229)
        Me.BtnTimeout.Name = "BtnTimeout"
        Me.BtnTimeout.Size = New System.Drawing.Size(68, 21)
        Me.BtnTimeout.TabIndex = 28
        Me.BtnTimeout.Text = "Act"
        Me.BtnTimeout.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 12)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "offset"
        Me.ToolTip1.SetToolTip(Me.Label7, "参数偏移修正")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 12)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "target"
        Me.ToolTip1.SetToolTip(Me.Label8, "若提示错误412则适当增大时延")
        '
        'LllbkgColor
        '
        Me.LllbkgColor.AutoSize = True
        Me.LllbkgColor.Location = New System.Drawing.Point(11, 122)
        Me.LllbkgColor.Name = "LllbkgColor"
        Me.LllbkgColor.Size = New System.Drawing.Size(53, 12)
        Me.LllbkgColor.TabIndex = 45
        Me.LllbkgColor.TabStop = True
        Me.LllbkgColor.Text = "bkgColor"
        Me.ToolTip1.SetToolTip(Me.LllbkgColor, "调整背景颜色")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "val1/val2"
        Me.ToolTip1.SetToolTip(Me.Label2, "若提示错误412则适当增大时延")
        '
        'BtnAutoCorrection
        '
        Me.BtnAutoCorrection.Location = New System.Drawing.Point(225, 257)
        Me.BtnAutoCorrection.Name = "BtnAutoCorrection"
        Me.BtnAutoCorrection.Size = New System.Drawing.Size(68, 21)
        Me.BtnAutoCorrection.TabIndex = 31
        Me.BtnAutoCorrection.Text = "Auto"
        Me.BtnAutoCorrection.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(302, 229)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(114, 30)
        Me.Button9.TabIndex = 32
        Me.Button9.Text = "Reset All"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'CbAutoOc
        '
        Me.CbAutoOc.AutoSize = True
        Me.CbAutoOc.Checked = True
        Me.CbAutoOc.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbAutoOc.Enabled = False
        Me.CbAutoOc.Location = New System.Drawing.Point(500, 35)
        Me.CbAutoOc.Name = "CbAutoOc"
        Me.CbAutoOc.Size = New System.Drawing.Size(156, 16)
        Me.CbAutoOc.TabIndex = 36
        Me.CbAutoOc.Text = "Auto Offset Correction"
        Me.CbAutoOc.UseVisualStyleBackColor = True
        Me.CbAutoOc.Visible = False
        '
        'Button8
        '
        Me.Button8.Enabled = False
        Me.Button8.Location = New System.Drawing.Point(302, 119)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(114, 30)
        Me.Button8.TabIndex = 37
        Me.Button8.Text = "..."
        Me.Button8.UseVisualStyleBackColor = True
        '
        'btnFaded
        '
        Me.btnFaded.Location = New System.Drawing.Point(302, 157)
        Me.btnFaded.Name = "btnFaded"
        Me.btnFaded.Size = New System.Drawing.Size(114, 30)
        Me.btnFaded.TabIndex = 38
        Me.btnFaded.Text = "/Cheat"
        Me.btnFaded.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(225, 284)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(68, 21)
        Me.Button11.TabIndex = 42
        Me.Button11.Text = "Act"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.Location = New System.Drawing.Point(225, 311)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(68, 21)
        Me.Button7.TabIndex = 49
        Me.Button7.Text = "Act"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Last Update:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(359, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 12)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "UserName:"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(424, 65)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(95, 12)
        Me.LblID.TabIndex = 55
        Me.LblID.TabStop = True
        Me.LblID.Text = "Data Initial..."
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(69, 148)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(150, 21)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "4033043"
        '
        'TbDataL
        '
        Me.TbDataL.Location = New System.Drawing.Point(69, 175)
        Me.TbDataL.Name = "TbDataL"
        Me.TbDataL.ReadOnly = True
        Me.TbDataL.Size = New System.Drawing.Size(150, 21)
        Me.TbDataL.TabIndex = 4
        Me.TbDataL.Text = "C:\fentiao"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(69, 202)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(150, 21)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Text = "1000"
        '
        'TbColor
        '
        Me.TbColor.Location = New System.Drawing.Point(69, 119)
        Me.TbColor.Name = "TbColor"
        Me.TbColor.ReadOnly = True
        Me.TbColor.Size = New System.Drawing.Size(150, 21)
        Me.TbColor.TabIndex = 21
        '
        'TbTimeout
        '
        Me.TbTimeout.Location = New System.Drawing.Point(69, 229)
        Me.TbTimeout.Name = "TbTimeout"
        Me.TbTimeout.Size = New System.Drawing.Size(150, 21)
        Me.TbTimeout.TabIndex = 27
        Me.TbTimeout.Text = "10000"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(69, 284)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(150, 21)
        Me.TextBox5.TabIndex = 41
        Me.TextBox5.Text = "200000"
        '
        'TbOffsetVal
        '
        Me.TbOffsetVal.Location = New System.Drawing.Point(69, 256)
        Me.TbOffsetVal.Name = "TbOffsetVal"
        Me.TbOffsetVal.ReadOnly = True
        Me.TbOffsetVal.Size = New System.Drawing.Size(150, 21)
        Me.TbOffsetVal.TabIndex = 46
        Me.TbOffsetVal.Text = "2333"
        '
        'Cbval1
        '
        Me.Cbval1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbval1.FormattingEnabled = True
        Me.Cbval1.Items.AddRange(New Object() {"Now Exp.", "Next Exp.", "Total Exp."})
        Me.Cbval1.Location = New System.Drawing.Point(69, 311)
        Me.Cbval1.Name = "Cbval1"
        Me.Cbval1.Size = New System.Drawing.Size(74, 20)
        Me.Cbval1.TabIndex = 50
        '
        'CbVal2
        '
        Me.CbVal2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbVal2.FormattingEnabled = True
        Me.CbVal2.Items.AddRange(New Object() {"Total Exp.", "Now Exp.", "Next Exp."})
        Me.CbVal2.Location = New System.Drawing.Point(145, 311)
        Me.CbVal2.Name = "CbVal2"
        Me.CbVal2.Size = New System.Drawing.Size(74, 20)
        Me.CbVal2.TabIndex = 51
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(591, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 12)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Interval"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TimerFaded
        '
        Me.TimerFaded.Interval = 1000
        '
        'CbNoLog
        '
        Me.CbNoLog.AutoSize = True
        Me.CbNoLog.Location = New System.Drawing.Point(83, 88)
        Me.CbNoLog.Name = "CbNoLog"
        Me.CbNoLog.Size = New System.Drawing.Size(60, 16)
        Me.CbNoLog.TabIndex = 58
        Me.CbNoLog.Text = "No Log"
        Me.CbNoLog.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(223, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 12)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Now:"
        '
        'LblNowTime
        '
        Me.LblNowTime.AutoSize = True
        Me.LblNowTime.Location = New System.Drawing.Point(258, 65)
        Me.LblNowTime.Name = "LblNowTime"
        Me.LblNowTime.Size = New System.Drawing.Size(95, 12)
        Me.LblNowTime.TabIndex = 60
        Me.LblNowTime.Text = "Data Initial..."
        '
        'TimerUpdate
        '
        Me.TimerUpdate.Enabled = True
        Me.TimerUpdate.Interval = 1000
        '
        'TmEasterEgg
        '
        Me.TmEasterEgg.Interval = 5000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.funny
        Me.PictureBox1.Location = New System.Drawing.Point(422, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(234, 244)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(667, 341)
        Me.Controls.Add(Me.LblNowTime)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CbNoLog)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LblID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbVal2)
        Me.Controls.Add(Me.Cbval1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbOffsetVal)
        Me.Controls.Add(Me.LllbkgColor)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnFaded)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.BtnAutoCorrection)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnTimeout)
        Me.Controls.Add(Me.TbTimeout)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CbBluepb)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TbColor)
        Me.Controls.Add(Me.BtnDeveloper)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbDataL)
        Me.Controls.Add(Me.LblUpdData)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.CbAutoOc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(683, 380)
        Me.MinimumSize = New System.Drawing.Size(683, 380)
        Me.Name = "frmMain"
        Me.Text = "Settings"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuNi.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblUpdData As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnDeveloper As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Button1 As Button
    Friend WithEvents ccd As ColorDialog
    Friend WithEvents Ni As NotifyIcon
    Friend WithEvents CbBluepb As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnTimeout As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnAutoCorrection As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents CbAutoOc As CheckBox
    Friend WithEvents Button8 As Button
    Friend WithEvents btnFaded As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents LllbkgColor As LinkLabel
    Friend WithEvents Button7 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblID As LinkLabel
    Friend WithEvents MenuNi As ContextMenuStrip
    Friend WithEvents 显示主界面ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 隐藏设置窗口ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出EToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TbDataL As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TbColor As TextBox
    Friend WithEvents TbTimeout As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TbOffsetVal As TextBox
    Friend WithEvents Cbval1 As ComboBox
    Friend WithEvents CbVal2 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TimerFaded As Timer
    Friend WithEvents ChangelogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EasterEggToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CbNoLog As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LblNowTime As Label
    Friend WithEvents TimerUpdate As Timer
    Friend WithEvents TmEasterEgg As Timer
End Class
