using FVD.Domain;
using System.Collections.Generic;

namespace FVD.Data
{
    public static class DB_Professors
    {
        public static List<Professor> professors = new List<Professor>()
        {
            { new Professor("Prof", "Barabas") },
            { new Professor("Prof", "Gobelijn") },
            { new Professor("Prof", "Zonnebloem")}
        };
    }
}
