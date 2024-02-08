namespace MagnumProjekt;

public interface INahrungsmittel 
{
    public double Brennwert { get; }
    public double Eiweiß { get; }
    public double Kohlenhydrat { get; }
    public double Fett { get; }
}