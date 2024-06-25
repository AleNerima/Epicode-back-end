namespace CVWebApp.Models
{
    public class CV
    {
        public InformazioniPersonali InformazioniPersonali { get; set; }
        public List<Studi> StudiEffettuati { get; set; }
        public List<Esperienza> EsperienzeLavorative { get; set; }
    }
}
