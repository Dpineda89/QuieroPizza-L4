using ServiTec.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTec.Bibl
{
    public class ClientesBibl
    {
        ServiTexContext _ServiTexContext;
        public List<Cliente> ListadeClientes { get; set; }

        public ClientesBibl()
        {
            _ServiTexContext = new ServiTexContext();
            ListadeClientes = new List<Cliente>();
        }

        public List<Cliente> ObtenerClientes()
        {
            ListadeClientes = _ServiTexContext.Clientes
                .OrderBy(r => r.Nombre)
                .ToList();

            return ListadeClientes;
        }

        public List<Cliente> ObtenerClientesActivos()
        {
            ListadeClientes = _ServiTexContext.Clientes
                .Where(r => r.Activo)
                .OrderBy(r => r.Nombre)
                .ToList();

            return ListadeClientes;
        }

        public void GuardarCliente(Cliente cliente)
        {
            if (cliente.Id == 0)
            {
                _ServiTexContext.Clientes.Add(cliente);
            }
            else
            {
                var clienteExistente = _ServiTexContext.Clientes.Find(cliente.Id);

                clienteExistente.Nombre = cliente.Nombre;
                clienteExistente.Telefono = cliente.Telefono;
                clienteExistente.Direccion = cliente.Direccion;
                clienteExistente.Activo = cliente.Activo;
            }

            _ServiTexContext.SaveChanges();
        }

        public Cliente ObtenerCliente(int id)
        {
            var cliente = _ServiTexContext.Clientes.Find(id);

            return cliente;
        }

        public void EliminarCliente(int id)
        {
            var cliente = _ServiTexContext.Clientes.Find(id);

            _ServiTexContext.Clientes.Remove(cliente);
            _ServiTexContext.SaveChanges();
        }
    }
}
