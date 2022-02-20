/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2022, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using BH.oM.Base;
using BH.oM.Reflection;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.Adapters.EnergyPlus
{
    public class ESOFile : BHoMObject
    {
        [Description("Path of the ESO file output from EnerygPlus simulation")]
        public virtual string FilePath { get; set; } = "";
        [Description("Objects with which results are associated")]
        public virtual List<string> ResultsObjects { get; set; } = new List<string>();
        [Description("Simulated attribute of object being described")]
        public virtual List<string> ResultsAttribute { get; set; } = new List<string>();
        [Description("Results values")]
        public virtual List<List<double>> ResultsValues { get; set; } = new List<List<double>>();
        [Description("EnergyPlus version used for simulation")]
        public virtual string EnergyPlusVersion { get; set; } = "";
        [Description("The frequency with which the results values are being reported")]
        public virtual DateTime CreationDate { get; set; } = new DateTime();
    }
}


