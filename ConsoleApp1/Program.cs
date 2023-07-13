// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

var foo = new ResourceRepo<CaseStudy>();

var caseStudy = foo.GetItemById(1);

var bar = new ResourceRepo<Newsletter>();

var newsLetter = bar.GetItemById(2);

Console.WriteLine("DONE");