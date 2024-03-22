using ConsoleApp;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

try
{
    Log.Information("Start");

    var pathToTexts = Path.Combine(Directory.GetCurrentDirectory(), "Texts", "labeledTrainData.tsv");
    var pathToStopWords = Path.Combine(Directory.GetCurrentDirectory(), "StopWords", "stop-words.txt");
    var pathToLemmitization = Path.Combine(Directory.GetCurrentDirectory(), "Lemmitization", "lemmitization.lem");
    
    await ApplicationRunner.RunAsync(pathToTexts, pathToStopWords, pathToLemmitization);
}
finally
{
    Log.CloseAndFlush();
}