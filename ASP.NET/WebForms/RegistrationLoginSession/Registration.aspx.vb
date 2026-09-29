Imports System.Data.SqlClient

Public Class Registration
    Inherits System.Web.UI.Page

    Private ReadOnly cs = System.Configuration.ConfigurationManager.ConnectionStrings("Db").ConnectionString

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        EnsureDatabase()
    End Sub

    Private Sub EnsureDatabase()
        Using c As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True")
            c.Open()
            Using cmd As New SqlCommand("IF DB_ID('DotNetPractical') IS NULL CREATE DATABASE DotNetPractical", c)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        Using c As New SqlConnection(cs)
            c.Open()
            Using cmd As New SqlCommand("IF OBJECT_ID('Users') IS NULL CREATE TABLE Users(Id INT IDENTITY PRIMARY KEY, Username NVARCHAR(50) UNIQUE, Password NVARCHAR(100))", c)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Protected Sub btnRegister_Click(sender As Object, e As EventArgs)
        Try
            Using c As New SqlConnection(cs)
                Using cmd As New SqlCommand("INSERT INTO Users(Username,Password) VALUES(@u,@p)", c)
                    cmd.Parameters.AddWithValue("@u", txtUser.Text)
                    cmd.Parameters.AddWithValue("@p", txtPass.Text)
                    c.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            lbl.Text = " Registered. Go to Login."
        Catch
            lbl.Text = "Username already exists."
        End Try
    End Sub
End Class
