using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_Emolod_6._3
{
    public partial class Form1 : Form
    {
        List<Comment> comments = new List<Comment>();
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                comments.Add(new Comment(new User("user" + i), "Comment "+i));
            }
        }
               
    }
}
