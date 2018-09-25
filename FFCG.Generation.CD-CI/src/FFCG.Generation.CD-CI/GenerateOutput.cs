using System;

    namespace FFCG.Generation.CD_CI
    {
        public class GenerateOutput
        {
            public string GetInitialOutput()
            {
                return "Hello World";
            }

            public string GetPersonalGreeting(string name)
            {
                string personalGreeting = $"Hello {name}!";
                return personalGreeting;
            }
        }

    }
