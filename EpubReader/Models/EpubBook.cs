using System.Collections.Generic;

namespace EpubReader.Models
{
    public class EpubBook
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public List<EpubChapter> Chapters { get; set; } = new List<EpubChapter>();
        public string CoverImagePath { get; set; } = string.Empty;
    }

    public class EpubChapter
    {
        public string Title { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public int Order { get; set; }
        public string Content { get; set; } = string.Empty;
    }
}
