namespace TheBrainApiQuickstart.Pages; 

public class NoteResponse {
    
	public Guid brainId { get; set; }
	
	public Guid sourceId { get; set; }
	
	public int sourceType { get; set; }
	
	public DateTime modificationDateTime { get; set; }

	public string? markdown { get; set; }
	
	public string? html { get; set; }
	
	public string? text { get; set; }
}