using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

[DefaultClassOptions, ImageName("BO_Users")]
public class User : INotifyPropertyChanged
{
    private int userId;
    [Key]
    [RuleRequiredField("RuleRequiredField for User.UserId", DefaultContexts.Save)]
    public int UserId
    {
        get { return userId; }
        protected set
        {
            if (userId != value)
            {
                userId = value;
                OnPropertyChanged();
            }
        }
    }


    private string userName;
    [MaxLength(100)]
    [RuleRequiredField("RuleRequiredField for User.UserName", DefaultContexts.Save)]
    public string UserName
    {
        get { return userName; }
        set
        {
            if (userName != value)
            {
                userName = value;
                OnPropertyChanged();
            }
        }
    }


    [Browsable(false)]
    private string _password;
    public string Password
    {
        get
        {
            return _password;
        }
        set
        {
            _password = value;
            OnPropertyChanged();
        }
    }


    private DateTime joinDate;
    public DateTime JoinDate
    {
        get { return joinDate; }
        set
        {
            if (joinDate != value)
            {
                joinDate = value;
                OnPropertyChanged();
            }
        }
    }


    private DateTime outDate;
    public DateTime OutDate
    {

        get { return outDate; }
        set
        {
            if (outDate != value)
            {
                outDate = value;
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

    //
    private int _permissionId;
    [ForeignKey("Permission")] // tao 1 khoá ngoại tham chiếu tới table permiss  
    [RuleRequiredField("RuleRequiredField for Users.Permission", DefaultContexts.Save)] //gán cho table User.permission
    public int PermissionId // khai báo ra thuộc tính của bảng 
    {
        get
        {
            return _permissionId;
        }
        set
        {
            _permissionId = value;
            OnPropertyChanged();
        }
    }
    //
    private Permission _permission;
    #region Virtual Properties  
    public virtual Permission Permission
    {
        get { return _permission; }
        set
        {
            _permission = value;
            OnPropertyChanged();
        }
    }
    #endregion

    // Relation side Many

    //private Permission _permission;
    //public virtual Permission Permission
    //{
    //    get { return _permission; }
    //    set
    //    {
    //        if (_permission != value)
    //        {
    //            _permission = value;
    //            OnPropertyChanged();
    //        }
    //    }
    //}

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


  
    
    #region INotifyPropertyChanged members
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion
}

