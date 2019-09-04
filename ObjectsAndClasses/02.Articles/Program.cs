using System;

namespace _02.Articles
{
    class Program
    {

        class Article
        {
            public Article(string title, string content, string author)

            {
                Title = title;
                Content = content;
                Author = author;
            }

            public string Title { get; set; }

            public string Content { get; set; }

            public string Author { get; set; }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }

            public void Edit(string newContent)
            {
                Content = newContent;
            }

            public void newTitle (string title)
            {
                Title = title;
            }
            public void newAuthor (string author)
            {
                Author = author;
            }

        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ");

            string title = input[0];
            string content = input[1];
            string author = input[2];

            int n = int.Parse(Console.ReadLine());

            Article article = new Article(title,content,author);

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(": ");

                string command = line[0];

                if (command == "Edit")
                {
                    string newContent = line[1];
                    article.Edit(newContent);
                    
                }
                else if (command == "ChangeAuthor")
                {
                    string newAuthor = line[1];
                    article.newAuthor(newAuthor);
                }
                else if (command == "Rename")
                {
                    string rename = line[1];
                    article.newTitle(rename);
                }
            }

            Console.WriteLine(article);
        }
    }
}
