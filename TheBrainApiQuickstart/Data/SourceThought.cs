namespace TheBrainApiQuickstart.Data;

public class SourceThought {
    
    public string id { get; set; }
    
    public string brainId { get; set; }
    
    public DateTime creationDateTime { get; set; }
    
    public DateTime modificationDateTime { get; set; }
    
    public string name { get; set; }
    
    public string cleanedUpName { get; set; }
    
    public int acType { get; set; }
    
    public int kind { get; set; }
}
