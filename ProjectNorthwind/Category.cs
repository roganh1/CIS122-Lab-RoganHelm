using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthwind
{
    internal class Category
    {
        //Class Variables
        private int categoryId = -1;
        private string categoryName = "n/a";
        private string description = "n/a";

        //Gets and Sets
        public int CategoryId
        {
            get { return this.categoryId; }
            set
            {
                if (value > -1)
                {
                    this.categoryId = value;
                }
                else
                {
                    this.categoryId = 0;
                }
            }
        }
        public string CategoryName
        {
            get { return this.categoryName; }
            set { this.categoryName = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        
        //Methods
        public override string ToString()
        {
            string message = "";
            message = message + "Category ID: " + this.CategoryId + "\n";
            message = message + "Category Name: " + this.CategoryName + "\n";
            message = message + "Description: " + this.Description + "\n";
            return message;
        }
        public Category()
        {
            //Empty constructor
        }
        public Category(int categoryId, string categoryName, string description)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            Description = description;
        }
    }
}
