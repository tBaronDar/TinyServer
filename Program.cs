//Boiler plate and its explanation
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
//Creates a WebApplicationBuilder instance, which sets up the application with default configurations like dependency injection, logging, and configuration management.
//The args parameter allows you to pass command-line arguments to the application if needed.

//builder.Services.AddDbContext<WineDbContext>(options=>options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllers(); // Registers controllers as services.
//Registers controller services into the application’s dependency injection (DI) container.
//Controllers are classes that handle HTTP requests, and this line ensures that they are recognized and usable by the app.
//Without this, ASP.NET Core wouldn't know how to route requests to your controllers.


WebApplication app = builder.Build();
//Builds the WebApplication instance using the configurations and services added in the previous steps.
//This creates a pipeline that can process incoming HTTP requests and generate responses.

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())// In the begining only dev enviroment.
{
    app.UseDeveloperExceptionPage(); // For detailed error pages in development.
}
//Checks if the app is running in the Development environment (configured in launchSettings.json or the system environment variables).
//If it’s in development, it adds a middleware called DeveloperExceptionPage to show detailed error pages when an exception occurs.
//This is useful during development but should not be enabled in production.


app.UseHttpsRedirection(); // Redirect HTTP to HTTPS.
//Adds middleware to automatically redirect HTTP requests to HTTPS.
//This ensures your app enforces secure communication using SSL/TLS.

app.MapControllers(); // Automatically map routes for controllers.
//Automatically maps routes to any controllers you’ve defined in the project.
//For example:
//A controller with [Route("api/[controller]")] will map to /api/yourcontrollername.
//This eliminates the need to manually define every route.

app.Run();
//Starts the web application and begins listening for incoming HTTP requests.
//This is the entry point where the application runs indefinitely until it’s stopped.