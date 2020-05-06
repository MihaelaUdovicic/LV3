using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LV3
{
    class Dataset : Prototype
    {
        private List<List<string>> data; //list of lists of strings
        public Dataset()
        {
            this.data = new List<List<string>>();
            
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        
        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
            return
           new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData()
        {
            this.data.Clear();
        }

       
        public string PrintList()
        {

            StringBuilder stringBuilder = new StringBuilder();
            foreach (List<string> items in this.data)
            {
                foreach (var item in items)
                {
                    stringBuilder.Append(item).Append(" ");
                }
              
            }
            return stringBuilder.ToString();
        }

        
        public Prototype Clone()
        {
            
            Dataset clone = new Dataset();
            clone.data = new List<List<string>>(this.data.Count);
            foreach (List<string> data in this.data)
            {
                clone.data.Add((List<string>)Clone());
            }
            return clone;
        }



    }
}
