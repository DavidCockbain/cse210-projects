using System;


public class Fraction
{
private int topnum;
private int botnum;

    public Fraction()
    {
        topnum = 1;
        botnum = 1;

    }

    public Fraction(int wholenum)
    {
        topnum = wholenum;
        botnum = 1;

    }

    
     public Fraction(int top, int bot)
     {
         topnum = top;
         botnum = bot;

     }
     
    public string GetFractionString()
    {
        string text = ($"{topnum}/{botnum}");
        return text;
    }

    public double GetDecimalValue()
    {
        return(double) topnum / (double) botnum;
    }


}