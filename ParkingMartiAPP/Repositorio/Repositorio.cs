using Microsoft.EntityFrameworkCore;
using ParkingMartiAPP.Clases;
using ParkingMartiAPP.Data;

namespace ParkingMartiAPP.Repositorio
{
    public class Repositorio : IRepositorio
    {
        private readonly ApplicationDbContext _contexto;
        public Repositorio (ApplicationDbContext contexto) 
        {
            _contexto = contexto;
        }
        public Task<Camiones> ActualizarCamion(int camionID, Camiones camion)
        {
            throw new NotImplementedException();
        }

        public async Task<Clientes> ActualizarCliente(int clienteID, Clientes cliente)
        {
            var clienteBD = await _contexto.Clientes.FindAsync(clienteID);
            clienteBD.NIF = cliente.NIF;
            clienteBD.CuentaBancaria = cliente.CuentaBancaria;
            clienteBD.Correo = cliente.Correo;
            clienteBD.Direccion = cliente.Direccion;
            clienteBD.Camiones = cliente.Camiones;
            clienteBD.Telefono2 = cliente.Telefono2;
            clienteBD.Telefono1 = cliente.Telefono1;
            clienteBD.NombreYApellidos = cliente.NombreYApellidos;
            clienteBD.Poblacion = cliente.Poblacion;
            await _contexto.SaveChangesAsync();
            return clienteBD;
        }

        public Task<Proformas> ActualizarProforma(int proformaID, Proformas proforma)
        {
            throw new NotImplementedException();
        }

        public Task<Proveedores> ActualizarProveedor(int proveedorID, Proveedores proveedor)
        {
            throw new NotImplementedException();
        }

        public Task<Trabajadores> ActualizarTrabajador(int trabajadorID, Trabajadores trabajador)
        {
            throw new NotImplementedException();
        }

        public Task<Proformas> AnularFactura(int facturaID, Proformas proforma)
        {
            throw new NotImplementedException();
        }

        public Task<Camiones> CrearCamion(Camiones camion)
        {
            throw new NotImplementedException();
        }

        public async Task<Clientes> CrearCliente(Clientes cliente)
        {
            if (cliente != null) 
            {
                await _contexto.Clientes.AddAsync(cliente);
                await _contexto.SaveChangesAsync();
                return cliente;
            }
            else 
            {
                return new Clientes();
            }
        }
        public async Task<Vehiculos> CrearVehiculo(Vehiculos vehiculo)
        {
            if (vehiculo != null)
            {
                await _contexto.Vehiculos.AddAsync(vehiculo);
                await _contexto.SaveChangesAsync();
                return vehiculo;
            }
            else
            {
                return new Vehiculos();
            }
        }

        public Task<Proformas> CrearFactura(Proformas proforma, Facturas factura)
        {
            throw new NotImplementedException();
        }

        public Task<Proformas> CrearProforma(Proformas proforma)
        {
            throw new NotImplementedException();
        }

        public Task<Proveedores> CrearProveedor(Proveedores proveedor)
        {
            throw new NotImplementedException();
        }

        public Task<Trabajadores> CrearTrabajador(Trabajadores proveedor)
        {
            throw new NotImplementedException();
        }

        public Task EliminarCamion(int camionID)
        {
            throw new NotImplementedException();
        }

        public async Task EliminarCliente(int clienteID)
        {
            var clienteDB = await _contexto.Clientes.FindAsync(clienteID);
            _contexto.Remove(clienteDB);
            await _contexto.SaveChangesAsync();
        }

        public Task EliminarProforma(int proformaID)
        {
            throw new NotImplementedException();
        }

        public Task EliminarProveedor(int proveedorID)
        {
            throw new NotImplementedException();
        }

        public Task EliminarTrabajador(int trabajadorID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Camiones>> GetCamiones()
        {
            return _contexto.Camiones.ToListAsync();
        }

        public Task<Camiones> GetCamionesDelCliente(int clienteID)
        {
            throw new NotImplementedException();
        }

        public Task<Camiones> GetCamionID(int camionID)
        {
            throw new NotImplementedException();
        }

        public async Task<Clientes> GetClienteID(int clienteID)
        {
            var clienteDB = await _contexto.Clientes.FindAsync(clienteID);
            if (clienteDB == null) 
            {
                return new Clientes();
            }
            return clienteDB;
        }

        public Task<List<Clientes>> GetClientes()
        {
            return _contexto.Clientes.ToListAsync();
        }
        public Task<List<Vehiculos>> GetVehiculos()
        {
            return _contexto.Vehiculos.ToListAsync();
        }

        public Task<Proformas> GetFacturaID(int facturaID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Proformas>> GetFacturas()
        {
            throw new NotImplementedException();
        }

        public Task<Proformas> GetFacturasPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            throw new NotImplementedException();
        }

        public Task<Proformas> GetProformaID(int proformaID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Proformas>> GetProformas()
        {
            throw new NotImplementedException();
        }

        public Task<Proformas> GetProformasPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            throw new NotImplementedException();
        }

        public Task<List<Proveedores>> GetProveedores()
        {
            throw new NotImplementedException();
        }

        public Task<Proveedores> GetProveedorID(int proveedorID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Trabajadores>> GetTrabajadores()
        {
            throw new NotImplementedException();
        }

        public Task<Trabajadores> GetTrabajadorID(int trabajadorID)
        {
            throw new NotImplementedException();
        }
    }
}
