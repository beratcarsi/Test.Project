using EFatura.Core.UBLTypes.UBLv21.Udt;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Test.Project.Core
{
    public class TableClass
    {
        private List<KeyValuePair<string, Type>> _fieldInfo = new List<KeyValuePair<string, Type>>();
        private string _className;

        private Dictionary<Type, string> dataMapper
        {
            get
            {
                var dataMapper = new Dictionary<Type, string>();
                dataMapper.Add(typeof(long), "BIGINT");
                dataMapper.Add(typeof(int), "INT");
                dataMapper.Add(typeof(string), "NVARCHAR(MAX)");
                dataMapper.Add(typeof(byte), "TINYINT");
                dataMapper.Add(typeof(bool), "BIT");
                dataMapper.Add(typeof(DateTime), "DATETIME");
                dataMapper.Add(typeof(float), "FLOAT");
                dataMapper.Add(typeof(decimal), "DECIMAL(18,2)");
                dataMapper.Add(typeof(Guid), "UNIQUEIDENTIFIER");

                // for UBL types
                dataMapper.Add(typeof(AmountType), "DECIMAL(18,2)");
                //dataMapper.Add(typeof(BinaryObjectType), "NVARCHAR(MAX)"); // cctscctBinaryObjectType object
                dataMapper.Add(typeof(CodeType), "NVARCHAR(MAX)");
                dataMapper.Add(typeof(GraphicType), "NVARCHAR(MAX)");
                dataMapper.Add(typeof(DateType), "DATETIME");
                dataMapper.Add(typeof(TimeType), "DATETIME");
                dataMapper.Add(typeof(IdentifierType), "UNIQUEIDENTIFIER");
                dataMapper.Add(typeof(IndicatorType), "NVARCHAR(MAX)");
                dataMapper.Add(typeof(MeasureType), "NVARCHAR(MAX)");
                dataMapper.Add(typeof(NameType), "NVARCHAR(MAX)");
                dataMapper.Add(typeof(NumericType), "DECIMAL(18,2)");
                dataMapper.Add(typeof(PercentType), "DECIMAL(18,2)");
                dataMapper.Add(typeof(QuantityType), "DECIMAL(18,2)");
                dataMapper.Add(typeof(RateType), "DECIMAL(18,2)");
                dataMapper.Add(typeof(EFatura.Core.UBLTypes.UBLv21.Udt.ValueType), "DECIMAL(18,2)");
                dataMapper.Add(typeof(TextType), "NVARCHAR(MAX)");

                return dataMapper;
            }
        }

        public List<KeyValuePair<string, Type>> Fields
        {
            get { return this._fieldInfo; }
            set { this._fieldInfo = value; }
        }

        public string ClassName
        {
            get { return this._className; }
            set { this._className = value; }
        }

        public TableClass(Type t)
        {
            this._className = t.Name;

            foreach (PropertyInfo p in t.GetProperties())
            {
                var field = new KeyValuePair<string, Type>(p.Name, p.PropertyType);
                this.Fields.Add(field);
            }
        }

        public string CreateTableScript()
        {
            var script = new StringBuilder();

            script.AppendLine("CREATE TABLE " + this.ClassName);
            script.AppendLine("(");
            //script.AppendLine("\t Id INT,");
            for (int i = 0; i < this.Fields.Count; i++)
            {
                KeyValuePair<string, Type> field = this.Fields[i];

                if (dataMapper.ContainsKey(field.Value))
                {
                    script.Append("\t " + field.Key + " " + dataMapper[field.Value]);
                }
                else
                {
                    // Complex Type? 
                    script.Append("\t " + field.Key + " " + field.Value.Name);
                    //script.Append("\t " + field.Key + " INT");
                }

                if (i != this.Fields.Count - 1)
                    script.Append(",");

                script.Append(Environment.NewLine);
            }

            script.AppendLine(")");


            return script.ToString();
        }

    }
}
