using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

//[MetadataType(typeof(Permission))]
//[RuleCriteria("RuleCriteria for Permission", DefaultContexts.Save, "PermissionId is not null", SkipNullOrEmptyValues = false)]
[DefaultClassOptions, ImageName("BO_Permission")]
public class Permission : INotifyPropertyChanged
{

    private int permissionId;
    [Key]

    [RuleRequiredField("RuleRequiredField for Permission.PermissionId", DefaultContexts.Save)]
    public int PermissionId
    {
        get { return permissionId; }
        protected set
        {
            if (permissionId != value)
            {
                permissionId = value;
                OnPropertyChanged();
            }
        }
    }

    

    private string permissionName;
    [MaxLength(100)]
    [RuleRequiredField("RuleRequiredField for Permission.PermissionName", DefaultContexts.Save)]
    public string PermissionName
    {
        get { return permissionName; }
        set
        {
            if (permissionName != value)
            {
                permissionName = value;
                OnPropertyChanged();
            }
        }
    }


    private bool userManage;
    public bool UserManage
    {
        get { return userManage; }
        set
        {
            if (userManage != value)
            {
                userManage = value;
                OnPropertyChanged();
            }
        }
    }


    
    private bool customer;
    public bool Customer
    {
        get { return customer; }
        set
        {
            if (customer != value)
            {
                customer = value;
                OnPropertyChanged();
            }
        }

    }


    
    private bool machines;
    public bool Machines
    {

        get { return machines; }
        set
        {
            if (machines != value)
            {
                machines = value;
                OnPropertyChanged();
            }
        }
    }

    



    
    private bool services;
    public bool Services
    {
        get { return services; }
        set
        {
            if (services != value)
            {
                services = value;
                OnPropertyChanged();
            }
        }
    }

    

    private bool serviecsRequest;
    public bool ServicesRequest
    {
        get { return serviecsRequest; }
        set
        {
            if (serviecsRequest != value)
            {
                serviecsRequest = value;
                OnPropertyChanged();
            }
        }

    }

    

    private bool report;
    public bool Report
    {
        get { return report; }
        set
        {
            if (report != value)
            {
                report = value;
                OnPropertyChanged();
            }
        }

    }

    
    private bool export;
    public bool Export
    {
        get { return export; }
        set
        {
            if (export != value)
            {
                export = value;
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

