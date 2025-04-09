Football leagues in Denmark is organised in tiers. The first tier (SuperLigaen) use the same tournament style as the second tier (NordicBetLigaen), which mean that handling scores is done in a uniform manner.

 

Each tier is composed of 12 teams, that play internally between themselves in 22 rounds, after which the tier is split into an upper and lower fraction, each consisting of 6 teams. Each fraction then play internally between themselves in 10 additional rounds, after which the table is then finished.

 

Your job is to implement a football processor application, that based on a lot of comma-separated files inside a directory can process and print the necessary information on the console as well as into a result file in the same directory.

 

There could be any number of files available, depending on the current data, so the processor should process any number of files from one end to the other, and after processing each file it must present the current table standings of the league. The files are all csv files (Comma Separated Values), so they can be edited in a spreadsheet easily.

 

Files includes are:

setup.csv
teams.csv
round-1.csv
round-2.csv
…
round-32.cvs
 

The setup file contain a line on the league setup, such as

League name
Number of positions to promote to Champions league 
(usually 1 in Superligaen, 0 in NordicBetLigaen, they have promotions instead)
Number of subsequent positions to promote to Europe league
Number of subsequent positions to promote to Conference League
Number of positions to promote to an upper league 
(when the above is all zero, these ones are show, so 2 in NordicBetLigaen, 0 in Superligaen)
Number of final positions that are to be relegated into a lower league (usually 2)
 

The teams file contains information about the individual clubs, Each club specify, in this order:

Abbreviation
Full club name
Special ranking 
(W-last years champion, C-Last years cup winner, P-Promoted team, R-Relegated team)
 

 

After having loaded the setup and teams file, the current standings must be presented. Each club is represented with a formatted line showing the following information

Position in the table
Special marking in parentheses
Full club name
Games played
Number of games won
Number of games drawn
Number of games lost
Goals for
Goals against
Goal Difference
Points achieved
Current winning streak (up to 5 latest played games represented as W|D|L for win, draw, loss, or just a dash when no such streak is present)
 

The list is sorted such that order is:

By points
By goal difference
By goals for
By goals against
Alphabetically 
 

The position is calculated per team based on the same sorting, except that two clubs with the same points and goal figures must have the same position.

 

In case multiple teams have the same position, only the first team shows the position number, and the rest inherit this number by showing a dash instead.

 

Example:

 

Pos

 

Team

M

W

D

L

GF

GA

GD

P

Streak

1

(P)

Lyngby Boldklub (LBK)

1

1

0

0

1

0

1

3

W-

-

 

Odense Boldklub (OB)

1

1

0

0

1

0

1

3

W-

…

 

 

 

 

 

 

 

 

 

 

 

11

 

Brøndby IF (BIF)

1

0

0

1

0

1

-1

0

L-

-

 

FC København (FCK)

1

0

0

1

0

1

-1

0

L-

 

 

The top lines should be individually coloured to show CL, EL, EC qualification or promotion qualification and the last lines should be individually coloured to show the relegation threat. Apart from that, easy colouring would be nice, such as green, amber, red in streaks, if possible, and/or anything to make it pleasing to the user (Strive to make it look the best to a user, always)

 

When processing the individual rounds, the file contains the following items

Home team abbreviated
Away team abbreviated
Score (x-y) where x is home team goals and y is away team goals
Other data may exist after that.
 

 

 

When processing each round, the rules should apply

 

In case of error, processing should stop and no further processing should be done, clearly stating where the processing stopped and what the problem was (With a human explanation, not some creepy algorithmic expression)
Only teams known from teams file should be processed (even though other results may be in there)
During the first 22 rounds, you can only play against the same team in one home and one away match. After 22 rounds, the same applies again, but this time for teams inside each fraction
In Denmark you are not allowed to play against yourself
If games had to be cancelled and postponed, they would reside in a file called round-x-a.csv, where the a represents an incremental additional number.
For the initial rounds, only a league table is shown. After the split, two tables of the upper and lower fraction must be presented separately
Any custom rules you deem necessary, which are then explainedMarking & Deliverables
 

The project can be handed in as a link to a GitHub repository or as a git bundle.

 

You can work in groups of up to 3 people, but each must make a valuable contribution, and be easily identified in each git commit.

 

The solution must contain a markdown document outlining the solution, the usage (how I should read it), and the rule/error help information (README.md)



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
 
 
