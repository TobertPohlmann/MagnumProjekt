namespace Magnum.Model.Nahrung.Data
{
    public class GerichtData
    {
        public string? Name { get; set; } = string.Empty;
        public int GerichtId { get; set; }
        public Guid UserId { get; set; } = Guid.Empty;
        List<BeigabeData> ZutatenListe { get; set; } = default!;
    }
}
