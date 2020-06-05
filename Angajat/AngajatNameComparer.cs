using System.Collections.Generic;

namespace Angajat
{

    class AngajatNameComparer : IComparer<Angajat>
    {
        public int Compare(Angajat left, Angajat right)
        {
            int comp1 = string.Compare(left.Nume, right.Nume);
            if (comp1 != 0)
                return comp1;
            else
            {
                int comp2 = string.Compare(left.Nume, right.Nume);
                if (comp2 != 0)
                    return comp2;
                return 0;
            }
        }
    }
}
