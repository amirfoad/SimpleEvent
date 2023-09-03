namespace SimpleEvent;

public static class CatHelperMethods
{
    public static void CatIsDead(object sender,int health)
    {
        var cat = (Cat)sender;
        if (health<= 0)
        {
            Console.WriteLine($"{cat.Name} is no longer alive😫");
        }
        
    }
    
    public static void CatOnHealthChanged(object sender,int health)
    {
        var cat = (Cat)sender;
        Console.WriteLine($"{cat.Name} has new health:  {health}");
    }
}