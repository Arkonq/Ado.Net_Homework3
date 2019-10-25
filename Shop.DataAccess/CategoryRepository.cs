using Shop.DataAccess.Abstract;
using Shop.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Shop.DataAccess
{
	public class CategoryRepository : ICategoryRepository
	{
		private const string CONNECTION_STRING = "Server=A-305-04;Database=ShopDB;Trusted_Connection=True;";
		/*
		 * 1. Открыть подключение
		 * 2. Создать запрос
		 * 3. Выполнить запрос
		 * 4. Закрыть подключение
		*/
		public void Add(Category category)
		{
			using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
			using (SqlCommand sqlCommand = connection.CreateCommand())
			{
				string query = $"INSERT INTO Categories " +
						$"VALUES (" +
						$"'{category.Id}', " +
						$"'{category.CreationDate.ToString("yyyy-MM-dd HH:mm:ss.fff")}', " +
						$"'{category.DeletedDate}', " +
						$"'{category.Name}'," +
						$"'{category.ImagePath}');";
				sqlCommand.CommandText = query;

				connection.Open();
				sqlCommand.ExecuteNonQuery();
			}
		}

		public void Delete(Guid categoryId)
		{
			throw new NotImplementedException();
		}

		public ICollection<Category> GetAll()
		{
			using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
			using (SqlCommand sqlCommand = connection.CreateCommand())
			{
				string query = "SELECT * FROM Categories";
				sqlCommand.CommandText = query;

				connection.Open();
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

				List<Category> categories = new List<Category>();
				while (sqlDataReader.Read())
				{
					categories.Add(new Category
					{
						Id = Guid.Parse(sqlDataReader["id"].ToString()),
						CreationDate = DateTime.Parse(sqlDataReader["creationDate"].ToString()),
						DeletedDate = DateTime.Parse(sqlDataReader["deletedDate"].ToString()),
						Name = sqlDataReader["name"].ToString(),
						ImagePath = sqlDataReader["imagePath"].ToString()
					});
				}
				return categories;
			}
		}

		public void Update(Category category)
		{
			throw new NotImplementedException();
		}
	}
}
