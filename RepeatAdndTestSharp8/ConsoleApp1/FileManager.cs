using System;
using System.Collections.Generic;
using System.Text;

namespace _001_Problem
{
    class FileManager
    {

        public bool FindLogFile(string fileName) {

            //FileDataObject obj = new FileDataObject();
            TestDataObject obj = new TestDataObject(); //для тестирования

            List<string> files = obj.GetFiles();

            foreach (var file in files) {

                if (file.Contains(fileName)) {

                    return true;
                        
                }

            }

            return false;
        }

    }
}
