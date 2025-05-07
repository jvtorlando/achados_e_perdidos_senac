using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using achados_e_perdidos_senac.Model;
using achados_e_perdidos_senac.Repositorios;

namespace achados_e_perdidos_senac.Controllers
{
    internal class ItemPerdidoController
    {

        private readonly ItemRepositorio itemRepositorio;

        public ItemPerdidoController(ItemRepositorio itemRepositorio)
        {
            this.itemRepositorio = itemRepositorio;
        }

        public bool InserirItemPerdido(ItemPerdido itemPerdido) {

           bool resultadoInsercao =  itemRepositorio.InserirItem(itemPerdido);

            if (resultadoInsercao) {

                MessageBox.Show("Ítem cadastrado com sucesso");

                return true;

            }

            MessageBox.Show("Não foio possível cadastrar o item. Tente novamente!");


            return false;




        }
    }
}
