using System;

namespace MongoDbDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");

            //PersonModel person = new PersonModel
            //{
            //    FirstName = "Ribhu",
            //    LastName = "Goel",
            //    PrimaryAddress = new AddressModel
            //    {
            //        StreetAddress = "16 Inner Cir",
            //        City = "Scottsdale",
            //        State = "AZ",
            //        ZipCode = "85258"
            //    }
            //};

            // Insert
            //db.InsertRecord("Users", person);
            //db.InsertRecord("Users", new PersonModel { FirstName = "Shreyas", LastName = "Deshmukh"});

            // Load All
            //var recs = db.LoadRecords<PersonModel>("Users");

            //foreach (var rec in recs)
            //{
            //    Console.WriteLine($"{rec.Id} : {rec.FirstName} {rec.LastName}");

            //    if(rec.PrimaryAddress != null)
            //    {
            //        Console.WriteLine(rec.PrimaryAddress.City);
            //    }
            //    Console.WriteLine();
            //}

            // Load by Id
            //var oneRec = db.LoadRecordById<PersonModel>("Users", new Guid("cebe7910-fd42-4974-8212-cce32aa54f0b"));

            // Upsert record
            //oneRec.DateofBirth = new DateTime(1992, 11, 22, 0, 0, 0, DateTimeKind.Utc);
            //db.UpsertRecord("Users", oneRec.Id, oneRec);

            // Delete Record
            //db.DeleteRecord<PersonModel>("Users", oneRec.Id);


            var recs = db.LoadRecords<NameModel>("Users");

            foreach (var rec in recs)
            {
                Console.WriteLine($"{rec.FirstName} {rec.LastName}");

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
