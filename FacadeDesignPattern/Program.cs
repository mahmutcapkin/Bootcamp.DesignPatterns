// See https://aka.ms/new-console-template for more information
using FacadeDesignPattern;

//Facade DP

//App app = new App();
//app.WritingDatabaseAndCache();

App app1 = new App("cache","cache");
app1.WritingDatabaseAndCache();
