namespace MagnumProjekt.Nahrung;

public static class Gerichte
{
    public static Gericht KLEINER_SALAT = new ("Kleiner Salat", (Zutaten.SALAT, 40),(Zutaten.WURZELN,35),(Zutaten.GURKE,40),(Zutaten.ÖL,17),(Zutaten.SOJASOSSE,17));
    public static Gericht HAFERFLOCKEN_MIT_MILCH = new ("Haferflocken mit Milch",(Zutaten.HAFERFLOCKEN, 200), (Zutaten.MILCH, 200));
    public static Gericht NUDELN_MIT_EI = new ("Vollkornnudeln mit Ei",(Zutaten.VOLLKORNNUDELN, 100), (Zutaten.EI, 300),(Zutaten.BUTTER,30));
    public static Gericht LACHS_MIT_REIS = new ("Lachs mit Reis",(Zutaten.LACHS, 200), (Zutaten.REIS, 200), (Zutaten.ÖL, 20));
    public static Gericht NUDELN_MIT_RIND = new ("Rindfleisch mit Nudeln",(Zutaten.RINDFLEISCH, 150), (Zutaten.VOLLKORNNUDELN, 300));
    public static Gericht KICHERERBSENNUDELN_MIT_EI = new ("Kichererbsennudeln mit Ei",(Zutaten.KICHERERBSENNUDELN, 100), (Zutaten.EI, 280),(Zutaten.ÖL,30));
    public static Gericht HANDVOLL_MANDELN = new ("Handvoll Mandeln", (Zutaten.MANDELN, 100));
    public static Gericht EINE_BANANE = new ("Eine Banane",(Zutaten.BANANE, 120));
    public static Gericht QUICHE = new("Quiche", (Zutaten.WEIZENMEHL, 125), (Zutaten.BUTTER, 70), (Zutaten.WURZELN, 600),
        (Zutaten.SCHMAND, 200),(Zutaten.MILCH,100),(Zutaten.EI,180));
}