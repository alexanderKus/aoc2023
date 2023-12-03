
var input = "input.txt";

#if DEBUG
input = "test.txt";
#endif

var lines = File.ReadLines(input);
var sum = 0;

foreach(var line in lines)
{
  var number = string.Empty;
  foreach(var c in line) 
  {
    if (char.IsDigit(c))
    {
      number += c;
      break;
    }
  }
  foreach(var c in line.Reverse()) 
  {
    if (char.IsDigit(c))
    {
      number += c;
      break;
    }
  }
  sum += int.Parse(number);
}

Console.WriteLine(sum);