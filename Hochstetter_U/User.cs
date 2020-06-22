using System;
namespace Hochstetter_U
{
    public class User
    {

        // Static field currentID stores the job ID of the last User that
        // has been created.
        private static int currentID;

        protected int UserID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

        public User()
        {
            UserID = 0;
            FirstName = "";
            LastName = "";
        }

        public User(String uFirstName, String uLastName)
        {   
            UserID = this.GetNextID();
            FirstName = uFirstName;
            LastName = uLastName;
        }

        // Static constructor to initialize the static member, currentID. This
        // constructor is called one time, automatically, before any instance
        // of User is created, or currentID is referenced.
        static User() => currentID = 0;

        // currentID is a static field. It is incremented each time a new
        // instance of User is created.
        protected int GetNextID() => ++currentID;

        // Method Update enables you to update the First and Last name of an
        // existing User object.
        public void Update(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName= lastName;    
        }

        public string GetFullName() {
            return this.FirstName + ' ' + this.LastName;
        }
    }
}
    