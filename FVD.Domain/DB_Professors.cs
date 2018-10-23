using System.Collections.Generic;

namespace FVD.Domain
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
