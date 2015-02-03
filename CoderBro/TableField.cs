using System;
using System.Collections.Generic;
using System.Text;

namespace CoderBro
{
    class TableField
    {
        public string FieldName { get;set; }
        public string FieldNameWithType { get; set; }

        public string ClassField { get; set; }

        public string _dataType;
        public string DataType
        {
            get { return _dataType; }
            set { value =_dataType;} 
        }

        public string IsNullable { get;set; }
        
        public string CharacterMaximumLength { get; set; }

        public TableField(string fieldName, string dataType, string isNullable, string characterMaximumLength)
        {
            FieldName = fieldName;
            //FOR CLASS PPOPERTIES
            if (dataType == "nvarchar") ClassField = "public string " + FieldName+ "=string.Empty;\r" ;
            if (dataType == "varchar") ClassField = "public string " + FieldName+ "=string.Empty;\r" ;
            if (dataType == "int") ClassField = "public int " + FieldName+";\r";
            if (dataType == "smalldatetime") ClassField = "public DateTime " + FieldName + ";\r";
            if (dataType == "bit") ClassField = "public bool " + FieldName + ";\r";
            if (dataType == "decimal") ClassField = "public decimal " + FieldName + ";\r";


            // FOR SP PARAMETERS
          
            if ((dataType == "varchar") || (dataType == "nvarchar"))
            {
                dataType = dataType + "(" + characterMaximumLength + ")";
            }

            string nullcase = string.Empty;
            if (isNullable == "YES") nullcase = "=null";
            FieldNameWithType = FieldName + " " + dataType + nullcase;
        }

        public override string ToString()
        {
            return FieldName;
        }

    }
}
