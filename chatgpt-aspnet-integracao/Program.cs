using chatgpt_aspnet_integracao.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.AddChatGpt(/*builder.Configuration*/);
builder.AddSerilog(builder.Configuration, "ChatGPT Integração");

// Add services to the container.

builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddControllers();
builder.Services.AddSwagger(builder.Configuration, "ChatGPT Integração");
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UserSwaggerDoc("ChatGPT Integração");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
