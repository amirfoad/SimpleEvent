using System.ComponentModel.Design;

namespace SimpleEvent;

public record Cat

{
    public Cat(int id,
        string name,
        int health)
    {
        Id = id;
        Name = name;
        Health = health;
    }
    private int _health;
    public int Id { get; set; }
    public string Name { get; set; }
    public int Health
    {
        get => _health;
        set
        {
            _health = value;
            OnHealthChanged?.Invoke(this,_health);
        }
    }
    public event EventHandler<int> OnHealthChanged;
}