using ParkingMartiAPP.Clases;

namespace ParkingMartiAPP.Repositorio
{
    public interface IRepositorio
    {
        // Clientes
        public Task<List<Clientes>> GetClientes();
        public Task<Clientes> GetClienteID(int clienteID);
        public Task<Clientes> CrearCliente(Clientes cliente);
        public Task<Clientes> ActualizarCliente(int clienteID,Clientes cliente);
        public Task<Clientes> EliminarCliente(int clienteID);
    }
}
