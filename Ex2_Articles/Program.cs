using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex2_Articles
{
    namespace _Articles
    {
        class Articles
        {
            public string Title;
            public string Content;
            public string Author;

            public Articles(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }

            public void Edit(string newContent)
            {
                this.Content = newContent;
            }

            public void ChangeAuthor(string newAuthor)
            {
                this.Author = newAuthor;
            }

            public void Rename(string newTitle)
            {
                this.Title = newTitle;
            }

            public override string ToString()
            {
                return Title + " - " + Content + ": " + Author;
            }
        }



        class Program
        {
            static void Main(string[] args)
            {

                string q = Console.ReadLine();
                List<string> parameters = q.Split(", ").ToList();
                int count = int.Parse(Console.ReadLine());

                Articles article = new Articles(parameters[0], parameters[1], parameters[2]);


                for (int i = 0; i < count; i++)
                {
                    List<string> currCommand = Console.ReadLine().Split(": ").ToList();


                    if (currCommand[0] == "Edit")
                    {
                        article.Edit(currCommand[1]);
                    }


                    if (currCommand[0] == "ChangeAuthor")
                    {
                        article.ChangeAuthor(currCommand[1]);
                    }


                    if (currCommand[0] == "Rename")
                    {
                        article.Rename(currCommand[1]);
                    }
                }

                Console.WriteLine(article.ToString());
            }
        }
    }
}