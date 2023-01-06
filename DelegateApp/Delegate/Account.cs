namespace Banking;
using EGov;

public class Account
{
    public event TaxOperation overBalance; 
    public event BankOperation underBalance;
    public double balance{get;set;}
    public int actno{get;set;}

    public Account(double balance,int actno)
    {
        this.balance = balance;
        this.actno = actno;
    }

    public void Deposit(double amount)
    {
        this.balance+=amount;
    }

    public void Withdraw(double amount)
    {
        this.balance-=amount;
    }

    public override string ToString()
    {
        return "Account No : "+this.actno+" "+"Current Balance : "+this.balance;
    }

    public void ProcessTax()
    {
        if (this.balance >= 250000)
        {
            overBalance(this.balance);
        }
    }

    public void ProcessBalance()
    {
        if (this.balance < 5000)
        {
            underBalance(this.balance,this);
        }
    }

}