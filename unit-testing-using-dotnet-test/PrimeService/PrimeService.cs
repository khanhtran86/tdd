using System;
namespace PrimeService;

public class PrimeService
{
    public bool IsPrime(int candidate)
    {
        //throw new NotImplementedException("Not implemented");
        if(candidate<=2)
        {
            return false;
        }
        return true;
    }
}
