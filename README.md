Como criar novo projeto MVC aula07

Aplicativo Web ASP.NET Core
Botar nome e criar
escolher Web Application ( controlador de vista de modelos)
Na pasta Modelo click direito adicionar classe > classe e escolher nome


Click direito na pasta Model > adicional> Classe > sellecionar classe e dar um nome UsuarioModel
criar propet de nome, sobrenome... get set

Click direito na pasta Model > adicional> Classe > sellecionar classe e dar um nome UsuarioTeste
criar uma lista usando a classe UsuarioModel
criar um construtor de UsuarioTeste e dentro botar listaUsuario.add({ nome = "aaaa", sobrenom ... })para adicionar. 
Logo duplicar o adicionar outra listaUsuario 

criar um Metodo CriaUsuario pasando parametro UsuarioModel e adicionar uma lista de usuarioModelo
public void CriarUsuario(UsuarioModel usuarioMod){
            usuariosList.Add(usuarioMod);
        }

criar um Metodo AtualizaUsuario pasando parametro UsuarioModel e fazer um foreach para percorrer a listaUsuario. 
dentro dele num if verificamos si o email ja existe, se existe remove e adiciona novo usuario
public void AtualizaUsuario(UsuarioModel usuarioMode){
            foreach(UsuarioModel u in usuariosList) {
            if(u.email == usuarioMode.email)
                {
                    usuariosList.Remove(u);
                    usuariosList.Add(usuarioMode);
                }
            }
        }
