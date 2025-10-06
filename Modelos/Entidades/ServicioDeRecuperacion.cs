using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Modelos.Entidades
{
    public class ServicioDeRecuperacion
    {
        private string token;
        private string nombreUsuario;

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Token { get => token; set => token = value; }

        // Genera el token y envía correo
        public string RecuperarContra(string userRequesting)
        {
            try
            {
                bool usuarioEncontrado = false;

                // Buscar usuario en BD
                using (SqlConnection sql = Conexion.Conectar())
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = sql;
                        command.CommandText = "SELECT nombreUsuario FROM Usuario WHERE nombreUsuario = @user";
                        command.Parameters.AddWithValue("@user", userRequesting);
                        command.CommandType = CommandType.Text;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                NombreUsuario = reader["nombreUsuario"].ToString();
                                usuarioEncontrado = true;
                            }
                        }
                    }
                }

                if (!usuarioEncontrado)
                    return "Lo lamentamos, no existe un usuario con este nombre de usuario.";

                // Generar token temporal y guardarlo en la propiedad
                this.Token = Guid.NewGuid().ToString("N").Substring(0, 8);

                // Enviar correo con el token
                using (var mailService = new SoporteDeContrasena("noedavidsaraviasiliezar345@gmail.com", "thsuzoavqvnpcjvv"))
                {
                    bool emailEnviado = mailService.EnviarMail(
                        subject: "SYSTEM: Recuperación de contraseña",
                        body: $"Hola!, {NombreUsuario}\n\nSe ha generado un token temporal para entrar al sistema.\n" +
                              $"Tu token temporal es: {this.Token}\n\n" +
                              "Por favor ingresa el token correctamente en la aplicación.",
                        recipientMail: new List<string> { NombreUsuario }
                    );

                    return emailEnviado
                        ? $"Hola, {NombreUsuario}\nRevisa tu email: {NombreUsuario}"
                        : $"Error enviando email a {NombreUsuario}";
                }
            }
            catch (Exception ex)
            {
                return $"Error en la recuperación de contraseña: {ex.Message}";
            }
        }

        // Consultar el token actual (solo para depuración)
        public string ConsultarToken()
        {
            return this.Token ?? "No se ha generado ningún token aún";
        }

        // Validar que el token ingresado coincida con el generado
        public bool ValidarToken(string tokenIngresado)
        {
            return !string.IsNullOrEmpty(this.Token) && this.Token.Equals(tokenIngresado);
        }

        // Actualizar clave en BD
        public bool ActualizarClave(string nuevaclave)
        {
            using (SqlConnection sql = Conexion.Conectar())
            {
                using (var updateCmd = new SqlCommand(
                    "UPDATE Usuario SET clave = @nuevaClave WHERE nombreUsuario = @user", sql))
                {
                    updateCmd.Parameters.AddWithValue("@nuevaClave", nuevaclave);
                    updateCmd.Parameters.AddWithValue("@user", NombreUsuario);

                    updateCmd.ExecuteNonQuery();
                    return true;
                }
            }
        }
    }
}
