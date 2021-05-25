using System;
namespace MaratonaTreinamento.Model
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SiteOrigem { get; set; }
        public int DifficultyLevel { get; set; }
        public string NecessaryKnowledge { get; set; }
        public string Description { get; set; }
        public string AuthorsComment { get; set; }
    }
}
