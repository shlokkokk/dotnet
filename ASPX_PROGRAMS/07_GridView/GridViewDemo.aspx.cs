using System; using System.Data; using System.Data.SqlClient;
namespace PracticalPack { public partial class GridViewDemo:System.Web.UI.Page { private const string cs=@"Data Source=.;Initial Catalog=StudentDB;Integrated Security=True"; protected void Page_Load(object sender,EventArgs e){ if(!IsPostBack) LoadGrid(); } void LoadGrid(){ using(var da=new SqlDataAdapter("SELECT Id,Name,Course FROM Students",cs)){ var t=new DataTable(); da.Fill(t); GridView1.DataSource=t; GridView1.DataBind(); } } } }
/* THEORY / VIVA NOTES
1. GridView is an ASP.NET Web Forms control used to display tabular data.
2. DataSource specifies the object from which GridView gets its records.
3. DataBind() binds the assigned source and generates the displayed rows.
4. DataTable is a common in-memory data source for GridView.
5. Typical flow: SELECT -> DataAdapter -> DataTable -> DataSource -> DataBind().
*/
