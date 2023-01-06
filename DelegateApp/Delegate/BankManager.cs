namespace Banking;
using System.Collections.Generic;


public delegate void BankOperation(double amount,Account acct);
public class BankManager
{
    List<Account> BlockList = new List<Account>();
    public void BlockAccount(double amount,Account? acct)
    {
        Account act = acct;
       BlockList.Add(act);
    }

    public void MessageAccount(double amount,Account? acct)
    {
        Console.WriteLine("Your account has been blocked through Message "+acct.actno);
    }

    public void EmailAccount(double amount,Account? acct)
    {
        Console.WriteLine("Your account has been blocked through Email "+acct.actno);
    }

    public void ShowBlockedAccount()
    {
        foreach (var list in BlockList)
        {
            Console.WriteLine(list);   
        }
    }
}