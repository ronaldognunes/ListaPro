namespace ListaPro.Entidades
{
    public class ListaUsuario
    {
        public int IdLista { get; set; }
        public int IdUsuario { get; set; }
        public Lista lista { get; set; }
        public Usuario usuario { get; set; }
    }
}