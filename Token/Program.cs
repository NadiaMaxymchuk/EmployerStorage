using Token;

var builder = WebApplication.CreateBuilder(args);

// Manually create an instance of the Startup class
var startup = new Startup(builder.Configuration);

// Manually call ConfigureServices()
startup.ConfigureServices(builder.Services);

var app = builder.Build();

startup.Configure(app);

app.MapGet("/", () => "Hello World!");


app.Run();
