using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.oM.Adapters.EnergyPlus;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EnergyPlus_oM
{
    public static class EPJson_Engine
    {
        //public static string Simulate(string energyPlusMainDirectoryPath, string inputFile, string weatherFilePath = "", bool isSilent = true)
        //{
        //    string tempPath = System.IO.Path.GetTempPath();
        //    string tempFileBase = tempPath + Guid.NewGuid().ToString();
        //    string ePJsonTempFile = tempFileBase + ".epJSON";
        //    File.WriteAllText(ePJsonTempFile, ePJson);

        //    var process = new Process();
        //    process.StartInfo.WorkingDirectory = tempPath;
        //    process.StartInfo.FileName = energyPlusMainDirectoryPath;
        //    process.StartInfo.CreateNoWindow = isSilent;
        //    process.StartInfo.Arguments = " --convert-only " + ePJsonTempFile;
        //    process.Start();
        //    process.WaitForExit();

        //    string result;
        //    try
        //    {
        //        result = File.ReadAllText(tempFileBase + ".idf");
        //    }
        //    catch (Exception e)
        //    {
        //        result = File.ReadAllText(tempPath + "eplusout.err");
        //    }

        //    return result;
        //}

        /// <summary>
        /// Convert an input file (either to IDF or EPJSON) to the other format.
        /// </summary>
        /// <param name="energyPlusMainDirectoryPath"></param>
        /// <param name="input"></param>
        /// <param name="isSilent"></param>
        /// <returns></returns>
        public static string Convert(string energyPlusMainDirectoryPath, string input ,bool isSilent = true)
        {
            bool isJson = input.StartsWith("{");
            string baseExtension = isJson ? ".epJSON" : ".idf";
            string targetExtension = isJson ? ".idf" :".epJSON";

            string tempPath = System.IO.Path.GetTempPath();
            string tempFileBase = tempPath + Guid.NewGuid().ToString();
            string ePJsonTempFile = tempFileBase + baseExtension;
            File.WriteAllText(ePJsonTempFile, input);

            var process = new Process();
            process.StartInfo.WorkingDirectory = tempPath;
            process.StartInfo.FileName = energyPlusMainDirectoryPath;
            process.StartInfo.CreateNoWindow = isSilent;
            process.StartInfo.Arguments = " --convert-only " + ePJsonTempFile; 
            process.Start();
            process.WaitForExit();

            string result;
            try
            {
                result = File.ReadAllText(tempFileBase + targetExtension);
            }
            catch (Exception e)
            {
                result = File.ReadAllText(tempPath + "eplusout.err");
            }
            return result;
        }

        public static string GetIDF(string energyPlusMainDirectoryPath, EPJson ePJson, bool isSilent = true) =>
            Convert(energyPlusMainDirectoryPath, GetEPJsonString(ePJson), isSilent);

        public static string GetIDF(string energyPlusMainDirectoryPath, string baseIDF, string ePJson,  bool isSilent = true) =>
            Convert(energyPlusMainDirectoryPath, GetMergedEPJsonString(Convert(energyPlusMainDirectoryPath,baseIDF), ePJson),isSilent);

        public static string GetIDF(string energyPlusMainDirectoryPath, string baseIDF, EPJson ePJson, bool isSilent = true) =>
            Convert(energyPlusMainDirectoryPath, GetMergedEPJsonString( Convert(energyPlusMainDirectoryPath,baseIDF, isSilent), GetEPJsonString(ePJson)), isSilent);
        public static string GetIDF(string energyPlusMainDirectoryPath, EPJson baseEPJson, EPJson ePJson, bool isSilent = true) =>
            Convert(energyPlusMainDirectoryPath, GetMergedEPJsonString(baseEPJson, ePJson), isSilent);

        public static string GetMergedEPJsonString(EPJson basEPJson, EPJson additionalEpJson) =>
            GetMergedEPJsonString(GetEPJsonString(basEPJson), GetEPJsonString(additionalEpJson));

        public static string GetMergedEPJsonString(string baseEPJson, string additionalEpJson)
        {
            JObject mergedEPJsonJson = JObject.Parse(baseEPJson);
            mergedEPJsonJson.Merge(JObject.Parse(additionalEpJson));
            return JsonConvert.SerializeObject(mergedEPJsonJson);
        }

        public static string GetEPJsonString(EPJson epJson)
        {
            return JsonConvert.SerializeObject(epJson, Formatting.Indented);
        }
    }
}
