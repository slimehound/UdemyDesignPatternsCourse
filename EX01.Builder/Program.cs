using Coding.Exercise;

CodeBuilder cb = new("Person")
    .AddField("Name", "string")
    .AddField("Age", "int");

Console.WriteLine(cb);