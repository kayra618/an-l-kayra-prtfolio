namespace aasdqawdawfaefgaef.Models;

public class Project
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string? GithubUrl { get; set; }
    public string? LiveUrl { get; set; }
    public List<string> Technologies { get; set; } = new();
}

public class BlogPost
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Excerpt { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime PublishedDate { get; set; }
    public string Author { get; set; } = "Anıl Kayra Cengiz";
}

public class SystemSpec
{
    public string Category { get; set; } = string.Empty; // e.g., CPU, GPU
    public string Name { get; set; } = string.Empty; // e.g., i7-14700K
    public string Icon { get; set; } = string.Empty; // CSS class for icon
}
