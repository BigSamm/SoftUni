using MishMash.App.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace MishMash.App.ViewModels.Channels
{
    public class BaseChannelViewModel
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public ChannelType Type { get; set; }
        
        public int FollowersCount { get; set; }
    }
}