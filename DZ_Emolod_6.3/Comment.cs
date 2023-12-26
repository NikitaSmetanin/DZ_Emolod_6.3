using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Emolod_6._3
{
    
    internal class Comment
    {
        Random random = new Random();
        static int autoInc = 0;
        private int id = 0;
        private string text = "";
        private User user = null;
        private int like = 0;
        private int dislike = 0;

        public Comment(User user, string text)
        {
            this.text = text;
            this.user = user;
            //this.id = ++autoInc;
        }

        public int getId() { return id; }
        public string getText() { return text; }
        public User getUser() { return user; }
        public int getLike() { return like;}
        public int getDislike() {  return dislike;}
        public void setLike(int like) {  this.like = like;}
        public void setDislike(int dislike) {  this.dislike = dislike;}
    }
}
