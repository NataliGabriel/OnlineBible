using System.Text.Json.Serialization;

namespace APIBible.Data
{
    public class ResponseData
    {
        public BibleModel[] bible { get; set; }
    }
    public class BibleModel
    {
        public string name { get; set; }
        public string chapters { get; set; }
        public abbrev abbrev { get; set; }

    }
    public class abbrev
    {
        public string pt { get; set; }
        public string en { get; set; }
    }
    public class FindBooks
    {
        public abbrev abbrev { get; set; }
        public string Author { get; set; }
        public int Chapters { get; set; }
        public string Comment { get; set; }
        public string Group { get; set; }
        public string Name { get; set; }
        public string Testament { get; set; }
    }
    public class FindVerses
    {
        public abbrev Abbrev { get; set; }
        public string Name { set; get; }
        public string Author { set; get; }
        public string Group { get; set; }
        public string Version { get; set; }
    }
    public class Chapter
    {
        public int Number { get; set; }
        public int Verses { get; set; }
    }
    public class Verse
    {
        public int Number { get; set; }
        public string Text { get; set; }
    }
    public class Scripture
    {
        public FindVerses Book { get; set; }
        public Chapter Chapter { get; set; }
        public Verse[] verses { get; set; }
    }
}
