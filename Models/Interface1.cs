using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

internal interface IDatabase
{
    void OpenConnection();
    void CloseConnection();
    SqlConnection GetConnection();
    void CheackMoney(Label labelUserMoney, int id);
    void CheackMoney_HKD(Label labelUserMoney, int id);
    void CheackMoney_credit(Label labelUserMoney, int id);
    void CheackMoney_deposit(Label labelUserMoney, int id);
    Task ApiValute(Label value_dollar);

}