using System;

namespace ConsoleApp.Clases.BolsaEmpleo
{
    public class Personas
    {
        private int id = 0;
        private string cedula = "";
        private string nombre = "";
        private string direccion = "";
        private string cargo = "";
        private string estado = "";



        public int Id { get => this.id; set => this.id = value; }
        public string Cedula { get => this.cedula; set => this.cedula = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Direccion { get => this.direccion; set => this.direccion = value; }
        public string Cargo { get => this.cargo; set => this.cargo = value; }
        public string Estado { get => this.estado; set => this.estado = value; }
    }

    public class Estudios
    {
        private int id = 0;
        private int cod_estudio = 0;
        private string nom_estudi = "";
        private Personas? persona = null;


        public int Id { get => this.id; set => this.id = value; }
        public int Cod_estudio { get => this.cod_estudio; set => this.cod_estudio = value; }
        public string Nom_estudi { get => this.nom_estudi; set => this.nom_estudi = value; }

        public Personas? Persona { get => this.persona; set => this.persona = value; }
    }

    public class Empresas
    {
        private int id = 0;
        private int cod_empre = 0;
        private string nom_empre = "";
        private string direc_empresa = "";
        

        public int Id { get => this.id; set => this.id = value; }
        public int Cod_empre { get => this.cod_empre; set => this.cod_empre = value; }
        public string Nom_empre { get => this.nom_empre; set => this.nom_empre = value; }
        public string Direc_empresa { get => this.direc_empresa; set => this.direc_empresa = value; }
    }

    public class Vacantes
    {
        private int id = 0;
        private string nomb_vac = "";
        private Empresas? empresa = null;

        public int Id { get => this.id; set => this.id = value; }
      
        public string Nomb_vac { get => this.nomb_vac; set => this.nomb_vac = value; }
        public Empresas? Empresa { get => this.empresa; set => this.empresa = value; }
    }

    public class Postulaciones
    {
        private int id = 0;

        private Empresas? empresa = null;
        private Personas? persona = null;
        private Vacantes? vacante = null;

        public int Id { get => this.id; set => this.id = value; }
        public Empresas? Empresas {get => this.empresa; set => this.empresa = value;}
        public Personas? Persona { get => this.persona; set => this.persona = value; }
        public Vacantes? Vacante { get => this.vacante; set => this.vacante = value; }
        
    }

    public class Login
    {
        private int id = 0;
        private string usiario = "";
        private string contraseña = "";

        public int Id { get => this.id; set => this.id = value; }
        public string Usiario { get => this.usiario; set => this.usiario = value; }
        public string Contraseña { get => this.contraseña; set => this.contraseña = value; }
        
    }
}