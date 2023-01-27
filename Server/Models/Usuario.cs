using System.ComponentModel.DataAnnotatios;
using facturacion_2023.Shared.Requests;

namespace facturacion_2023.Server.Models;

//Representa la esctructura de datos del usuario.(la tabla en la DB).
public class Usuario

{
 [Key]
 public int Id {get;set;}
 public int usuarioRolId { get; set;}
 public UsuarioRol UsuarioRol {get;set;} = default!;
 public string Name {get; set;} = null!;
 public string Nickname {get; set;} = null!;
 public string Password {get; set;} = null!;
 public virtual Icollection<UsuarioRol>? ususario {get; set;}

 public static Ususario Crear(UsuarioRequest request)
 {
    return new Ususario(){
        UsuarioRolId = request.UsuarioRolId,
        Name.request.Name,
        Nickname = request.Nickname,
        Password = request.Password

    };
 }
 public void Editar (UsuarioRequest resqueset)
 {
    usuarioRolId = resqueset.UsuarioRolId;
    Name = resqueset.Name;
    Nickname = resqueset.Nickname;
    //password = request.password;

 }
}