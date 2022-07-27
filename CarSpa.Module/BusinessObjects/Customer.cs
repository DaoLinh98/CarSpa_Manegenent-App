using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
// ...
[DefaultClassOptions, ImageName("BO_Customer")]
public class Customer : INotifyPropertyChanged
{
    private int customerId;
    [Key]

    [RuleRequiredField("RuleRequiredField for Customer.CustomerId", DefaultContexts.Save)]
    public int CustomerId
    {
        get { return customerId; }
        protected set
        {
            if (customerId != value)
            {
                customerId = value;
                OnPropertyChanged();
            }
        }
    }
    private string customerName;
    [MaxLength(100)]
    [RuleRequiredField("RuleRequiredField for Customer.CustomerName", DefaultContexts.Save)]
    public string CustomerName
    {
        get { return customerName; }
        set
        {
            if (customerName != value)
            {
                customerName = value;
                OnPropertyChanged();
            }
        }
    }
    private string address;
    public string Address
    {
        get { return address; }
        set
        {
            if (address != value)
            {
                address = value;
                OnPropertyChanged();
            }
        }
    }

    private string taxcode;
    public string TaxCode
    {
        get { return taxcode; }
        set
        {
            if (taxcode != value)
            {
                taxcode = value;
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