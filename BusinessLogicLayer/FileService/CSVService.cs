using CsvHelper;
using CsvHelper.Configuration;
using Models.Dto_Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.FileService
{
    public class CSVService : ICSVService
    {
        public async Task<IEnumerable<T>> ReadCSV<T>(Stream file)
        {
            using (var reader = new StreamReader(file))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                MissingFieldFound = null, // Ignore missing fields
            }))
            {
                csv.Context.RegisterClassMap<PersonMap>(); // Register the custom mapping

                var records = csv.GetRecords<T>();
                return records.ToList(); // Assuming you want to return a list.
            }
        }
        public sealed class PersonMap : ClassMap<Person>
        {
            public PersonMap()
            {
                Map(m => m.Name).Name("Name"); // Map the "Name" column in the CSV to the Name property.
                Map(m => m.Age).Name("Age");   // Map the "Age" column in the CSV to the Age property.
            }
        }


    }
}
