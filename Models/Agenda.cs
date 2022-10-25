namespace agenda.Models {
    using System.ComponentModel.DataAnnotations;

    public class Agenda
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string telefone { get; set; }
    }
}