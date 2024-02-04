// See https://aka.ms/new-console-template for more information

using MagnumProjekt;

Console.WriteLine("Hello, World!");

var ei = new Zutat(Convert.ToInt32(89 / 0.6), 7.5 / 0.6, 0.4 / 0.6, 6.5 / 0.6);
var haferflocken = new Zutat(339,12.5,55,6.5);
var hähnchenbrust = new Zutat(102,24,0,0.7);
var rindfleisch = new Zutat(150,19,0,8);
var mandeln = new Zutat(611,24,5.7,53);
var vollkornnudeln = new Zutat(139,5.8,26,1);
var öl = new Zutat(884,0,0,100);
var lachs = new Zutat(180,19.9,0,11.2);
var brokkoli = new Zutat(43,4,2.9,0.2);
var milch = new Zutat(64,3.3,4.8,3.5);
var butter = new Zutat(717, 0.9, 0.1, 81);
var reis = new Zutat(347, 7.3, 77.3, 0.9);
var banane = new Zutat(93, 1.15, 23, 0.2);
var tofu = new Zutat(124, 15, 2, 7);

var haferflockenMitMilch = new Gericht("Haferflocken mit Milch",(haferflocken, 500), (milch, 500));
var nudelnMitEi = new Gericht("Nudeln mit Ei",(vollkornnudeln, 200), (ei, 400),(butter,20));
var lachsMitReis = new Gericht("Lachs mit Reis",(lachs, 200), (reis, 200), (öl, 10));
var nudelnMitRind = new Gericht("Rindfleisch mit Nudeln",(rindfleisch, 150), (vollkornnudeln, 300));

var handvollMandeln = new Gericht("Handvoll Mandeln", (mandeln, 100));
var eineBanane = new Gericht("Eine Banane",(banane, 120));

var tagesPlan = new Tagesplan();
tagesPlan.AddGericht(haferflockenMitMilch,0.5);
//tagesPlan.AddGericht(lachsMitReis,1);
tagesPlan.AddGericht(nudelnMitEi,1);
tagesPlan.AddGericht(handvollMandeln,1);
tagesPlan.AddGericht(eineBanane,1);
tagesPlan.PrintTagesNährwert();



