
var input = "input.txt";
//var input = "input2.txt";
//var input = "test.txt"; // for part 1
//var input = "test2.txt"; // for part 2

//Part1(input);
Part2(input);

static void Part1(string input)
{
  var lines = File.ReadLines(input);
  var sum = 0;

  foreach(var line in lines)
  {
    var first = line.First(char.IsDigit);
    var last = line.Last(char.IsDigit);
    var number = first * 10 + last;
    sum += number;
  }

  Console.WriteLine(sum);
}


static void Part2(string input)
{
  var lines = File.ReadLines(input);
  var sum = 0;
  Dictionary<string, int> x = new()
  {
    { "1" , 1},
    { "2" , 2},
    { "3" , 3},
    { "4" , 4},
    { "5" , 5},
    { "6" , 6},
    { "7" , 7},
    { "8" , 8},
    { "9" , 9},
    { "one" , 1},
    { "two" , 2},
    { "three", 3},
    { "four", 4},
    { "five", 5},
    { "six", 6},
    { "seven", 7},
    { "eight", 8},
    { "nine", 9},
  };

  foreach(var line in lines)
  {
    var firstValue = 0;
    var lastValue = 0;
    var firstIndex = line.Length;
    var lastIndex = -1;

    foreach(var (k, v) in x)
    {
      var index = line.IndexOf(k);
      if (index == -1)
      {
        continue;
      }

      if (index < firstIndex)
      {
        firstIndex = index;
        firstValue = v;
      }

      index = line.LastIndexOf(k);
      if (index > lastIndex)
      {
        lastIndex = index;
        lastValue = v;
      }
    }
    var number = firstValue * 10 + lastValue;
    sum += number;
  }
  Console.WriteLine(sum);
}