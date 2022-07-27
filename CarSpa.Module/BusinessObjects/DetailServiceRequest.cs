using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

[DefaultClassOptions, ImageName("BO_DetailServiceRequest")]
public class DetailServiceRequest : INotifyPropertyChanged
{
    private int detailRequestId;
    [Key]
    [RuleRequiredField("RuleRequiredField for DetailServiceRequest.DetailRequsetId", DefaultContexts.Save)]
    public int DetailRequsetId
    {
        get { return detailRequestId; }
        protected set
        {
            if (detailRequestId != value)
            {
                detailRequestId = value;
                OnPropertyChanged();
            }
        }
    }
    //
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
    //
    //Crete ForeignKey CustomerID
    private int _customerId;
    [ForeignKey("Customer")]
    [RuleRequiredField("RuleRequiredField for DetailServiceRequests.Customer", DefaultContexts.Save)]
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
    [RuleRequiredField("RuleRequiredField for DetailServiceRequests.Machine", DefaultContexts.Save)]
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
    [RuleRequiredField("RuleRequiredField for DetailServiceRequests.Status", DefaultContexts.Save)]
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
    [RuleRequiredField("RuleRequiredField for DetailServiceRequests.Users", DefaultContexts.Save)] //statement require
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
    //
    //Crete ForeignKey ServiceID
    private int _serviceId;
    [ForeignKey("Service")]
    [RuleRequiredField("RuleRequiredField for DetailServiceRequests.Service", DefaultContexts.Save)]
    public int ServiceId
    {
        get
        {
            return _serviceId;
        }
        set
        {
            _serviceId = value;
            OnPropertyChanged();
        }
    }
    //
    private Service _service;
    #region Virtual Properties  
    public virtual Service Service
    {
        get { return _service; }
        set
        {
            _service = value;
            OnPropertyChanged();
        }
    }
    #endregion
    
    //Crete ForeignKey ServiceID
    private int _partId;
    [ForeignKey("Inventory")]
    [RuleRequiredField("RuleRequiredField for DetailServiceRequests.Inventory", DefaultContexts.Save)]
    public int PartId
    {
        get
        {
            return _partId;
        }
        set
        {
            _partId = value;
            OnPropertyChanged();
        }
    }
    //
    private Inventory _Part;
    #region Virtual Properties  
    public virtual Inventory Inventory
    {
        get { return _Part; }
        set
        {
            _Part = value;
            OnPropertyChanged();
        }
    }
    #endregion
    //
    private int quantity;
    public int Quantity
    {
        get { return quantity; }
        set
        {
            if (quantity != value)
            {
                quantity = value;
                OnPropertyChanged();
            }
        }
    }

    private string partReceived;
    public string PartReceived
    {
        get { return partReceived; }
        set
        {
            if (partReceived != value)
            {
                partReceived = value;
                OnPropertyChanged();
            }
        }
    }
    //
    private string note;
    public string Note
    {
        get { return note; }
        set
        {
            if (note != value)
            {
                note = value;
                OnPropertyChanged();
            }
        }
    }
    //
    private decimal totalCost;
    public decimal TotalCost
    {
        get {
            if(quantity >0 && _Part != null && _service != null)
            {
                totalCost = quantity * _Part.Pricce + _service.Price;
            }
            return totalCost; 
        }
        //set
        //{
        //    if (totalCost != value)
        //    {
        //        totalCost = value;
        //        OnPropertyChanged();
        //    }
        //}
    }

    #region INotifyPropertyChanged members
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion

}