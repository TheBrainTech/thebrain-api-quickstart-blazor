namespace TheBrainApiQuickstart.Data; 

public class ThoughtCreateModel {
    
    public string Name { get; set; }
    
    public int Kind { get; set; }
    
    public string Label { get; set; }
    
    public Guid TypeId { get; set; }
    
    public Guid SourceThoughtId { get; set; }
    
    public int Relation { get; set; }
    
    public int AcType { get; set; }
    
}