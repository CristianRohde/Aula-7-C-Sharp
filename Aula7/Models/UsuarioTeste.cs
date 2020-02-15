using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula7.Models
{
    public class UsuarioTeste
    {
        public List<UsuarioModel> listaUsuario = new List<UsuarioModel>();
        public UsuarioTeste()
        {
            listaUsuario.Add(new UsuarioModel
            {
                nome = "Cristian",
                sobrenome = "Rohde",
                endereco = "Rua aaaaaa",
                email = "cdc@gmail.com",
                nascimento = Convert.ToDateTime("04/12/1983")
            });

            listaUsuario.Add(new UsuarioModel
            {
                nome = "Jose",
                sobrenome = "Bala",
                endereco = "Rua ddd",
                email = "gfg@gmail.com",
                nascimento = Convert.ToDateTime("18/05/1990")
            });
            listaUsuario.Add(new UsuarioModel
            {
                nome = "Dadi",
                sobrenome = "Yans",
                endereco = "Rua jhhj",
                email = "yans@gmail.com",
                nascimento = Convert.ToDateTime("25/10/1989")
            });
        }
        public void CriaUsuario(UsuarioModel usuarioModelo)
        {
            listaUsuario.Add(usuarioModelo);

        }
        public void AtualizaUsuario(UsuarioModel usuarioModelo)
        {
            foreach(UsuarioModel u in listaUsuario)
            {
                if(u.email == usuarioModelo.email)
                {
                    listaUsuario.Remove(u);
                    listaUsuario.Add(usuarioModelo);
                }
            }
        }
        public UsuarioModel GetUsuario(string Email)
        {
            UsuarioModel u = null;
            foreach(UsuarioModel usuario in listaUsuario)
            {
                if (usuario.email == Email)
                {
                    u = usuario;
                }
            }
            return u;
        }
        public void DeletarUsuario(string Email)
        {
            foreach(UsuarioModel usuario in listaUsuario)
            {
                if(usuario.email == Email)
                {
                    listaUsuario.Remove(usuario);
                    break;
                }
            }
        }
    }
}
