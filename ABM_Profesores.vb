Imports System.IO
Imports System.Data.SqlClient
Public Class ABM_Profesores

    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=sistema; integrated security=true")

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cli As New Menu
        cli.ShowDialog()
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text = TextBox1.Text.Replace("'", "").Replace(" ", "").Replace("""", "")

        Dim da As New SqlDataAdapter("SELECT apellido, nombre, usuario, clave from [Sistema].[dbo].[Usuarios] where usuario like '" & TextBox1.Text & "'", con)
        Dim ds As New DataSet
        da.Fill(ds, "Usuarios")

        If ds.Tables("Usuarios").Rows.Count <> 0 Then

            If ds.Tables("Usuarios").Rows(0)("clave").trim.toUpper() = TextBox2.Text.Trim.ToUpper() Then

                nombre = ds.Tables("Usuarios").Rows(0)("nombre").trim
                apellido = ds.Tables("Usuarios").Rows(0)("apellido").trim
                Dim cli As New Menu
                cli.ShowDialog()
            Else
                MsgBox("Contraseña incorrecta")
            End If

        Else

            MsgBox("Usuario no encontrado")

        End If

    End Sub
End Class