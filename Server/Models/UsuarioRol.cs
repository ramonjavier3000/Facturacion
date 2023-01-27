namespace facturacion_2023.Server.Models;

    public class UsuarioRol
{
    [Key]
 public int Id {get;set;}
 public string Name {get; set;} = null!;
 public  int MyProperty {get; set;}
 public bool permisoParaCrear {get; set;}
 public bool permisoParaEditar {get; set;}
 public bool permisoParaEliminar {get; set;}
    public virtual  IColletion<UsuarioRol>? Usuarios {get; set; }


}
