namespace CodeFirstApproachWithOneToMany
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DBOperation dBOperation = new DBOperation();

            DirectorModel directorModel = new DirectorModel();
            directorModel.DirectorId = 1;
            directorModel.DirectorName = "Dname";
            
            dBOperation.InsertDirector(directorModel);
            
            //MovieModel movieModel = new MovieModel();
            //movieModel.MovieId = 1;
            //movieModel.MovieName = "ABC";
            //movieModel.MovieGenre = "Humour";
            //movieModel.DirectorId = 1;
            
            //dBOperation.InsertMovies(movieModel);           
            //dBOperation.FindMovie(movieModel.MovieId);

            DirectorAddress directorAddress = new DirectorAddress();
            directorAddress.DirectorAddressId = 1;
            directorAddress.City = "Chennai";
            directorAddress.State = "TN";
            directorAddress.Country = "India";

            dBOperation.InsertDirectorsAddress(directorAddress);

        }
    }
}
