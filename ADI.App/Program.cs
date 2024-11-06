// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using ADI.Services;
using ADI.Services.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddTransient<OpenLibraryApiClient>();

var host = builder.Build();

var openLibraryApiClient = host.Services.GetRequiredService<OpenLibraryApiClient>();

var searchQuery = new SearchQuery
{
    Author = "Brandon Sanderson",
};

Console.WriteLine(JsonSerializer.Serialize(await openLibraryApiClient.Search(searchQuery)));