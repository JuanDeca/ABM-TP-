Public Class Menu

    Private Sub saludo() Handles Me.Load
        Label3.Text = nombre & " " & apellido
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cli As New Clientes
        cli.ShowDialog()
        saludo()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cli As New Proveedores
        cli.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cli As New Usuarios
        cli.ShowDialog()
    End Sub

    Private Sub saludo(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class