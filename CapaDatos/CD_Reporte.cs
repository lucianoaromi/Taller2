﻿using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Reporte
    {

        
        public List<ReporteVenta> Venta(string fechainicio, string fechafin, int idusuario)
        { 
            List<ReporteVenta> lista = new List<ReporteVenta>();
 
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
  
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("sp_ReporteVentas111", oconexion);
                    cmd.Parameters.AddWithValue("fechainicio", fechainicio);
                    cmd.Parameters.AddWithValue("fechafin", fechafin);
                    cmd.Parameters.AddWithValue("idusuario", idusuario);
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                   
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            
                            lista.Add(new ReporteVenta()
                            {

                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                                UsuarioRegistro = dr["UsuarioRegistro"].ToString(),
                                DocumentoCliente = dr["DocumentoCliente"].ToString(),
                                ApellidoCliente = dr["ApellidoCliente"].ToString(),
                                CodigoProducto = dr["CodigoProducto"].ToString(),
                                NombreProducto = dr["NombreProducto"].ToString(),
                                Categoria = dr["Categoria"].ToString(),
                                Precio = dr["Precio"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),
                                SubTotal = dr["SubTotal"].ToString(),
                                DesMetPago = dr["DesMetPago"].ToString(),
                            });
                        }
                    }

                }
                
                catch (Exception ex)
                {

                    lista = new List<ReporteVenta>();
                }

            }

            return lista;


        }
    }    
}
