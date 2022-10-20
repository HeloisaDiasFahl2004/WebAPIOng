namespace WebAPIOng.Utils
{
    public class DatabaseSettings:IDatabaseSettings
    {
       public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string PetCollectionName { get; set; }
        public string AdotanteCollectionName { get; set; }
    }
}
