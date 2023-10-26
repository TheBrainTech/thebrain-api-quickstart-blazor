namespace TheBrainApiQuickstart.Data; 

public class Thought {
    
	public Guid id { get; set; }
	
	public Guid brainId { get; set; }

	public DateTime creationDateTime { get; set; }
	
	public DateTime modificationDateTime { get; set; }
	
	public string name { get; set; }
	
	public string cleanedUpName { get; set; }

	public Guid? typeId { get; set; }
	
	public DateTime? displayModificationDateTime { get; set; }

	public DateTime? forgottenDateTime { get; set; }

	public DateTime? linksModificationDateTime { get; set; }

	public int acType { get; set; }

	public int kind { get; set; }

	public string label { get; set; }

	public string? foregroundColor { get; set; }

	public string? backgroundColor { get; set; }
    
}