namespace GhostTracker.GhostManager;

public static class GhostCache
{
    public static Ghost[] Ghosts { get; } =
    [
        new Ghost
        {
            Id = 1, Name = "Slimer", Type = "Ectoplasmic", Age = 50, DateOfDead = new DateTime(1975, 6, 20),
            HauntLocation = "Sedgewick Hotel", Appearance = "Green blob with a big appetite", DangerLevel = 3,
            Abilities = "Eating, Making mess"
        },
        new Ghost
        {
            Id = 2, Name = "Lady in White", Type = "Spectral", Age = 100, DateOfDead = new DateTime(1925, 10, 31),
            HauntLocation = "Shandor Library", Appearance = "Pale woman in white dress", DangerLevel = 4,
            Abilities = "Invisibility, Wailing"
        },
        new Ghost
        {
            Id = 3, Name = "Marshmallow Man", Type = "Manifestation", Age = 35, DateOfDead = new DateTime(1990, 5, 5),
            HauntLocation = "Downtown", Appearance = "Giant marshmallow", DangerLevel = 5,
            Abilities = "Size alteration, Resilience"
        },
        new Ghost
        {
            Id = 4, Name = "Screaming Specter", Type = "Banshee", Age = 250, DateOfDead = new DateTime(1775, 11, 2),
            HauntLocation = "Old Cemetery", Appearance = "Hooded figure", DangerLevel = 4,
            Abilities = "Screaming, Summoning smaller spirits"
        },
        new Ghost
        {
            Id = 5, Name = "Phantom of the Opera", Type = "Wraith", Age = 150, DateOfDead = new DateTime(1875, 3, 14),
            HauntLocation = "Abandoned Theater", Appearance = "Masked figure", DangerLevel = 4,
            Abilities = "Illusions, Music manipulation"
        },
        new Ghost
        {
            Id = 6, Name = "Poltergeist Phil", Type = "Poltergeist", Age = 60, DateOfDead = new DateTime(1965, 7, 20),
            HauntLocation = "Suburban House", Appearance = "Invisible force", DangerLevel = 3,
            Abilities = "Moving objects, Causing disturbances"
        },
        new Ghost
        {
            Id = 7, Name = "Vaporous Vlad", Type = "Ethereal", Age = 400, DateOfDead = new DateTime(1625, 8, 15),
            HauntLocation = "Ancient Ruins", Appearance = "Mist-like form", DangerLevel = 5,
            Abilities = "Teleportation, Phasing"
        },
        new Ghost
        {
            Id = 8, Name = "Haunting Harriet", Type = "Revenant", Age = 200, DateOfDead = new DateTime(1825, 11, 10),
            HauntLocation = "Deserted Mansion", Appearance = "Victorian woman", DangerLevel = 4,
            Abilities = "Possession, Shadow manipulation"
        },
        new Ghost
        {
            Id = 9, Name = "Wail of Woe", Type = "Phantom", Age = 300, DateOfDead = new DateTime(1725, 2, 28),
            HauntLocation = "Seaside Tavern", Appearance = "Seafaring ghost", DangerLevel = 4,
            Abilities = "Weather control, Crying"
        },
        new Ghost
        {
            Id = 10, Name = "Spectral Steve", Type = "Apparition", Age = 75, DateOfDead = new DateTime(1945, 4, 22),
            HauntLocation = "War Memorial", Appearance = "Soldier’s ghost", DangerLevel = 3,
            Abilities = "Creating illusions, Camouflage"
        },
        new Ghost
        {
            Id = 11, Name = "Ghastly George", Type = "Poltergeist", Age = 80, DateOfDead = new DateTime(1945, 12, 25),
            HauntLocation = "Old Manor", Appearance = "Invisible force", DangerLevel = 3,
            Abilities = "Moving objects, Causing disturbances"
        },
        new Ghost
        {
            Id = 12, Name = "Wailing Wanda", Type = "Banshee", Age = 300, DateOfDead = new DateTime(1725, 3, 15),
            HauntLocation = "Haunted Forest", Appearance = "Hooded figure", DangerLevel = 4,
            Abilities = "Screaming, Summoning smaller spirits"
        },
        new Ghost
        {
            Id = 13, Name = "Phantom Phil", Type = "Wraith", Age = 120, DateOfDead = new DateTime(1905, 7, 10),
            HauntLocation = "Abandoned Factory", Appearance = "Masked figure", DangerLevel = 4,
            Abilities = "Illusions, Music manipulation"
        },
        new Ghost
        {
            Id = 14, Name = "Spectral Sally", Type = "Apparition", Age = 90, DateOfDead = new DateTime(1935, 8, 22),
            HauntLocation = "Old School", Appearance = "Ghostly child", DangerLevel = 2,
            Abilities = "Creating illusions, Camouflage"
        },
        new Ghost
        {
            Id = 15, Name = "Eerie Eric", Type = "Ethereal", Age = 500, DateOfDead = new DateTime(1525, 9, 30),
            HauntLocation = "Ancient Castle", Appearance = "Mist-like form", DangerLevel = 5,
            Abilities = "Teleportation, Phasing"
        },
        new Ghost
        {
            Id = 16, Name = "Haunting Hannah", Type = "Revenant", Age = 250, DateOfDead = new DateTime(1775, 11, 5),
            HauntLocation = "Deserted Mansion", Appearance = "Victorian woman", DangerLevel = 4,
            Abilities = "Possession, Shadow manipulation"
        },
        new Ghost
        {
            Id = 17, Name = "Vengeful Victor", Type = "Spectral", Age = 150, DateOfDead = new DateTime(1875, 10, 31),
            HauntLocation = "Old Church", Appearance = "Pale man in black suit", DangerLevel = 4,
            Abilities = "Invisibility, Wailing"
        },
        new Ghost
        {
            Id = 18, Name = "Creepy Carl", Type = "Manifestation", Age = 60, DateOfDead = new DateTime(1965, 5, 5),
            HauntLocation = "Downtown", Appearance = "Giant shadow", DangerLevel = 5,
            Abilities = "Size alteration, Resilience"
        },
        new Ghost
        {
            Id = 19, Name = "Spooky Susan", Type = "Ectoplasmic", Age = 70, DateOfDead = new DateTime(1955, 6, 20),
            HauntLocation = "Old Hotel", Appearance = "Green blob", DangerLevel = 3, Abilities = "Eating, Making mess"
        },
        new Ghost
        {
            Id = 20, Name = "Terrifying Tom", Type = "Poltergeist", Age = 90, DateOfDead = new DateTime(1935, 7, 20),
            HauntLocation = "Suburban House", Appearance = "Invisible force", DangerLevel = 3,
            Abilities = "Moving objects, Causing disturbances"
        },
        new Ghost
        {
            Id = 21, Name = "Gloomy Greg", Type = "Spectral", Age = 110, DateOfDead = new DateTime(1915, 4, 10),
            HauntLocation = "Old Barn", Appearance = "Pale farmer", DangerLevel = 3, Abilities = "Invisibility, Wailing"
        },
        new Ghost
        {
            Id = 22, Name = "Frightening Fiona", Type = "Banshee", Age = 320, DateOfDead = new DateTime(1705, 12, 1),
            HauntLocation = "Haunted Lake", Appearance = "Hooded figure", DangerLevel = 4,
            Abilities = "Screaming, Summoning smaller spirits"
        },
        new Ghost
        {
            Id = 23, Name = "Phantom Fred", Type = "Wraith", Age = 140, DateOfDead = new DateTime(1885, 6, 14),
            HauntLocation = "Abandoned Warehouse", Appearance = "Masked figure", DangerLevel = 4,
            Abilities = "Illusions, Music manipulation"
        },
        new Ghost
        {
            Id = 24, Name = "Spectral Sam", Type = "Apparition", Age = 85, DateOfDead = new DateTime(1940, 9, 22),
            HauntLocation = "Old Hospital", Appearance = "Ghostly doctor", DangerLevel = 3,
            Abilities = "Creating illusions, Camouflage"
        },
        new Ghost
        {
            Id = 25, Name = "Eerie Emma", Type = "Ethereal", Age = 450, DateOfDead = new DateTime(1575, 11, 30),
            HauntLocation = "Ancient Temple", Appearance = "Mist-like form", DangerLevel = 5,
            Abilities = "Teleportation, Phasing"
        },
        new Ghost
        {
            Id = 26, Name = "Haunting Harry", Type = "Revenant", Age = 220, DateOfDead = new DateTime(1805, 10, 5),
            HauntLocation = "Deserted Mansion", Appearance = "Victorian gentleman", DangerLevel = 4,
            Abilities = "Possession, Shadow manipulation"
        },
        new Ghost
        {
            Id = 27, Name = "Vengeful Vanessa", Type = "Spectral", Age = 160, DateOfDead = new DateTime(1865, 8, 31),
            HauntLocation = "Old Church", Appearance = "Pale woman in black dress", DangerLevel = 4,
            Abilities = "Invisibility, Wailing"
        },
        new Ghost
        {
            Id = 28, Name = "Creepy Clara", Type = "Manifestation", Age = 70, DateOfDead = new DateTime(1955, 4, 5),
            HauntLocation = "Downtown", Appearance = "Giant shadow", DangerLevel = 5,
            Abilities = "Size alteration, Resilience"
        },
        new Ghost
        {
            Id = 29, Name = "Spooky Steve", Type = "Ectoplasmic", Age = 65, DateOfDead = new DateTime(1960, 7, 20),
            HauntLocation = "Old Hotel", Appearance = "Green blob", DangerLevel = 3, Abilities = "Eating, Making mess"
        },
        new Ghost
        {
            Id = 30, Name = "Terrifying Tina", Type = "Poltergeist", Age = 95, DateOfDead = new DateTime(1930, 6, 20),
            HauntLocation = "Suburban House", Appearance = "Invisible force", DangerLevel = 3,
            Abilities = "Moving objects, Causing disturbances"
        },
        new Ghost
        {
            Id = 31, Name = "Ghastly Gary", Type = "Poltergeist", Age = 85, DateOfDead = new DateTime(1940, 12, 25),
            HauntLocation = "Old Manor", Appearance = "Invisible force", DangerLevel = 3,
            Abilities = "Moving objects, Causing disturbances"
        },
        new Ghost
        {
            Id = 32, Name = "Wailing Wendy", Type = "Banshee", Age = 310, DateOfDead = new DateTime(1715, 3, 15),
            HauntLocation = "Haunted Forest", Appearance = "Hooded figure", DangerLevel = 4,
            Abilities = "Screaming, Summoning smaller spirits"
        },
        new Ghost
        {
            Id = 33, Name = "Phantom Pete", Type = "Wraith", Age = 130, DateOfDead = new DateTime(1895, 7, 10),
            HauntLocation = "Abandoned Factory", Appearance = "Masked figure", DangerLevel = 4,
            Abilities = "Illusions, Music manipulation"
        },
        new Ghost
        {
            Id = 34, Name = "Spectral Sarah", Type = "Apparition", Age = 95, DateOfDead = new DateTime(1930, 8, 22),
            HauntLocation = "Old School", Appearance = "Ghostly child", DangerLevel = 2,
            Abilities = "Creating illusions, Camouflage"
        },
        new Ghost
        {
            Id = 35, Name = "Eerie Edward", Type = "Ethereal", Age = 510, DateOfDead = new DateTime(1515, 9, 30),
            HauntLocation = "Ancient Castle", Appearance = "Mist-like form", DangerLevel = 5,
            Abilities = "Teleportation, Phasing"
        },
        new Ghost
        {
            Id = 36, Name = "Haunting Helen", Type = "Revenant", Age = 260, DateOfDead = new DateTime(1765, 11, 5),
            HauntLocation = "Deserted Mansion", Appearance = "Victorian woman", DangerLevel = 4,
            Abilities = "Possession, Shadow manipulation"
        },
        new Ghost
        {
            Id = 37, Name = "Vengeful Victor", Type = "Spectral", Age = 150, DateOfDead = new DateTime(1875, 10, 31),
            HauntLocation = "Old Church", Appearance = "Pale man in black suit", DangerLevel = 4,
            Abilities = "Invisibility, Wailing"
        },
        new Ghost
        {
            Id = 38, Name = "Creepy Carl", Type = "Manifestation", Age = 60, DateOfDead = new DateTime(1965, 5, 5),
            HauntLocation = "Downtown", Appearance = "Giant shadow", DangerLevel = 5,
            Abilities = "Size alteration, Resilience"
        },
        new Ghost
        {
            Id = 39, Name = "Spooky Susan", Type = "Ectoplasmic", Age = 70, DateOfDead = new DateTime(1955, 6, 20),
            HauntLocation = "Old Hotel", Appearance = "Green blob", DangerLevel = 3, Abilities = "Eating, Making mess"
        },
        new Ghost
        {
            Id = 40, Name = "Terrifying Tom", Type = "Poltergeist", Age = 90, DateOfDead = new DateTime(1935, 7, 20),
            HauntLocation = "Suburban House", Appearance = "Invisible force", DangerLevel = 3,
            Abilities = "Moving objects, Causing disturbances"
        },
        new Ghost
        {
            Id = 41, Name = "Ghastly George", Type = "Poltergeist", Age = 80, DateOfDead = new DateTime(1945, 12, 25),
            HauntLocation = "Old Manor", Appearance = "Invisible force", DangerLevel = 3,
            Abilities = "Moving objects, Causing disturbances"
        },
        new Ghost
        {
            Id = 42, Name = "Wailing Wanda", Type = "Banshee", Age = 300, DateOfDead = new DateTime(1725, 3, 15),
            HauntLocation = "Haunted Forest", Appearance = "Hooded figure", DangerLevel = 4,
            Abilities = "Screaming, Summoning smaller spirits"
        },
        new Ghost
        {
            Id = 43, Name = "Phantom Phil", Type = "Wraith", Age = 120, DateOfDead = new DateTime(1905, 7, 10),
            HauntLocation = "Abandoned Factory", Appearance = "Masked figure", DangerLevel = 4,
            Abilities = "Illusions, Music manipulation"
        },
        new Ghost
        {
            Id = 44, Name = "Spectral Sally", Type = "Apparition", Age = 90, DateOfDead = new DateTime(1935, 8, 22),
            HauntLocation = "Old School", Appearance = "Ghostly child", DangerLevel = 2,
            Abilities = "Creating illusions, Camouflage"
        },
        new Ghost
        {
            Id = 45, Name = "Eerie Eric", Type = "Ethereal", Age = 500, DateOfDead = new DateTime(1525, 9, 30),
            HauntLocation = "Ancient Castle", Appearance = "Mist-like form", DangerLevel = 5,
            Abilities = "Teleportation, Phasing"
        },
        new Ghost
        {
            Id = 46, Name = "Haunting Hannah", Type = "Revenant", Age = 250, DateOfDead = new DateTime(1775, 11, 5),
            HauntLocation = "Deserted Mansion", Appearance = "Victorian woman", DangerLevel = 4,
            Abilities = "Possession, Shadow manipulation"
        },
        new Ghost
        {
            Id = 47, Name = "Vengeful Victor", Type = "Spectral", Age = 150, DateOfDead = new DateTime(1875, 10, 31),
            HauntLocation = "Old Church", Appearance = "Pale man in black suit", DangerLevel = 4,
            Abilities = "Invisibility, Wailing"
        },
        new Ghost
        {
            Id = 48, Name = "Creepy Carl", Type = "Manifestation", Age = 60, DateOfDead = new DateTime(1965, 5, 5),
            HauntLocation = "Downtown", Appearance = "Giant shadow", DangerLevel = 5,
            Abilities = "Size alteration, Resilience"
        },
        new Ghost
        {
            Id = 49, Name = "Spooky Susan", Type = "Ectoplasmic", Age = 70, DateOfDead = new DateTime(1955, 6, 20),
            HauntLocation = "Old Hotel", Appearance = "Green blob", DangerLevel = 3, Abilities = "Eating, Making mess"
        },
        new Ghost
        {
            Id = 50, Name = "Terrifying Tom", Type = "Poltergeist", Age = 90, DateOfDead = new DateTime(1935, 7, 20),
            HauntLocation = "Suburban House", Appearance = "Invisible force", DangerLevel = 3,
            Abilities = "Moving objects, Causing disturbances"
        },
        new Ghost
        {
            Id = 51, Name = "Ghastly Gary", Type = "Poltergeist", Age = 85, DateOfDead = new DateTime(1940, 12, 25),
            HauntLocation = "Old Manor", Appearance = "Invisible force", DangerLevel = 3,
            Abilities = "Moving objects, Causing disturbances"
        },
        new Ghost
        {
            Id = 52, Name = "Wailing Wendy", Type = "Banshee", Age = 310, DateOfDead = new DateTime(1715, 3, 15),
            HauntLocation = "Haunted Forest", Appearance = "Hooded figure", DangerLevel = 4,
            Abilities = "Screaming, Summoning smaller spirits"
        },
        new Ghost
        {
            Id = 53, Name = "Phantom Pete", Type = "Wraith", Age = 130, DateOfDead = new DateTime(1895, 7, 10),
            HauntLocation = "Abandoned Factory", Appearance = "Masked figure", DangerLevel = 4,
            Abilities = "Illusions, Music manipulation"
        },
        new Ghost
        {
            Id = 54, Name = "Spectral Sarah", Type = "Apparition", Age = 95, DateOfDead = new DateTime(1930, 8, 22),
            HauntLocation = "Old School", Appearance = "Ghostly child", DangerLevel = 2,
            Abilities = "Creating illusions, Camouflage"
        },
        new Ghost
        {
            Id = 55, Name = "Eerie Edward", Type = "Ethereal", Age = 510, DateOfDead = new DateTime(1515, 9, 30),
            HauntLocation = "Ancient Castle", Appearance = "Mist-like form", DangerLevel = 5,
            Abilities = "Teleportation, Phasing"
        },
        new Ghost
        {
            Id = 56, Name = "Haunting Helen", Type = "Revenant", Age = 260, DateOfDead = new DateTime(1765, 11, 5),
            HauntLocation = "Deserted Mansion", Appearance = "Victorian woman", DangerLevel = 4,
            Abilities = "Possession, Shadow manipulation"
        },
        new Ghost
        {
            Id = 57, Name = "Vengeful Victor", Type = "Spectral", Age = 150, DateOfDead = new DateTime(1875, 10, 31),
            HauntLocation = "Old Church", Appearance = "Pale man in black suit", DangerLevel = 4,
            Abilities = "Invisibility, Wailing"
        },
        new Ghost
        {
            Id = 58, Name = "Creepy Carl", Type = "Manifestation", Age = 60, DateOfDead = new DateTime(1965, 5, 5),
            HauntLocation = "Downtown", Appearance = "Giant shadow", DangerLevel = 5,
            Abilities = "Size alteration, Resilience"
        },
        new Ghost
        {
            Id = 59, Name = "Spooky Susan", Type = "Ectoplasmic", Age = 70, DateOfDead = new DateTime(1955, 6, 20),
            HauntLocation = "Old Hotel", Appearance = "Green blob", DangerLevel = 3, Abilities = "Eating, Making mess"
        },
        new Ghost
        {
            Id = 60, Name = "Terrifying Tom", Type = "Poltergeist", Age = 90, DateOfDead = new DateTime(1935, 7, 20),
            HauntLocation = "Suburban House", Appearance = "Invisible force", DangerLevel = 3,
            Abilities = "Moving objects, Causing disturbances"
        },
        new Ghost
        {
            Id = 61, Name = "Ghastly George", Type = "Poltergeist", Age = 80, DateOfDead = new DateTime(1945, 12, 25),
            HauntLocation = "Old Manor", Appearance = "Invisible force", DangerLevel = 3,
            Abilities = "Moving objects, Causing disturbances"
        },
        new Ghost
        {
            Id = 62, Name = "Wailing Wanda", Type = "Banshee", Age = 300, DateOfDead = new DateTime(1725, 3, 15),
            HauntLocation = "Haunted Forest", Appearance = "Hooded figure", DangerLevel = 4,
            Abilities = "Screaming, Summoning smaller spirits"
        },
        new Ghost
        {
            Id = 63, Name = "Phantom Phil", Type = "Wraith", Age = 120, DateOfDead = new DateTime(1905, 7, 10),
            HauntLocation = "Abandoned Factory", Appearance = "Masked figure", DangerLevel = 4,
            Abilities = "Illusions, Music manipulation"
        },
        new Ghost
        {
            Id = 64, Name = "Spectral Sally", Type = "Apparition", Age = 90, DateOfDead = new DateTime(1935, 8, 22),
            HauntLocation = "Old School", Appearance = "Ghostly child", DangerLevel = 2,
            Abilities = "Creating illusions, Camouflage"
        },
        new Ghost
        {
            Id = 65, Name = "Eerie Eric", Type = "Ethereal", Age = 500, DateOfDead = new DateTime(1525, 9, 30),
            HauntLocation = "Ancient Castle", Appearance = "Mist-like form", DangerLevel = 5,
            Abilities = "Teleportation, Phasing"
        },
        new Ghost
        {
            Id = 66, Name = "Haunting Hannah", Type = "Revenant", Age = 250, DateOfDead = new DateTime(1775, 11, 5),
            HauntLocation = "Deserted Mansion", Appearance = "Victorian woman", DangerLevel = 4,
            Abilities = "Possession, Shadow manipulation"
        },
        new Ghost
        {
            Id = 67, Name = "Vengeful Victor", Type = "Spectral", Age = 150, DateOfDead = new DateTime(1875, 10, 31),
            HauntLocation = "Old Church", Appearance = "Pale man in black suit", DangerLevel = 4,
            Abilities = "Invisibility, Wailing"
        },
        new Ghost
        {
            Id = 68, Name = "Creepy Carl", Type = "Manifestation", Age = 60, DateOfDead = new DateTime(1965, 5, 5),
            HauntLocation = "Downtown", Appearance = "Giant shadow", DangerLevel = 5,
            Abilities = "Size alteration, Resilience"
        },
        new Ghost
        {
            Id = 69, Name = "Spooky Susan", Type = "Ectoplasmic", Age = 70, DateOfDead = new DateTime(1955, 6, 20),
            HauntLocation = "Old Hotel", Appearance = "Green blob", DangerLevel = 3, Abilities = "Eating, Making mess"
        },
        new Ghost
        {
            Id = 70, Name = "Terrifying Tom", Type = "Poltergeist", Age = 90, DateOfDead = new DateTime(1935, 7, 20),
            HauntLocation = "Suburban House", Appearance = "Invisible force", DangerLevel = 3,
            Abilities = "Moving objects, Causing disturbances"
        },
        new Ghost
        {
            Id = 71, Name = "Ghastly Gary", Type = "Poltergeist", Age = 85, DateOfDead = new DateTime(1940, 12, 25),
            HauntLocation = "Old Manor", Appearance = "Invisible force", DangerLevel = 3,
            Abilities = "Moving objects, Causing disturbances"
        },
        new Ghost
        {
            Id = 72, Name = "Wailing Wendy", Type = "Banshee", Age = 310, DateOfDead = new DateTime(1715, 3, 15),
            HauntLocation = "Haunted Forest", Appearance = "Hooded figure", DangerLevel = 4,
            Abilities = "Screaming, Summoning smaller spirits"
        },
        new Ghost
        {
            Id = 73, Name = "Phantom Pete", Type = "Wraith", Age = 130, DateOfDead = new DateTime(1895, 7, 10),
            HauntLocation = "Abandoned Factory", Appearance = "Masked figure", DangerLevel = 4,
            Abilities = "Illusions, Music manipulation"
        },
        new Ghost
        {
            Id = 74, Name = "Spectral Sarah", Type = "Apparition", Age = 95, DateOfDead = new DateTime(1930, 8, 22),
            HauntLocation = "Old School", Appearance = "Ghostly child", DangerLevel = 2,
            Abilities = "Creating illusions, Camouflage"
        },
        new Ghost
        {
            Id = 75, Name = "Eerie Edward", Type = "Ethereal", Age = 510, DateOfDead = new DateTime(1515, 9, 30),
            HauntLocation = "Ancient Castle", Appearance = "Mist-like form", DangerLevel = 5,
            Abilities = "Teleportation, Phasing"
        },
        new Ghost
        {
            Id = 76, Name = "Haunting Helen", Type = "Revenant", Age = 260, DateOfDead = new DateTime(1765, 11, 5),
            HauntLocation = "Deserted Mansion", Appearance = "Victorian woman", DangerLevel = 4,
            Abilities = "Possession, Shadow manipulation"
        },
        new Ghost
        {
            Id = 77, Name = "Vengeful Victor", Type = "Spectral", Age = 150, DateOfDead = new DateTime(1875, 10, 31),
            HauntLocation = "Old Church", Appearance = "Pale man in black suit", DangerLevel = 4,
            Abilities = "Invisibility, Wailing"
        },
        new Ghost
        {
            Id = 78, Name = "Creepy Carl", Type = "Manifestation", Age = 60, DateOfDead = new DateTime(1965, 5, 5),
            HauntLocation = "Downtown", Appearance = "Giant shadow", DangerLevel = 5,
            Abilities = "Size alteration, Resilience"
        },
        new Ghost
        {
            Id = 79, Name = "Spooky Susan", Type = "Ectoplasmic", Age = 70, DateOfDead = new DateTime(1955, 6, 20),
            HauntLocation = "Old Hotel", Appearance = "Green blob", DangerLevel = 3, Abilities = "Eating, Making mess"
        },
        new Ghost
        {
            Id = 80, Name = "Terrifying Tom", Type = "Poltergeist", Age = 90, DateOfDead = new DateTime(1935, 7, 20),
            HauntLocation = "Suburban House", Appearance = "Invisible force", DangerLevel = 3,
            Abilities = "Moving objects, Causing disturbances"
        },
        new Ghost
        {
            Id = 81, Name = "Ghastly George", Type = "Poltergeist", Age = 80, DateOfDead = new DateTime(1945, 12, 25),
            HauntLocation = "Old Manor", Appearance = "Invisible force", DangerLevel = 3,
            Abilities = "Moving objects, Causing disturbances"
        },
        new Ghost
        {
            Id = 82, Name = "Wailing Wanda", Type = "Banshee", Age = 300, DateOfDead = new DateTime(1725, 3, 15),
            HauntLocation = "Haunted Forest", Appearance = "Hooded figure", DangerLevel = 4,
            Abilities = "Screaming, Summoning smaller spirits"
        },
        new Ghost
        {
            Id = 83, Name = "Phantom Phil", Type = "Wraith", Age = 120, DateOfDead = new DateTime(1905, 7, 10),
            HauntLocation = "Abandoned Factory", Appearance = "Masked figure", DangerLevel = 4,
            Abilities = "Illusions, Music manipulation"
        },
        new Ghost
        {
            Id = 84, Name = "Spectral Sally", Type = "Apparition", Age = 90, DateOfDead = new DateTime(1935, 8, 22),
            HauntLocation = "Old School", Appearance = "Ghostly child", DangerLevel = 2,
            Abilities = "Creating illusions, Camouflage"
        },
        new Ghost
        {
            Id = 85, Name = "Eerie Eric", Type = "Ethereal", Age = 500, DateOfDead = new DateTime(1525, 9, 30),
            HauntLocation = "Ancient Castle", Appearance = "Mist-like form", DangerLevel = 5,
            Abilities = "Teleportation, Phasing"
        },
        new Ghost
        {
            Id = 86, Name = "Haunting Hannah", Type = "Revenant", Age = 250, DateOfDead = new DateTime(1775, 11, 5),
            HauntLocation = "Deserted Mansion", Appearance = "Victorian woman", DangerLevel = 4,
            Abilities = "Possession, Shadow manipulation"
        },
        new Ghost
        {
            Id = 87, Name = "Vengeful Victor", Type = "Spectral", Age = 150, DateOfDead = new DateTime(1875, 10, 31),
            HauntLocation = "Old Church", Appearance = "Pale man in black suit", DangerLevel = 4,
            Abilities = "Invisibility, Wailing"
        },
        new Ghost
        {
            Id = 88, Name = "Creepy Carl", Type = "Manifestation", Age = 60, DateOfDead = new DateTime(1965, 5, 5),
            HauntLocation = "Downtown", Appearance = "Giant shadow", DangerLevel = 5,
            Abilities = "Size alteration, Resilience"
        },
        new Ghost
        {
            Id = 89, Name = "Spooky Susan", Type = "Ectoplasmic", Age = 70, DateOfDead = new DateTime(1955, 6, 20),
            HauntLocation = "Old Hotel", Appearance = "Green blob", DangerLevel = 3, Abilities = "Eating, Making mess"
        },
        new Ghost
        {
            Id = 90, Name = "Terrifying Tom", Type = "Poltergeist", Age = 90, DateOfDead = new DateTime(1935, 7, 20),
            HauntLocation = "Suburban House", Appearance = "Invisible force", DangerLevel = 3,
            Abilities = "Moving objects, Causing disturbances"
        },
        new Ghost
        {
            Id = 91, Name = "Ghastly Gary", Type = "Poltergeist", Age = 85, DateOfDead = new DateTime(1940, 12, 25),
            HauntLocation = "Old Manor", Appearance = "Invisible force", DangerLevel = 3,
            Abilities = "Moving objects, Causing disturbances"
        },
        new Ghost
        {
            Id = 92, Name = "Wailing Wendy", Type = "Banshee", Age = 310, DateOfDead = new DateTime(1715, 3, 15),
            HauntLocation = "Haunted Forest", Appearance = "Hooded figure", DangerLevel = 4,
            Abilities = "Screaming, Summoning smaller spirits"
        },
        new Ghost
        {
            Id = 93, Name = "Phantom Pete", Type = "Wraith", Age = 130, DateOfDead = new DateTime(1895, 7, 10),
            HauntLocation = "Abandoned Factory", Appearance = "Masked figure", DangerLevel = 4,
            Abilities = "Illusions, Music manipulation"
        },
        new Ghost
        {
            Id = 94, Name = "Spectral Sarah", Type = "Apparition", Age = 95, DateOfDead = new DateTime(1930, 8, 22),
            HauntLocation = "Old School", Appearance = "Ghostly child", DangerLevel = 2,
            Abilities = "Creating illusions, Camouflage"
        },
        new Ghost
        {
            Id = 95, Name = "Eerie Edward", Type = "Ethereal", Age = 510, DateOfDead = new DateTime(1515, 9, 30),
            HauntLocation = "Ancient Castle", Appearance = "Mist-like form", DangerLevel = 5,
            Abilities = "Teleportation, Phasing"
        },
        new Ghost
        {
            Id = 96, Name = "Haunting Helen", Type = "Revenant", Age = 260, DateOfDead = new DateTime(1765, 11, 5),
            HauntLocation = "Deserted Mansion", Appearance = "Victorian woman", DangerLevel = 4,
            Abilities = "Possession, Shadow manipulation"
        },
        new Ghost
        {
            Id = 97, Name = "Vengeful Victor", Type = "Spectral", Age = 150, DateOfDead = new DateTime(1875, 10, 31),
            HauntLocation = "Old Church", Appearance = "Pale man in black suit", DangerLevel = 4,
            Abilities = "Invisibility, Wailing"
        },
        new Ghost
        {
            Id = 98, Name = "Creepy Carl", Type = "Manifestation", Age = 60, DateOfDead = new DateTime(1965, 5, 5),
            HauntLocation = "Downtown", Appearance = "Giant shadow", DangerLevel = 5,
            Abilities = "Size alteration, Resilience"
        },
        new Ghost
        {
            Id = 99, Name = "Spooky Susan", Type = "Ectoplasmic", Age = 70, DateOfDead = new DateTime(1955, 6, 20),
            HauntLocation = "Old Hotel", Appearance = "Green blob", DangerLevel = 3, Abilities = "Eating, Making mess"
        },
        new Ghost
        {
            Id = 100, Name = "Terrifying Tom", Type = "Poltergeist", Age = 90, DateOfDead = new DateTime(1935, 7, 20),
            HauntLocation = "Suburban House", Appearance = "Invisible force", DangerLevel = 3,
            Abilities = "Moving objects, Causing disturbances"
        }
    ];
}

public record Ghost
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string Type { get; init; }
    public int Age { get; set; }
    public DateTime DateOfDead { get; set; }
    public string HauntLocation { get; set; }
    public string Appearance { get; set; }
    public int DangerLevel { get; set; }
    public string Abilities { get; set; }
    public bool Online { get; set; }
}