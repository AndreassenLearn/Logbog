namespace Logbog
{
  public class TopicNote
  {
    public DateTime DateOfCreation { get; set; }
    public string Source { get; set; }

    public TopicNote(DateTime dateOfCreation, string source)
    {
      DateOfCreation = dateOfCreation;
      Source = source;
    }
  }
}
