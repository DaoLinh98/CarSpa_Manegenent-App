using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

[DefaultClassOptions, ImageName("BO_Machine")]
public class Machine : INotifyPropertyChanged
{
    private int machineId;
    [Browsable(false)]
    public int MachineId
    {
        get { return machineId; }
        protected set
        {
            if (machineId != value)
            {
                machineId = value;
                OnPropertyChanged();
            }
        }
    }

    //

    private string machineName;
    [MaxLength(100)]
    [RuleRequiredField("RuleRequiredField for Machine.MachineName", DefaultContexts.Save)]
    public string MachineName
    {
        get { return machineName; }
        set
        {
            if (machineName != value)
            {
                machineName = value;
                OnPropertyChanged();
            }
        }
    }


    private string serialNumber;
    public string SerialNumber
    {
        get { return serialNumber; }
        set
        {
            if (serialNumber != value)
            {
                serialNumber = value;
                OnPropertyChanged();
            }
        }
    }


    private DateTime soldDate;
    public DateTime SoldDate
    {

        get { return soldDate; }
        set
        {
            if (soldDate != value)
            {
                soldDate = value;
                OnPropertyChanged();
            }
        }
    }



    private string soldBy;
    public string SoldBy
    {
        get { return soldBy; }
        set
        {
            if (soldBy != value)
            {
                soldBy = value;
                OnPropertyChanged();
            }
        }

    }

    
    private string warrantyTime;
    public string WarrantyTime
    {
        get { return warrantyTime; }
        set
        {
            if (warrantyTime != value)
            {
                warrantyTime = value;
                OnPropertyChanged();
            }
        }
    }

    

    private DateTime warrantyExpired;
    public DateTime WarrantyExpired
    {
        get { return warrantyExpired; }
        set
        {
            if (warrantyExpired != value)
            {
                warrantyExpired = value;
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

