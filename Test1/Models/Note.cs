using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Test1
{
    [DataContract]
    public class Note : INotifyPropertyChanged
    {
        private string title;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        [DataMember]
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value != title)
                {
                    title = value;
                    NotifyPropertyChanged("Title");
                }
            }
        }

        private string noteText;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        [DataMember]
        public string NoteText
        {
            get
            {
                return noteText;
            }
            set
            {
                if (value != noteText)
                {
                    noteText = value;
                    NotifyPropertyChanged("NoteText");
                }
            }
        }

        private DateTime createDate;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        [DataMember]
        public DateTime CreateDate
        {
            get
            {
                return createDate;
            }
            set
            {
                if (value != createDate)
                {
                    createDate = value;
                    NotifyPropertyChanged("CreateDate");
                }
            }
        }

        private string eventDate;
            /// <summary>
            /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
            /// </summary>
            /// <returns></returns>
            [DataMember]
            public string EventDate
            {
                get
                {
                    return eventDate;
                }
                set
                {
                    if (value != eventDate)
                    {
                        eventDate = value;
                        NotifyPropertyChanged("EventDate");
                    }
                }
            }

        private string eventLocation;
            /// <summary>
            /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
            /// </summary>
            /// <returns></returns>
            [DataMember]
            public string EventLocation
            {
                get
                {
                    return eventLocation;
                }
                set
                {
                    if (value != eventLocation)
                    {
                        eventLocation = value;
                        NotifyPropertyChanged("EventLocation");
                    }
                }
            }

        private string eventCategory;
            /// <summary>
            /// Goes to SelectCategory and returns the user input.
            /// </summary>
            [DataMember]
            public string EventCategory
            {
                get
                {
                    return eventCategory;
                }
                set
                {
                    if (value != eventCategory)
                    {
                        eventCategory = value;
                        NotifyPropertyChanged("EventCategory");
                    }
                }
            }

        


        public void Save()
        {
            ObservableCollection<Note> currentNotes = StorageHelper.Load<ObservableCollection<Note>>(App.NotesFileName);
            currentNotes.Add(this);
            StorageHelper.Save<ObservableCollection<Note>>(App.NotesFileName, currentNotes);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
