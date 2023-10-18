
class Program
{
    static void Main(string[] args)
    {
        Buffet ChileanBuffet = new Buffet();
        Ninja Flavio = new Ninja();
        while (Flavio.IsFull == false)
        {
            Flavio.Eat(ChileanBuffet.Serve());
        }
        Console.WriteLine($"Peligro: el consumo de calorías es de {Flavio.caloriasCount}. ¡El ninja está lleno y no puede comer más!");
    }
}


class Food
{
    public string Name;
    public int Calories;
    public bool IsSpicy;
    public bool IsSweet;


    public Food(string name, int calories, bool isspicy, bool issweet)
    {
        Name = name;
        Calories = calories;
        IsSpicy = isspicy;
        IsSweet = issweet;
    }

}

class Buffet
{
    public List<Food> Menu;

    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Pizza Napolitana",500, false, false),
            new Food("Completo", 600, false, false),
            new Food("Hamburguesa", 250, false, false),
            new Food("Pollo Asado", 800, false, false),
            new Food("Helado de chocolate", 500, false, false),
            new Food("Lasagna", 135, false, false),
            new Food("Spaghetti", 651, false, false),
        };
    }
    Random RandomIndex = new Random();
    public Food Serve()
    {
        return Menu[RandomIndex.Next(Menu.Count)];
    }
}



class Ninja
{
    private int calorieIntake;
    public int caloriasCount
    {
        get
        {
            return calorieIntake;
        }
    }

    public List<Food> FoodHistory;


    // add a constructor
    public Ninja()
    {
        calorieIntake = 0;
        FoodHistory = new List<Food>() { };
    }
    // add a public "getter" property called "IsFull"
    public bool IsFull
    {
        get
        {
            bool full = false;
            if (calorieIntake > 1200)
            {
                full = true;
            }
            return full;
        }
    }
    // build out the Eat method
    public void Eat(Food item)
    {

        calorieIntake += item.Calories;
        FoodHistory.Add(item);
        Console.WriteLine($"Nombre Comida : {item.Name} Es picante : {item.IsSpicy} Es Dulce : {item.IsSweet}");

    }
}