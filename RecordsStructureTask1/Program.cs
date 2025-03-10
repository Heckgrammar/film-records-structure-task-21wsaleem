namespace RecordsStructureTask1
{
    internal class Program
    {
        struct Film
        {
            namespace RecordsStructureTask1
{
    internal class Program
    {
        struct Film
        {
       {
        public string title;
        public string certificate;
        public int year;
        public bool beingShown;

        public Film(string title, string certificate, int year, bool beingShown)
        {
            this.title = title;
            this.certificate = certificate;
            this.year = year;
            this.beingShown = beingShown;
        }
    }

    static void Main(string[] args)
    {
        Film hulk = new Film("Hulk", "12A", 2005, false);
        Film ironMan = new Film("Iron Man", "12A", 2008, false);
        Film antMan = new Film("Ant-Man", "12A", 2015, false);
        Film[] filmCollection = new Film[] { antMan, hulk, ironMan };


        Film newestFilm = filmCollection[0]; 

        foreach (Film film in filmCollection)
        {
            if (film.year > newestFilm.year)
            {
                newestFilm = film;
            }
        }

        Console.WriteLine("The newest film is: " + newestFilm.title);

       
        foreach (Film film in filmCollection)
        {
            if (film.title == "Ant-Man")
            {
                film.beingShown = true;
                Console.WriteLine(film.title + " is now being shown.");
            }
        }
    }
}
