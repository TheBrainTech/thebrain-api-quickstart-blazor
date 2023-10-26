namespace TheBrainApiQuickstart.Data; 

public class Link {
    
	public Guid id { get; set; }
	
	public Guid brainId { get; set; }

	public DateTime creationDateTime { get; set; }
	
	public DateTime modificationDateTime { get; set; }
	
	public string name { get; set; }
	
	public string cleanedUpName { get; set; }

	public Guid? typeId { get; set; }
	
	public int kind { get; set; }

	public string color { get; set; }

	public int? thickness { get; set; }
	
	public Guid thoughtIdA { get; set; }

	public Guid thoughtIdB { get; set; }

	public int relation { get; set; }

	public int direction { get; set; }

	public int meaning { get; set; }
	
}