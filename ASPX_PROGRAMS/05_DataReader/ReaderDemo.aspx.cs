using System; using System.Data.SqlClient;
namespace PracticalPack { public partial class ReaderDemo:System.Web.UI.Page { private const string cs=@"Data Source=.;Initial Catalog=StudentDB;Integrated Security=True"; protected void Page_Load(object sender,EventArgs e){ using(var con=new SqlConnection(cs)) using(var cmd=new SqlCommand("SELECT Id,Name,Course FROM Students",con)){ con.Open(); using(var r=cmd.ExecuteReader()){ while(r.Read()) lblResult.Text += r["Id"]+" - "+r["Name"]+" - "+r["Course"]+"<br/>"; } } } } }
/* THEORY / VIVA NOTES
1. SqlDataReader belongs to connected ADO.NET data access.
2. It is forward-only and read-only and normally requires the connection to remain open.
3. ExecuteReader() executes a command that returns rows.
4. Read() moves to the next available record and returns true while a record exists.
5. It is efficient when records only need to be read sequentially.
*/
