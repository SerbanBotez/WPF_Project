using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using WpfApp.Model;

namespace WpfApp.ViewModel
{
    public class QuestionViewModel
    {

        public QuestionViewModel()
        {
           LoadQuestions();
        }

        public ObservableCollection<Question> Questions
        {
            get;
            set;
        }

        public void LoadQuestions()
        {
            ObservableCollection<Question> questions = new ObservableCollection<Question>();

            XmlDocument xDoc = new XmlDocument();
            string resource = "C:\\Users\\Serban\\Desktop\\StoreApplication\\StoreApplication\\QuestionsList.xml";
            xDoc.Load(resource);

            string inputDiff = "easy";
            int questionsNumber = 1;
            var random = new Random();

            List<String> viableQuestions = new List<String>();

            foreach (XmlNode node in xDoc.DocumentElement)
            {
                string diff = node.Attributes[1].InnerText;
                if (diff.Equals(inputDiff))
                {
                    viableQuestions.Add(node.Attributes[0].InnerText);
                }

            }

            for (int i = 1; i <= questionsNumber; i++)
            {
                int index = random.Next(viableQuestions.Count);
                //MessageBox.Show(viableQuestions[index]);

                foreach (XmlNode node in xDoc.DocumentElement)
                {
                    string name = node.Attributes[0].InnerText;
                    if (name == viableQuestions[index])
                    {
                        Question q1 = new Question();

                        foreach (XmlNode child in node.ChildNodes)
                        {
                            if (child.Name == "difficulty")
                            {
                                q1.Difficulty = child.InnerText;
                            }

                            if (child.Name == "description")
                            {
                                q1.Description = child.InnerText;
                            }

                            if (child.Name == "response")
                            {
                                q1.AddResponse(child.InnerText);
                            }

                            if (child.Name == "correct_response")
                            {
                                q1.AddCorrectResponse(child.InnerText);
                            }

                        }
                    }
                }
                viableQuestions.RemoveAt(index);
            }

            Questions = questions;
        }
    }
}
