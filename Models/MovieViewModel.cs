namespace PeliculaLanding.Models;

public class MovieViewModel
{
    public string Titulo {get; set;} = "Spider-Man: Brand New Day";
    public string TagLine {get; set;} = "Un nuevo comienzo para Peter Parker. Una nueva amenaza para Spider-Man";
    public string Lanzamiento {get; set;} = "2026-07-24T00:00:00";
    public string Director {get; set;} = "Destin Daniel Cretton";
    public string Estudio { get; set;} = "Marvel Studios & Sony Pictures";
    public string TrailerID {get; set;} = "8TZMtslA3UY";
    public string HeroBannerURL {get; set;} = "https://m.media-amazon.com/images/M/MV5BOWNjYWM3NWItOGE0ZS00MWRjLThiZWEtYjc4ZmNmMmU5ZTVmXkEyXkFqcGc@._V1_.jpg";
    public string PosterURL {get; set;} = "https://sm.ign.com/ign_nordic/image/n/new-spider/new-spider-man-brand-new-day-posters-released_4ac8.jpg";

    public string Sipnosis {get; set;} = "Luego de 5 años sin que nadie recuerde quien es Peter Parker, Spider-Man ahora deberá enfrentar a un nuevo enemigo mientras este intenta lidiar con su propia mutación arácnida";

    public List<ActorModel> Reparto {get; set;} = new List<ActorModel>
    {
        new ActorModel { Nombre = "Tom Holland", Personaje = "Peter Parker / Spider-Man", Icono = "🕷️"},
        new ActorModel { Nombre = "Zendaya", Personaje = "MJ", Icono = "🔴" },
        new ActorModel { Nombre = "Jacob Batalon", Personaje = "Ned Leeds", Icono = "💻" },
        new ActorModel { Nombre = "Jon Bernthal", Personaje = "Frank Castle / Punisher", Icono = "💀" },
        new ActorModel { Nombre = "Mark Ruffalo", Personaje = "Bruce Banner / Hulk", Icono = "🧪" },
        new ActorModel { Nombre = "Sadie Sink", Personaje = "Jean Grey", Icono = "🔥" }
    };
}

public class ActorModel
{
    public string Nombre {get; set;} = string.Empty;
    public string Personaje {get; set;} = string.Empty;
    public string Icono { get; set; } = "🎭";
}