import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class Bat2 here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Bat2 extends Actor
{
    private int speed = 7;
    
    
    public void act() 
    {
        checkKey();
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
        if (Greenfoot.isKeyDown("w") )
        {
            moveUp();
        }
        if (Greenfoot.isKeyDown("s") )
        {
            moveDown();
        }
    }
}