using aasdqawdawfaefgaef.Models;

namespace aasdqawdawfaefgaef.Services;

public interface IDataService
{
    List<Project> GetProjects();
    List<BlogPost> GetBlogPosts();
    List<SystemSpec> GetSystemSpecs();
}

public class DataService : IDataService
{
    public List<Project> GetProjects()
    {
        return new List<Project>
        {
            new Project
            {
                Id = 1,
                Title = "Discord Bot",
                Description = "Python ile geliştirilmiş işlevsel bir Discord botu.",
                Technologies = new List<string> { "Python", "Discord.py" },
                GithubUrl = "https://github.com/kayra618"
            },
            new Project
            {
                Id = 2,
                Title = "Sudoku",
                Description = "Python kullanılarak geliştirilmiş oynanabilir Sudoku oyunu.",
                Technologies = new List<string> { "Python", "Algoritmalar" },
                GithubUrl = "https://github.com/kayra618"
            },
            new Project
            {
                Id = 3,
                Title = "Arduino Projeleri",
                Description = "Donanım programlama üzerine geliştirilmiş çeşitli projeler.",
                Technologies = new List<string> { "C++", "Arduino" },
                GithubUrl = "https://github.com/kayra618"
            }
        };
    }

    public List<BlogPost> GetBlogPosts()
    {
        return new List<BlogPost>
        {
            new BlogPost
            {
                Id = 1,
                Title = "Neden C#?",
                Excerpt = "Bir genç yazılımcı olarak neden C# dilini seçtim?",
                Content = "C#, hem oyun geliştirmede hem de web dünyasında inanılmaz bir güce sahip...",
                PublishedDate = DateTime.Now.AddDays(-10)
            },
            new BlogPost
            {
                Id = 2,
                Title = "Blazor ile Gelecek",
                Excerpt = "WebAssembly ve Blazor'un modern web dünyasındaki yeri.",
                Content = "JavaScript'e karşı C# ile web geliştirmek çok daha keyifli...",
                PublishedDate = DateTime.Now.AddDays(-5)
            }
        };
    }

    public List<SystemSpec> GetSystemSpecs()
    {
        return new List<SystemSpec>
        {
            new SystemSpec { Category = "İşlemci", Name = "Intel Core i7-14700K", Icon = "bi bi-cpu" },
            new SystemSpec { Category = "Ekran Kartı", Name = "NVIDIA GeForce RTX 5060 Ti", Icon = "bi bi-gpu-card" },
            new SystemSpec { Category = "Bellek", Name = "32 GB DDR5 RAM", Icon = "bi bi-memory" },
            new SystemSpec { Category = "Depolama", Name = "1 TB NVMe SSD", Icon = "bi bi-hdd-network" }
        };
    }
}
