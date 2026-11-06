using Capi.Assessment.Invoice.Api.Extensions;
using Capi.Assessment.Invoice.Domain;
using Capi.Assessment.Invoice.Persistence.Extensions;
using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder
    .Services
    .AddControllers()
    .AddNewtonsoftJson();

builder.Services
    .ConfigureApplicationInfrastructure();

builder.Services
    .ConfigureCapiAssessmentInvoiceDomain()
    .ConfigureCapiAssessmentInvoicePersistence();

builder.Services.AddLogging(l => l.AddConsole());
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "EventCatalogService.Api", Version = "v1" });
});

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
