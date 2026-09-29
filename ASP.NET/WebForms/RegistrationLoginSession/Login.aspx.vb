Imports System.Data.SqlClient

Public Class Login
    Inherits System.Web.UI.Page

    Private ReadOnly cs = System.Configuration.ConfigurationManager.ConnectionStrings("Db").ConnectionString

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs)
        Using c As New SqlConnection(cs)
            Using cmd As New SqlCommand("SELECT COUNT(*) FROM Users WHERE Username=@u AND Password=@p", c)
                cmd.Parameters.AddWithValue("@u", txtUser.Text)
                cmd.Parameters.AddWithValue("@p", txtPass.Text)
                c.Open()

                If CInt(cmd.ExecuteScalar()) = 1 Then
                    Session("username") = txtUser.Text
                    Response.Redirect("Student.aspx")
                Else
                    lbl.Text = " Invalid login"
                End If
            End Using
        End Using
    End Sub
End Class
