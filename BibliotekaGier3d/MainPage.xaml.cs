using BibliotekaGier3d.Model;
namespace BibliotekaGier3d
{
    public partial class MainPage : ContentPage
    {
        List<Game> games;
        public MainPage()
        {
            InitializeComponent();
            games = new List<Game>()
            {
                new Game()
                {
                    Id = 1,
                    Title = "Star Wars Battlefront 2022",
                    Description = "Be the hero in the ultimate STAR WARS™ battle fantasy with STAR WARS™ Battlefront™ II: Celebration Edition!",
                    ReleaseDate = new DateTime(2020,6,11),
                    Genres = ["MultiPlayer","Pvp","Tactical","Sci-fi","FPS" ],
                    Image = "https://cdn.cloudflare.steamstatic.com/steam/apps/1237950/header.jpg?t=1710240858"
                },
                new Game()
                {
                    Id=2,
                    Title = "7 Days to Die",
                    Description = "7 Days to Die is an open-world game that is a unique combination of first-person shooter, survival horror, tower defense, and role-playing games. Play the definitive zombie survival sandbox RPG that came first. Navezgane awaits!",
                    ReleaseDate = new DateTime(2013,12,13),
                    Genres = ["Survival","Horror","Zobmies","Online Co-Op"],
                    Image = "https://cdn.cloudflare.steamstatic.com/steam/apps/251570/header.jpg?t=1710457402"
                },
                new Game()
                {
                    Id = 3,
                    Title = "STAR WARS Jedi: Fallen Order",
                    Description = "A galaxy-spanning adventure awaits in Star Wars Jedi: Fallen Order, a 3rd person action-adventure title from Respawn. An abandoned Padawan must complete his training, develop new powerful Force abilities, and master the art of the lightsaber - all while staying one step ahead of the Empire.",
                    ReleaseDate = new DateTime(2019,11,15),
                    Genres = ["Sci-fi","Action","RPG","Swordplay","Exploration","Third Person"],
                    Image = "https://cdn.cloudflare.steamstatic.com/steam/apps/1172380/header.jpg?t=1709862857"
                },
                new Game()
                {
                    Id = 4,
                    Title = "STAR WARS Jedi: Survivor",
                    Description = "The story of Cal Kestis continues in STAR WARS Jedi: Survivor™, a galaxy-spanning, third-person, action-adventure game.",
                    ReleaseDate = new DateTime(2023,04,28),
                    Genres = ["Sci-fi","Action","RPG","Swordplay","Exploration","Third Person","Dificult"],
                    Image = "https://cdn.cloudflare.steamstatic.com/steam/apps/1774580/header.jpg?t=1710494527"
                },
                new Game()
                {
                    Id = 5,
                    Title = "STAR WARS: Squadrons",
                    Description = "Master the art of starfighter combat in the authentic piloting experience STAR WARS™: Squadrons. Feel the adrenaline of first-person multiplayer space dogfights alongside your squadron, and buckle up in a thrilling STAR WARS™ story.",
                    ReleaseDate = new DateTime(2020,10,1),
                    Genres = ["Flight","Multiplayer","Sci-fi","Co-op","Simulation","Space Sim"],
                    Image = "https://cdn.cloudflare.steamstatic.com/steam/apps/1222730/header.jpg?t=1709982587"
                },
                new Game()
                {
                    Id = 6,
                    Title = "Cyberpunk 2077",
                    Description = "Cyberpunk 2077 is an open-world, action-adventure RPG set in the dark future of Night City — a dangerous megalopolis obsessed with power, glamor, and ceaseless body modification.",
                    ReleaseDate = new DateTime(2020,12,10),
                    Genres = ["Cyberpunk","Action","Stroy Rich","First-Person"],
                    Image = "https://cdn.cloudflare.steamstatic.com/steam/apps/1091500/header.jpg?t=1710407467"
                }
            };
            view.ItemsSource = games;
        }

    }

}
