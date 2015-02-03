using System;
using System.Collections.Generic;
using System.Text;

namespace CoderBro
{
    class ClassField
    {
        public string FieldName { get;set; }
        public string FieldNameWithType { get; set; }

        public string _dataType;
        public string DataType
        {
            get { return _dataType; }
            set { value =_dataType;} 
        }

        public string IsNullable { get;set; }
        
        public string CharacterMaximumLength { get; set; }

        public ClassField(string fieldName, string dataType)
        {
            FieldName = fieldName;
            if ((dataType == "varchar") || (dataType == "nvarchar"))
            {
                FieldNameWithType = "public string " + FieldName;
            }

            if (dataType == "int") FieldNameWithType = "public int " + FieldName;
            if (dataType == "smalldatetime") FieldNameWithType = "public DateTime " + FieldName;
            if (dataType == "bit") FieldNameWithType = "public Boolean " + FieldName;
            if (dataType == "decimal") FieldNameWithType = "public decimal " + FieldName;
            
        }

        public override string ToString()
        {
            return FieldName;
        }

    }
}
