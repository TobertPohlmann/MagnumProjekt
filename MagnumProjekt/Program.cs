// See https://aka.ms/new-console-template for more information

using MagnumProjekt.Kalender;

Kalender kalender = new();

Ernährungstagebuch.SchreibeErnährungsTagebuchIn(kalender);
TrainingsKalender.SchreibeTrainingsTagebuchIn(kalender);
Gewichtstagebuch.SchreibeGewichtsTagebuchIn(kalender);

kalender.GetErnährung(8,2,2024).PrintTagesNährwert();
