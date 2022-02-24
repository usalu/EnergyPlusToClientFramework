using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.oM.Adapters.EnergyPlus;

namespace EnergyPlus_oM
{
    public class EPJsonToIDFConverter
    {
        //private EnergyPlusJson energyPlusJson { get; set; }

        public static string GetIDF(string energyPlusMainDirectoryPath,string ePJson ,bool isSilent = true)
        {
            string tempPath = System.IO.Path.GetTempPath();

            string tempFileBase = tempPath + Guid.NewGuid().ToString();

            string ePJsonTempFile = tempFileBase + ".epJSON";

            File.WriteAllText(ePJsonTempFile, ePJson);

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
                result = File.ReadAllText(tempFileBase + ".idf");
            }
            catch (Exception e)
            {
                result = File.ReadAllText(tempPath + "eplusout.err");
            }

            return result;
        }
    }
}
