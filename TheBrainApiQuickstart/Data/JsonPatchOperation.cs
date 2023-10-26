namespace TheBrainApiQuickstart.Data;

public class JsonPatchOperation {
    
    public string op { get; set; }
    
    public string path { get; set; }
    
    public object value { get; set; }
    
}
