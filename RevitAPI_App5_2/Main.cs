using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Создайте приложение для изменения типов стен. Приложение должно работать следующим
//образом: в первую очередь выдаётся запрос для выбора стен. Когда стены выбраны,
//появляется окно со списком доступных типов стен и кнопкой «Изменить тип». По
//нажатию на кнопку «Изменить тип», новый тип стен применяется для выбранных
//стен.

namespace RevitAPI_App5_2
{
    [Transaction(TransactionMode.Manual)]

    public class Main : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog.Show("Сообщение", "Выберите стены, у которых хотите изменить тип. После выбора нажмите Finish");

            var window = new MainView(commandData);
            window.ShowDialog();
            return Result.Succeeded;
        }
    }
}
