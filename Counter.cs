namespace knightmoves;
public class Counter
{
    public static int Visitors = 100;

    // Add your code here
    public static int PrefixIncrement;
    public static int PostfixIncrement;
    public static int PrefixDecrement;
    public static int PostfixDecrement;

    public void Count()
    {
        PrefixIncrement("Visitors", ++Visitors);
        PostfixIncrement("Visitors",Visitors++);
        PrefixDecrement("Visitors",--Visitors);
        PostfixDecrement("Visitors", Visitors--);
    }
}
