using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace GroupingExample
{
    public class VegModel : INotifyPropertyChanged
    {
        //OnPropertyChanged(nameof(MilestoneInspectionSheetID));
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        private string _comment;
        public string Comment
        {
            get
            {
                return _comment;
            }
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(Comment));
            }
        }

        private bool _isReallyAVeggie;
        public bool IsReallyAVeggie
        {
            get
            {
                return _isReallyAVeggie;
            }
            set
            {
                _isReallyAVeggie = value;
                OnPropertyChanged(nameof(IsReallyAVeggie));
            }
        }

        private string _image;
        public string Image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
                OnPropertyChanged(nameof(Image));
            }
        }


        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }

    public class GroupedVeggieObject : ObservableCollection<VegModel>, INotifyPropertyChanged
    {
        private string _longname;
        public string LongName 
        {
            get
            {
                return _longname;
            }
            set
            {
                _longname = value;
                OnPropertyChanged(nameof(LongName));
            }
        }
        private string _shortName;
        public string ShortName
        {
            get
            {
                return _shortName;
            }
            set
            {
                _shortName = value;
                OnPropertyChanged(nameof(ShortName));
            }
        }
        public event PropertyChangedEventHandler PropertyModified;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyModified == null)
                return;

            PropertyModified.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
