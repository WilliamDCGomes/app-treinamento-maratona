using System;
using Xamarin.Forms;

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

        public string GetColor
        {
            get
            {
                switch (DifficultyLevel)
                {
                    case 1:
                        return Color.Green.ToHex().ToString();
                        break;
                    case 2:
                        return Color.Blue.ToHex().ToString();
                        break;
                    case 3:
                        return Color.Purple.ToHex().ToString();
                        break;
                    case 4:
                        return Color.Orange.ToHex().ToString();
                        break;
                    case 5:
                        return Color.Red.ToHex().ToString();
                        break;
                }
                return Color.Yellow.ToHex().ToString();
            }
        }
        public string GetImagebackground
        {
            get
            {
                switch (DifficultyLevel)
                {
                    case 1:
                        return "beginnerLevel.jpg";
                        break;
                    case 2:
                        return "postBeginnerLevel.jpg";
                        break;
                    case 3:
                        return "intermediateLevel.jpg";
                        break;
                    case 4:
                        return "postIntermediateLevel.png";
                        break;
                    case 5:
                        return "hardLevel.png";
                        break;
                }
                return "";
            }
        }
    }
}
