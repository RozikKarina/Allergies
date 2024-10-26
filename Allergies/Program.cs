using System;
using System.Collections.Generic;
using System.Linq;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private readonly int score;

    public Allergies(int score)
    {
        this.score = score;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return (score & (int)allergen) != 0;
    }

    public List<Allergen> List()
    {
        var allergies = Enum.GetValues(typeof(Allergen)).Cast<Allergen>();
        return allergies.Where(IsAllergicTo).ToList();
    }
}