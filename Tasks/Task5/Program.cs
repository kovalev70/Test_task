using System.Text.Json;
using Task5.Abstractions;
using Task5.Enums;
using Task5.FigureValues;
using Task5.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapPost("/calculateFigures", async (HttpContext context, int count, FigureType type) =>
{
    List<Figure> figures = new List<Figure>();

    for (int i = 0; i < count; i++)
    {
        Figure figure = null;
        Random rnd = new Random();
        int randomFigure = rnd.Next(0, 4);

        switch (type)
        {
            case FigureType.Rectangle:
                var rectangleValues = RectangleValues.GetRectangleValues();
                (double width, double height) = rectangleValues[randomFigure];
                figure = new Rectangle(width, height);
                break;

            case FigureType.Circle:
                var circleValues = CircleValues.GetCircleValues();
                double radius = circleValues[randomFigure];
                figure = new Circle(radius);
                break;

            case FigureType.Triangle:
                var triangleValues = TriangleValues.GetTriangleValues();
                (double sideA, double sideB, double sideC) = triangleValues[randomFigure];
                figure = new Triangle(sideA, sideB, sideC);
                break;

            default:
                break;
        }

        figures.Add(figure);
    }

    string response = JsonSerializer.Serialize(figures.Select(f => new { Info = f.GetInfo() }));
    context.Response.ContentType = "application/json";

    await context.Response.WriteAsync(response);
});

app.UseSwagger();
app.UseSwaggerUI();

app.Run();