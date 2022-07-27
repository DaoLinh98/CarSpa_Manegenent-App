//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Runtime.CompilerServices;
////using CarSpa.Module.Utils;
//using DevExpress.Persistent.Base;
//using DevExpress.Persistent.Validation;


//    [MetadataType(typeof(Account))]
//    [DefaultClassOptions, ImageName("BO_Account")]
//public class Account : INotifyPropertyChanged
//{
//    private string _accountID;
//    private string _firstName;
//    private string _lastName;
//    private string _midName;
//    private string _email;
//    private bool _active;
//    private string _password;

//    private Permission _permission;

//    public Account()
//    {
//    }

//    #region Properties
//    [Key]
//    [MaxLength(20)]
//    [RuleRequiredField("RuleRequiredField for Employee.EmployeeID", DefaultContexts.Save)]
//    public string AccountID
//    {
//        get
//        {
//            return _accountID;
//        }
//        set
//        {
//            _accountID = value;
//            OnPropertyChanged();
//        }
//    }
//    public bool Active
//    {
//        get
//        {
//            return _active;
//        }
//        set
//        {
//            _active = value;
//            OnPropertyChanged();
//        }
//    }

//    [MaxLength(50)]
//    [RuleRequiredField("RuleRequiredField for Employee.FirstName", DefaultContexts.Save)]
//    public string FirstName
//    {
//        get
//        {
//            return _firstName;
//        }
//        set
//        {
//            _firstName = value;
//            OnPropertyChanged();
//        }
//    }

//    [MaxLength(50)]
//    [RuleRequiredField("RuleRequiredField for Employee.LastName", DefaultContexts.Save)]
//    public string LastName
//    {
//        get
//        {
//            return _lastName;
//        }
//        set
//        {
//            _lastName = value;
//            OnPropertyChanged();
//        }
//    }

//    [MaxLength(50)]
//    public string MidName
//    {
//        get
//        {
//            return _midName;
//        }
//        set
//        {
//            _midName = value;
//            OnPropertyChanged();
//        }
//    }

//    [NotMapped]
//    public string FullName
//    {
//        get
//        {
//            if ((MidName != null) && (MidName.Trim() != ""))
//            {
//                return string.Format("{0} {1} {2}", LastName, MidName, FirstName).Trim();
//            }
//            else
//            {
//                return string.Format("{0} {1}", LastName, FirstName).Trim();
//            }
//        }
//    }

//    [MaxLength(100)]
//    public string Email
//    {
//        get
//        {
//            return _email;
//        }
//        set
//        {
//            _email = value;
//            OnPropertyChanged();
//        }
//    }

//    [Browsable(false)]
//    public string Password
//    {
//        get
//        {
//            return _password;
//        }
//        set
//        {
//            _password = value;
//            OnPropertyChanged();
//        }
//    }

//    private int _permissionId;
//    [ForeignKey("Permission")] // tao 1 khoá ngoại tham chiếu tới table permiss  
//    [RuleRequiredField("RuleRequiredField for Users.Permission", DefaultContexts.Save)] //gán cho table User.permission
//    public int PermissionId // khai báo ra thuộc tính của bảng 
//    {
//        get
//        {
//            return _permissionId;
//        }
//        set
//        {
//            _permissionId = value;
//            OnPropertyChanged();
//        }
//    }

//    #endregion Properties

//    #region Virtual Properties
//    public virtual Permission Permission
//    {
//        get { return _permission; }
//        set
//        {
//            _permission = value;
//            OnPropertyChanged();
//        }
//    }

//    public void ResetPassword(string password)
//    {
//        Password = GenerateHelper.Encrypt(password);
//    }























//    #endregion Virtual Properties

//    #region INotifyPropertyChanged members
//    public event PropertyChangedEventHandler PropertyChanged;
//    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
//    {
//        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
//    }
//    #endregion
//}
