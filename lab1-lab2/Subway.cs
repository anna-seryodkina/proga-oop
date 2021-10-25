using System.Collections.Generic;

namespace lab1
{
    class Subway : Train
    {
        public string line;
        string currentStation;

        Dictionary<string, List<string>> lines_stations;


        public Subway()
        {
            this.line = "red";
            this.lines_stations = new Dictionary<string, List<string>>();
        }

        public Subway(string line, Dictionary<string, List<string>> lines_stations)
        {
            this.line = line;
            this.lines_stations = lines_stations;
        }

        public string CurrentStation
        {
            get
            {
                return this.currentStation;
            }
            set
            {
                if(lines_stations.TryGetValue(line, out List<string> list))
                {
                    if(list.Contains(value))
                    {
                        currentStation = value;
                    }
                }
                throw new LineNotExistException("Line does not exist: ", line);
            }
        }

        public void ShowCurrentStation()
        {

            System.Console.WriteLine("current station: " + currentStation);
        }
    }

}
