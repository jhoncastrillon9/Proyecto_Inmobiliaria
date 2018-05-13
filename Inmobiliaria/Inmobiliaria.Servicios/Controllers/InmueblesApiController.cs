using Newtonsoft.Json;
using System.Net.Http.Formatting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Inmobiliaria.Datos;
using Inmobiliaria.Datos.Modelo;

namespace Inmobiliaria.Servicios.Controllers
{
    public class MunicipiosApiController : ApiController
    {
        Inmobiliaria_DesarrolloEntities_Desarrollo BD = new Inmobiliaria_DesarrolloEntities_Desarrollo();

        [HttpGet]
        public IEnumerable<Inmuebles> Get()

        {
            var LInmuebles = BD.Inmuebles.ToList();

            return LInmuebles;
        }
        

        [HttpGet]
        public Inmuebles Get(int id)
        {
            Inmuebles cosa = new Inmuebles();
           
            var Inmueble = BD.Inmuebles.FirstOrDefault(x => x.Id == id);

            return Inmueble;
        }

        [HttpPost]
        public bool Post(Inmuebles Inmueble)
        {
            try
            {
                BD.Inmuebles.Add(Inmueble);
                //Retorne True si se guardan los cambios
                return BD.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }

         
        }

        [HttpPut]
        public bool Put(Inmuebles Inmueble)
        {
            var InmuebleActualizar = BD.Inmuebles.FirstOrDefault(x => x.Id == Inmueble.Id);

            InmuebleActualizar.Codigo = Inmueble.Codigo;
            InmuebleActualizar.Titulo = Inmueble.Titulo;
            InmuebleActualizar.Descripcion = Inmueble.Descripcion;
            InmuebleActualizar.Direccion = Inmueble.Direccion;
            InmuebleActualizar.IdEstado = Inmueble.IdEstado;
            InmuebleActualizar.IdLlaves = Inmueble.IdLlaves;
            InmuebleActualizar.PrecioPropietario = Inmueble.PrecioPropietario;
            InmuebleActualizar.Porcentaje = Inmueble.Porcentaje;
            InmuebleActualizar.Honorarios = Inmueble.Honorarios;
            InmuebleActualizar.FechaCaptacion = Inmueble.FechaCaptacion;
            InmuebleActualizar.IdIva = Inmueble.IdIva;
            InmuebleActualizar.PrecioFinal = Inmueble.PrecioFinal;
            InmuebleActualizar.Habitaciones = Inmueble.Habitaciones;
            InmuebleActualizar.Banos = Inmueble.Banos;
            InmuebleActualizar.Porteria = Inmueble.Porteria;
            InmuebleActualizar.Piscina = Inmueble.Piscina;
            InmuebleActualizar.Area = Inmueble.Area;
            InmuebleActualizar.IdMunicipio = Inmueble.IdMunicipio;
            InmuebleActualizar.IdPropietario = Inmueble.IdPropietario;
            InmuebleActualizar.Observacion = Inmueble.Observacion;
            InmuebleActualizar.IdCategoria = Inmueble.IdCategoria;
            //InmuebleActualizar.IdInmobiliaria = Inmueble.IdInmobiliaria;
            //Si si actualiza el inmueble retorna True
            return BD.SaveChanges() > 0;
        }

        [HttpGet]
        public bool Delete(int id)
        {
            var InmuebleEliminar = BD.Inmuebles.FirstOrDefault(x => x.Id == id);
            BD.Inmuebles.Remove(InmuebleEliminar);
            //si eleimina el libro retortna true
            return BD.SaveChanges() > 0;
        }


    }
}
