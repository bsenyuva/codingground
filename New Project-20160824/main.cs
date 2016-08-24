using System.IO;
using System;

class Program
{
    static void Main()
    {
//For Double Axe
        bool isRanged = false;
        double MlSpeed = 3.25;
        int WpSpeed = 30;

//Current code
        int max = ((int)MlSpeed * 2500) / (100 + WpSpeed);
        if (isRanged) max = max / 2;
        Console.WriteLine("Current leech value for " + MlSpeed + " ms and " + WpSpeed + " SSI is: " + max);
        
//Correct code
        max = (int)(MlSpeed * 2500 / (100 + WpSpeed));
        if (isRanged) max = max / 2;
        Console.WriteLine("Correct leech value for " + MlSpeed + " ms and " + WpSpeed + " SSI is: " + max);
    }
}
