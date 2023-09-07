using Coding.Exercise;

var cb = new CodeBuilder("Person")
    .AddField("Name", "string")
    .AddField("Age", "int");

Console.WriteLine(cb);