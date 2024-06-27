<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class baltaDoS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(baltaDoS))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtReceive = New System.Windows.Forms.RichTextBox()
        Me.txtHeader = New System.Windows.Forms.RichTextBox()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMakineler = New System.Windows.Forms.Label()
        Me.txtDenenen = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIndirilen = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtDurum = New System.Windows.Forms.Label()
        Me.txtHatadurum = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMakinehiz = New System.Windows.Forms.TextBox()
        Me.txtOlumakineler = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFloodhiz = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCalisanmakineler = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtLimit = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(9, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Giden Header:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(9, 247)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Gelen Cevap:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Host:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(410, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 30)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "SSL Yok (80)"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtReceive
        '
        Me.txtReceive.BackColor = System.Drawing.Color.Black
        Me.txtReceive.ForeColor = System.Drawing.Color.Silver
        Me.txtReceive.Location = New System.Drawing.Point(12, 263)
        Me.txtReceive.Name = "txtReceive"
        Me.txtReceive.ReadOnly = True
        Me.txtReceive.Size = New System.Drawing.Size(495, 208)
        Me.txtReceive.TabIndex = 12
        Me.txtReceive.Text = ""
        '
        'txtHeader
        '
        Me.txtHeader.BackColor = System.Drawing.Color.Black
        Me.txtHeader.ForeColor = System.Drawing.Color.White
        Me.txtHeader.Location = New System.Drawing.Point(12, 77)
        Me.txtHeader.Name = "txtHeader"
        Me.txtHeader.Size = New System.Drawing.Size(495, 161)
        Me.txtHeader.TabIndex = 11
        Me.txtHeader.Text = resources.GetString("txtHeader.Text")
        '
        'txtHost
        '
        Me.txtHost.BackColor = System.Drawing.Color.Black
        Me.txtHost.ForeColor = System.Drawing.Color.White
        Me.txtHost.Location = New System.Drawing.Point(45, 20)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(256, 20)
        Me.txtHost.TabIndex = 10
        Me.txtHost.Text = "www.incisozluk.com.tr"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(307, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 30)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "SSL Var (443)"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(528, 358)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Makineler:"
        '
        'txtMakineler
        '
        Me.txtMakineler.AutoSize = True
        Me.txtMakineler.ForeColor = System.Drawing.Color.Yellow
        Me.txtMakineler.Location = New System.Drawing.Point(640, 358)
        Me.txtMakineler.Name = "txtMakineler"
        Me.txtMakineler.Size = New System.Drawing.Size(13, 13)
        Me.txtMakineler.TabIndex = 18
        Me.txtMakineler.Text = "0"
        '
        'txtDenenen
        '
        Me.txtDenenen.AutoSize = True
        Me.txtDenenen.ForeColor = System.Drawing.Color.Red
        Me.txtDenenen.Location = New System.Drawing.Point(640, 425)
        Me.txtDenenen.Name = "txtDenenen"
        Me.txtDenenen.Size = New System.Drawing.Size(13, 13)
        Me.txtDenenen.TabIndex = 22
        Me.txtDenenen.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(528, 425)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Denenen Soket:"
        '
        'txtIndirilen
        '
        Me.txtIndirilen.AutoSize = True
        Me.txtIndirilen.ForeColor = System.Drawing.Color.Yellow
        Me.txtIndirilen.Location = New System.Drawing.Point(640, 207)
        Me.txtIndirilen.Name = "txtIndirilen"
        Me.txtIndirilen.Size = New System.Drawing.Size(13, 13)
        Me.txtIndirilen.TabIndex = 28
        Me.txtIndirilen.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(528, 207)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "İndirilen Sayfa (KB):"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(513, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(183, 30)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Threadları Durdur"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtDurum
        '
        Me.txtDurum.AutoSize = True
        Me.txtDurum.ForeColor = System.Drawing.Color.Yellow
        Me.txtDurum.Location = New System.Drawing.Point(640, 458)
        Me.txtDurum.Name = "txtDurum"
        Me.txtDurum.Size = New System.Drawing.Size(13, 13)
        Me.txtDurum.TabIndex = 30
        Me.txtDurum.Text = "0"
        '
        'txtHatadurum
        '
        Me.txtHatadurum.AutoSize = True
        Me.txtHatadurum.ForeColor = System.Drawing.Color.Lime
        Me.txtHatadurum.Location = New System.Drawing.Point(640, 410)
        Me.txtHatadurum.Name = "txtHatadurum"
        Me.txtHatadurum.Size = New System.Drawing.Size(10, 13)
        Me.txtHatadurum.TabIndex = 32
        Me.txtHatadurum.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(528, 410)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Hata Durum:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(528, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Makine Artış Ms:"
        '
        'txtMakinehiz
        '
        Me.txtMakinehiz.Location = New System.Drawing.Point(640, 77)
        Me.txtMakinehiz.Name = "txtMakinehiz"
        Me.txtMakinehiz.Size = New System.Drawing.Size(59, 20)
        Me.txtMakinehiz.TabIndex = 34
        Me.txtMakinehiz.Text = "100"
        '
        'txtOlumakineler
        '
        Me.txtOlumakineler.AutoSize = True
        Me.txtOlumakineler.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtOlumakineler.Location = New System.Drawing.Point(640, 374)
        Me.txtOlumakineler.Name = "txtOlumakineler"
        Me.txtOlumakineler.Size = New System.Drawing.Size(13, 13)
        Me.txtOlumakineler.TabIndex = 37
        Me.txtOlumakineler.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(528, 374)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Ölü Makineler:"
        '
        'txtFloodhiz
        '
        Me.txtFloodhiz.Location = New System.Drawing.Point(640, 129)
        Me.txtFloodhiz.Name = "txtFloodhiz"
        Me.txtFloodhiz.Size = New System.Drawing.Size(59, 20)
        Me.txtFloodhiz.TabIndex = 39
        Me.txtFloodhiz.Text = "100"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(528, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Flood Ms:"
        '
        'txtCalisanmakineler
        '
        Me.txtCalisanmakineler.AutoSize = True
        Me.txtCalisanmakineler.ForeColor = System.Drawing.Color.Lime
        Me.txtCalisanmakineler.Location = New System.Drawing.Point(640, 225)
        Me.txtCalisanmakineler.Name = "txtCalisanmakineler"
        Me.txtCalisanmakineler.Size = New System.Drawing.Size(13, 13)
        Me.txtCalisanmakineler.TabIndex = 41
        Me.txtCalisanmakineler.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(528, 225)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Çalışan Makineler:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(528, 458)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Durum:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(528, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 13)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Makine Limiti:"
        '
        'txtLimit
        '
        Me.txtLimit.Location = New System.Drawing.Point(640, 103)
        Me.txtLimit.Name = "txtLimit"
        Me.txtLimit.Size = New System.Drawing.Size(59, 20)
        Me.txtLimit.TabIndex = 44
        Me.txtLimit.Text = "1000"
        '
        'baltaDoS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1318, 495)
        Me.Controls.Add(Me.txtLimit)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCalisanmakineler)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtFloodhiz)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtOlumakineler)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMakinehiz)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtHatadurum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDurum)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtIndirilen)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtDenenen)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtMakineler)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtReceive)
        Me.Controls.Add(Me.txtHeader)
        Me.Controls.Add(Me.txtHost)
        Me.Controls.Add(Me.Button1)
        Me.Name = "baltaDoS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balta DoS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtReceive As System.Windows.Forms.RichTextBox
    Friend WithEvents txtHeader As System.Windows.Forms.RichTextBox
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMakineler As System.Windows.Forms.Label
    Friend WithEvents txtDenenen As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtIndirilen As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtDurum As System.Windows.Forms.Label
    Friend WithEvents txtHatadurum As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMakinehiz As System.Windows.Forms.TextBox
    Friend WithEvents txtOlumakineler As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFloodhiz As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCalisanmakineler As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtLimit As System.Windows.Forms.TextBox

End Class
