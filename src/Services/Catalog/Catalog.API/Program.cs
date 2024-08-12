var builder = WebApplication.CreateBuilder(args);

//Add Services to DI container

var app = builder.Build();

//Configure HTTP request pipeline

app.Run();
