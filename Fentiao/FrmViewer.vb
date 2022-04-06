Public Class FrmViewer

    'Win32 API
    Declare Auto Function ReleaseCapture Lib "user32.dll" Alias "ReleaseCapture" () As Boolean
    Declare Auto Function SendMessage Lib "user32.dll" Alias "SendMessage" (ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
    'Win32 Message
    Private Const WM_SYSCOMMAND As Integer = &H112&
    Private Const SC_MOVE As Integer = &HF010&
    Private Const HTCAPTION As Integer = &H2&

    'Dim g As Graphics = Me.PictureBox1.CreateGraphics
    'Dim mpen As New Pen(Color.Red)
    'Dim Points As PointF() = {New PointF(12, 12), New PointF(12, 51.5), New PointF(63.5, 20.0F), New PointF(50.0F, 100.0F)}

    Private Sub frmLogin_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)
        End If
    End Sub

    Private Sub LblLevel_DoubleClick(sender As Object, e As EventArgs) Handles LblLevel.DoubleClick
        frmMain.Show()
    End Sub

    Private Sub FrmViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblLevel.Parent = PictureBox1
        LblLevel.BackColor = Color.Transparent
    End Sub
End Class