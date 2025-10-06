namespace Prototype;

public class Handler {
    public static void Handle() {
        CharacterFactory characterFactory = new CharacterFactory();
        Character hero = characterFactory.CreateCharacter("Archer", 5, "Ranger");
        Console.WriteLine(hero);
        Character villain = characterFactory.CreateCharacter("Goblin", 3, "Warrior");
        Console.WriteLine(villain);
    }
}