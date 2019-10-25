using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ado.NetHomework3
{
	public partial class ConnectionForm : Form
	{
		public ConnectionForm()
		{
			InitializeComponent();
		}

		static string serverName;
		private void buttonConnect_Click(object sender, EventArgs e)
		{
			serverName = textBoxServerName.Text;
			string connectionString = $"Server={serverName};Database=master;Trusted_Connection=True;";
			string queryString = "DROP DATABASE IF EXISTS MyDB;" +
													 "CREATE DATABASE MyDB;";
			try
			{
				using (SqlConnection sqlConnection = new SqlConnection(connectionString))
				{
					sqlConnection.Open();
					SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show($"Что-то пошло не так: {exception}");
				return;
			}
			MessageBox.Show("Вау, вы подключились к базе данных!");
		}		
	}
}
