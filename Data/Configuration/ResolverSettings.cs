namespace rbl_tracker.Configuration
{
    public class ResolverSettings
    {
        public List<string> Resolvers {get; set;} = new List<string>();
        public bool ContinueOnDnsError { get; set; }
        public bool UseRandomNameServer { get; set; }
        public bool ContinueOnEmptyResponse { get; set; }
    }
}