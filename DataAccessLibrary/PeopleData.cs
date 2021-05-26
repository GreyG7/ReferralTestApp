using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class PeopleData : IPeopleData
    {
        private readonly ISqlDataAccess db;

        public PeopleData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public Task<List<PersonModel>> GetPeople()
        {
            string sql = "SELECT * FROM dbo.Person";

            return db.LoadData<PersonModel, dynamic>(sql, new { });
        }

        public Task InsertPerson(PersonModel person)
        {
            string sql = @"INSERT INTO dbo.Person (FirstName, LastName, EmailAddress)
                           VALUES(@FirstName, @LastName, @EmailAddress)";

            return db.SaveData(sql, person);

        }
    }
}
