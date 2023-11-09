using System.Collections.Generic;

namespace Patrones
{
    public class EventLogger
    {
        private static EventLogger? Instance;
        private List<string> Events;
        private EventLogger()
        {
            this.Events = new List<string>();
        }
        public static EventLogger GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EventLogger();
            }
            return Instance;
        }

        public void AddEvent(string text)
        {
            this.Events.Add(text);
        }

        public void ShowEvents()
        {
            foreach (var text in Events)
            {
                Console.WriteLine(text);
            }
        }
    }
}