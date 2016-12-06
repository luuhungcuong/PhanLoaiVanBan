using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhanLoaiVanBan.DocumentProcessing
{
    public class NaiveBayesWorker : System.ComponentModel.BackgroundWorker
    {
        public int TotalWords {get;set;}
        public int ToTalDocuments { get; set; }        
    }
}
