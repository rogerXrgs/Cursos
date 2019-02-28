namespace MyWebApp.Entidades
{
    public class ItemPedido
    {
        //Definir atributos da classe.
        public int Id
        {
            get;

            set;
        }

        public Produto Produto 
        {
            get;

            set;
        }

        public int Quantidade
        {
            get;

            set;
        }
    }
}
