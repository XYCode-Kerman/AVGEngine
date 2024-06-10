public class Variable
{
    public string name { get; set; }
    public string default_value { get; set; } = "None";
}

public class Conversation
{
    public string cond { get; set; }
    public string speaker { get; set; }
    public string speaker_img { get; set; }
    public string background_img { get; set; }
    public string content { get; set; }
}

public class Section
{
    public string cond { get; set; } = "True";
    public string name { get; set; }
    public string summary { get; set; }
    public string description { get; set; }
    public Conversation[] conversations { get; set; }
}


public class ADF
{
    public string name { get; set; }
    public string description { get; set; }
    public string version { get; set; }
    public string author { get; set; }
    public Variable[] variables { get; set; }
    public string[] keywords { get; set; }
    public string[] categories { get; set; }
    public string[] tags { get; set; }
    public Section[] sections { get; set; }
}
