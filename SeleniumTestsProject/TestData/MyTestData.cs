using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestsProject.TestData
{
    public class MyTestData
    {
        public string TestCaseName { get; set; }
        public string Input { get; set; }
        public string Others { get; set; }

        public static List<MyTestData> LoadTestDataFromFile()
        {
            //var myFile = $"{Environment.CurrentDirectory}\\TestData\\MyTestDataJson.json";
            var myFile = @"C:\Users\Adina\Projects\AgileHub_Testare_Automatizata\Unit Test Project\SeleniumTestsProject\SeleniumTestsProject\TestData\MyTestDataJson.json";

            try
            {
                using (var reader = new StreamReader(myFile))
                {
                    var json = reader.ReadToEnd();
                    var config = JObject.Parse(json).SelectToken("ScenarioDto").ToString();
                    var myTestDataList = JsonConvert.DeserializeObject<List<MyTestData>>(config);

                    return myTestDataList;
                }

            }
            catch (Exception)
            {
                throw new Exception($"There's a problem with file {myFile}");
            }

        }

    }
}
