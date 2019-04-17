using System;
using System.Collections.Generic;
using System.Text;

namespace FinalApp
{
    public class Item : Models.BaseFodyObservable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
