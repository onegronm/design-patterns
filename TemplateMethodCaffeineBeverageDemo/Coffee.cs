using System;

namespace TemplateMethodCaffeineBeverageDemo
{
    public class Coffee : CaffeineBeverage
    {
        public override void brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void addCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override bool customerWantsCondiments()
        {
            string answer = getUserInput();

            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else return false;
        }

        private string getUserInput()
        {
            string answer = null;

            Console.Write("Would you like milk and sugar with your coffee (y/n)? ");

            try {
                answer = Console.In.ReadLine();
            } catch (Exception ex) {
                Console.WriteLine("IO error trying to read your answer");
            }

            if(answer == null) {
                return "no";
            }

            return answer;
        }
    }
}
