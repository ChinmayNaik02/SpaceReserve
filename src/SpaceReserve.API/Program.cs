using SpaceReserve.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

#pragma warning disable CS0612 // Type or member is obsolete
builder.AddStartupServices();
#pragma warning restore CS0612 // Type or member is obsolete

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.UseHttpsRedirection();

app.Run();