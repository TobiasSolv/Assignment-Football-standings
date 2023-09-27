using System.Globalization;
using System.Reflection.PortableExecutable;
using CsvHelper;
using CsvHelper.Configuration;




public class team
{
    public string teamName { get; set; }
    public int MatchesPlayed { get; set; }
    public int wins { get; set; }
    public int draws { get; set; }
    public int losses { get; set; }
    public string goals { get; set; }
    public int difference { get; set; }
    public int points { get; set; }

}

public class Map : ClassMap<team>
{
    public Map()
    {
        Map(m => m.teamName).Name("Team");
        Map(m => m.MatchesPlayed).Name("M");
        Map(m => m.wins).Name("W");
        Map(m => m.draws).Name("D");
        Map(m => m.losses).Name("L");
        Map(m => m.goals).Name("Goals");
        Map(m => m.difference).Name("Dif");
        Map(m => m.points).Name("Pt");
    }
}


public class teams1
{
    public string Abbreviation { set; get; }
    public string Full_club_name { set; get; }
    public string Special_ranking { set; get; }

}

public class setup
{
    public string League { set; get; }
    public int Positions_to_promote_to_Champions_league { set; get; }
    public int Europe_league { set; get; }
    public int Conference_League { set; get; }
    public int Upper_league { set; get; }
    public int Lower_league { set; get; }
}

public class run
{

    public static void Main()

    {
        Boolean istrue = true;
        while (istrue) {
            Console.WriteLine("\n1: all rounds \n" +
                "2: setup \n" +
                "3: teams: \n" +
                "4: Exit");
            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    ShowAllRounds();
                    break;
                case "2":
                    ShowSetup();
                    break;
                case "3":
                    ShowTeams();
                    break;
                case "4":
                    istrue = false;
                    break;  
                default:
                    Console.WriteLine("Invalid input. Please enter a valid option (1, 2, 3 or 4).");
                    break;

            }
        }

    }

    public static void ShowSetup()
    {
        const string setupFile = "setup.csv";

        if (File.Exists(setupFile))
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";"
            };

            using (var readSetup = new StreamReader(setupFile))
            using (var csv = new CsvReader(readSetup, config))
            {
                

               
                var setups = csv.GetRecords<setup>().ToList();

                Console.WriteLine("Read data from CSV file successfully.");

                
                Console.WriteLine("League\t\tPositions to Promote to Champions League\tEurope League\tConference League\tUpper League\tLower League");
                foreach (var setup in setups)
                {
                    Console.WriteLine($"{setup.League,-20}\t\t\t\t{setup.Positions_to_promote_to_Champions_league}\t\t\t{setup.Europe_league}\t\t{setup.Conference_League}\t\t\t{setup.Upper_league}\t\t{setup.Lower_league}");
                }
            }
        }
        else
        {
            Console.WriteLine($"The CSV file {setupFile} does not exist or can't access the file");
        }
    }

    public static void ShowTeams()
    {
        const string teamsFile = "teams.csv";

        if (File.Exists(teamsFile))
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";"
            };

            using (var readTeam = new StreamReader(teamsFile))
            using (var csv = new CsvReader(readTeam, config))
            {
                
                var teams = csv.GetRecords<teams1>().ToList();

                Console.WriteLine("Read data from CSV file successfully.");

                
                Console.WriteLine("Abbreviation\tFull club name\t\t\tSpecial ranking");
                foreach (var team in teams)
                {
                    Console.WriteLine($"{team.Abbreviation,-12}\t{team.Full_club_name,-30}\t{team.Special_ranking}");
                }
            }
        }
        else
        {
            Console.WriteLine($"The CSV file {teamsFile} does not exist or can't access the file");
        }
    }

    public static void ShowAllRounds()
    {

        List<string> roundFiles = new List<string>
        {
            "round1.csv", "round2.csv", "round3.csv", "round4.csv",
            "round5.csv", "round6.csv", "round7.csv", "round8.csv",
            "round9.csv", "round10.csv", "round11.csv", "round12.csv",
            "round13.csv", "round14.csv", "round15.csv", "round16.csv",
            "round17.csv", "round18.csv", "round19.csv", "round20.csv",
            "round21.csv", "round22.csv", "round23.csv", "round24.csv",
            "round25.csv", "round26.csv", "round27.csv", "round28.csv",
            "round29.csv", "round30.csv", "round31.csv", "round32.csv",
            "round33.csv", "round34.csv", "round35.csv", "round36.csv",
            "round37.csv", "round38.csv",
        };

        foreach (var roundFile in roundFiles)
        {
            Console.WriteLine($"Processing {roundFile}");

            List<team> teams;

            if (File.Exists(roundFile))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ";"
                };

                using (var readround = new StreamReader(roundFile))
                using (var csv = new CsvReader(readround, config))


                {
                    csv.Context.RegisterClassMap<Map>();
                    teams = csv.GetRecords<team>().ToList();

                }

                Console.WriteLine("Read data from CSV file successfully.");

            }
            else
            {
                Console.WriteLine($"The CSV file {roundFile} does not exist or can't access the file");
                continue;
            }


            teams = teams.OrderByDescending(t => t.points)
                         .ThenByDescending(t => t.difference)
                         .ToList();


            Console.WriteLine(new string('-', 98));
            Console.WriteLine("Position\tTeam\t\t\tM\tW\tD\tL\tGoals\t\tDif\tPt");
                for (int i = 0; i < teams.Count; i++)
                {
                    team team = teams[i];
                    Console.WriteLine($"{i + 1,-8}\t{team.teamName,-20}\t{team.MatchesPlayed,-4}\t{team.wins,-4}\t{team.draws,-4}\t{team.losses,-4}\t{team.goals,-8}\t{team.difference,-4}\t{team.points,-4}");
                }
            Console.WriteLine(new string('-', 98));
        }
    }
    }



