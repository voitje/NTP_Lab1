using System.ComponentModel;

namespace Salary
{
    /// <summary>
    /// Перечисление сущностей
    /// </summary>
    public enum TypeSalary : byte
    {
        [Description("По часам")]
        Hourly,
        [Description("По окладу и ставке")]
        Rate,
    }
}
