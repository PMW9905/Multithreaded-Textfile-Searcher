using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
DataHandler

Stores the file location, name, and string queue.
String Queue stores the lines of the textfile that contain the substring.
BackgroundWorker work puts strings into queue
BackgroundWorker Progress Update dequeues.

Written by Parker Whitehead for CS6326.001, assignment 4, starting 10/20/2021.
NetID: pmw180000
*/
namespace Asg4_pmw180000
{
    class DataHandler
    {
        private string fileName;
        private string fileDir;
        public ConcurrentQueue<string> queue;
        public DataHandler()
        {
            fileName = "";
            fileDir = "";
            queue = new ConcurrentQueue<string>();
        }

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public string FileDir
        {
            get { return fileDir; }
            set { fileDir = value; }
        }
    }
}
