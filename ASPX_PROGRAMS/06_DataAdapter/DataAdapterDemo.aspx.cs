using System; using System.Data; using System.Data.SqlClient;
namespace PracticalPack { public partial class DataAdapterDemo:System.Web.UI.Page { private const string cs=@"Data Source=.;Initial Catalog=StudentDB;Integrated Security=True"; protected void Page_Load(object sender,EventArgs e){ using(var da=new SqlDataAdapter("SELECT Id,Name,Course FROM Students",cs)){ var table=new DataTable(); da.Fill(table); GridView1.DataSource=table; GridView1.DataBind(); } } } }
/* THEORY / VIVA NOTES
1. SqlDataAdapter is commonly used for disconnected data access.
2. It acts as a bridge between a database and DataTable/DataSet.
3. Fill() retrieves data and fills the in-memory structure.
4. After Fill(), the application can work with the DataTable without reading each row directly.
5. A common flow is SELECT -> DataAdapter -> DataTable -> GridView.
*/
