using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

[DefaultClassOptions, ImageName("BO_ServiceRequest")]
public class ServiceRequest : INotifyPropertyChanged
{
    private int requestId;
    [Key]
    [RuleRequiredField("RuleRequiredField for ServiceRequest.RequestId", DefaultContexts.Save)]
    public int RequestId
    {
        get { return requestId; }
        protected set
        {
            if (requestId != value)
            {
                requestId = value;
                OnPropertyChanged();
            }
        }
    }

    private DateTime requestDate;
    public DateTime RequestDate
    {
        get { return requestDate; }
        set
        {
            if (requestDate != value)
            {
                requestDate = value;
                OnPropertyChanged();
            }
        }
    }

    //Crete ForeignKey CustomerID
    private int _customerId;
    [ForeignKey("Customer")]
    [RuleRequiredField("RuleRequiredField for ServiceRequests.Customer", DefaultContexts.Save)]
    public int CustomerId
    {
        get
        {
            return _customerId;
        }
        set
        {
            _customerId = value;
            OnPropertyChanged();
        }
    }

    private Customer _customer;
    #region Virtual Properties  
    public virtual Customer Customer
    {
        get { return _customer; }
        set
        {
            _customer = value;
            OnPropertyChanged();
        }
    }
    #endregion


    private int _machineId;
    [ForeignKey("Machine")]
    [RuleRequiredField("RuleRequiredField for ServiceRequests.Machine", DefaultContexts.Save)]
    public int MachineId
    {
        get
        {
            return _machineId;
        }
        set
        {
            _machineId = value;
            OnPropertyChanged();
        }
    }

    private Machine _machine;
    #region Virtual Properties  
    public virtual Machine Machine
    {
        get { return _machine; }
        set
        {
            _machine = value;
            OnPropertyChanged();
        }
    }
    #endregion


    private int _statusId;
    [ForeignKey("Status")]
    [RuleRequiredField("RuleRequiredField for ServiceRequests.Status", DefaultContexts.Save)]
    public int StatusId
    {
        get
        {
            return _statusId;
        }
        set
        {
            _statusId = value;
            OnPropertyChanged();
        }
    }

    private Status _status;
    #region Virtual Properties  
    public virtual Status Status
    {
        get { return _status; }
        set
        {
            _status = value;
            OnPropertyChanged();
        }
    }
    #endregion


    //Crete ForeignKey has name is UserID
    private int _userId;
    [ForeignKey("User")] // Reference to Users table
    [RuleRequiredField("RuleRequiredField for ServiceRequests.Users", DefaultContexts.Save)] //statement require
    public int UserId // Add column UserId into ServiceRequest table
    {
        get
        {
            return _userId;
        }
        set
        {
            _userId = value;
            OnPropertyChanged();
        }
    }

    //Create list selectiom (side n)
    private User _user;
    #region Virtual Properties  
    public virtual User User
    {
        get { return _user; }
        set
        {
            _user = value;
            OnPropertyChanged();
        }
    }
    #endregion

    private decimal totalCost;
    public decimal TotalCost
    {
        get { return totalCost; }
        set
        {
            if (totalCost != value)
            {
                totalCost = value;
                OnPropertyChanged();
            }
        }
    }

    private DateTime createDate;
    public DateTime CreateDate
    {
        get { return createDate; }
        set
        {
            if (createDate != value)
            {
                createDate = value;
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

}