namespace TheBrainApiQuickstart.Data; 

public class ThoughtGraph {
    
    
	public Thought activeThought { get; set; }
	
	public IEnumerable<Thought> parents { get; set; }
	public IEnumerable<Thought> children { get; set; }
	public IEnumerable<Thought> jumps { get; set; }
	public IEnumerable<Thought>? siblings { get; set; }

	public IEnumerable<Thought> tags { get; set; }
	
	public Thought? type { get; set; }
	
	public IEnumerable<Link> links { get; set; }
	
	public IEnumerable<Attachment> attachments { get; set; }
    
}