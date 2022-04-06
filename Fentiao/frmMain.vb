Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class frmMain

    Dim fileReader As String        '读出数据的容器
    Dim js As JObject               '作为json被解析后的数据
    Dim JsonStr As String           '同上
    Dim ftdattime                   '数据拉取时间
    'Dim filehash                   '文件哈希
    Dim fileattr As String          '文件属性

    Dim leftval                     '进度条左边值，应该是个常量
    Dim rightval                    '进度条右边值，应该也是个常量（纠正：是变量）
    Dim totalexp                    '总经验
    Dim nowexp                      '现在的经验值
    Dim nextexp                     '升级所需经验值
    Dim upnickname As String        'UP主用户名
    Dim uid As String               'uid

    Dim debugflag                   '调试标记
    Dim saveddata As String         '调试412用的文件存储（已弃用）
    Dim firstinit As Boolean        'First Init-Register
    Dim orilocation As String       '偏移值-原始
    Dim biliapiaddr As Uri          'api地址（String转uri）
    Dim icden As Net.ICredentials   '就随便赋个null，反正也不会报错
    Dim randomnum                   '随机化Interval
    Dim timeoutPlz                  '如果出现意外的逃脱设置（已弃用）

    Dim eeval                       '彩蛋的随机值（临时弃用）
    Dim EEMain                      '主界面Menu的彩蛋
    Dim KQTLT                       '卡其脱离太
    Dim Kally                       '彩蛋

    Private Sub BtnDeveloper_Click(sender As Object, e As EventArgs) Handles BtnDeveloper.Click
        FrmDevTools.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Try

            Randomize()

            If My.Computer.Network.IsAvailable Then
                If File.Exists(TbDataL.Text & "\LiveData.ftdat") Then
                    fileReader = My.Computer.FileSystem.ReadAllText(TbDataL.Text & "\LiveData.ftdat")
                    My.Computer.FileSystem.DeleteFile(TbDataL.Text & "\LiveData.ftdat")
                End If
                If File.Exists("C:\fentiao\DevFlag-Force412.ftdat") Then
                    biliapiaddr = New Uri("https://api.bilibili.com/x/relation/followers?vmid=" & TextBox1.Text & "&pn=1&ps=20&order=desc")
                    saveddata = "\LiveData-412.ftdat"
                Else
                    biliapiaddr = New Uri("https://api.live.bilibili.com/live_user/v1/UserInfo/get_anchor_in_room?roomid=" & TextBox1.Text)
                    saveddata = "\LiveData.ftdat"
                End If
                '拉取粉丝量：My.Computer.Network.DownloadFile("https://api.bilibili.com/x/relation/followers?vmid=" & TextBox1.Text & "&pn=1&ps=20&order=desc", "c:\fentiao\data.ftdat")
                My.Computer.Network.DownloadFile(biliapiaddr, TbDataL.Text & saveddata, icden, False, 4000, True)
                'MSDN官方示例：My.Computer.Network.DownloadFile("http://www.cohowinery.com/downloads/", "C:\Documents and Settings\All Users\Documents\WineList.txt", "", "", False, 500, True)
            End If

            '开始执行主代码部分

            JsonStr = fileReader
            FrmDevTools.TbData0.Text = fileReader

            js = JObject.Parse(JsonStr)

            totalexp = Integer.Parse(js.SelectToken("data").SelectToken("level").SelectToken("anchor_score")) + Integer.Parse(js.SelectToken("data").SelectToken("level").SelectToken("master_level").SelectToken("upgrade_score"))
            nowexp = js.SelectToken("data").SelectToken("level").SelectToken("master_level").SelectToken("anchor_score")
            nextexp = js.SelectToken("data").SelectToken("level").SelectToken("master_level").SelectToken("upgrade_score")
            upnickname = js.SelectToken("data").SelectToken("info").SelectToken("uname")
            uid = js.SelectToken("data").SelectToken("info").SelectToken("uid")

            ProgressBar1.Maximum = totalexp
            ProgressBar1.Value = nowexp

            If Cbval1.SelectedIndex = 0 Then
                FrmViewer.LblNow.Text = nowexp
            ElseIf Cbval1.SelectedIndex = 1 Then
                FrmViewer.LblNow.Text = nextexp
            ElseIf Cbval1.SelectedIndex = 2 Then
                FrmViewer.LblNow.Text = totalexp
            End If
            If CbVal2.SelectedIndex = 0 Then
                FrmViewer.LblNext.Text = totalexp
            ElseIf CbVal2.SelectedIndex = 1 Then
                FrmViewer.LblNext.Text = nowexp
            ElseIf CbVal2.SelectedIndex = 2 Then
                FrmViewer.LblNext.Text = nextexp
            End If

            LblUpdData.Text = js.SelectToken("data").SelectToken("level").SelectToken("update_time")

            FrmViewer.LblLevel.Text = js.SelectToken("data").SelectToken("level").SelectToken("master_level").SelectToken("level")

            FrmViewer.PbTop.Width = （nowexp / totalexp） * 550

            TextBox3.Text = totalexp

            LblID.Text = upnickname

            'filehash = My.Computer.FileSystem.GetHashCode().ToString
            ftdattime = System.IO.File.GetAttributes(TbDataL.Text & "\LiveData.ftdat").ToString

            If CbAutoOc.Checked = True Then
                FrmViewer.LblNext.Left = FrmViewer.LblNow.Location.X + FrmViewer.LblNow.Size.Width - 15
                'MsgBox(FrmViewer.LblNext.Location.X.ToString & vbNewLine & FrmViewer.LblNext.Size.Width.ToString)
                'FrmViewer.Width = FrmViewer.LblNext.Location.X.ToString + FrmViewer.LblNext.Size.Width.ToString + 30
                FrmViewer.Width = FrmViewer.LblNow.Location.X + FrmViewer.LblNow.Width + FrmViewer.LblNext.Width
            End If

            Ni.Text = "Live Progressbar" & vbNewLine & "Last Data Grab: " & LblUpdData.Text

            Do
                randomnum = Int(Rnd() * 10000)
                If randomnum > 5000 And randomnum < TbTimeout.Text Then
                    Timer1.Interval = randomnum
                    Label10.Text = randomnum
                    Exit Do
                End If
            Loop

        Catch ex As Exception

            '新建一个log窗口输出log
            Dim exMsg = String.Format("Source:{0} happened exception :{1} on {2}", ex.Source, ex.Message, ex.TargetSite)
            If CbNoLog.Checked = False Then
                If FrmLog.TbLog.Text = "" Then
                    FrmLog.TbLog.Text = Format(Now, "HH:mm:ss") & " - " & exMsg
                    FrmLog.Show()
                Else
                    If ex.Message = "未将对象引用设置到对象的实例。" Then
                        Timer1.Enabled = False
                        MsgBox("Parameter rommid is incorrect.", vbCritical, "Error 0")
                        FrmLog.TbLog.Text = FrmLog.TbLog.Text & vbNewLine & Format(Now, "HH:mm:ss") & " - " & exMsg
                        FrmLog.Show()
                    Else
                        FrmLog.TbLog.Text = FrmLog.TbLog.Text & vbNewLine & Format(Now, "HH:mm:ss") & " - " & exMsg
                        FrmLog.Show()
                    End If
                End If
            End If

        End Try

        TbOffsetVal.Text = orilocation - FrmViewer.Width

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "InitValv12", Nothing) Is Nothing Then
            My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\LingTool\Ft")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "InitValv12", "Init Done.")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "roomid", "4033043")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "TbDataL", "C:\fentiao")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "TbTimeOut", "5000")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "TbTimeOutNew", "10000")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "ViewerWidth", "984")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "LeftVal", "0")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "RightVal", "0")
            Cbval1.SelectedIndex = 0
            CbVal2.SelectedIndex = 0
            firstinit = True
        Else
            firstinit = False
            TextBox1.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "roomid", "4033043")
            TbDataL.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "TbDataL", "C:\fentiao")
            TbTimeout.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "TbTimeOutNew", "10000")
            Timer1.Interval = TbTimeout.Text
            FrmViewer.Width = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "ViewerWidth", "984")
            Cbval1.SelectedIndex = Val(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "LeftVal", "0"))
            CbVal2.SelectedIndex = Val(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "RightVal", "0"))
        End If

        orilocation = FrmViewer.LblNext.Location.X

        FrmViewer.Show()

        debugflag = "0"

        Kally = "Data Initial..."

        TbColor.Text = (ccd.Color).ToString

        FrmViewer.PbBlueTop.Visible = True
        FrmViewer.PbBlueBottom.Visible = True
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "Topbar", "False")

        FrmViewer.LblNow.Text = "23333"
        FrmViewer.LblNext.Text = "2333"

        EEMain = 0

        If System.IO.File.Exists("C:\fentiao\DevFlag.ftdat") Then
            Ni.ShowBalloonTip(60, "初始化完成", My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "roomid", "4033043") & vbNewLine & My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "TbDataL", "C:\fentiao") & vbNewLine & Val(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "LeftVal", "0")).ToString & vbNewLine & Val(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "RightVal", "0")).ToString, ToolTipIcon.Info)
            Ni.ShowBalloonTip(3600, "Fentiao App", "此版本为内部测试版本，可能会有很多问题导致无法正常使用。请更换正式版（Release版本）使用！", ToolTipIcon.Warning)
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Ni.ShowBalloonTip(5, "主界面已隐藏", "双击托盘图标或双击主体的等级数字重新显示主界面", ToolTipIcon.Info)
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        If KQTLT = "0" Or KQTLT = "" Then
            Ni.ShowBalloonTip(5, "卡其脱离太 莫诺摸那一", "木哟库喏八嘎呐哇那类那一 搜类得kimi哇一大哟", ToolTipIcon.Info)
            PictureBox1.Image = WindowsApp1.My.Resources.Resources.kqtlt
            KQTLT = "1"
        ElseIf KQTLT = "1" Then
            KQTLT = "0"
            PictureBox1.Image = WindowsApp1.My.Resources.Resources.funny
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Timer1.Enabled = True Then
            Timer1.Enabled = False
            TextBox1.ReadOnly = False
            LblUpdData.Text = "Data Initial..."
            ProgressBar1.Maximum = 100
            ProgressBar1.Value = 20
            Ni.ShowBalloonTip(30, "房间号设置", "已停止拉取数据，您现在可以更改房间号了" & vbNewLine & "若新更改的房间号不正确可能导致程序崩溃！", ToolTipIcon.Info)
        Else
            Timer1.Enabled = True
            TextBox1.ReadOnly = True
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "roomid", TextBox1.Text)
            Ni.ShowBalloonTip(30, "房间号设置", "房间号已设定为" & TextBox1.Text & vbNewLine & "Enjoy ur live!", ToolTipIcon.Info)
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MsgBox("Function Developing...", vbCritical, "Ling Tool.")
    End Sub

    Private Sub ChanglogToolStripMenuItem_Click(sender As Object, e As EventArgs)

        MsgBox("None.", vbCritical, "Ling Tool.")

    End Sub

    Private Sub ccd_HelpRequest(sender As Object, e As EventArgs) Handles ccd.HelpRequest
        MsgBox("暂无帮助信息", vbCritical, "Ling Tools.")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmViewer.BackColor = ccd.Color
        TbColor.Text = (ccd.Color).ToString
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Ni.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub BtnTimeout_Click(sender As Object, e As EventArgs) Handles BtnTimeout.Click
        If TbTimeout.Text < 2000 Then
            If MsgBox("延时若小于2000ms则可能会出现412错误（接口拒绝服务），确定要将时延设置为" & TbTimeout.Text & "毫秒吗？", vbYesNo, "Ling Tool.") = 6 Then
                Timer1.Interval = TbTimeout.Text
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "TbTimeOutNew", TbTimeout.Text)
                Ni.ShowBalloonTip(5, "时延设置", "时延已设置为" & TbTimeout.Text & vbNewLine & "若出现412错误请更换ip并适当增大时延值", ToolTipIcon.Info)
            Else
                TbTimeout.Text = "2000"
            End If
        Else
            Timer1.Interval = TbTimeout.Text
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "TbTimeOutNew", TbTimeout.Text)
            Ni.ShowBalloonTip(5, "时延设置", "时延已设置为" & TbTimeout.Text & vbNewLine & "若出现412错误请更换ip并适当增大时延值", ToolTipIcon.Info)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TbDataL.ReadOnly = True Then
            Timer1.Enabled = False
            TbDataL.ReadOnly = False
            LblUpdData.Text = "Data Initial..."
            ProgressBar1.Maximum = 100
            ProgressBar1.Value = 20
            Ni.ShowBalloonTip(60, "数据保存点", "已停止拉取数据，您现在可以更改数据保存路径了" & vbNewLine & "若新更改的数据路径不存在或不正确（包括只读或权限不正确）可能导致程序崩溃！" & vbNewLine & "修改时结尾不需要斜杠", ToolTipIcon.Info)
        Else
            Timer1.Enabled = True
            TbDataL.ReadOnly = True
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "TbDataL", TbDataL.Text)
            Ni.ShowBalloonTip(15, "数据保存点", "数据保存路径已设置为" & TbDataL.Text & "\LiveData" & vbNewLine & "Enjoy ur live!", ToolTipIcon.Info)
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'If MsgBox("是否确定重设所有相关值？", vbYesNo, "重置") = 6 Then
        '    LblUpdData.Text = "Data Initial..."
        '    FrmDevTools.TbData0.Text = "Data Initial..."
        '    TextBox1.Text = "4033043"
        '    TbDataL.Text = "C:\fentiao"
        '    TbTimeout.Text = "5000"
        '    My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "InitVal", "Init Done.")
        '    My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "InitValv8", "Init Done.")
        '    My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "roomid", "4033043")
        '    My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "TbDataL", "C:\fentiao")
        '    My.Computer.Registry.SetValue("HKEYToolTipIcon.Info)_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "TbTimeOut", "5000")
        '    Ni.ShowBalloonTip(30, "重置", "重置完成", 
        'End If
        MsgBox("Failed", vbCritical, "Ling Tools")
    End Sub

    Private Sub CbBluepb_CheckedChanged(sender As Object, e As EventArgs) Handles CbBluepb.CheckedChanged
        If CbBluepb.Checked = True Then
            FrmViewer.PbBlueTop.Visible = True
            FrmViewer.PbBlueBottom.Visible = True
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "Topbar", "True")
        ElseIf CbBluepb.Checked = False Then
            FrmViewer.PbBlueTop.Visible = False
            FrmViewer.PbBlueBottom.Visible = False
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "Topbar", "False")
        End If
    End Sub

    Private Sub BtnAutoCorrection_Click(sender As Object, e As EventArgs) Handles BtnAutoCorrection.Click
        FrmViewer.LblNext.Left = FrmViewer.LblNow.Location.X + FrmViewer.LblNow.Size.Width
    End Sub

    Private Sub CbAutoOc_CheckedChanged(sender As Object, e As EventArgs) Handles CbAutoOc.CheckedChanged
        If CbAutoOc.Checked = False Then
            'OcL1.Enabled = True
            'OcL2.Enabled = True
            BtnAutoCorrection.Enabled = True
            FrmViewer.LblNext.Left = FrmViewer.LblNow.Location.X + FrmViewer.LblNow.Size.Width
        Else
            'OcL1.Enabled = False
            'OcL2.Enabled = False
            BtnAutoCorrection.Enabled = False
            'FrmViewer.LblNext.Left = orilocation
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub LllbkgColor_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LllbkgColor.LinkClicked
        ccd.ShowDialog()
        FrmViewer.BackColor = ccd.Color
    End Sub

    Private Sub Cbval1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbval1.SelectedIndexChanged
        If Cbval1.SelectedIndex = 0 Then
            FrmViewer.LblNow.Text = nowexp
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "LeftVal", "0")
            Ni.ShowBalloonTip(5, "Val.1设定", "Val.1已设定为当前经验值", ToolTipIcon.Info)
        ElseIf Cbval1.SelectedIndex = 1 Then
            FrmViewer.LblNow.Text = nextexp
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "LeftVal", "1")
            Ni.ShowBalloonTip(5, "Val.1设定", "Val.1已设定为升级所需经验值", ToolTipIcon.Info)
        ElseIf Cbval1.SelectedIndex = 2 Then
            FrmViewer.LblNow.Text = totalexp
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "LeftVal", "2")
            Ni.ShowBalloonTip(5, "Val.1设定", "Val.1已设定为总经验值", ToolTipIcon.Info)
        End If
    End Sub

    Private Sub Cbval2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbVal2.SelectedIndexChanged
        If CbVal2.SelectedIndex = 0 Then
            FrmViewer.LblNow.Text = totalexp
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "LeftVal", "0")
            Ni.ShowBalloonTip(5, "Val.2设定", "Val.2已设定为总经验值", ToolTipIcon.Info)
        ElseIf CbVal2.SelectedIndex = 1 Then
            FrmViewer.LblNow.Text = nowexp
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "LeftVal", "1")
            Ni.ShowBalloonTip(5, "Val.2设定", "Val.2已设定为总经验值", ToolTipIcon.Info)
        ElseIf CbVal2.SelectedIndex = 2 Then
            FrmViewer.LblNow.Text = nextexp
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\LingTool\Ft", "LeftVal", "2")
            Ni.ShowBalloonTip(5, "Val.2设定", "Val.2已设定为总经验值", ToolTipIcon.Info)
        End If
    End Sub

    Private Sub LblID_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblID.LinkClicked
        Process.Start("https://space.bilibili.com/" & uid)
    End Sub

    Private Sub 隐藏设置窗口ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 隐藏设置窗口ToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub 显示主界面ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 显示主界面ToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub 退出EToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出EToolStripMenuItem.Click
        End
    End Sub

    Private Sub TbFdInterVal_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TbFdUpData_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TbTargetData_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ChangelogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem.Click
        MsgBox("我什么时候写过这个东西", vbInformation, "Changelog")
    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Live Progessbar" & vbNewLine & vbNewLine & "Designed by Aeka0" & vbNewLine & "Code by Lxn", vbInformation, "About")
    End Sub

    Private Sub EasterEggToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EasterEggToolStripMenuItem.Click
        If EEMain = 0 Then
            MsgBox("别点我，我不是彩蛋" & vbNewLine & "你见过哪个彩蛋这么明显的⊂彡☆))д`)", vbInformation, "俺不是彩蛋")
            EEMain = EEMain + 1
        ElseIf EEMain = 1 Then
            MsgBox("告诉你别点了，这真的不是彩蛋" & vbNewLine & "再点就报警了啊⊂彡☆))д´)", vbInformation, "俺不是彩蛋")
            EEMain = EEMain + 1
        ElseIf EEMain = 2 Then
            MsgBox("啧你怎么还在点⊂彡☆))д´)" & vbNewLine & "告诉你别点了", vbInformation, "俺不是彩蛋")
            EEMain = EEMain + 1
        ElseIf EEMain = 3 Then
            MsgBox("你这个人怎么回事！！！" & vbNewLine & "怎么还在点(|||ﾟдﾟ)", vbInformation, "俺不是彩蛋")
            EEMain = EEMain + 1
        ElseIf EEMain = 4 Then
            MsgBox("你看这个人无聊的很，一直在点不是彩蛋的东西" & vbNewLine & "(`ヮ´ )σ`∀´)ﾟ∀ﾟ)σ", vbInformation, "俺不是彩蛋")
            EEMain = EEMain + 1
        ElseIf EEMain = 5 Then
            MsgBox("Android系统连点版本号是有彩蛋了" & vbNewLine & "可我没有啊！！！", vbInformation, "俺不是彩蛋")
            EEMain = EEMain + 1
        ElseIf EEMain = 6 Then
            MsgBox("再点我拧你头信不信(╬ﾟдﾟ)" & vbNewLine & " ", vbInformation, "俺不是彩蛋")
            EEMain = EEMain + 1
        ElseIf EEMain = 7 Then
            MsgBox("行行行你赢了，" & vbNewLine & "彩蛋已经停用了。" & vbNewLine & "别点了啊，再点我也不会理你了", vbInformation, "俺真的不是彩蛋")
            EEMain = EEMain + 1
        ElseIf EEMain = 8 Then
            MsgBox("你怎么还在点" & vbNewLine & "这是最后一条了，真的是最后一条了", vbInformation, "俺真的不是彩蛋")
            EEMain = EEMain + 1
        End If
    End Sub

    Private Sub TimerUpdate_Tick(sender As Object, e As EventArgs) Handles TimerUpdate.Tick
        LblNowTime.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub TmEasterEgg_Tick(sender As Object, e As EventArgs) Handles TmEasterEgg.Tick
        '由于OBS捕捉的问题导致该功能暂时弃用
        '重新启用需要将Timer的Enable改成True即可
        '2021-04-14更新重新启用了本彩蛋
        '新的变量：Kally
        Randomize()
        eeval = Int(Rnd() * 100)
        Do
            If eeval = 0 Then
                Kally = "无物为真，诸行皆可"
                Exit Do
            ElseIf eeval = 1 Then
                Kally = "交给姐姐我吧☆~"
                Exit Do
            ElseIf eeval = 2 Then
                Kally = "坏孩子都要被烘焙掉哦❤~"
                Exit Do
            ElseIf eeval = 3 Then
                Kally = "生而为人，整点狠活"
                Exit Do
            ElseIf eeval = 4 Then
                Kally = "无物为真，诸行皆可"
                Exit Do
            ElseIf eeval = 5 Then
                Kally = "其实我对混合咖啡还是很有自信的"
                Exit Do
            ElseIf eeval = 6 Then
                Kally = "消除恐惧的最好方法就是面对恐惧"
                Exit Do
            ElseIf eeval = 7 Then
                Kally = "好时代，来临吧！"
                Exit Do
            ElseIf eeval = 8 Then
                Kally = "坚持学习勤充电，每天进步一点点"
                Exit Do
            ElseIf eeval = 9 Then
                Kally = "你刚刚说我的头发怎么了？"
                Exit Do
            ElseIf eeval = 10 Then
                Kally = "犹豫，就会败北"
                Exit Do
            ElseIf eeval = 11 Then
                Kally = "遇事不决，读读用户手册"
                Exit Do
            ElseIf eeval = 12 Then
                Kally = "那我就卖个萌给你看✧ヽ(>ω• )ゞ"
                Exit Do
            ElseIf eeval = 13 Then
                Kally = "不忘信念、不畏羞耻、不留遗憾"
                Exit Do
            ElseIf eeval = 14 Then
                Kally = "玄不救非，氪不改命"
                Exit Do
            ElseIf eeval = 15 Then
                Kally = "Don't panic"
                Exit Do
            ElseIf eeval = 16 Then
                Kally = "你，渴望力量吗？"
                Exit Do
            ElseIf eeval = 17 Then
                Kally = "↑↑↓↓←→←→BABA"
                Exit Do
            ElseIf eeval = 18 Then
                Kally = "遇到困难，睡大觉"
                Exit Do
            ElseIf eeval = 19 Then
                Kally = "←TO BE COUNTINUED~"
                Exit Do
            ElseIf eeval = 20 Then
                Kally = "刚刚柜子是不是动了一下？"
                Exit Do
            ElseIf eeval = 21 Then
                Kally = "0 error(s), 0 warning(s)"
                Exit Do
            ElseIf eeval = 22 Then
                Kally = "有没有可能是因为你观测了，所以这里才出现了一句话？"
                Exit Do
            ElseIf eeval = 23 Then
                Kally = "久坐要多站起来活动哦"
                Exit Do
            ElseIf eeval = 24 Then
                Kally = "看到这条文字的话就站起来原地跳10次吧"
                Exit Do
            ElseIf eeval = 25 Then
                Kally = "今天有喝足够多的水吗？"
                Exit Do
            ElseIf eeval = 26 Then
                Kally = "多喝热水确实是对的!"
                Exit Do
            ElseIf eeval = 27 Then
                Kally = "好梦向来易醒"
                Exit Do
            ElseIf eeval = 28 Then
                Kally = "一息若存，希望不灭"
                Exit Do
            ElseIf eeval = 29 Then
                Kally = "比完美更重要的是完成"
                Exit Do
            ElseIf eeval = 30 Then
                Kally = "好梦向来易醒"
                Exit Do
            ElseIf eeval = 31 Then
                Kally = "千鸟在林，不如一鸟在手"
                Exit Do
            ElseIf eeval = 32 Then
                Kally = "精彩的人生不必苛求完美"
                Exit Do
            ElseIf eeval = 33 Then
                Kally = "比完美更重要的是完成"
                Exit Do
            ElseIf eeval = 34 Then
                Kally = "人生无重来，珍重而活"
                Exit Do
            ElseIf eeval = 35 Then
                Kally = "公者千古，私者一时"
                Exit Do
            ElseIf eeval = 36 Then
                Kally = "步伐虽小，密而不停"
                Exit Do
            ElseIf eeval = 37 Then
                Kally = "恋爱和战斗都要勇往直前"
                Exit Do
            ElseIf eeval = 38 Then
                Kally = "自我感动是最没有用处的"
                Exit Do
            Else
                Exit Do
            End If
        Loop
    End Sub

    Private Sub ProgressBar1_DoubleClick(sender As Object, e As EventArgs) Handles ProgressBar1.DoubleClick
        FrmViewer.Show()
    End Sub

    Private Sub btnFaded_Click(sender As Object, e As EventArgs) Handles btnFaded.Click
        MsgBox("Failed", vbCritical, "Live Progessbar")
    End Sub

End Class


