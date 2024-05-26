using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Extensions
{
    public static class EnumExtensions
    {
        public static string? AsReadable(this DayOfWeek value, string? undefinedDescription = null)
        {
            return value switch
            {
                DayOfWeek.Sunday => "Domingo",
                DayOfWeek.Monday => "Segunda-feira",
                DayOfWeek.Tuesday => "Terça-feira",
                DayOfWeek.Wednesday => "Quarta-feira",
                DayOfWeek.Thursday => "Quinta-feira",
                DayOfWeek.Friday => "Sexta-feira",
                DayOfWeek.Saturday => "Sábado",
                _ => undefinedDescription
            };
        }

        public static string? AsShortReadable(this DayOfWeek value, string? undefinedDescription = null)
        {
            return value switch
            {
                DayOfWeek.Sunday => "DOM",
                DayOfWeek.Monday => "SEG",
                DayOfWeek.Tuesday => "TER",
                DayOfWeek.Wednesday => "QUA",
                DayOfWeek.Thursday => "QUI",
                DayOfWeek.Friday => "SEX",
                DayOfWeek.Saturday => "SAB",
                _ => undefinedDescription
            };
        }
    }
}
