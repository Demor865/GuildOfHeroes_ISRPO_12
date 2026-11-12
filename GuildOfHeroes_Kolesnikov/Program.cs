using System.Diagnostics;
//     >>> Герои <<<

//Probe.Run();

Console.WriteLine("\n    >>> Main <<<\n");

Guild guild = new Guild("Гильдия героев");
Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);
Hero sergey = new Hero("Сергей", 110);

guild.Heroes.Add(sergey);
guild.Heroes.Add(yaroslav);
guild.Heroes.Add(anastasia);
guild.Heroes.Add(artem);
guild.Heroes.Add(alexander);

Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.Heroes.Count}");

int strongCount = 0;

foreach (Hero hero in guild.Heroes) {
    if (hero.Health >= 120) {
        strongCount += 1;
    }
}

Hero strongest = guild.Heroes[0];

foreach (Hero hero in guild.Heroes) {
    if (hero.Health >= strongest.Health) {
        strongest = hero;
    }
}
Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {strongCount}");
Console.WriteLine($"Самый здоровый: [{strongest.Name}]");


//     >>> Оружия <<<
Console.WriteLine("\n    >>> Класс оружия <<<\n");

Arsenal arsenal = new Arsenal("Арсенал гильдии героев");

Weapon Sword = new Weapon("Эскалибур", 46, "Меч");
Weapon Bow = new Weapon("Охотничий лук", 5, "Лук");
Weapon Staff = new Weapon("Жезл молний", 34, "Посох");
Weapon LongSword = new Weapon("Дуболом", 26, "Двуручный меч");

arsenal.Weapons.Add(Sword);
arsenal.Weapons.Add(Bow);
arsenal.Weapons.Add(Staff);
arsenal.Weapons.Add(LongSword);

Console.WriteLine($"\n-------------------------");
Console.WriteLine($"ИМЯ - УРОН | ТИП | ПРОЧНОСТЬ");
foreach (Weapon weapon in arsenal.Weapons) {
    Console.WriteLine($"{weapon.Name} - {weapon.Damage} | {weapon.Type} | {weapon.Strength}");
}
Console.WriteLine($"-------------------------\n");


Console.WriteLine("\n>>> Проверка <<<\n");

Console.WriteLine($"Всего оружий - {arsenal.Weapons.Count}");

if (arsenal.Weapons.Count > 0) {
    Console.WriteLine($"Первое оружие - {arsenal.Weapons[0].Name}");
    Console.WriteLine($"Последнее оружие - {arsenal.Weapons[arsenal.Weapons.Count - 1].Name}");
}

foreach (Weapon weapon in arsenal.Weapons) {
    Console.WriteLine($"{weapon.GetInfo()}");
}

int count = 0; // Счетчик оружий с уроном >= 30

foreach (Weapon weapon in arsenal.Weapons) {
    if (weapon.Damage >= 30) {
        count += 1;
    }
}

Console.WriteLine($"Оружий с высоким уроном (>= 30) - {count}");

arsenal.Weapons[2].Strength_Damage(0.2);
Console.WriteLine("После изменения прочности:");
Console.WriteLine(arsenal.Weapons[2].GetInfo());