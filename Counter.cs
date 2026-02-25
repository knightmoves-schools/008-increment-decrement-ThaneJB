namespace knightmoves;
public class Counter
{
    

    // Add your code here
    public static int PrefixIncrement;
    public static int PostfixIncrement;
    public static int PrefixDecrement;
    public static int PostfixDecrement;

    public void Count() {
        int Visitors = 100;

        PrefixIncrement("Visitors", ++Visitors);
        PostfixIncrement("Visitors",Visitors++);
        PrefixDecrement("Visitors",--Visitors);
        PostfixDecrement("Visitors", Visitors--);
    }
}
