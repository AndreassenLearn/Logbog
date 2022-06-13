namespace Logbog
{
  public class Topic
  {
    public string Name { get; set; }
    public ushort MainIndex { get; set; }
    public ushort? SubIndex { get; set; } = null;
    public ushort? SubSubIndex { get; set; } = null;
    public List<TopicNote> TopicNotes { get; set; } = new List<TopicNote>();
    public List<Topic> Topics { get; set; } = new List<Topic>();

    /// <summary>
    /// Empty constructor.
    /// </summary>
    public Topic() : this(0, "No topic") { }

    /// <summary>
    /// Constructor for creating the main topic.
    /// </summary>
    /// <param name="mainIndex">Topic index - must be unique.</param>
    /// <param name="name">Topic name.</param>
    /// <param name="topicConstructors">Collection for further creation of subtopics and sub-subtopics.</param>
    public Topic(ushort mainIndex, string name, List<TopicConstructor>? topicConstructors = null)
    {
      Name = name;
      MainIndex = mainIndex;
      SubIndex = SubSubIndex = null;

      if (topicConstructors != null)
      {
        foreach(TopicConstructor subTopic in topicConstructors)
        {
          Topics.Add(new Topic(mainIndex, subTopic.Index, subTopic.Name, subTopic.TopicConstructors));
        }
      }
    }

    /// <summary>
    /// Constructor for create a subtopic.
    /// </summary>
    /// <param name="mainIndex">Main topic index.</param>
    /// <param name="subIndex">Subtopic index.</param>
    /// <param name="name">Subtopic name.</param>
    /// <param name="topicConstructors">Collection for further creation of subtopics and sub-subtopics.</param>
    private Topic(ushort mainIndex, ushort subIndex, string name, List<TopicConstructor>? topicConstructors = null)
    {
      Name = name;
      MainIndex = mainIndex;
      SubIndex = subIndex;

      if (topicConstructors != null)
      {
        foreach (TopicConstructor subSubTopic in topicConstructors)
        {
          Topics.Add(new Topic(mainIndex, subIndex, subSubTopic.Index, subSubTopic.Name));
        }
      }
    }

    /// <summary>
    /// Constructor for create a sub-subtopic.
    /// </summary>
    /// <param name="mainIndex">Main topic index.</param>
    /// <param name="subIndex">Subtopic index.</param>
    /// <param name="subSubIndex">Sub-subtopic index.</param>
    /// <param name="name">Sub-subtopic name.</param>
    private Topic(ushort mainIndex, ushort subIndex, ushort subSubIndex, string name)
    {
      Name = name;
      MainIndex = mainIndex;
      SubIndex = subIndex;
      SubSubIndex = subSubIndex;
    }
  }
}
