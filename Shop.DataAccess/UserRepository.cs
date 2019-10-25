using Shop.DataAccess.Abstract;
using Shop.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Shop.DataAccess
{
	public class UserRepository : IUserRepository
	{
		private const string CONNECTION_STRING = "Server=A-305-04;Database=ShopDB;Trusted_Connection=True;";
		public void Add(User user)
		{
			using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
			using (SqlCommand sqlCommand = connection.CreateCommand())
			{
				string query = $"INSERT INTO Users " +
						$"VALUES (" +
						$"'{user.Id}', " +
						$"'{user.CreationDate.ToString("yyyy-MM-dd HH:mm:ss.fff")}', " +
						$"'{user.DeletedDate}', " +
						$"'{user.PhoneNumber.ToString()}'," +
						$"'{user.Email.ToString()}'," +
						$"'{user.Address.ToString()}'," +
						$"'{user.Password.ToString()}'," +
						$"'{user.VerificationCode.ToString()}');";
				sqlCommand.CommandText = query;

				connection.Open();
				sqlCommand.ExecuteNonQuery();
			}
		}

		public void Delete(Guid userId)
		{
			using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
			using (SqlCommand sqlCommand = connection.CreateCommand())
			{
				//INSERT INTO Customer (FirstName, LastName, City, Country, Phone)
				//VALUES('Craig', 'Smith', 'New York', 'USA', 1 - 01 - 993 2800)
				string query = $"INSERT INTO Users (deletedDate) VALUES ('{DateTime.Now});";
				sqlCommand.CommandText = query;

				connection.Open();
				sqlCommand.ExecuteNonQuery();
			}
		}

		public ICollection<User> GetAll()
		{
			using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
			using (SqlCommand sqlCommand = connection.CreateCommand())
			{
				string query = "SELECT * FROM Users";
				sqlCommand.CommandText = query;

				connection.Open();
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

				List<User> users = new List<User>();
				while (sqlDataReader.Read())
				{
					users.Add(new User
					{
						Id = Guid.Parse(sqlDataReader["id"].ToString()),
						CreationDate = DateTime.Parse(sqlDataReader["creationDate"].ToString()),
						DeletedDate = DateTime.Parse(sqlDataReader["deletedDate"].ToString()),
						PhoneNumber = sqlDataReader["phoneNumber"].ToString(),
						Email = sqlDataReader["email"].ToString(),
						Address = sqlDataReader["address"].ToString(),
						Password = sqlDataReader["password"].ToString(),
						VerificationCode = sqlDataReader["verificationCode"].ToString()
					});
				}
				return users;
			}
		}

		public void Update(User user)
		{
			throw new NotImplementedException();
		}
	}
}
