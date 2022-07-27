using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

[DefaultClassOptions, ImageName("BO_Status")]
public class Status : INotifyPropertyChanged
{
    private int statusId;
    [Browsable(false)]
    public int StatusId
    {
        get { return statusId; }
        protected set
        {
            if (statusId != value)
            {
                statusId = value;
                OnPropertyChanged();
            }
        }
    }

    //

    private string statusName;
    [MaxLength(100)]
    [RuleRequiredField("RuleRequiredField for Status.StatusName", DefaultContexts.Save)]
    public string StatusName
    {
        get { return statusName; }
        set
        {
            if (statusName != value)
            {
                statusName = value;
                OnPropertyChanged();
            }
        }
    }

    #region INotifyPropertyChanged members
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion

    //Relationship 1-n with Service Request (Side 1)
    //public Status()
    //{
    //    ContactsCollection = new List<ServiceRequest>();
    //}
    //private IList<ServiceRequest> contactsCollection;
    //public virtual IList<ServiceRequest> ContactsCollection
    //{
    //    get { return contactsCollection; }
    //    set
    //    {
    //        if (contactsCollection != value)
    //        {
    //            contactsCollection = value;
    //            OnPropertyChanged();
    //        }
    //    }
    //}
}