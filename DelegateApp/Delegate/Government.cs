namespace EGov;

public delegate void TaxOperation(double amount);

public class Government
{
    public void DeductIncomeTax(double amount)
    {
        Console.WriteLine("30% income tax deducted from your account");
    }

     public void DeductProfessionalTax(double amount)
    {
        Console.WriteLine("10% professional tax deducted from your account");
    }

     public void DeductServiceTax(double amount)
    {
        Console.WriteLine("18% service tax deducted from your account");
    }
}