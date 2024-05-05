using System.Windows.Forms;
internal interface IMoneyOperations 
{
    void CheackMoney(Label labelUserMoney, int id);
    void CheackMoney_HKD(Label labelUserMoney, int id);
    void CheackMoney_credit(Label labelUserMoney, int id);
    void CheackMoney_deposit(Label labelUserMoney, int id);
}

