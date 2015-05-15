using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private String cliDNI;
        private String cliNombre;
        private String cliApellido;
        private String cliSexo;
        private DateTime cliFechaNacimiento;
        private Decimal cliIngresos;
        private String cliDireccion;
        private String cliTelefono;

        public String CliDNI
        {
            get { return cliDNI; }
            set { cliDNI = value; }
        }

        public String CliNombre
        {
            get { return cliNombre; }
            set { cliNombre = value; }
        }

        public String CliApellido
        {
            get { return cliApellido; }
            set { cliApellido = value; }
        }

        public String CliSexo
        {
            get { return cliSexo; }
            set { cliSexo = value; }
        }

        public DateTime CliFechaNacimiento
        {
            get { return cliFechaNacimiento; }
            set { cliFechaNacimiento = value; }
        }

        public Decimal CliIngresos
        {
            get { return cliIngresos; }
            set { cliIngresos = value; }
        }
        
        public String CliDireccion
        {
            get { return cliDireccion; }
            set { cliDireccion = value; }
        }
        

        public String CliTelefono
        {
            get { return cliTelefono; }
            set { cliTelefono = value; }
        }
        
        public Cliente()
        {

        }

        public Cliente(string dni,string nombre,string apellido,string sexo,DateTime fechaNacimiento,decimal ingresos,string direccion,string telefono)
        {
            CliDNI = dni;
            CliNombre = nombre;
            CliApellido = apellido;
            CliSexo = sexo;
            CliFechaNacimiento = fechaNacimiento;
            CliIngresos = ingresos;
            CliDireccion = direccion;
            CliTelefono = telefono;
        }
    }
}
