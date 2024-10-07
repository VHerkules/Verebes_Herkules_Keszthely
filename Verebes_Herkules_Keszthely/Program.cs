using Verebes_Herkules_Keszthely;
using System.Text;

List<Versenyzok> versenyzoklista = [];

using StreamReader sr = new(path: @"..\..\..\src\forras.txt");
while(!sr.EndOfStream) versenyzoklista.Add(new(sr.ReadLine()));

Console.WriteLine($"{versenyzoklista.Count} versenyző fejezte be a versenyt.");

//1.feladat
var lnelitj = versenyzoklista.Count(p => p.Kategoria == "elit junior");
Console.WriteLine($"1. feladat: Versenyzők száma elit junior kategóriában: {lnelitj}");

//2.fealdat
var lnferfik = versenyzoklista.Where(p => p.Nem == "f");
var lnfatlag = lnferfik.Average(p => p.Eletkor);
Console.WriteLine($"2. feladat: férfi versenyzők átlagéletkora: {lnfatlag:0} év");

//3.feladat
var lnfutas = versenyzoklista.Sum(p => p.Futas.TotalHours);
Console.WriteLine($"3. feladat: a versenyzők futással töltött összideje órában: {lnfutas:0.00}");

//4.feladat
var lnhuszhuszonnegy = versenyzoklista.Where(p => p.Kategoria == "20-24");
var lnuszasatlag = lnhuszhuszonnegy.Average(p => p.Uszas.TotalHours + (p.Uszas.TotalMinutes / 60) + (p.Uszas.TotalSeconds / 360));
Console.WriteLine($"4. feladat: átlagos úszási idő 20-24 kategóriában: {lnuszasatlag:0} óra");

//5.feladat
var lnnok = versenyzoklista.Where(p => p.Nem == "n");

//6.feladat
