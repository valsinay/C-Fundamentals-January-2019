using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Tagram
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> listPerson = new List<Person>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                if (line.Contains("ban"))
                {
                    string[] tokens = line.Split();
                    string name = tokens[1];

                    for (int i = 0; i < listPerson.Count; i++)
                    {
                        if (listPerson[i].Username==name)
                        {
                            listPerson.Remove(listPerson[i]);
                            i--;
                        }
                    }
                }
                else
                {
                    string[] tokens = line.Split(" -> ");
                    string name = tokens[0];
                    string tag = tokens[1];
                    int likes = int.Parse(tokens[2]);

                    TagsAndLikes tagsAndLikes = new TagsAndLikes(tag, likes);

                    Person person = new Person(name, new List<TagsAndLikes>());
                    person.PersonTagsLikes.Add(tagsAndLikes);


                    bool wasAdded = false;
                    foreach (var personn in listPerson)
                    {
                        if (personn.Username == name)
                        {
                            personn.PersonTagsLikes.Add(tagsAndLikes);
                            wasAdded = true;
                            break;
                        }
                    }
                    if (!wasAdded)
                    {
                        listPerson.Add(person);
                    }
                }
            }
            var filteredList = listPerson.OrderByDescending(x => x.PersonTagsLikes.Select(y => y.Likes).Sum())
                .ThenBy(x => x.PersonTagsLikes.Select(y => y.Tags).Count());

            foreach (var person in filteredList)
            {
                Console.Write(person);
            }
        }
    }

    public class Person
    {
        public Person(string username, List<TagsAndLikes> personTagsLikes)
        {
            this.Username = username;
            this.PersonTagsLikes = personTagsLikes;
        }

        int sum = 0;

        public string Username { get; set; }

        public List<TagsAndLikes> PersonTagsLikes { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Username}");

            foreach (var person in PersonTagsLikes)
            {
                sb.AppendLine($"- {person.Tags}: {person.Likes}");

            }
            return sb.ToString();
        }
    }

    public class TagsAndLikes
    {

        public TagsAndLikes(string tags, int likes)
        {
            this.Tags = tags;
            this.Likes = likes;
        }

        public string Tags { get; set; }

        public int Likes { get; set; }
    }
}
