using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = CreatePost();
            
            while (true) {
                var input = Console.ReadLine();

                switch (input)
                {
                    case "up":
                        post.Upvote();
                        Console.WriteLine("The number of votes has increased to {0}", post.VoteValue);

                        break;
                    case "down":
                        post.Downvote();
                        Console.WriteLine("The number of votes has decreased to {0} ", post.VoteValue);

                        break;
                    case "display":
                        Console.WriteLine();
                        Console.WriteLine("Current votes {0} ", post.VoteValue);
                        break;
                }
                if (input == "exit") { break; };
            }
        }

        static Post CreatePost()
        {
            Console.Write("Title: ");
                string _titlePost = Console.ReadLine();
            Console.Write("Description: ");
            string _desc = Console.ReadLine();

            var post = new Post(_titlePost, _desc);

            DisplayInfo(post);

            return post; 
        }

        static void  DisplayInfo(Post post)
        {
            Console.WriteLine();
            Console.WriteLine(@"---------------");
            Console.WriteLine(@"<Post information>");
            Console.WriteLine("Title < {0} >", post.Title);
            Console.WriteLine("Description < {0} >", post.Description);
            Console.WriteLine("Time < {0} >", post.DateTimeCreation);
        }
    }
}
