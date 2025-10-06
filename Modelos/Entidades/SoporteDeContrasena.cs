using Modelos.Entidades;
using System;

namespace Modelos.Entidades
{
    public class SoporteDeContrasena : OlvidasteLaContraseña
    {
     

        // Constructor que recibe correo y contraseña del remitente
        public SoporteDeContrasena(string correoEmpresa, string contrasenaEmpresa)
            : base(correoEmpresa, contrasenaEmpresa)
        {
          
        }
    }
}
