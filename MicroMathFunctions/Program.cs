var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapGet("/cubed/{nbr:decimal}", (decimal nbr) => {
    return nbr * nbr * nbr;
});

app.MapGet("/modulo/{num:int}/{denom:int}", (int num, int denom) =>
{
    if (denom is 0)
    {
        return Results.BadRequest();    //Like a 404 error
    }
    var answer = num % denom;
    return Results.Ok(answer);


});
app.Run();
