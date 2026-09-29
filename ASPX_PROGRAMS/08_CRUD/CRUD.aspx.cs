using System; using System.Data; using System.Data.SqlClient;
namespace PracticalPack { public partial class CRUD:System.Web.UI.Page { private const string cs=@"Data Source=.;Initial Catalog=StudentDB;Integrated Security=True"; protected void Page_Load(object sender,EventArgs e){ if(!IsPostBack) LoadData(); }
protected void btnInsert_Click(object s,EventArgs e){ Execute("INSERT INTO Students(Id,Name,Course) VALUES(@Id,@Name,@Course)"); LoadData(); }
protected void btnUpdate_Click(object s,EventArgs e){ Execute("UPDATE Students SET Name=@Name,Course=@Course WHERE Id=@Id"); LoadData(); }
protected void btnDelete_Click(object s,EventArgs e){ using(var con=new SqlConnection(cs)) using(var cmd=new SqlCommand("DELETE FROM Students WHERE Id=@Id",con)){ cmd.Parameters.AddWithValue("@Id",txtId.Text); con.Open(); cmd.ExecuteNonQuery(); } lblMessage.Text="Deleted."; LoadData(); }
protected void btnLoad_Click(object s,EventArgs e){ LoadData(); }
void Execute(string sql){ using(var con=new SqlConnection(cs)) using(var cmd=new SqlCommand(sql,con)){ cmd.Parameters.AddWithValue("@Id",txtId.Text); cmd.Parameters.AddWithValue("@Name",txtName.Text); cmd.Parameters.AddWithValue("@Course",txtCourse.Text); con.Open(); cmd.ExecuteNonQuery(); } lblMessage.Text="Operation completed."; }
void LoadData(){ using(var da=new SqlDataAdapter("SELECT Id,Name,Course FROM Students",cs)){ var t=new DataTable(); da.Fill(t); GridView1.DataSource=t; GridView1.DataBind(); } }
} }
/* THEORY / VIVA NOTES
1. CRUD means Create, Read, Update and Delete.
2. In SQL these correspond to INSERT, SELECT, UPDATE and DELETE.
3. SqlConnection represents the SQL Server connection.
4. SqlCommand represents the SQL statement being executed.
5. Parameters such as @Id and @Name keep user values separate from the SQL command text.
6. ExecuteNonQuery() is used for INSERT, UPDATE and DELETE.
7. SELECT data can be filled into a DataTable through SqlDataAdapter.
8. The DataTable can be assigned to GridView.DataSource and displayed using DataBind().
9. A CRUD page combines Web Form controls, ADO.NET, SQL and GridView binding.
*/
