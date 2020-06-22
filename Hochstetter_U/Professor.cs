using System;

namespace Hochstetter_U
{
    public class Professor
    {
        int ProfessorID;
        string FirstName;
        string LastName;

        public void SetProfessor(int pID, String pFirstName, String pLastName)
        {
            ProfessorID = pID;
            FirstName = pFirstName;
            LastName = pLastName;
        }
    }
}
