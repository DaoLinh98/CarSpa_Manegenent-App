using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

[DefaultClassOptions, ImageName("BO_Inventory")]
public class Inventory : INotifyPropertyChanged
{
    private int partId;
    [Key]
    [RuleRequiredField("RuleRequiredField for Inventory.PartId", DefaultContexts.Save)]
    public int PartId
    {
        get { return partId; }
        protected set
        {
            if (partId != value)
            {
                partId = value;
                OnPropertyChanged();
            }
        }
    }

    //

    private string partName;
    [MaxLength(100)]
    [RuleRequiredField("RuleRequiredField for Iventory.PartName", DefaultContexts.Save)]
    public string PartName
    {
        get { return partName; }
        set
        {
            if (partName != value)
            {
                partName = value;
                OnPropertyChanged();
            }
        }
    }


    private string description;
    public string Description
    {
        get { return description; }
        set
        {
            if (description != value)
            {
                description = value;
                OnPropertyChanged();
            }
        }
    }


    private decimal price;
    public decimal Pricce
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

    //

    private bool active = true;
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

    //
    

    #region INotifyPropertyChanged members
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion
}

