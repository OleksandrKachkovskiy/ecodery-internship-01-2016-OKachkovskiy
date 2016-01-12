//На жаль, для вирішення цієї задачі я звернувся по допомогу :(


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        string MESSAGE = Console.ReadLine();

        Console.Error.WriteLine(MESSAGE); 

        Console.WriteLine(CNEncode(MESSAGE));
    }

    public static string CNEncode(string m)
    {
        string bits = StringToBits(m);

        return BitsToPreCN(bits);
    }

    public static string StringToBits(string m)
    {
        string bits = null;
        
        byte[] bytes = Encoding.ASCII.GetBytes(m);        

        foreach(byte b in bytes) {
            bits += Convert.ToString(b,2).PadLeft(7,'0'); 
        }

        return bits;
    }

    public static string BitsToPreCN(string bits)
    {
        string tes = null;
        
        int oc = 0;
        for(int i = 0; i < bits.Length-1; i++) {
            if(bits[i] != bits[i+1]) {           
                tes += BitNum(bits[i]);          
                tes += "".PadRight(i+1-oc, '0'); 
                tes += " ";                      
                oc = i+1; 
            }
        }
        if(bits.Length-oc != bits.Length) { 
            tes += BitNum(bits[bits.Length-1]);
            tes += "".PadRight(bits.Length-oc, '0');
        }
        
        return tes;
    }

    public static string BitNum(char c)
    {
        return (c == '0' ? "00 " : "0 "); 
    }
}
