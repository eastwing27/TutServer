using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace TutServer.Models
{
    public static class JsonModel
    {
        public static List<Answer> Answers { get; private set; }

        static public void Load()
        {
            if (!File.Exists("answers.json"))
            {
                Answers = new List<Answer>()
                {
                    new Answer()
                    {
                        Rating = 3,
                        Author = "Гершель Парасюк",
                        Date = DateTime.UtcNow,
                        Content = "Angular!"
                    },

                    new Answer()
                    {
                        Rating = -5,
                        Author = "Алан",
                        Date = DateTime.UtcNow,
                        Content = "React!!11"
                    },

                    new Answer()
                    {
                        Rating = 23,
                        Author = "Гершель Парасюк",
                        Date = DateTime.UtcNow,
                        Content = "Реакт - это не фреймворк, олень"
                    }
                };

                Save();
            }

            var json = File.ReadAllText("answers.json");
            Answers = JsonConvert.DeserializeObject<List<Answer>>(json);
        }

        static public void Save()
        {
            var json = JsonConvert.SerializeObject(Answers);
            File.WriteAllText("answers.json", json);
        }
    }
}
