public class Shape  
{
    
    public String controlUp;
    public String controlDown;
    public Shape(){}
    public Shape(Shape target)
    {
            if(target != null){
                this.controlUp = target.controlUp;
                this.controlDown = target.controlDown;
            }
            
    }
    
}