// See https://aka.ms/new-console-template for more information

using MagnumProjekt.Kalender;
using MagnumProjekt.Nahrung;

Kalender kalender = new();

Ernährungstagebuch.SchreibeErnährungsTagebuchIn(kalender);
TrainingsKalender.SchreibeTrainingsTagebuchIn(kalender);
Gewichtstagebuch.SchreibeGewichtsTagebuchIn(kalender);

kalender.GetErnährung(12,2,2024).PrintTagesNährwert();

//Gerichte.AlleGerichte(Nährwert.Eiweiß,false);