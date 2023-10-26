namespace TheBrainApiQuickstart.Data; 

public class Attachment {
    
	public Guid id { get; set; }
	
	public Guid brainId { get; set; }
	
	public Guid sourceId { get; set; }
	
	public int sourceType { get; set; }

	public DateTime creationDateTime { get; set; }
	
	public DateTime modificationDateTime { get; set; }
	
	public string name { get; set; }
	
	public double position { get; set; }

	public DateTime? fileModificationDateTime { get; set; }
	
	public int type { get; set; }

	public bool isNotes { get; set; }
	
	public long? dataLength { get; set; }
	
	public string location { get; set; }
	
}