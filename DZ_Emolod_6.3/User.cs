using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Emolod_6._3
{
    internal class User
    {
        static int autoInc = 0;
        private int id = 0;
        private string name = "";

        public User(string name) {
            this.name = name;
            this.id = ++autoInc;
        }
        public int getId() { return id; }
        public string getName() { return name; } 
    }
}
