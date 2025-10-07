namespace Prototype;

// THEORY: allows creation of new objects by cloning existing prototypes

public class Character: ICloneable {
    public string Name { get; set; }
    public int Level { get; set; }
    public string Class { get; set; }

    public Character(string name, int level, string charClass) {
        Name = name;
        Level = level;
        Class = charClass;
    }

    public override string ToString() {
        return $"Name: {Name}, Level: {Level}, Class: {Class}";
    }

    public object Clone() {
        return MemberwiseClone();
    }
}

public class CharacterFactory {
    private Character prototype;
    public CharacterFactory() {
        this.prototype = new Character("Hero", 1, "Warrior");
    }

    public Character CreateCharacter(string name, int level, string charClass) {
        Character newCharacter = (Character)prototype.Clone();
        newCharacter.Name = name;
        newCharacter.Level = level;
        newCharacter.Class = charClass;
        return newCharacter;
    }
}