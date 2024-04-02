﻿using Actividad5.DAL;
using Actividad5.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.BSS
{
    public class DetalleVentaBSS
    {
        DetalleVentaDAL dal = new DetalleVentaDAL();
        public DataTable ListarDetalleVentaBss()
        {
            return dal.ListarDetalleVentaDal();
        }
        public void InsertarDetalleVentaBss(DetalleVenta detalleventa)
        {
            dal.InsertarDetalleVentaDAL(detalleventa);
        }
        public DetalleVenta ObtenerDetalleVentaIdBss(int id)
        {
            return dal.ObtenerDetalleVentaIdDal(id);
        }
        public void EditarDetalleVentaBss(DetalleVenta p)
        {
            dal.EditarDetalleVentaDal(p);
        }
        public void EliminarDetalleVentaBss(int id)
        {
            dal.EliminarDetalleVentaDal(id);
        }
        public DataTable DetalleVentaDatosBSS(int id)
        {
            return dal.DetalleVentaDatosDal(id);
        }
    }
}
