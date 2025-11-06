using ProyectoTOO.Model;
using ProyectoTOO.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTOO.Controller
{
    public class Usuario
    {
        private string idUsuario;
        private string correo;
        private string usuario;
        private string contraseña;
        private string claveRecuperacion;
        private string rol;
        private string estadoUsuario;
        private DateTime ultimaFechaDeIngreso;
        private DateTime fechaRegistro;

        public Usuario() { }

        public string IdUsuario { get { return idUsuario; } set { idUsuario = value; } }
        public string Correo { get { return correo; } set { correo = value; } }
        public string User { get { return usuario; } set { usuario = value; } }
        public string Pass { get { return contraseña; } set { contraseña = value; } }
        public string ClaveRecuperacion { get { return claveRecuperacion; } set { claveRecuperacion = value; } }
        public string Rol { get { return rol; } set { rol = value; } }

        public string Estado { get { return estadoUsuario; } set { estadoUsuario = value; } }
        public DateTime UltimaFecha { get { return ultimaFechaDeIngreso; } set { ultimaFechaDeIngreso = value; } }
        public DateTime FechaRegistro { get { return fechaRegistro; } set { fechaRegistro = value; } }


        /// <summary>
        /// Esta funcion se utiliza para autenticar a los usuarios
        /// </summary>
        /// <param name="correo"></param>
        /// <param name="password"></param>
        /// <returns></returns>

        public Usuario Login(string correo, string password)
        {
            UsuarioModel model = new UsuarioModel();
            return model.Autenticar(correo, password);
        }

        /// <summary>
        /// Esta funcion se utiliza para registrar a los usuarios
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool RegistrarUsuario(Usuario usuario)
        {
            UsuarioModel model = new UsuarioModel();
            return model.Registrar(usuario);
        }

        //Esta funcion se utiliza para autenticar a los usuarios
        public bool CambiarPassword(int idUsuario, string nuevaPass)
        {
            UsuarioModel model = new UsuarioModel();
            return model.CambiarPassword(idUsuario, nuevaPass);
        }

        /// <summary>
        /// Esta funcion se utiliza para realizar una busqueda de los usuarios por correo
        /// </summary>
        /// <param name="correo"></param>
        /// <returns></returns>
        public Usuario BuscarUsuarioPorCorreo(string correo)
        {
            UsuarioModel model = new UsuarioModel();
            return model.BuscarPorCorreo(correo);
        }

    }

    public class InstitucionEducativa
    {
        private int idInstitucion;
        private string nombreInstitucion;
        private string correoInstitucion;
        private string direccion;
        private string descripción;

        public InstitucionEducativa() { }
        public int IdInstitucion { get { return idInstitucion; } set { idInstitucion = value; } }
        public string NombreInstitucion { get { return nombreInstitucion; } set { nombreInstitucion = value; } }
        public string CorreoInstitucion { get { return correoInstitucion; } set { correoInstitucion = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Descripcion { get { return descripción; } set { descripción = value; } }

        public List<InstitucionEducativa> listaInstituciones()
        {
            List<InstitucionEducativa> lista;
            InstitucionModel inst = new InstitucionModel();
            lista = inst.listaInstitusiones();

            return lista;
        }


    }

    public class Administrador
    {
        private int idAdmin;
        private string nombres;
        private string apellidos;
        private string institucion;
        private string idUsuario;
        public Administrador() { }

        public int IdDirectorProyecto { get { return idAdmin; } set { idAdmin = value; } }
        public string IdUser { get { return idUsuario; } set { idUsuario = value; } }

        public string Institucion { get { return institucion; } set { institucion = value; } }
        public string Nombre { get { return nombres; } set { nombres = value; } }
        public string Apellido { get { return apellidos; } set { apellidos = value; } }

        public bool registroAdministrador(Administrador admin)
        {
            AdministradorModel administradorModel = new AdministradorModel();

            return administradorModel.Registrar(admin);

        }

    }

    public class DirectorProyecto
    {
        private int idDirectorProyecto;
        private string nombres;
        private string apellidos;
        private string institucion;
        private string idUsuario;
        public DirectorProyecto() { }

        public int IdDirectorProyecto { get { return idDirectorProyecto; } set { idDirectorProyecto = value; } }
        public string IdUser { get { return idUsuario; }set { idUsuario = value; }}
        public string Institucion { get { return institucion; } set { institucion = value; } }
        public string Nombre { get { return nombres; } set { nombres = value; } }
        public string Apellido { get { return apellidos; } set { apellidos = value; } }

        /// <summary>
        /// Este metodo registra un director de proyecto en la base de datos
        /// </summary>
        /// <param name="director"></param>
        /// <returns></returns>
        public bool registroDirector(DirectorProyecto director)
        {
            DirectorModel directorModel = new DirectorModel();

            return directorModel.Registrar(director);

        }

        /// <summary>
        /// Este metodo devuelve la lsita de todos los directores de proyecto registrados en la base de datos
        /// </summary>
        /// <returns></returns>
        public List<DirectorProyecto> listarDirectores()
        {
            List<DirectorProyecto> director;
            DirectorModel directorModel = new DirectorModel();


            return director=directorModel.listaDirectoresProyecto();
        }

    }

    public class Investigador
    {
        private int idInvestigador;
        private string nombres;
        private string apellidos;
        private string institucion;
        private string idUsuario;
        public Investigador() { }

        public int IdInvestigador { get { return idInvestigador; } set { idInvestigador = value; } }
        public string IdUser { get { return idUsuario; } set { idUsuario = value; } }
        public string Institucion { get { return institucion; } set { institucion = value; } }
        public string Nombre { get { return nombres; } set { nombres = value; } }
        public string Apellido { get { return apellidos; } set { apellidos = value; } }

        public bool registroInvestigador(Investigador investigador)
        {
            InvestigadorModel invest = new InvestigadorModel();

            return invest.Registrar(investigador);

        }

    }


    public class Telefono
    {
        private int idTelefono;
        private string telefono1;
        private string telefono2;
        private string telefono3;
        private int idInstitucion;
        private int idAdmin;
        private int idDirectorProyecto;
        private int idInvestigador;



        public Telefono() { }


        public int IdTelefono { get { return idTelefono; } set { idTelefono = value; } }
        public string Telefono1{get { return telefono1; }set { telefono1 = value; }}

        public string Telefono2{get { return telefono2; }set { telefono2 = value; }}

        public string Telefono3{get { return telefono3; }set { telefono3 = value; }}
        public int IdInstitucion { get { return idInstitucion; } set { idInstitucion = value; } }
        public int IdAdmin { get { return idAdmin; } set { idAdmin = value; } }
        public int IdDirectorProyecto { get { return idDirectorProyecto; } set { idDirectorProyecto = value; } }
        public int IdInvestigador { get { return idInvestigador; } set { idInvestigador = value; } }

    }

    public class AreaTematica
    {
        private int idAreaTematica;
        private string nombreArea;
        private string descripcionArea;

        public AreaTematica() { }

        public AreaTematica(string nombreArea, string descripcionArea) {
            
            this.nombreArea = nombreArea;
            this.descripcionArea = descripcionArea;
            
        }


        public int IdAreaTematica { get { return idAreaTematica; } set { idAreaTematica = value; } }
        public string NombreArea{get { return nombreArea; }set { nombreArea = value; }}

        public string DescripcionArea{get { return descripcionArea; }set { descripcionArea = value; }}


        /// <summary>
        /// Este metodo hace un insert en la tabla de areas tematicas
        /// </summary>
        /// <param name="areaTematica"></param>
        public void crearArea(AreaTematica areaTematica)
        {
            AreaTematicaModel areaTematicaModel = new AreaTematicaModel();

            areaTematicaModel.insertarAreaTematica(areaTematica);


        }

        /// <summary>
        /// Este metodo verifica si existen areas tematicas que mostrar si no existen devuelve false
        /// </summary>
        /// <returns></returns>
        public bool hayAreasTematicas()
        {

            bool hayElemtosEnlaLista = false;

            AreaTematicaModel area = new AreaTematicaModel();

            List<AreaTematica> lista = area.listaAreaTematica();

            if (lista != null && lista.Count > 0)
            {
                hayElemtosEnlaLista = true;
            }

            return hayElemtosEnlaLista;
        }

        public List<AreaTematica> listarAreasTematicas()
        {
            AreaTematicaModel areaModel = new AreaTematicaModel();
            return areaModel.listaAreaTematica();
        }



    }

    public class Producto
    {
        private int idProducto;
        private string nombreProducto;
        private string tipoProducto;
        private DateTime fechaEntrega;
        private string descripcionProducto;
        private int idProyecto;

        public Producto() { }

        public int IdProducto { get { return idProducto; } set { idProducto = value; } }
        public string NombreProducto{get { return nombreProducto; }set { nombreProducto = value; }}

        public string TipoProducto{get { return tipoProducto; }set { tipoProducto = value; }}

        public DateTime FechaEntrega{get { return fechaEntrega; }set { fechaEntrega = value; }}

        public string DescripcionProducto{get { return descripcionProducto; }set { descripcionProducto = value; }}

        public int IdProyecto { get { return idProyecto; } set { idProyecto = value; }}
    }

    public class Proyecto
    {
        private int idProyecto;
        private string nombreProyecto;
        private string descripcion;
        private DateTime fechaInicio;
        private DateTime fechafin;
        private string estado;
        private int idareaTematica;
        private int idDirectorproyecto;

        public Proyecto() { }

        public int IdProyecto { get { return idProyecto; } set { idProyecto = value; } }
        public string NombreProyecto {get { return nombreProyecto; } set { nombreProyecto = value; }}

        public string Descripcion {get { return descripcion; }set { descripcion = value; } }

        public DateTime FechaInicio {get { return fechaInicio; }set { fechaInicio = value; }}

        public DateTime FechaFin {get { return fechafin; }set { fechafin = value; }}

        public string Estado {get { return estado; }set { estado = value; }}

        public int IdAreaTematica {get { return idareaTematica; }set { idareaTematica = value; }}

        public int IdDirectorProyecto{get { return idDirectorproyecto; }set { idDirectorproyecto = value; }}


        public void registrarProyecto(Proyecto proyecto)
        {
            ProyectoModel proyectoModel = new ProyectoModel();
            proyectoModel.insertarProyecto(proyecto);

        }


        public List<Proyecto> ListarProyecto()
        {
            ProyectoModel proyectoModel = new ProyectoModel();
            return proyectoModel.listaProyectos();

        }

        public void elimnarProyecto(int idProyecto)
        {
            ProyectoModel proyectoModel = new ProyectoModel();
            proyectoModel.eliminarProyecto(idProyecto);
        }

        public void actualizarProyecto(int id, string estado)
        {
            ProyectoModel proyectoModel = new ProyectoModel();
            proyectoModel.actualizarEstadoProyecto(id, estado);
        }

    }





}
