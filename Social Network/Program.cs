using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            Post post = new Post();
            post.Text = postText;
            post.ShowPost();


        }

        class Post
        {
            private string text;
            public string Text
            {
                get { return text; }
                set { text = value; }
            }
            //write a constructor here


            public void ShowPost()
            {
                Console.WriteLine("New post");
                Console.WriteLine(text);
            }

            //write a property for member text

        }



    }
}
