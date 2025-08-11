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
        public Task EliminarCliente(int clienteID);

        // Proveedores
        public Task<List<Proveedores>> GetProveedores();
        public Task<Proveedores> GetProveedorID(int proveedorID);
        public Task<Proveedores> CrearProveedor(Proveedores proveedor);
        public Task<Proveedores> ActualizarProveedor(int proveedorID, Proveedores proveedor);
        public Task EliminarProveedor(int proveedorID);

        // Trabajadores
        public Task<List<Trabajadores>> GetTrabajadores();
        public Task<Trabajadores> GetTrabajadorID(int trabajadorID);
        public Task<Trabajadores> CrearTrabajador(Trabajadores proveedor);
        public Task<Trabajadores> ActualizarTrabajador(int trabajadorID, Trabajadores trabajador);
        public Task EliminarTrabajador(int trabajadorID);

        // Camiones
        public Task<List<Camiones>> GetCamiones();
        public Task<Camiones> GetCamionID(int camionID);
        public Task<Camiones> CrearCamion(Camiones camion);
        public Task<Camiones> ActualizarCamion(int camionID, Camiones camion);
        public Task EliminarCamion(int camionID);

        // Proformas
        public Task<List<Proformas>> GetProformas();
        public Task<Proformas> GetProformaID(int proformaID);
        public Task<Proformas> GetProformasPorFecha(DateTime fechaDesde, DateTime fechaHasta);

        public Task<Proformas> CrearProforma(Proformas proforma);
        public Task<Proformas> ActualizarProforma(int proformaID, Proformas proforma);
        public Task EliminarProforma(int proformaID);

        // Proformas
        public Task<List<Proformas>> GetFacturas();
        public Task<Proformas> GetFacturaID(int facturaID);
        public Task<Proformas> GetFacturasPorFecha(DateTime fechaDesde, DateTime fechaHasta);

        public Task<Proformas> CrearFactura(Proformas proforma,Facturas factura);
        public Task<Proformas> AnularFactura(int facturaID, Proformas proforma);

    }
}
