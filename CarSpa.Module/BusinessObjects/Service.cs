using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
// ...
[DefaultClassOptions, ImageName("BO_Service")]
public class Service : INotifyPropertyChanged
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Column("serviceId", TypeName = "uniqueidentifier")]
    private int serviceId;
    [Browsable(false)]
    public int ServiceId
    {
        get { return serviceId; }
        protected set
        {
            if (serviceId != value)
            {
                serviceId = value;
                OnPropertyChanged();
            }
        }
    }
    private string serviceName;
    [MaxLength(100)]
    [RuleRequiredField("RuleRequiredField for Service.ServiceName", DefaultContexts.Save)]
    public string ServiceName
    {
        get { return serviceName; }
        set
        {
            if (serviceName != value)
            {
                serviceName = value;
                OnPropertyChanged();
            }
        }
    }
    private decimal price;
    public decimal Price
    {
        get { return price; }
        set
        {
            if (price != value)
            {
                price = value;
                OnPropertyChanged();
            }
        }
    }

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


    private bool active =true ;
    public bool Active
    {
        get { return active; }
        set
        {
            if (active != value)
            {
                active = value;
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