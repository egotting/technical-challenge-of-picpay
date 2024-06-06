namespace technical_challenge_of_picpay.Exceptions;

public class DontHaveBalance : Exception
{
    public DontHaveBalance( string message) : base(message)
    {
    }
}