using System.ComponentModel.DataAnnotations;

namespace MishMash.App.ViewModels.Channels
{
    public class CreateChannelsViewModel
    {
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public string Tags { get; set; }
        
        public string Type { get; set; }
    }
}