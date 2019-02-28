using System;
using System.Collections;
using System.Collections.Generic;

namespace MyWebApp.Entidades
{
    public class Pedido
    {
        //Definir atributos da classe.
        public int Id
        {
            get;

            set;
        }

        public DateTime DataPedido
        {
            get;

            set;
        }

        public ICollection<ItemPedido> ItensPedidos
        {
            get;
            set;
        }
    }
}

