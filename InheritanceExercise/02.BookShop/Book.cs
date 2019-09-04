namespace _02.BookShop
{
    using System;
    using System.Text;

    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public Book(string title, string author, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;

        }

        public virtual string Author
        {
            get => this.author;

            set
            {
                var input = value.Split();
                if (input.Length > 1)
                {
                    if (int.TryParse(input[1][0].ToString(), out int _))
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                }

                this.author = value;
            }
        }

        public string Title
        {
            get => this.title;

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }
        public virtual decimal Price
        {
            get => this.price;

            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:f2}");

            return sb.ToString().TrimEnd();
                
        }
    }
}
