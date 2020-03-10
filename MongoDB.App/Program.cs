using System;

namespace MongoDB.App
{
	class Program
	{
		[Obsolete]
		static void Main(string[] args)
		{
			MongoCRUD db = new MongoCRUD("AddressBook");

			//PersonModel person = new PersonModel
			//{
			//	FirstName = "Bill",
			//	LastName = "James",
			//	PrimaryAddress = new AddressModel
			//	{ 
			//		StreetAddress = "101 Oak Street",
			//		City = "Scranton",
			//		State = "PA",
			//		ZipCode = "18512"
			//	}
			//};

			//db.InsertRecord("Users", person);

			var recs = db.LoadRecords<NameModel>("Users");

			foreach (var rec in recs)
			{
				Console.WriteLine($"{ rec.FirstName } {rec.LastName }");
				Console.WriteLine();
			}

			//foreach (var rec in recs)
			//{
			//	Console.WriteLine($"{ rec.Id }: { rec.FirstName } {rec.LastName }");

			//	if (rec.PrimaryAddress != null)
			//	{
			//		Console.WriteLine(rec.PrimaryAddress.City);
			//	}

			//	Console.WriteLine();
			//}

			//var oneRec = db.LoadRecordById<PersonModel>("Users", new Guid("296d5a00-51f2-49aa-8616-a8481b8ab665"));
			//oneRec.DateOfBirth = new DateTime(1992, 10, 31, 0, 0, 0, DateTimeKind.Utc);
			//db.UpsertRecords("Users", oneRec.Id, oneRec);
			//db.DeleteRecord<PersonModel>("Users", oneRec.Id);

			Console.ReadLine();
		}
	}
}
