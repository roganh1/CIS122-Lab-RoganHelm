namespace Project_NorthWind_Webapp
{
    public class Employee
    {
        //Class variables
        private int employeeId = -1;
        private string lastName = "n/a";
        private string firstName = "n/a";
        private string title = "n/a";
        private string titleOfCourtesy = "n/a";
        private DateOnly birthdate;
        private DateOnly hireDate;
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string homePhone = "n/a";
        private string extension = "n/a";
        private string notes = "n/a";
        private int reportsTo = -1;

        //Gets and sets
        public int EmployeeId
        {
            get { return this.employeeId; }
            set
            {
                if (value > -1)
                {
                    this.employeeId = value;
                }
                else
                {
                    this.employeeId = 0;
                }
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string TitleOfCourtesy
        {
            get { return this.titleOfCourtesy; }
            set { this.titleOfCourtesy = value; }
        }
        // Come back to lines 174, 175
        public DateOnly BirthDate { get; set; }
        public DateOnly HireDate { get; set; }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string City
        {
            get { return this.City; }
            set { this.City = value; }
        }
        public string Region
        {
            get { return this.Region; }
            set { this.Region = value; }
        }
        public string PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
        }
        public string HomePhone
        {
            get { return this.homePhone; }
            set { this.homePhone = value; }
        }
        public string Extension
        {
            get { return this.extension; }
            set { this.extension = value; }
        }
        public string Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }
        public int ReportsTo
        {
            get { return this.reportsTo; }
            set { this.reportsTo = value; }
        }
        //Methods
        public override string ToString()
        {
            string message = "";
            message = message + "Employeed ID: " + this.EmployeeId + "\n";
            message = message + "Last Name: " + this.LastName + "\n";
            message = message + "First Name: " + this.FirstName + "\n";
            message = message + "Title: " + this.Title + "\n";
            message = message + "Title of Courtesy: " + this.TitleOfCourtesy + "\n";
            message = message + "Address: " + this.Address + "\n";
            message = message + "City: " + this.City + "\n";
            message = message + "Region: " + this.Region + "\n";
            message = message + "Postal Code: " + this.PostalCode + "\n";
            message = message + "Home Phone: " + this.HomePhone + "\n";
            message = message + "Extension: " + this.Extension + "\n";
            message = message + "Notes: " + this.Notes + "\n";
            message = message + "Reports To: " + this.ReportsTo + "\n";
            return message;
        }
        public Employee()
        {
            //Empty constructor
        }
        public Employee(int anEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, DateOnly aBirthdate, DateOnly aHireDate, string anAddress, string aCity, string aRegion, string aPostalCode, string aHomePhone, string anExtension, string someNotes, int reportsTo)
        {
            this.EmployeeId = anEmployeeId;
            this.LastName = aLastName;
            this.FirstName = aFirstName;
            this.Title = aTitle;
            this.TitleOfCourtesy = aTitleOfCourtesy;
            this.birthdate = aBirthdate;
            this.HireDate = aHireDate;
            this.Address = anAddress;
            this.City = aCity;
            this.Region = aRegion;
            this.PostalCode = aPostalCode;
            this.HomePhone = aHomePhone;
            this.Extension = anExtension;
            this.Notes = someNotes;
            this.ReportsTo = reportsTo;
        }
    }
}
