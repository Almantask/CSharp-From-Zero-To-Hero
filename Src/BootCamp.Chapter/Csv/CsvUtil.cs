using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter.Csv
{
    public static class CsvUtil
    {
        public static List<string> GetPropertiesName(object inputObject)
        {
            List<string> propertyList = new List<string>();

            if (inputObject != null)
            {
                propertyList.AddRange(from property in inputObject.GetType().GetProperties()
                                      select property.Name.ToCamelCase());
            }

            return propertyList;
        }
    }
}