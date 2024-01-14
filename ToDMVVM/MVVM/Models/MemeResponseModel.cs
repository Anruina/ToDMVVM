using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDMVVM.MVVM.Models
{
    public class MemeResponseModel
    {
        string PostLink;
        string Subreddit;
        string Title;
        string URL;
        bool NSFW;
        bool Spoiler;
        string Author;
        int Ups;
        string[] Preview;
    }
}
