// Fraction.cs
public class Fraction
{
    private int numerator;
    private int denominator;

    // Constructor with no parameters
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor with one parameter
    public Fraction(int numerator)
    {
        this.numerator = numerator;
        denominator = 1;
    }

    // Constructor with two parameters
    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        this.denominator = denominator;
    }

    // Getters and Setters
    public int Numerator 
    { 
        get { return numerator; } 
        set { numerator = value; } 
    }

    public int Denominator 
    { 
        get { return denominator; } 
        set 
        {
            if (value == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            denominator = value; 
        } 
    }

    // Method to return fraction string
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Method to return decimal value
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}