using System;
using System.IO;
using System.Xml;


namespace FileIOExercises
{
    class Program
    {

        struct User
        {
            public string FirstName;
            public string LastName;
            public string Profession;
            public Address Address;
        }

        struct Address
        {
            public string Street;
            public string City;
            public string State;
            public string Zip;
        }

        static void Main(string[] args)
        {
            //string filePath = @"C:\Users\Akimi Yano\Desktop\git_repos\csharp-stack\csharp_tutorials\FileIOExercises\sampleText.txt";

            //// read with File:
            //string fileContents = File.ReadAllText(filePath);
            //Console.WriteLine(fileContents);

            //// read with StreamReader:
            //using (var reader = new StreamReader(filePath))
            //{
            //    while (!reader.EndOfStream)
            //    {
            //        var line = reader.ReadLine();
            //        Console.WriteLine(line);
            //    }
            //}

            //// write with File:
            //filePath = @"C:\Users\Akimi Yano\Desktop\git_repos\csharp-stack\csharp_tutorials\FileIOExercises\sampleText2.txt";
            //var s = "Hello World!";
            //File.WriteAllText(filePath, s);

            //// write with File - append:
            //File.AppendAllText(filePath, s);

            //// write with StreamWriter:
            //bool append = true;

            //using (var sw = new StreamWriter(filePath, append))
            //{
            //    sw.WriteLine(s);
            //}


            string file = @"C:\Users\Akimi Yano\Desktop\git_repos\csharp-stack\csharp_tutorials\FileIOExercises\sampleText3.txt";

            // create the xml document
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(file);

            // get all the user nodes
            var userNodes = xmlDoc.SelectNodes("//User");

            // create an array to hold all the users
            var users = new User[userNodes.Count];

            // parse each user into a user object
            int userIndex = 0;
            foreach (XmlElement element in userNodes)
            {
                // parse the user fields
                var user = new User();
                user.FirstName = element.GetAttribute("FirstName");
                if (element.HasAttribute("LastName"))
                    user.LastName = element.GetAttribute("LastName");
                user.Profession = element.GetAttribute("Profession");

                // parse the address fields
                var addressElement = (XmlElement)element.FirstChild;
                var address = new Address();
                address.Street = addressElement.GetAttribute("Street");
                address.City = addressElement.GetAttribute("City");
                address.State = addressElement.GetAttribute("State");
                address.Zip = addressElement.GetAttribute("Zip");

                // assign the address to the current user
                user.Address = address;

                // add the current user to the array
                users[userIndex] = user;
                userIndex++;
                Console.WriteLine($"{user.FirstName},{user.LastName},{user.Profession},{user.Address.Street},{user.Address.City},{user.Address.State},{user.Address.Zip}");
            }

            users[0].LastName = "Yamamoto";
            users[1].Address.City = "Tokyo";

            foreach (var person in users)
            {
                Console.WriteLine($"{person.FirstName},{person.LastName},{person.Profession},{person.Address.Street},{person.Address.City},{person.Address.State},{person.Address.Zip}");
            }

            userNodes = xmlDoc.SelectNodes("//User");

            var settings = new XmlWriterSettings();
            settings.Indent = true;
            string outputFile = @"C:\Users\Akimi Yano\Desktop\git_repos\csharp-stack\csharp_tutorials\FileIOExercises\sampleText4.txt";
            using (var sw = XmlWriter.Create(outputFile, settings))
            {
                sw.WriteStartDocument();
                sw.WriteStartElement("Users");
                foreach (var user in users)
                {
                    sw.WriteStartElement("User");

                    sw.WriteAttributeString("FirstName", user.FirstName);
                    sw.WriteAttributeString("LastName", user.LastName);
                    sw.WriteAttributeString("Profession", user.Profession);

                    sw.WriteStartElement("Address");
                    sw.WriteAttributeString("Street", user.Address.Street);
                    sw.WriteAttributeString("City", user.Address.City);
                    sw.WriteAttributeString("State", user.Address.State);
                    sw.WriteAttributeString("Zip", user.Address.Zip);
                    sw.WriteEndElement();

                    sw.WriteEndElement();
                }

                sw.WriteEndElement();
                sw.WriteEndDocument();
            }


        }


        }
    }

