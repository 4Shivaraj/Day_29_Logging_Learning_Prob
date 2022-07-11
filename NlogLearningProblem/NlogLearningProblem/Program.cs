namespace NlogLearningProblem
{
    class Proogram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The First Number :");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Second Number :");
            int second = Convert.ToInt32(Console.ReadLine());

            Addition.sum(first, second);
        }
    }
}


//Notes
//Need To Change Comment Both @ 27 and 36 line which was there earlier
//Need To Specify Path of .txt as 28 Line
//Go To Property of Nlog.config and change it to Build Action -> Content & Copy if newer

//Changes To Be Made in Nlog.config
/*

    < !--
    Write events to a file with the date in the filename. -->
	<target xsi:type = "File" name = "f" fileName = "C:\\Users\\4shiv\\OneDrive\\Desktop\\Learning Problem\\NlogLearningProblem\\NlogLearningProblem\\LoggerFiles\\LogData.txt"
            layout = "${longdate} ${uppercase:${level}} ${message}" /> 
    -->
</ targets >

  < rules >
    < !--add your logging rules here -->

    <!--
    Write all events with minimal level of Debug (So Debug, Info, Warn, Error and Fatal, but not Trace)  to "f"-- >
    < logger name = "*" minlevel = "Debug" writeTo = "f" />
    -->
  </ rules >
</ nlog >

*/

//Result
//Negative Case
//Enter The First Number :
//34
//Enter The Second Number :
//65

//2022 - 07 - 11 22:04:46.4576 WARN Input Should Not Be 0 Or Less Than Zero
//2022-07-11 22:04:46.5488 ERROR Input Should Be Positive Number

//Positive Case
//Enter The First Number :
//34
//Enter The Second Number :
//65

//2022 - 07 - 11 22:04:59.1418 DEBUG Debug Succesfull with sum operation
//2022-07-11 22:04:59.2694 INFO Succesfully completed and Sum is99
