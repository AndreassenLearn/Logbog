namespace Logbog
{
  public class TopicConstructor
  {
    public ushort Index { get; set; }
    public string Name { get; set; }
    public List<TopicConstructor>? TopicConstructors {get; set;}

    public TopicConstructor(ushort index, string name, List<TopicConstructor>? topicConstructors = null)
    {
      Index = index;
      Name = name;
      TopicConstructors = topicConstructors;
    }
  }
}
