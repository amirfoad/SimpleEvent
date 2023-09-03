// See https://aka.ms/new-console-template for more information

using SimpleEvent;

Cat cat = new(1, "meow", 100);

cat.OnHealthChanged += CatHelperMethods.CatOnHealthChanged;
cat.OnHealthChanged += CatHelperMethods.CatIsDead;
cat.Health = 200;

for (int i = 0; i < 10; i++)
{
    cat.Health -= 20;
}