namespace TheBrainApiQuickstart.Data;

public class SearchResult {
    
    public SourceThought? sourceThought { get; set; }
    
    public int searchResultType { get; set; }
    
    public bool isFromOtherBrain { get; set; }
    
    public string name { get; set; }
    
    public string attachmentId { get; set; }
    
    public string brainName { get; set; }
    
    public string brainId { get; set; }
    
    public int entityType { get; set; }
    
    public int sourceType { get; set; }
}
