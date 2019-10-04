using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class Post
    {
        private string _title;
        private string _description;
        private DateTime _datecreation;
        private int _votevalue;

        public DateTime DateTimeCreation { get { return _datecreation; } }
        public string Description { get { return _description;} }
        public string Title { get { return _title;} }
        public int VoteValue { get { return _votevalue; } } 


        public Post(string title, string desc)
        {
            _title = title;
            _description = desc;
            _datecreation = DateTime.Now;
            _votevalue = 0;
        }

        public void Upvote()
        {
            _votevalue++;
        }

        public void Downvote()
        {
            _votevalue--;
        }
    }
}
