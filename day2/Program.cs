//var lines = File.ReadAllLines("test.txt");
var lines = File.ReadAllLines("input.txt");

//Part1(lines);
Part2(lines);


void Part1(string[] lines)
{
  var sum = 0;
  foreach(var line in lines)
  {
    var x = line.Split(':');
    var gameId = int.Parse(x[0].Split(' ')[1]);
    var games = x[1].Split(';');
    var p = true;
    foreach(var game in games)
    {
      var cubes = game.Split(',');
      foreach(var cube in cubes)
      {
        var y = cube.Trim().Split(' ');
        var n = int.Parse(y[0]);
        var color = y[1];
        if (color == "red" && n > 12)
          p = false;
        else if (color == "green" && n > 13)
          p = false;
        else if (color == "blue" && n > 14)
          p = false;
      }
    }
    if (p)
      sum += gameId;
  }

  Console.WriteLine(sum);
}


void Part2(string[] lines)
{
  var sum = 0;
  foreach(var line in lines)
  {
    var x = line.Split(':');
    var gameId = int.Parse(x[0].Split(' ')[1]);
    var cubes = x[1].Split(';').SelectMany(x => x.Split(','));
    int r = 1;
    int b = 1;
    int g = 1;
    foreach(var cube in cubes)
    {
      var y = cube.Trim().Split(' ');
      var n = int.Parse(y[0]);
      var color = y[1];
      if (color == "red" && n > r)
        r = n;
      else if (color == "green" && n > g)
        g = n;
      else if (color == "blue" && n > b)
        b = n;
    }
    sum += r * b * g;
  }

  Console.WriteLine(sum);
}