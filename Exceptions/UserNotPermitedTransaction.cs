namespace technical_challenge_of_picpay.Exceptions;

public class UserNotPermitedTransaction : Exception
{
    public UserNotPermitedTransaction(string message) :base(message)
    {
    }
}