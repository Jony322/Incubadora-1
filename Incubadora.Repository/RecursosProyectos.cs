
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Incubadora.Repository
{

using System;
    using System.Collections.Generic;
    
public partial class RecursosProyectos
{

    public string Id { get; set; }

    public string IdProyecto { get; set; }

    public string IdRecurso { get; set; }

    public int IntParticipacion { get; set; }



    public virtual Proyectos Proyectos { get; set; }

    public virtual Recursos Recursos { get; set; }

}

}
