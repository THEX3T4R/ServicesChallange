namespace Challange.Services.Catelog.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string FeatureCollectionName { get ; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
