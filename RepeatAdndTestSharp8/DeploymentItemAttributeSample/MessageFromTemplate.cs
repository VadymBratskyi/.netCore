using System;
using System.IO;

namespace DeploymentItemAttributeSample
{
    public class MessageFromTemplate
    {

        public string TepmplateFolder { get; set; }

        public string FromTemplate(string name, string level, DateTime creationTime) {

            var path = Path.Combine(TepmplateFolder, "ExamCreatedTemplate.txt");

            var template = File.ReadAllText(path);
            template = template.Replace("{Name}", name);
            template = template.Replace("{Level}", level);
            template = template.Replace("{DateAndTime}", creationTime.ToLongDateString());

            return template;
        }

    }
}
