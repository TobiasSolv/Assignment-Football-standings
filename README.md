# Assignment-Football-standings

public class team makes getter and setter for the headlines in the csv for all rounds. 

public class Map maps csv colums to the class team properties.

publich class teams1 makes getter and setter for the headlines in the csv for teams.

publich class setup makes getter and setter for the headlines in the csv for setup.

publich class run is where all actions is being done. 

public static void Main has a switch where you can type the number to get all rounds, setup, teams and exit.
It is wrapped around with a while loop, where you can press the number for exit to get out and close the program.

public static void ShowSetup shows all data there is in the setup.csv file.
It first checks if the setupFile file exist using File.Exists(setupFile).
If it exist it then read the csv file using CsvHelper libary.
Then it configures the CsvHelper to use ";" as the delimiter for the csv file.
It uses StreamReader to read the setup file and use the CsvReader to parse the csv data.
Then it reads the data from the csv file and maps it to a list that represent the data read.
It then prints a message that the data has been read.
Then prints the header row for the table.
It then enters a foreach loop to go through each setup object in the list.
In the loop it prints the value.
If the setup.csv file does not exist or can't be accessed, it prints an error message.

 public static void ShowTeams does basically the same as public static void ShowSetup.
 The only difference is the csv file which in this case is teams.csv.

 public static void ShowAllRounds is also showing all data there is in all rounds files.
 First makes a list of all 38 rounds csv files.
 Then use for each loop to iterate through each round file in the list.
 It then displays a massege that it is processing the specific round file.
 It checks if the file exist.
 If the file exist it then configures CsvHelper with delimiter (";"). 
 In the using block maps the columns in the csv file to the properties of the team class.
 Then it reads the data from the csv file into a list.
 It then prints a message if the data has been successfully read from the csv file.
 If the file does not exist or can't acces it, it prints an error message and then countinues to the next file.
 Then it sorts the teams based on their points and goal difference.
 It then prints dashes after that it prints the headers.
 Then loops through the team and prints the data for each team.
 And lastly prits dashes.
 
 
