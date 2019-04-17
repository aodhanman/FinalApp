using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace FinalApp.Models
{
    public abstract class BaseFodyObservable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
