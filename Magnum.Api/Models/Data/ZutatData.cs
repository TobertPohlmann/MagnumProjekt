namespace Magnum.Model.Nahrung.Data
{
    public class ZutatData
    {
        public int ZutatId { get; set; }
        public Guid UserId { get; set; } = Guid.Empty;
        public string? ZutatName { get; set; } = string.Empty;
        public double Brennwert { get; set; } = 0;
        public double Eiweiß { get; set; } = 0;
        public double Kohlenhydrat { get; set; } = 0;
        public double Fett { get; set; } = 0;
    }
}
