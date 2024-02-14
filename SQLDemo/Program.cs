using System;
using System.Data.SqlClient;

namespace SQLDemo {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("SQL demo running...");

            string connectionString = "";

            SqlConnection connection = new SqlConnection(connectionString);

            try {
                connection.Open();
                // string cmdText = "SELECT CustomerId, FirstName, LastName, Address, City, State FROM [dbo].[Customer] WHERE Country='Brazil';";

                string cmdText = "SELECT CustomerId, FirstName, LastName, Address, City, State FROM [dbo].[Customer] WHERE CustomerId = 5;";

                using SqlCommand cmd = new SqlCommand(cmdText, connection);

                using SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("Reader Executed...");

                // List<string> names = new List<string>();

                // while (reader.Read()) {
                //     names.Add(reader.GetString(0));
                    
                // }
                List<Customer> customers = new List<Customer>();
                while(reader.Read()) {

                    int? id = reader.GetInt32(0);
                    string? fname = reader.GetString(1) ?? "";
                    string? lname = reader.GetString(2) ?? "";
                    string? address = reader.GetString(3) ?? "";
                    string? city = reader.GetString(4) ?? "";
                    string? state = reader["State"].ToString() ?? "";

                    customers.Add(new Customer(id, fname, lname, address, city, state));
                }



                connection.Close();

                foreach (Customer c in customers) {
                    c.introduction();
                }

                Customer newCustomer = new Customer(9999, "Jim", "BillyBob","Revature", "1 awesomeville", "CoolsTown", "RI", "USA", 02879, "401-777-7777", "806-345-6789", "awesome@cool.net", 1);

                connection.Open();
                string cmdText1 = $"INSERT INTO Customer (CustomerId, FirstName, LastName, Company, Address, City, State, Country, PostalCode, Phone, Fax, Email, SupportRepId) VALUES({newCustomer.id}, '{newCustomer.fname}', '{newCustomer.lname}', '{newCustomer.company}', '{newCustomer.address}', '{newCustomer.city}', '{newCustomer.state}', '{newCustomer.country}', {newCustomer.postal}, '{newCustomer.phone}', '{newCustomer.fax}', '{newCustomer.email}', {newCustomer.repId});";

                string cmdText1 = @"INSERT INTO Customer (CustomerId, FirstName, LastName, Company, Address, City, State, Country, PostalCode, Phone, Fax, Email, SupportRepId) VALUES(@id, '@fname', '@lname', '@company', '@address', '@city', '@state', '@country', @postal, '@phone', '@fax', '@email', @repid);";

       
                using SqlCommand cmd1 = new SqlCommand(cmdText1, connection);

                cmd1.Parameters.AddWithValue("@id", newCustomer.id);
                cmd1.Parameters.AddWithValue("@fname", newCustomer.fname);
                cmd1.Parameters.AddWithValue("@lname", newCustomer.lname);
                cmd1.Parameters.AddWithValue("@company", newCustomer.company);
                cmd1.Parameters.AddWithValue("@address", newCustomer.address);
                cmd1.Parameters.AddWithValue("@city", newCustomer.city);
                cmd1.Parameters.AddWithValue("@state", newCustomer.state);
                cmd1.Parameters.AddWithValue("@country", newCustomer.country);
                cmd1.Parameters.AddWithValue("@postal", newCustomer.postal);
                cmd1.Parameters.AddWithValue("@phone", newCustomer.phone);
                cmd1.Parameters.AddWithValue("@fax", newCustomer.fax);
                cmd1.Parameters.AddWithValue("@email", newCustomer.email);
                cmd1.Parameters.AddWithValue("@repid", newCustomer.repId);



                cmd1.ExecuteNonQuery();
                connection.Close();




            } catch (Exception e) {
                Console.WriteLine(e.Message);
                connection.Close();
            }

            Console.WriteLine("SQL demo ending...");
        }
    }

    public class Customer {
        //fields
        public int? id {get; set;}
        public string? fname{get; set;}
        public string? lname{get; set;}
        public string? company{get; set;}
        public string? address{get; set;}
        public string? city{get; set;}
        public string? state{get; set;}
        public string? country{get; set;}
        public int? postal{get; set;}
        public string? phone{get; set;}
        public string? fax{get; set;}
        public string? email{get; set;}
        public int? repId{get; set;}


        //constructors

        public Customer(int? id, string? fname, string? lname, string? address, string? city, string? state) {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.address = address;
            this.city = city;
            this.state = state;
        }

        public Customer(int? id, string? fname, string? lname, string? company, string? address, string? city, string? state, string? country, int? postal, string? phone, string? fax, string? email, int? repId) {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.address = address;
            this.city = city;
            this.state = state;
            this.country = country;
            this.postal = postal;
            this.phone = phone;
            this.fax = fax;
            this.email = email;
            this.repId = repId;
        }
        //methods
        public void introduction() {
            Console.WriteLine($"ID: {this.id}\n Name: {this.fname} {this.lname}");
        }


    }

}