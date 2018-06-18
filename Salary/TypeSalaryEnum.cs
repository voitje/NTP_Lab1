using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
