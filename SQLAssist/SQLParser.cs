using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLAssist
{
    class SQLParser
    {

        /*
         * Going to pass in some manner of array or list of the fields and their values. Might have to do a custom object with table name attached
         * Return will be INSERT INTO <tablename> (field1, field2, field3, field4, etc) VALUES('strvalue1','strvalue2',numvalue,NULL, etc)
         
         */
        string ConvertToInsert(string tablename, string[] fields, string[] values)
        {
            string insertSyntax = "INSERT INTO %1 (%2) VALUES (%3)";

            string fieldsFormatted = FormatToDelimited(fields);
            string valuesFormatted = FormatToDelimited(values);

            return string.Format(insertSyntax, tablename, fieldsFormatted, valuesFormatted);
        }

        string FormatToDelimited(string[] input)
        {
            return input.ToString();
        }
    }
}
