namespace knightmoves;
public class Counter
{
    public static int Visitors = 100;

    // Add your code here
    PrefixIncrement(++visitors);
    PostfixIncrement(visitors++);
    PrefixDecrement(--visitors);
    PostfixDecrement(visitors--);
}
