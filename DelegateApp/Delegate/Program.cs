using Banking;
using EGov;

Government govt = new Government();
BankManager bnk = new BankManager();

TaxOperation itoperation = new TaxOperation(govt.DeductIncomeTax);
TaxOperation prooperation = new TaxOperation(govt.DeductProfessionalTax);
TaxOperation servoperation = new TaxOperation(govt.DeductServiceTax);
BankOperation blockoperation = new BankOperation(bnk.BlockAccount);
BankOperation Messageoperation = new BankOperation(bnk.MessageAccount);
BankOperation Emailoperation = new BankOperation(bnk.EmailAccount);


TaxOperation generaloperation = null;
generaloperation=itoperation;
generaloperation+=prooperation;
generaloperation+=servoperation;

BankOperation generaloperation1 = null;
generaloperation1+=blockoperation;
generaloperation1+=Messageoperation;
generaloperation1+=Emailoperation;

Account act = new Account(50000,103);
act.overBalance+=generaloperation;

/* Console.WriteLine("Enter the Deposit amount : ");
act.Deposit(double.Parse(Console.ReadLine()));

Console.WriteLine("Enter the Withdraw amount : ");
act.Withdraw(double.Parse(Console.ReadLine())); */
 
act.ProcessTax();

Account act1 = new Account(4000,101);
act1.underBalance+=generaloperation1;

act1.ProcessBalance();

Account act2 = new Account(4500,102);
act2.underBalance+=generaloperation1;
act2.ProcessBalance();
bnk.ShowBlockedAccount();