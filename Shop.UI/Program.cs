/*
		1. Регистрация и вход (смс-код / email код) - сделать до 11.10 (Email есть на метаните)
		2. История покупок 
		3. Категории и товары (картинка в файловой системе)
		4. Покупка (корзина), оплата и доставка (PayPal/Qiwi/etc)
		5. Комментарии и рейтинги
		6. Поиск (пагинация - постраничность)

		Кто сделает 3 версии (Подключенный, автономный и EF) получит автомат на экзамене
*/

using Shop.DataAccess;
using Shop.DataAccess.Abstract;
using Shop.Domain;
using System;

namespace Shop.UI
{
	class Program
	{
		static void Registration()
		{
			string phoneNum,email,address,pass,verCode;
			Console.WriteLine("Введите номер телефона: ");
			phoneNum = Console.ReadLine();
			Console.WriteLine("Введите почту: ");
			email = Console.ReadLine();
			Console.WriteLine("Введите адрес: ");
			address = Console.ReadLine();
			Console.WriteLine("Введите пароль: ");
			pass = Console.ReadLine();
			Console.WriteLine("Введите секретный код (???): ");
			verCode = Console.ReadLine();

			User user = new User
			{
				PhoneNumber = phoneNum,
				Email = email,
				Address = address,
				Password = pass,
				VerificationCode = verCode
			};
			IUserRepository repository = new UserRepository();
			repository.Add(user);
			var res = repository.GetAll();
			;
		}

		static void Main(string[] args)
		{
			Registration();
			;
			return;
			Category category = new Category
			{
				Name = "Бытовая техника",
				ImagePath = "C:/data"
			};
			User user = new User
			{
				PhoneNumber = "8-800-555-35-35",
				Email = "pochta@example.com",
				Address = "Kazakhstan,Astana,Moldagulova 65, kv 52",
				Password = "qwerty123",
				VerificationCode = "GSDBQ521"
			};
			/*
			ICategoryRepository repository = new CategoryRepository();
			repository.Add(category);
			var res = repository.GetAll();
			*/
			IUserRepository repository = new UserRepository();
			var res = repository.GetAll();
			repository.Add(user);
			;
		}
	}
}
