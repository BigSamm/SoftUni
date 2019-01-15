using MishMash.App.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MishMash.App.ViewModels.Channels
{
    public class ChannelViewModel
    {
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public ChannelType Type { get; set; }
        
        public IEnumerable<string> Tags { get; set; }
        
        public string TagsAsString => String.Join(", ", this.Tags);
        
        public int FollowersCount { get; set; }
    }
}