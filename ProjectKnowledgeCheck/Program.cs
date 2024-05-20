using System;
using ProjectKnowledgeCheck;


public class Program : Record
{
    public static void Main(string[] args)
    {

        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<Record>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var record = new Record();

            Console.WriteLine("Enter the value for ");

            record.NumberOfDisks = int.Parse(Console.ReadLine());
            record.SizeInches = int.Parse(Console.ReadLine());


            recordList.Add(record);
        }

        public override string ToString() => record.ToString();


}
