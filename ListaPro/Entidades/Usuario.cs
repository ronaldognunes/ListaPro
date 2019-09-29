using System.Collections.Generic;

namespace ListaPro.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public ICollection<Lista> Listas { get; set; }
    }
}