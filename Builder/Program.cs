using Builder;

var csvTextBuilder = new CsvTextBuilder();

var csv = csvTextBuilder
    .AddHeader("Model", "Year", "Repossed")
    .AddRow("Audi", "2011", true)
    .AddRow("BMW", "2024", false)
    .AddRow("Ford", "2020", true)
    .CreateText();

Console.WriteLine(csv);