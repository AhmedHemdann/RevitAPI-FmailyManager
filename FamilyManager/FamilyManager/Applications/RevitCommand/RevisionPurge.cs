﻿using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyManager.Applications.RevitCommand
{
    [TransactionAttribute(TransactionMode.Manual)]
    public class RevisionPurge : IExternalCommand
    {
        #region public method
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {

            // implement the logic of code here.

           
            return Result.Succeeded;
        }
        #endregion
    }
}
