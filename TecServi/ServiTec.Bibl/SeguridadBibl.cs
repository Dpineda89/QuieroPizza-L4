using ServiTec.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ServiTec.Bibl
{
    public class SeguridadBibl
    {
        ServiTexContext _Contexto;
        public SeguridadBibl() 
        {
            _Contexto = new ServiTexContext();
        }
        public bool Autorizar(string nombreUsuario, string contrasena)
        {
            var contraseñaEncriptada = Encriptar.CodificarContrasena(contrasena);
            var usuario = _Contexto.Usuarios
                .FirstOrDefault(p => p.Nombre == nombreUsuario &&
                p.Contrasena == contraseñaEncriptada);

            if (usuario != null)
            {
                return true;
            }

            return false;
        }
    }
    
    public static class Encriptar
    {
        public static string CodificarContrasena(string contrasena)
        {
            var salt = "UNAH";

            byte[] bIn = Encoding.Unicode.GetBytes(contrasena);
            byte[] bSalt = Convert.FromBase64String(salt);
            byte[] bAll = new byte[bSalt.Length + bIn.Length];

            Buffer.BlockCopy(bSalt, 0, bAll, 0, bSalt.Length);
            Buffer.BlockCopy(bIn, 0, bAll, bSalt.Length, bIn.Length);
            HashAlgorithm s = HashAlgorithm.Create("SHA512");
            byte[] bRet = s.ComputeHash(bAll);

            return Convert.ToBase64String(bRet);
        }
    }
}


