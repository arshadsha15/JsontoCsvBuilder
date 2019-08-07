using CsvHelper;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace JsonToCSVBuilder
{
    public partial class CSVBuilder : Form
    {
        public CSVBuilder()
        {
            InitializeComponent();
        }

        Dictionary<string, dynamic> jsonKeyValues;

        private void Button_CreateCSV_Click(object sender, EventArgs e)
        {
            jsonKeyValues = new Dictionary<string, dynamic>();
            if (string.IsNullOrEmpty(this.txt_InputJsonTextBox.Text))
            {
                MessageBox.Show("Input a Json");
                return;
            }
            if (string.IsNullOrEmpty(this.txt_FilePath.Text))
            {
                MessageBox.Show("Input FilePath");
                return;
            }
            if (string.IsNullOrEmpty(this.txt_fileName.Text))
            {
                MessageBox.Show("Input FileName");
                return;
            }
            if (string.IsNullOrEmpty(this.txt_FilePath.Text))
            {
                MessageBox.Show("Input FilePath");
                return;
            }
            try
            {
                string jsonContent = this.txt_InputJsonTextBox.Text;
                JObject json = JObject.Parse(jsonContent);
                JsonToKeyValuePairUtility(json);
                CSVCreator();
                MessageBox.Show("Json has been Successfully Converted To CSV");
                return;
            }
            catch
            {
                MessageBox.Show("Input a Valid Json");
                return;
            }
        }

        private void JsonToKeyValuePairUtility(JObject json, string appendedKey = null)
        {
            foreach (JProperty property in (JToken)json)
            {
                string key = appendedKey == null ? property.Name : appendedKey + "__" + property.Name;
                JToken jToken = property.Value;
                if (jToken.HasValues && jToken.GetType() != typeof(JArray))
                {
                    JsonToKeyValuePairUtility((JObject)jToken, key);
                }
                else if (jToken.HasValues && jToken.GetType() == typeof(JArray))
                {
                    JArray innerJsons = (JArray)jToken;
                    foreach (JToken innerJson in innerJsons)
                    {
                        if (innerJson.HasValues)
                        {
                            JsonToKeyValuePairUtility((JObject)innerJson, key + "__[" + innerJsons.IndexOf(innerJson) + "]");
                        }
                        else
                        {
                            jsonKeyValues.Add(key, jToken);
                            break;
                        }
                    }
                }
                else
                {
                    if (jToken.Value<dynamic>() == null)
                    {
                        jsonKeyValues.Add(key, null);
                    }
                    else
                    {
                        jsonKeyValues.Add(key, jToken.ToString());
                    }
                }
            }
        }

        private void CSVCreator()
        {
            TextWriter textWriter = new StreamWriter(this.txt_FilePath.Text + "\\" + this.txt_fileName.Text + ".csv");
            CsvWriter csv = new CsvWriter(textWriter);
            foreach (KeyValuePair<string, dynamic> jsonKeyValue in jsonKeyValues)
            {
                csv.WriteField(jsonKeyValue.Key);
            }
            if (this.cb_RecordNam.Checked == true) csv.WriteField("_RecordName_");
            if (this.cb_RandomEnabled.Checked == true) csv.WriteField("IsRandomEnabled");
            if (this.cb_isHeaderOnly.Checked == false)
            {
                csv.NextRecord();
                foreach (KeyValuePair<string, dynamic> jsonKeyValue in jsonKeyValues)
                {
                    if (jsonKeyValue.Value == null)
                    {
                        csv.WriteField("null");
                    }
                    else
                    {
                        if (jsonKeyValue.Value.GetType() == typeof(JArray))
                        {
                            csv.WriteField(jsonKeyValue.Value.ToString().Replace("\r\n", ""));
                        }
                        else
                        {
                            csv.WriteField(jsonKeyValue.Value);
                        }
                    }
                }
                if (this.cb_RecordNam.Checked == true) csv.WriteField("Rec1");
                if (this.cb_RandomEnabled.Checked == true) csv.WriteField("TRUE");
            }
            csv.Dispose();
        }
    }
}
