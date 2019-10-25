using System;
using System.Windows.Forms;

namespace Ado.NetHomework3
{
	/*
	Создать базу данных MyDB.  Создать простейшее приложение WinForms, позволяющее пользователю подключаться к базе данных MyDB, 
	используя аутентификацию SQL Server. Для построения строки подключения использовать SqlConnectionStringBuilder.  
	*/
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new ConnectionForm());
		}
	}
}
