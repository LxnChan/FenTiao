Imports System.Net

Public Class FrmDevTools

    Private Sub BtnDevCode_Click(sender As Object, e As EventArgs) Handles BtnDevCode.Click
        If TbDevCode.Text = "4033043" Then
            GbCloudControl.Visible = True
            GroupBox1.Visible = True
            GroupBox2.Visible = True
            GroupBox3.Visible = True
        ElseIf TbDevCode.Text = "6026" Then
            GroupBox1.Visible = True
        ElseIf TbDevCode.Text = "" Then
            MsgBox("DevCode参数不可为空！", vbCritical, "Dev Tool.")
        Else
            MsgBox("加载失败" & vbNewLine & vbNewLine & "Data Error: DevCode Error?", vbCritical, "Dev Tool.")
        End If
    End Sub

    Private Sub BtnGDT_Click(sender As Object, e As EventArgs) Handles BtnGDT.Click

    End Sub

    Private Sub FrmDevTools_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Async Sub Button2_ClickAsync(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ws = New System.Net.WebSockets.ClientWebSocket
        ' optional: ignore certificate errors
        ServicePointManager.ServerCertificateValidationCallback = Function(s, c, h, d) True

        Try
            Await ws.ConnectAsync(New Uri("wss://demos.kaazing.com/echo"), Nothing)
            If (ws.State = WebSockets.WebSocketState.Open) Then
                Debug.Print("Opened.")
                Await ws.SendAsync(New ArraySegment(Of Byte)(System.Text.Encoding.UTF8.GetBytes("{ ""message"":""hello""}")), WebSockets.WebSocketMessageType.Text, True, Nothing)
                Dim bytes(4096) As Byte
                Dim answ = New ArraySegment(Of Byte)(bytes)
                Await ws.ReceiveAsync(answ, Nothing)
                Debug.Print("answer:" + System.Text.Encoding.UTF8.GetString(answ.Array))
            Else
                Debug.Print("Not opened?!")
            End If
        Catch
            Debug.Print("Error.")
        End Try

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class