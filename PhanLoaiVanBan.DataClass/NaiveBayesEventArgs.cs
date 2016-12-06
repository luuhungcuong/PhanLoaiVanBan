using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhanLoaiVanBan.DocumentProcessing
{
    public class NaiveBayesEventArgs
    {
        public int CurrentWord { get; set; }
        public int TotalWord { get; set; }
        public string Word { get; set; }
        public int CurrentCagegory { get; set; }
        public int TotalCategory { get; set; }
        public string Category { get; set; }
        public int currentDocument { get; set; }
        public int TotalDocument { get; set; }
        public String Result;
    }
}
