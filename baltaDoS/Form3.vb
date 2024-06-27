Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Shell("ipconfig /flushdns")
        Label1.Enabled = True
        Timer2.Start()
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Shell("ipconfig /release")
        Label2.Enabled = True
        Timer3.Start()
        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Shell("ipconfig /renew")
        Label3.Enabled = True
        Timer4.Start()
        Timer3.Stop()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Form2.Show()
        Me.Close()
    End Sub
End Class