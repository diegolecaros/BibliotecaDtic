using System.ComponentModel;
namespace BibliotecaDtiC.Models
{
    public enum Autor
    {
        [Description("Stephen King")]
        StephenKing = 0,
        [Description("J.K. Rowling")]
        JKRowling = 1,
        [Description("George R.R. Martin")]
        GeorgeRRMartin = 2,
    }
}
