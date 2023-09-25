using PruebaSagrarioJrea.BD;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSagrarioJrea
{
    internal class Metodos
    {
        public List<Cliente> listarClientes()
        {
            try
            {
                Database db = new();
                var listClientes = (from cli in db.Clientes
                                    select cli).ToList();

                return listClientes;
            }
            catch (Exception)
            {
                return null;

            }

        }

        public bool guardarCliente(Cliente cli)
        {
            try
            {
                Database db = new();
                db.Add(cli);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public Cliente consultarCliente(string id)
        {
            try
            {
                Database db = new();
                var cliente = (from cli in db.Clientes where cli.identificacion == id select cli).FirstOrDefault();

                if (cliente == null) return null;
                return cliente;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public bool actualizarCliente(Cliente cl)
        {
            try
            {
                Database db = new();
                var cliente = (from cli in db.Clientes where cli.identificacion == cl.identificacion select cli).FirstOrDefault();
                cliente.identificacion = cl.identificacion;
                cliente.nombres = cl.nombres;
                cliente.apellidos = cl.apellidos;
                cliente.celular = cl.celular;
                cliente.email = cl.email;
                cliente.direccion = cl.direccion;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<campoFactura> listarFacturas() {

            try
            {
                Database db = new();
                var listFacturas = (from fact in db.Facturas
                                    join facCab in db.FacturaCabeceras on fact.idFacturaCabecera equals facCab.idFacturaCabecera
                                    join cli in db.Clientes on facCab.idCliente equals cli.idCliente
                                    select new
                                    {
                                        factura = fact,
                                        cliente = cli,
                                        cabecera = facCab
                                    }).ToList();
                List<campoFactura> listCampFact = new();

                foreach (var listaFact in listFacturas)
                {
                    campoFactura campFact = new campoFactura();
                    campFact.codigoFactura = listaFact.cabecera.codigoFactura;
                    campFact.fechaEmision = listaFact.cabecera.fechaEmision;
                    campFact.identificacion = listaFact.cliente.identificacion;
                    campFact.nombres = listaFact.cliente.nombres;
                    campFact.apellidos = listaFact.cliente.apellidos;
                    campFact.celular = listaFact.cliente.celular;
                    campFact.email = listaFact.cliente.email;
                    campFact.direccion = listaFact.cliente.direccion;
                    campFact.subtotal = listaFact.factura.subtotal;
                    campFact.iva = listaFact.factura.iva;
                    campFact.total = listaFact.factura.total;

                    var listContenido = (from facDet in db.FacturaDetalles
                                         where facDet.idFacturaCabecera == listaFact.cabecera.idFacturaCabecera
                                         select facDet).Count();
                    var texto = "producto";
                    if (listContenido > 1) texto = "productos";
                    campFact.contenido = listContenido + " " + texto;

                    listCampFact.Add(campFact);
                    //var listContenido = (from facDet in db.FacturaDetalles
                    //                    join prod in db.Productos on facDet.idProducto equals prod.idProducto
                    //                    where facDet.codigoFactura == listaFact.factura.codigoFactura
                    //                     select new
                    //                    {
                    //                        detalle = facDet,
                    //                        producto = prod
                    //                    }).ToList();
                    //campoFacturaContenido campFactDet = new campoFacturaContenido();
                    //foreach (var listaCont in listFacturas)
                    //{

                    //}
                }
                return listCampFact;
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public bool guardarFactura(campoFacturaCompleto factura)
        {
            try
            {
                Database db = new();
                var existeCliente = (from cli in db.Clientes
                                     where cli.identificacion == factura.identificacion
                                     select cli).FirstOrDefault();

                Cliente cliente = new();
                if (existeCliente != null)
                {
                    cliente.identificacion = factura.identificacion;
                    cliente.nombres = factura.nombres;
                    cliente.apellidos = factura.apellidos;
                    cliente.celular = factura.celular;
                    cliente.email = factura.email;
                    cliente.direccion = factura.direccion;
                    db.Add(cliente);
                    db.SaveChanges();
                }

                FacturaCabecera factCab = new();
                factCab.codigoFactura = factura.codigoFactura;
                factCab.fechaEmision = factura.fechaEmision;
                factCab.idCliente = (existeCliente == null) ? cliente.idCliente : existeCliente.idCliente;
                db.Add(factCab);
                db.SaveChanges();

                foreach (var item in factura.contenido)
                {
                    Producto producto = new();
                    producto.nombre = item.nombre;
                    producto.precio = item.precio;
                    db.Add(producto);
                    db.SaveChanges();

                    FacturaDetalle factDet = new();
                    factDet.idFacturaCabecera = factCab.idFacturaCabecera;
                    factDet.idProducto = producto.idProducto;
                    factDet.cantidad = item.cantidad;
                    factDet.total = item.total;
                    db.Add(factDet);
                    db.SaveChanges();
                }

                Factura fact = new();
                fact.idFacturaCabecera = factCab.idFacturaCabecera;
                fact.subtotal = factura.subtotal;
                fact.iva = factura.iva;
                fact.total = factura.total;
                db.Add(fact);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            


        }
        public campoFacturaCompleto consultarFactura(string id)
        {
            try
            {
                Database db = new();
                var factura = (from fact in db.Facturas
                               join facCab in db.FacturaCabeceras on fact.idFacturaCabecera equals facCab.idFacturaCabecera
                               join cli in db.Clientes on facCab.idCliente equals cli.idCliente
                               where cli.identificacion == id
                               select new
                               {
                                   factura = fact,
                                   cliente = cli,
                                   cabecera = facCab
                               }).FirstOrDefault();

                if (factura == null) return null;

                campoFacturaCompleto campFactComp = new();
                campFactComp.codigoFactura = factura.cabecera.codigoFactura;
                campFactComp.fechaEmision = factura.cabecera.fechaEmision;
                campFactComp.identificacion = factura.cliente.identificacion;
                campFactComp.nombres = factura.cliente.nombres;
                campFactComp.apellidos = factura.cliente.apellidos;
                campFactComp.celular = factura.cliente.celular;
                campFactComp.email = factura.cliente.email;
                campFactComp.direccion = factura.cliente.direccion;
                campFactComp.subtotal = factura.factura.subtotal;
                campFactComp.iva = factura.factura.iva;
                campFactComp.total = factura.factura.total;

                var contenido = (from facDet in db.FacturaDetalles
                                 join prod in db.Productos on facDet.idProducto equals prod.idProducto
                                 where facDet.idFacturaCabecera == factura.cabecera.idFacturaCabecera
                                 select new
                                 {
                                     detalle = facDet,
                                     producto = prod
                                 }).ToList();

                List<campoFacturaContenido> listCampFactCont = new();

                foreach (var lista in contenido)
                {
                    campoFacturaContenido campFactCont = new campoFacturaContenido();
                    campFactCont.idProducto = lista.producto.idProducto.ToString();
                    campFactCont.nombre = lista.producto.nombre;
                    campFactCont.precio = lista.producto.precio;
                    campFactCont.cantidad = lista.detalle.cantidad;
                    campFactCont.total = lista.detalle.total;
                    listCampFactCont.Add(campFactCont);
                }
                campFactComp.contenido = listCampFactCont;

                return campFactComp;
            }
            catch (Exception)
            {
                return null;
            }
            
        }
        public bool actualizarFactura(campoFacturaCompleto factura)
        {
            try
            {
                Database db = new();
                var buscarFactura = (from fact in db.Facturas
                                     join facCab in db.FacturaCabeceras on fact.idFacturaCabecera equals facCab.idFacturaCabecera
                                     join cli in db.Clientes on facCab.idCliente equals cli.idCliente
                                     where cli.identificacion == factura.identificacion
                                     select new
                                     {
                                         factura = fact,
                                         cliente = cli,
                                         cabecera = facCab
                                     }).FirstOrDefault();

                buscarFactura.cabecera.codigoFactura = factura.codigoFactura;
                buscarFactura.cabecera.fechaEmision = factura.fechaEmision;
                buscarFactura.cliente.identificacion = factura.identificacion;
                buscarFactura.cliente.nombres = factura.nombres;
                buscarFactura.cliente.apellidos = factura.apellidos;
                buscarFactura.cliente.celular = factura.celular;
                buscarFactura.cliente.email = factura.email;
                buscarFactura.cliente.direccion = factura.direccion;
                buscarFactura.factura.subtotal = factura.subtotal;
                buscarFactura.factura.iva = factura.iva;
                buscarFactura.factura.total = factura.total;

                var contenido = (from facDet in db.FacturaDetalles
                                 join prod in db.Productos on facDet.idProducto equals prod.idProducto
                                 where facDet.idFacturaCabecera == buscarFactura.cabecera.idFacturaCabecera
                                 select new
                                 {
                                     detalle = facDet,
                                     producto = prod
                                 }).ToList();

                foreach (var item in contenido)
                {
                    db.Remove(item.detalle);
                    db.Remove(item.producto);
                }

                foreach (var item in factura.contenido)
                {
                    Producto producto = new();
                    producto.nombre = item.nombre;
                    producto.precio = item.precio;
                    db.Add(producto);
                    db.SaveChanges();

                    FacturaDetalle factDet = new();
                    factDet.idFacturaCabecera = buscarFactura.factura.idFacturaCabecera;
                    factDet.idProducto = producto.idProducto;
                    factDet.cantidad = item.cantidad;
                    factDet.total = item.total;
                    db.Add(factDet);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public class campoFactura
        {
            public string idFactura { get; set; }
            public string codigoFactura { get; set; }
            public string fechaEmision { get; set; }
            public string identificacion { get; set; }
            public string nombres { get; set; }
            public string apellidos { get; set; }
            public string celular { get; set; }
            public string email { get; set; }
            public string direccion { get; set; }
            //public List<campoFacturaContenido> contenido { get; set; }
            public string contenido { get; set; }
            public string subtotal { get; set; }
            public string iva { get; set; }
            public string total { get; set; }
        }

        public class campoFacturaCompleto
        {
            public string idFactura { get; set; }
            public string codigoFactura { get; set; }
            public string fechaEmision { get; set; }
            public string identificacion { get; set; }
            public string nombres { get; set; }
            public string apellidos { get; set; }
            public string celular { get; set; }
            public string email { get; set; }
            public string direccion { get; set; }
            public List<campoFacturaContenido> contenido { get; set; }
            public string subtotal { get; set; }
            public string iva { get; set; }
            public string total { get; set; }
        }

        public class campoFacturaContenido
        {
            public string idProducto { get; set; }
            public string nombre { get; set; }
            public string precio { get; set; }
            public string cantidad { get; set; }
            public string total { get; set; }
        }
    }
}
