using System.ComponentModel.Design.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
       
        

    }
}

public class Enemy01 
{
    private string myColor01  = "Black";

    protected int attack01 = 0;

    protected int health01 = 100;

    public Enemy01(int attack01 , int health01)
    {
       this.attack01 = attack01;
       this.health01 = health01;
    }

    public virtual void SetColor01()
    {
        myColor01 = " Blue ";
    }
}

public class Mosigan01 
{

}

