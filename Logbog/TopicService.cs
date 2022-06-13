namespace Logbog
{
  public static class TopicService
  {
    private static List<Topic> Topics { get; set; } = new List<Topic>();

    static TopicService()
    {
      CreateAllTopics();
      CreateAllTopicNotes();
      //Sort();
    }

    public static Topic GetTopic(ushort mainIndex, ushort? subIndex, ushort? subSubIndex)
    {
      // Find main topic
      foreach (Topic topic in Topics)
      {
        if (topic.MainIndex == mainIndex)
        {
          if (subIndex == null) return topic;

          // Find subtopic
          foreach (Topic subTopic in topic.Topics)
          {
            if (subTopic.SubIndex == (ushort)subIndex)
            {
              if (subSubIndex == null) return subTopic;

              // Find sub-subtopic
              foreach (Topic subSubTopic in subTopic.Topics)
              {
                if (subSubTopic.SubSubIndex == (ushort)subSubIndex)
                {
                  return subSubTopic;
                }
              }
            }
          }
        }
      }

      return new Topic();
    }

    public static List<Topic> GetTopics()
    {
      return Topics;
    }

    private static void CreateAllTopics()
    {
      Topics.Add(new Topic(1, "IT som værdiskaber", new List<TopicConstructor>()
      {
        new TopicConstructor(1, "IT i samfundet", new List<TopicConstructor>()
        {
          new TopicConstructor(1, "Den digitale borger"),
          new TopicConstructor(2, "Sociale medier")
        }),
        new TopicConstructor(2, "IT i virksomheden", new List<TopicConstructor>()
        {
          new TopicConstructor(1, "Organisatoriske forandringsprocesser"),
          new TopicConstructor(2, "IT-systemer"),
          new TopicConstructor(3, "Big Data")
        })
      }));

      Topics.Add(new Topic(2, "Innovation", new List<TopicConstructor>()
      {
        new TopicConstructor(1, "4p-modellen for innovation"),
        new TopicConstructor(2, "Radikal og inkrementel innovation"),
        new TopicConstructor(3, "Innovation i digitale virksomheder"),
        new TopicConstructor(4, "Brugerdreven innovation"),
        new TopicConstructor(5, "Gør dit IT-projekt innovativt")
      }));

      Topics.Add(new Topic(3, "IT-sikkerhed, lovgivning og arkitektur", new List<TopicConstructor>()
      {
        new TopicConstructor(1, "IT-sikkerhed", new List<TopicConstructor>()
        {
          new TopicConstructor(1, "Fysisk og logisk sikkerhed"),
          new TopicConstructor(2, "Data- og kommunikationssikkerhed"),
          new TopicConstructor(3, "Cookies"),
          new TopicConstructor(4, "IT-sikkerhedspolitik")
        }),
        new TopicConstructor(2, "Lovgivning på IT-området", new List<TopicConstructor>()
        {
          new TopicConstructor(1, "Persondataforordningen"),
          new TopicConstructor(2, "Lov om ophavsret"),
          new TopicConstructor(3, "Købeloven og E-handelsloven")
        }),
        new TopicConstructor(3, "IT-systemers arkitektur", new List<TopicConstructor>()
        {
          new TopicConstructor(1, "Klient og server"),
          new TopicConstructor(2, "Trelags-arkitektur")
        })
      }));

      Topics.Add(new Topic(4, "Interaktionsdesign", new List<TopicConstructor>()
      {
        new TopicConstructor(1, "Systemudviklingsmetoder", new List<TopicConstructor>()
        {
          new TopicConstructor(1, "Eksempler på klassiske fasemodeller")
        }),
        new TopicConstructor(2, "Brugergrænseflade"),
        new TopicConstructor(3, "Brugervenlighed"),
        new TopicConstructor(4, "Design")
      }));

      Topics.Add(new Topic(5, "Test og igangsætning", new List<TopicConstructor>()
      {
        new TopicConstructor(1, "Systemtest"),
        new TopicConstructor(2, "Brugervenlighedstest"),
        new TopicConstructor(3, "Tænkte-højt-test"),
        new TopicConstructor(4, "Igangsætning")
      }));

      Topics.Add(new Topic(6, "Programmering", new List<TopicConstructor>()
      {
        new TopicConstructor(1, "Syntaks og semantik"),
        new TopicConstructor(2, "Kontrolstrukturer og funktioner", new List<TopicConstructor>()
        {
          new TopicConstructor(1, "Sekvenser"),
          new TopicConstructor(2, "Forgreninger"),
          new TopicConstructor(3, "While-løkker"),
          new TopicConstructor(4, "For-løkker"),
          new TopicConstructor(5, "Funktioner")
        }),
        new TopicConstructor(3, "Data og operationer"),
        new TopicConstructor(4, "Kommentarer i koden")
      }));

      Topics.Add(new Topic(7, "Databaser", new List<TopicConstructor>()
      {
        new TopicConstructor(1, "Relationsdatabaser"),
        new TopicConstructor(2, "Databasebegreber", new List<TopicConstructor>()
        {
          new TopicConstructor(1, "Relationer"),
          new TopicConstructor(2, "Nøglefelter"),
          new TopicConstructor(3, "E/R-diagram"),
          new TopicConstructor(4, "Normalisering"),
          new TopicConstructor(5, "Datatyper"),
          new TopicConstructor(6, "Forespørgsler")
        }),
        new TopicConstructor(3, "Værktøjer", new List<TopicConstructor>()
        {
          new TopicConstructor(1, "SQL"),
          new TopicConstructor(2, "Lokal webserver")
        }),
        new TopicConstructor(4, "Udvikling med SQL"),
        new TopicConstructor(5, "Konstruktion af database"),
        new TopicConstructor(6, "Databaseadgang fra hjemmeside")
      }));

      Topics.Add(new Topic(8, "Applikationer", new List<TopicConstructor>()
      {
        new TopicConstructor(1, "Udvikling af hjemmesider"),
        new TopicConstructor(2, "HTML"),
        new TopicConstructor(3, "CSS"),
        new TopicConstructor(4, "HTML- og CSS-koder", new List<TopicConstructor>()
        {
          new TopicConstructor(1, "CSS-grid")
        }),
        new TopicConstructor(5, "Dynamiske hjemmesider"),
        new TopicConstructor(6, "CMS-systemer"),
        new TopicConstructor(7, "Apps til mobil", new List<TopicConstructor>()
        {
          new TopicConstructor(1, "App-genre"),
          new TopicConstructor(2, "Native apps eller web apps"),
          new TopicConstructor(3, "App-udvikling")
        })
      }));

      Topics.Add(new Topic(9, "Projekter", new List<TopicConstructor>()
      {
        new TopicConstructor(1, "Skabelon til afsluttende eksamensprojekt"),
        new TopicConstructor(2, "IT-politik i en virksomhed"),
        new TopicConstructor(3, "ERP-systemer"),
        new TopicConstructor(4, "Design af hjemmeside"),
        new TopicConstructor(5, "Responsive HTML og beacons"),
        new TopicConstructor(6, "Hjemmeside med JavaScript"),
        new TopicConstructor(7, "Webshop"),
        new TopicConstructor(8, "App-design"),
        new TopicConstructor(9, "Databaser og PHP")
      }));

      Topics.Add(new Topic(10, "Log"));
    }

    private static void CreateAllTopicNotes()
    {
      // 1
      CreateTopicNotes(new List<TopicNote>()
      {
        new TopicNote(new DateTime(2022, 5, 17), "https://docs.google.com/document/d/e/2PACX-1vQ6wxVR3NROj0LCstB43YF7wxYJDpP8Jd3767BvjEoHxPW1ASOfZueHSh9cWY4DU_7xeuqwW3BpB8w2/pub?embedded=true")
      }, 1, 2, 1);

      // 2
      CreateTopicNotes(new List<TopicNote>()
      {
        new TopicNote(new DateTime(2022, 5, 19), "https://docs.google.com/document/d/e/2PACX-1vQ-r8BQemMNc0ezC2sbj6VHC4yqS-YQQPciSProNxBfitVf6hWvJXMhjktleOBoRCTOXrhOADOJUiul/pub?embedded=true"),
        new TopicNote(new DateTime(2022, 5, 19), "https://docs.google.com/document/d/e/2PACX-1vQUEkzwFkOYEL-yFSKapl8y0VYb6mX5vM2BaLN5pXjv_t-H_qBmArhm4Kui8AVB2ec-yp5d2F2Jxzsw/pub?embedded=true"),
        new TopicNote(new DateTime(2022, 5, 19), "https://docs.google.com/document/d/e/2PACX-1vSZCq97dFhNx_kLsU1PIPvYsZgl4T9QoKyBAUnn_Z3fT5Y-HtXlkrnc8Dbm5r3RHG62Vc4EtdgnXzXs/pub?embedded=true")
      }, 2);

      CreateTopicNotes(new List<TopicNote>()
      {
        new TopicNote(new DateTime(2022, 5, 17), "https://docs.google.com/document/d/e/2PACX-1vSe_gg2tX5UoYdN37nPCEWCHMf56fOoa9AAKBWogdoa9e-ajwqQAnhmsGKADqHww_2dcfcUQiagMXbx/pub?embedded=true"),
        new TopicNote(new DateTime(2022, 5, 17), "https://docs.google.com/document/d/e/2PACX-1vSEfJC1g9FMbXBKSPCg4itftxLXfTDaSYAJbRH5Sd7W588OJpHMNh16nTsotQ_FIpi2W3mTQ_Kwb8NZ/pub?embedded=true")
      }, 2, 1);

      CreateTopicNotes(new List<TopicNote>()
      {
        new TopicNote(new DateTime(2022, 5, 19), "https://docs.google.com/document/d/e/2PACX-1vTejBoEdV-Q1vLiiR46f8B1XNrGkkBq-g_j4m6kKQMn7jEn-G1CnIbsz5yo_sSqXrLSI_XBrer78wQq/pub?embedded=true")
      }, 2, 2);

      CreateTopicNotes(new List<TopicNote>()
      {
        new TopicNote(new DateTime(2022, 5, 19), "https://docs.google.com/document/d/e/2PACX-1vRQ9WAri3RYF-pMA8zh5yudJqY0lMNEymZR7tOL4aTrLeaAyS2pzqW3cW1kc3xyQMZtUkNOV43GEYou/pub?embedded=true")
      }, 2, 3);

      CreateTopicNotes(new List<TopicNote>()
      {
        new TopicNote(new DateTime(2022, 5, 19), "https://docs.google.com/document/d/e/2PACX-1vSbK7gUJgc1wYFR7PqqdMMquzMEPHVMpjpBdUDCf6zmOhc3SKwAvf7Gs4qSa52_DmNM_HOM5jzuqWrY/pub?embedded=true")
      }, 2, 4);

      CreateTopicNotes(new List<TopicNote>()
      {
        new TopicNote(new DateTime(2022, 5, 19), "https://docs.google.com/document/d/e/2PACX-1vQiKoCCSFkgze7BrKp1prlDQAmW4WmyuSrrlKdHen6nyd0eeOd7TEdUSaGkr7qo87wfJ4EWQTcRqfau/pub?embedded=true"),
        new TopicNote(new DateTime(2022, 5, 19), "https://docs.google.com/document/d/e/2PACX-1vQikfr_YwdSiq1uDfO2vgnNPhNEUpBgXVU0TZc2tm3lWglOrkakGvjerWM0n_OwLY1PvGk7w1_EQrSS/pub?embedded=true")
      }, 2, 5);

      // 4
      CreateTopicNotes(new List<TopicNote>()
      {
        new TopicNote(new DateTime(2022, 5, 24), "https://docs.google.com/document/d/e/2PACX-1vTokiWSvBd02gP67yLVNfaEYlpTztIdR3I9pbb7zSjBf6vWrXHes7NqclXiZtcO27pd6ceTrveiHof0/pub?embedded=true")
      }, 4, 1);

      CreateTopicNotes(new List<TopicNote>()
      {
        new TopicNote(new DateTime(2022, 5, 24), "https://docs.google.com/document/d/e/2PACX-1vQtHReDY5QCn17g_8yOcsbkGLM4OZsIEXafLZ_uUpdh-6hUau1fBqswtgqpWz7AhMTcDD_dss5Eie9h/pub?embedded=true")
      }, 4, 3);

      CreateTopicNotes(new List<TopicNote>()
      {
        new TopicNote(new DateTime(2022, 5, 23), "https://docs.google.com/document/d/e/2PACX-1vRAv1C9sh5_J70zNuyxuW4-pW5iNmab1VlO3294BpJu-XzgpqVbCoJ_COI_imSy7w8L2sr9otLjoUYz/pub?embedded=true")
      }, 4, 4);

      // 10
      CreateTopicNotes(new List<TopicNote>()
      {
        new TopicNote(new DateTime(2022, 5, 16), "https://docs.google.com/document/d/e/2PACX-1vQ345VyFIsdXtItTxOC0VboUL-vKNOkR-Ay4C0Ys-6OeIY_sYPcpq3XKUEHufv8DCPklN2yjEcYvgsf/pub?embedded=true"),
        new TopicNote(new DateTime(2022, 5, 17), "https://docs.google.com/document/d/e/2PACX-1vSFK7106UammMmK0Jr99jPL7bLYBJRstol2mXhM4D_8UfxyTHsTuQ1wY5-kRClesvuP3vs81lFjQRhd/pub?embedded=true"),
        new TopicNote(new DateTime(2022, 5, 19), "https://docs.google.com/document/d/e/2PACX-1vSUUuiBZuVrPYquoI62d7AD9rLqhbfzOJx1kCVO32xMlxMOSF-xe9J9aClIDC54zADOjww40QizynGf/pub?embedded=true"),
        new TopicNote(new DateTime(2022, 5, 20), "https://docs.google.com/document/d/e/2PACX-1vQh2Z_VW5y9hhOTrCeWgkMQsyQyg68nfFezyS9JyI4QLSH6KtQc3IXCdRpfLUiNQS3O-gAn-m0hTwWw/pub?embedded=true"),
        new TopicNote(new DateTime(2022, 5, 23), "https://docs.google.com/document/d/e/2PACX-1vQt0pL6vRMtkfmWH_sSaMB8G76qdrGcyFDAivSmqVBbsUqATNtx6-RSYeH5wJHoow9G5xrybFsKHrzU/pub?embedded=true"),
        new TopicNote(new DateTime(2022, 5, 24), "https://docs.google.com/document/d/e/2PACX-1vTfOd-wbBHZphDmUBnIS-pAukS1ahIVeQEG786-fBiIb-06lNzz-DOzy3Twt42sAXfrTTAal8QFbNxL/pub?embedded=true"),
        new TopicNote(new DateTime(2022, 5, 25), "https://docs.google.com/document/d/e/2PACX-1vQPNC46AtNgPPVzefbv7vKPAKivklQ4Tse_gvFCCfenCRDFzH0Z_7Q1XEnx0Ub5cXbLlLJrqZpD9-5z/pub?embedded=true"),
        new TopicNote(new DateTime(2022, 5, 30), "https://docs.google.com/document/d/e/2PACX-1vQWdLhf2-ilLolrqUC1dRWhD_nx8D55fKVQCkYZjwgBAe9ni_M20eBVfL5S7Lpuh3vJA97OPfHIzKpN/pub?embedded=true"),
        new TopicNote(new DateTime(2022, 5, 31), "https://docs.google.com/document/d/e/2PACX-1vTkADaXtbI_u6pfrZkJERwXMIeK9sGdRL4wCzGTHzEiL1GgUlLuVvpfAOg75sHP24QK0k6bZyDX8vaN/pub?embedded=true"),
        new TopicNote(new DateTime(2022, 6, 1), "https://docs.google.com/document/d/e/2PACX-1vRo-cNb7oAxxrFuwAHE5rVqNe-LE2MroKN0JCBOJFnaQbJf2fOXpfD1OxbTJ4R7mj39szoqeWLyR9D8/pub?embedded=true"),
        new TopicNote(new DateTime(2022, 6, 2), "https://docs.google.com/document/d/e/2PACX-1vQ5F0KF3NTcqXUgxWDTmzf63ROc0y9WHggT6TE6rZC2TDIewl42Hxw7E0PXaLP3NNogHXHIQDu62PA1/pub?embedded=true"),
        new TopicNote(new DateTime(2022, 6, 3), "https://docs.google.com/document/d/e/2PACX-1vTnrBefzoOao5WamdrgEA2trUzrU31QVEC-XzMSapMBhP54JbovxVLJh4_LWO6eMPo7mzwvqUzginRb/pub?embedded=true"),
        new TopicNote(new DateTime(2022, 6, 7), "https://docs.google.com/document/d/e/2PACX-1vS0rW_HtqHFr6NU0MGoMQqnBOvq5AAbjubkeofZWpDRSYtV3vph6e0dhGxD3fC1MbNQbrZTBYtZANZz/pub?embedded=true")
      }, 10);
    }

    private static void CreateTopicNotes(List<TopicNote> topicNotes, ushort mainIndex, ushort? subIndex = null, ushort? subSubIndex = null)
    {
      GetTopic(mainIndex, subIndex, subSubIndex).TopicNotes.AddRange(topicNotes);
    }
  }
}
