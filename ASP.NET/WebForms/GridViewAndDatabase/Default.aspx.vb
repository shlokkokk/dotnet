Imports System.Data.SqlClient

Public Class [Default]
    Inherits System.Web.UI.Page

    Private ReadOnly cs = System.Configuration.ConfigurationManager.ConnectionStrings("Db").ConnectionString

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        EnsureDatabase()
        If Not IsPostBack Then BindGrid()
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
            Using cmd As New SqlCommand("IF OBJECT_ID('Feedback') IS NULL CREATE TABLE Feedback(Id INT IDENTITY PRIMARY KEY, Name NVARCHAR(100), Message NVARCHAR(500))", c)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub BindGrid()
        Dim t As New DataTable()
        Using c As New SqlConnection(cs)
            Using da As New SqlDataAdapter("SELECT Id, Name, Message FROM Feedback ORDER BY Id DESC", c)
                da.Fill(t)
            End Using
        End Using
        GridView1.DataSource = t
        GridView1.DataBind()
    End Sub

    Protected Sub btnSave_Click(sender As Object, e As EventArgs)
        Using c As New SqlConnection(cs)
            Using cmd As New SqlCommand("INSERT INTO Feedback(Name, Message) VALUES(@name,@message)", c)
                cmd.Parameters.AddWithValue("@name", txtName.Text)
                cmd.Parameters.AddWithValue("@message", txtMessage.Text)
                c.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        lblStatus.Text = " Saved"
        txtName.Text = ""
        txtMessage.Text = ""
        BindGrid()
    End Sub
End Class
