using System.Text.RegularExpressions;
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
        else
        {
            bool result = true;
            for(int i=2; i<=candidate/2; i++)
            {
                if(candidate%2==0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        
    }
}
