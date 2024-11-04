// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using ADI.Services;
using ADI.Services.Models;

var openLibraryApiClient = new OpenLibraryApiClient();

var searchQuery = new SearchQuery
{
    Author = "Brandon Sanderson",
};

Console.WriteLine(JsonSerializer.Serialize(await openLibraryApiClient.Search(searchQuery)));