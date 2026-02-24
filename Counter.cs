namespace knightmoves;
public class Counter
{
    public static int Visitors = 100;

    // Add your code here
    public static int PrefixIncrement;
    public static int PostfixIncrement;
    public static int PrefixDecrement;
    public static int PostfixDecrement;

    static Counter()
    {
        PrefixIncrement = ++Visitors;
        PostfixIncrement = Visitors++;
        PrefixDecrement = --Visitors;
        PostfixDecrement = Visitors--;

        Visitors = 100;
    }
}
