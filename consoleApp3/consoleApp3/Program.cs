using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter player name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter player Team name: ");
            String teamname = Console.ReadLine();
            Console.WriteLine("Enter no of matches: ");
            int noOfMatches = int.Parse(Console.ReadLine());

            long totalRaidPoints = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter total Defence points: ");
            long totalDefencePoints = long.Parse(Console.ReadLine());
            IKabbadiPlayerStatistics kabbadiPlayerStatistics = new Student(name, teamname, noOfMatches, totalRaidPoints, totalRaidPoints);
            kabbadiPlayerStatistics.DisplayKabbadiPlayerDetails();
        }
        interface IKabbadiPlayerStatistics
        {
            void DisplayKabbadiPlayerDetails();
        }
        class Student : IKabbadiPlayerStatistics
        {
            String name;
            String teamname;
            int noOfMatches;
            long totalRaidPoints;
            long totalDefencePoints;
            string teamMembers;
           



            public Student(String name, String teamname, int noOfMatches, long totalRaidPoints, long totalDefencePoints)
            {
                this.name = name;
                this.teamname = teamname;
                this.noOfMatches = noOfMatches;
                this.totalRaidPoints = totalRaidPoints;
                this.totalDefencePoints = totalDefencePoints;
            }
            public void DisplayKabbadiPlayerDetails()
            {
                Console.WriteLine("Player Details");
                Console.WriteLine("Player name: " + name);
                Console.WriteLine("Team name: " + teamname);
                Console.WriteLine("No of matches: " + noOfMatches);
                Console.WriteLine("Total raid points: " + totalRaidPoints);
                Console.WriteLine("Total defence points: " + totalDefencePoints);



            }

        }
    }
}
