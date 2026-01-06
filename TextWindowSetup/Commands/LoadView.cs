using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCadAPI_demo.TextWindowSetup.Commands
{
    internal class LoadView
    {
        [CommandMethod("LOADVIEW")]
        public void OpenHotelUI()
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;

            ed.WriteMessage("\nCommand is ready");
        }
    }
}
