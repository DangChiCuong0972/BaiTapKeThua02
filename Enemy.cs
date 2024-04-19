public class Enemy
{
    private string myColor = "White";
    protected int attack = 0;

    protected int health = 100;
    
    
    public Enemy(int attack , int health)
    {
        this.attack = attack;
        this.health = health;
    }
    

    public virtual void SetColor()
    {
        myColor = "Red";
    }
}


