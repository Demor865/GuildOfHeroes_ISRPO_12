public class Arsenal  {
    public string Name { get; private set; }
    public List<Weapon> Weapons { get; private set; } = new List<Weapon>();

    public Arsenal (string name) {
        Name = name;
    }
}