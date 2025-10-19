using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTOO.Validaciones;

namespace ProyectoTOO.Controller
{
    public class Usuario
    {
        private int idUsuario;
        private string nombres;
        private string apellidos;
        private string correo;
        private string usuario;
        private string contraseña;
        private string claveRecuperacion;
        private string rol;
        private string estadoUsuario;
        private DateTime ultimaFechaDeIngreso;
        private DateTime fechaRegistro;

        public Usuario() { }

        public int IdUsuario { get { return idUsuario; } set { idUsuario = value; } }
        public string Nombre{ get { return nombres;} set{ nombres = value;}}
        public string Apellido { get {  return apellidos; } set {  apellidos = value; } }
        public string Correo { get { return correo; } set { correo = value; } }
        public string User { get { return usuario; } set { usuario = value; } }
        public string Pass { get { return contraseña; } set { contraseña = value; } }
        public string ClaveRecuperacion { get { return claveRecuperacion; } set { claveRecuperacion = value; } }
        public string Rol { get { return rol; } set { rol = value; } }

        public string Estado { get { return estadoUsuario; } set { estadoUsuario = value; } }
        public DateTime UltimaFecha { get { return ultimaFechaDeIngreso; } set { ultimaFechaDeIngreso = value; } }
        public DateTime FechaRegistro { get { return fechaRegistro; } set { fechaRegistro = value; } }

    }

    public class InstitucionEducativa:Usuario
    {
        private int idInstitucion;
        private string nombreInstitucion;

        public InstitucionEducativa() { }
        public int IdInstitucion { get { return idInstitucion; } set { idInstitucion = value; } }
        public string NombreInstitucion { get { return nombreInstitucion; } set { nombreInstitucion = value; } }


    }

    public class DirectorProyecto: Usuario
    {
        private int idDirectorProyecto;
        private InstitucionEducativa institucion;
        public DirectorProyecto() { }

        public int IdDirectorProyecto { get { return idDirectorProyecto; } set { idDirectorProyecto = value; } }
        public InstitucionEducativa Institucion {get { return institucion; }set { institucion = value; }}

    }

    public class Investigador:Usuario
    {
        private int idInvestigador;
        private InstitucionEducativa institucion;
        public Investigador() { }

        public int IdInvestigador { get { return idInvestigador; } set { idInvestigador = value; } }
        public InstitucionEducativa Institucion { get { return institucion; } set { institucion = value; } }

    }


    public class Telefono
    {
        private int idTelefono;
        private string telefono1;
        private string telefono2;
        private string telefono3;

        public Telefono() { }


        public int IdTelefono { get { return idTelefono; } set { idTelefono = value; } }
        public string Telefono1{get { return telefono1; }set { telefono1 = value; }}

        public string Telefono2{get { return telefono2; }set { telefono2 = value; }}

        public string Telefono3{get { return telefono3; }set { telefono3 = value; }}
    }

    public class AreaTematica
    {
        private int idAreaTematica;
        private string nombreArea;
        private string descripcionArea;

        public AreaTematica() { }


        public int IdAreaTematica { get { return idAreaTematica; } set { idAreaTematica = value; } }
        public string NombreArea{get { return nombreArea; }set { nombreArea = value; }}

        public string DescripcionArea{get { return descripcionArea; }set { descripcionArea = value; }}
    }

    public class Producto
    {
        private int idProducto;
        private string nombreProducto;
        private string tipoProducto;
        private DateTime fechaEntrega;
        private string descripcionProducto;
        private Proyecto proyecto;

        public Producto() { }

        public int IdProducto { get { return idProducto; } set { idProducto = value; } }
        public string NombreProducto{get { return nombreProducto; }set { nombreProducto = value; }}

        public string TipoProducto{get { return tipoProducto; }set { tipoProducto = value; }}

        public DateTime FechaEntrega{get { return fechaEntrega; }set { fechaEntrega = value; }}

        public string DescripcionProducto{get { return descripcionProducto; }set { descripcionProducto = value; }}

        public Proyecto Proyecto {get { return proyecto; } set { proyecto = value; }}
    }

    public class Proyecto
    {
        private int idProyecto;
        private string nombreProyecto;
        private string descripcion;
        private DateTime fechaInicio;
        private DateTime fechafin;
        private string estado;
        private AreaTematica areaTematica;
        private DirectorProyecto directorproyecto;

        public Proyecto() { }

        public int IdProyecto { get { return idProyecto; } set { idProyecto = value; } }
        public string NombreProyecto {get { return nombreProyecto; } set { nombreProyecto = value; }}

        public string Descripcion {get { return descripcion; }set { descripcion = value; } }

        public DateTime FechaInicio {get { return fechaInicio; }set { fechaInicio = value; }}

        public DateTime FechaFin {get { return fechafin; }set { fechafin = value; }}

        public string Estado {get { return estado; }set { estado = value; }}

        public AreaTematica AreaTematica {get { return areaTematica; }set { areaTematica = value; }}

        public DirectorProyecto DirectorProyecto{get { return directorproyecto; }set { directorproyecto = value; }}
    }





}
