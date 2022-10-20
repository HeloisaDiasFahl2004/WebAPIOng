namespace WebAPIOng.Utils
{
    public interface IDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }   
        string PetCollectionName { get; set;}
     
    }
}
