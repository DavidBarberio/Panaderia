using System;
using System.Collections.Generic;

namespace Panaderia
{
    public class ClienteRepositorio
    {
        private static List<Cliente> listaClientes = new List<Cliente>();

        public static Cliente BuscarID(String id)
        {
            return listaClientes.Find(x => x.dni == id);

        }

        public static void Guardar(Cliente cliente)
        {
            listaClientes.Add(cliente);
        }

        public static void Borrar(Cliente cliente)
        {
            listaClientes.Remove(cliente);
        }

        public static List<Cliente> ListaClientes()
        {
            return listaClientes;
        }
    }
}