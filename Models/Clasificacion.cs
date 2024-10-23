using System.ComponentModel;

namespace BibliotecaDtiC.Models
{
    public enum Clasificacion
    {
        [Description("Accion")]
        Accion = 0,
        [Description("Drama")]
        Drama = 1,
        [Description("Ciencia Ficcion")]
        CienciaFiccion = 2,
    }
}
