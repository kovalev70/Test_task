public record Train(string Destination, int TrainNumber, string DepartureTime);

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        var trains = new Train[]
        {
            new Train("Москва", 5, "17:00"),
            new Train("Анапа", 1, "11:30"),
            new Train("Саратов", 8, "09:00"),
            new Train("Мурманск", 15, "22:20"),
            new Train("Екатеринбург", 4, "11:00")
        };

        app.MapGet("/train/{trainNumber}", (int trainNumber) =>
        {
            var train = trains.FirstOrDefault(t => t.TrainNumber == trainNumber);
            return train != null ? Results.Ok(train) : Results.NotFound();
        });

        app.MapGet("/trains/sorted", () =>
        {
            var sortedTrains = trains.OrderBy(t => t.Destination).ThenBy(t => t.DepartureTime);
            return Results.Ok(sortedTrains);
        });

        app.MapGet("/trains/upcoming", () =>
        {
            var now = DateTimeOffset.UtcNow;
            var upcomingTrains = trains.Where(t => DateTime.Parse(t.DepartureTime) > now);
            return Results.Ok(upcomingTrains);
        });

        app.UseSwagger();
        app.UseSwaggerUI();

        app.Run();
    }
}