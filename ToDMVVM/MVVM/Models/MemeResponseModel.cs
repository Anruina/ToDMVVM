using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDMVVM.MVVM.Models
{
    public class MemeResponseModel
    {
        public string? PostLink { get; set; }
        public string? Subreddit {  get; set; }
        public string? Title { get; set; }
        public string? URL { get; set; }
        public bool NSFW { get; set; }
        public bool Spoiler { get; set; }
        public string? Author { get; set; }
        public int Ups { get; set; }
        public string[]? Preview { get; set; }
    }
}
