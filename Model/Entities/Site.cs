namespace Model.Entities;

[Table("SITES")]
public class Site
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string Url { get; set; }
    
    public string Title { get; set; }
    
    public string Description { get; set; }
    
    public EColor Color { get; set; }
}

public enum EColor
{
    GREEN,
    BLUE,
    ORANGE,
    PINK,
    PURPLE
}