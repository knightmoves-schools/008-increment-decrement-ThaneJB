namespace knightmoves;
public class Counter
{
    public static int Visitors = 100;

    // Add your code here
    public static int PrefixIncrement = (++Visitors);
    public static int PostfixIncrement = (Visitors++);
    public static int PrefixDecrement = (--Visitors);
    public static int PostfixDecrement = (Visitors--);

}
