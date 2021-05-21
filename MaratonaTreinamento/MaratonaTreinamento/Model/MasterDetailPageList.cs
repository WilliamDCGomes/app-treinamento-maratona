using System;
namespace MaratonaTreinamento.Model
{
    public class MasterDetailPageList
    {
        public string Icon { get; set; }
        public string Title { get; set; }

        public MasterDetailPageList(string icon, string title)
        {
            Icon = icon;
            Title = title;
        }
    }
}
