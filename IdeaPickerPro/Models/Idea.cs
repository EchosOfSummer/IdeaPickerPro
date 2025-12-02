using SQLite;

namespace IdeaPickerPro.Models;

public class Idea
{
    [PrimaryKey, AutoIncrement] 
    public int ID { get; set; }
    public string _Text { get; set; }
}