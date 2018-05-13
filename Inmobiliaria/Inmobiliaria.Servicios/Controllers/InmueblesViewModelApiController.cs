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
using Inmobiliaria.Datos.ViewModels;

namespace Inmobiliaria.Servicios.Controllers
{

    public class InmueblesViewModelApiController : ApiController
    {

        //conection dataBase
        Inmobiliaria_DesarrolloEntities_Desarrollo Database = new Inmobiliaria_DesarrolloEntities_Desarrollo();
        [HttpGet]       
        public InmueblesViewModel GetNew()

        {
            var viewmodel = new InmueblesViewModel
            {
                
                LMunicipios = Database.Municipios.Where(x => x.IdInmobiliaria == 1).ToList(),
                Estados = Database.Estados.ToList(),
                LZonasMunicipios = Database.ZonasMunicipios.ToList(),
                Lllaves = Database.llaves.ToList(),
                Liva = Database.Iva.ToList(),
                LPropietarios = Database.Propietarios.Where(x => x.IdInmobiliaria == 1).ToList(),
                LCategorias = Database.CategoriaInmuebles.Where(x => x.IdInmobiliaria == 1).ToList()

            };

            return viewmodel;
        }

        [HttpGet]

        public InmueblesViewModel GetGeneral()

        {
            var viewmodel = new InmueblesViewModel
            {
                LInmuebles = Database.Inmuebles.ToList(),
                LMunicipios = Database.Municipios.ToList()

            };

            return viewmodel;
        }

        [HttpGet]
        public InmueblesViewModel Getbyid(int id)
        {
            var viewmodel = new InmueblesViewModel
            {
                Inmuebles = (Database.Inmuebles.FirstOrDefault(x => x.Id == id)),
                LMunicipios = Database.Municipios.Where(x => x.IdInmobiliaria == 1).ToList(),
                Estados = Database.Estados.ToList(),
                LZonasMunicipios = Database.ZonasMunicipios.ToList(),
                Lllaves = Database.llaves.ToList(),
                Liva = Database.Iva.ToList(),
                LPropietarios = Database.Propietarios.Where(x => x.IdInmobiliaria == 1).ToList(),
                LCategorias = Database.CategoriaInmuebles.Where(x => x.IdInmobiliaria == 1).ToList()

            };

            return viewmodel;
        }

        [HttpPost]
        public bool PostNew(InmueblesViewModel Inmueble)
        {
            try
            {
                Database.Inmuebles.Add(Inmueble.Inmuebles);
                //Retorne True si se guardan los cambios
                return Database.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }

        }

        [HttpPut]
        public bool PutEdit(Inmuebles Inmueble)
        {
            var InmuebleActualizar = Database.Inmuebles.FirstOrDefault(x => x.Id == Inmueble.Id);

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
            return Database.SaveChanges() > 0;
        }

        [HttpDelete]
        public bool DeleteItem(int id)
        {
            var InmuebleEliminar = Database.Inmuebles.FirstOrDefault(x => x.Id == id);
            Database.Inmuebles.Remove(InmuebleEliminar);
            //si eleimina el libro retortna true
            return Database.SaveChanges() > 0;
        }



    }
}
