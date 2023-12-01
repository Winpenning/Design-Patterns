    import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)
public class Bat1 extends Actor
{
    private int speed = 7;
    public Shape shape;
    public String controlUp;
    public String controlDown;
    
    public void act() 
    {
        checkKey();// puxa o método de controle
    }    
    
    
    public void moveUp()
    {
        setLocation( getX() , getY() - speed);
    }
    
    public void moveDown()
    {
        setLocation( getX() , getY() + speed);
    }
    
    public void checkKey()
    {
        if (Greenfoot.isKeyDown("up") )
        {
            moveUp(); // método de definição de posição
        }
        if (Greenfoot.isKeyDown("down") )
        {
            moveDown(); // método de definição de posição
        }
    }
}
