﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektBlodbank
{
    using System.Data.Linq;
    using System.Data.Linq.Mapping;
    using System.Data;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;
    using System.Linq.Expressions;
    using System.ComponentModel;
    using System;
    using Business;

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database1")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertTotal(Total instance);
    partial void UpdateTotal(Total instance);
    partial void DeleteTotal(Total instance);
    partial void InsertDonation(Donation instance);
    partial void UpdateDonation(Donation instance);
    partial void DeleteDonation(Donation instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::ProjektBlodbank.Properties.Settings.Default.DatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Total> Totals
		{
			get
			{
				return this.GetTable<Total>();
			}
		}
		
		public System.Data.Linq.Table<Donation> Donations
		{
			get
			{
				return this.GetTable<Donation>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserId;
		
		private string _Firstname;
		
		private string _Lastname;
		
		private string _Streetname;
		
		private string _City;
		
		private int _ZipCode;
		
		private int _CPRNumber;
		
		private string _Login;
		
		private string _Password;
		
		private string _Bloodtype;
		
		private string _Email;
		
		private string _PhoneNumber;
		
		private System.DateTime _NextPlasmaDonation;
		
		private string _PreferredBusLocation;
		
		private System.DateTime _NextWholeBloodDonation;
		
		private EntitySet<Donation> _Donations;
		
		private EntityRef<Total> _Totals;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnFirstnameChanging(string value);
    partial void OnFirstnameChanged();
    partial void OnLastnameChanging(string value);
    partial void OnLastnameChanged();
    partial void OnStreetnameChanging(string value);
    partial void OnStreetnameChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnZipCodeChanging(int value);
    partial void OnZipCodeChanged();
    partial void OnCPRNumberChanging(int value);
    partial void OnCPRNumberChanged();
    partial void OnLoginChanging(string value);
    partial void OnLoginChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnBloodtypeChanging(string value);
    partial void OnBloodtypeChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnNextPlasmaDonationChanging(System.DateTime value);
    partial void OnNextPlasmaDonationChanged();
    partial void OnPreferredBusLocationChanging(string value);
    partial void OnPreferredBusLocationChanged();
    partial void OnNextWholeBloodDonationChanging(System.DateTime value);
    partial void OnNextWholeBloodDonationChanged();
    #endregion
		
		public User()
		{
			this._Donations = new EntitySet<Donation>(new Action<Donation>(this.attach_Donations), new Action<Donation>(this.detach_Donations));
			this._Totals = default(EntityRef<Total>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firstname", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Firstname
		{
			get
			{
				return this._Firstname;
			}
			set
			{
				if ((this._Firstname != value))
				{
					this.OnFirstnameChanging(value);
					this.SendPropertyChanging();
					this._Firstname = value;
					this.SendPropertyChanged("Firstname");
					this.OnFirstnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lastname", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Lastname
		{
			get
			{
				return this._Lastname;
			}
			set
			{
				if ((this._Lastname != value))
				{
					this.OnLastnameChanging(value);
					this.SendPropertyChanging();
					this._Lastname = value;
					this.SendPropertyChanged("Lastname");
					this.OnLastnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Streetname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Streetname
		{
			get
			{
				return this._Streetname;
			}
			set
			{
				if ((this._Streetname != value))
				{
					this.OnStreetnameChanging(value);
					this.SendPropertyChanging();
					this._Streetname = value;
					this.SendPropertyChanged("Streetname");
					this.OnStreetnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCode", DbType="Int NOT NULL")]
		public int ZipCode
		{
			get
			{
				return this._ZipCode;
			}
			set
			{
				if ((this._ZipCode != value))
				{
					this.OnZipCodeChanging(value);
					this.SendPropertyChanging();
					this._ZipCode = value;
					this.SendPropertyChanged("ZipCode");
					this.OnZipCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPRNumber", DbType="Int NOT NULL")]
		public int CPRNumber
		{
			get
			{
				return this._CPRNumber;
			}
			set
			{
				if ((this._CPRNumber != value))
				{
					this.OnCPRNumberChanging(value);
					this.SendPropertyChanging();
					this._CPRNumber = value;
					this.SendPropertyChanged("CPRNumber");
					this.OnCPRNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Login", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Login
		{
			get
			{
				return this._Login;
			}
			set
			{
				if ((this._Login != value))
				{
					this.OnLoginChanging(value);
					this.SendPropertyChanging();
					this._Login = value;
					this.SendPropertyChanged("Login");
					this.OnLoginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bloodtype", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Bloodtype
		{
			get
			{
				return this._Bloodtype;
			}
			set
			{
				if ((this._Bloodtype != value))
				{
					this.OnBloodtypeChanging(value);
					this.SendPropertyChanging();
					this._Bloodtype = value;
					this.SendPropertyChanged("Bloodtype");
					this.OnBloodtypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NextPlasmaDonation", DbType="DateTime NOT NULL")]
		public System.DateTime NextPlasmaDonation
		{
			get
			{
				return this._NextPlasmaDonation;
			}
			set
			{
				if ((this._NextPlasmaDonation != value))
				{
					this.OnNextPlasmaDonationChanging(value);
					this.SendPropertyChanging();
					this._NextPlasmaDonation = value;
					this.SendPropertyChanged("NextPlasmaDonation");
					this.OnNextPlasmaDonationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PreferredBusLocation", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string PreferredBusLocation
		{
			get
			{
				return this._PreferredBusLocation;
			}
			set
			{
				if ((this._PreferredBusLocation != value))
				{
					this.OnPreferredBusLocationChanging(value);
					this.SendPropertyChanging();
					this._PreferredBusLocation = value;
					this.SendPropertyChanged("PreferredBusLocation");
					this.OnPreferredBusLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NextWholeBloodDonation", DbType="DateTime NOT NULL")]
		public System.DateTime NextWholeBloodDonation
		{
			get
			{
				return this._NextWholeBloodDonation;
			}
			set
			{
				if ((this._NextWholeBloodDonation != value))
				{
					this.OnNextWholeBloodDonationChanging(value);
					this.SendPropertyChanging();
					this._NextWholeBloodDonation = value;
					this.SendPropertyChanged("NextWholeBloodDonation");
					this.OnNextWholeBloodDonationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Donation", Storage="_Donations", ThisKey="UserId", OtherKey="UserId")]
		public EntitySet<Donation> Donations
		{
			get
			{
				return this._Donations;
			}
			set
			{
				this._Donations.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Total", Storage="_Totals", ThisKey="UserId", OtherKey="UserId", IsUnique=true, IsForeignKey=false)]
		public Total Totals
		{
			get
			{
				return this._Totals.Entity;
			}
			set
			{
				Total previousValue = this._Totals.Entity;
				if (((previousValue != value) 
							|| (this._Totals.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Totals.Entity = null;
						previousValue.User = null;
					}
					this._Totals.Entity = value;
					if ((value != null))
					{
						value.User = this;
					}
					this.SendPropertyChanged("Totals");
				}
			}
		}

        internal Totals Total { get; set; }
        public List<Donation> DonationList { get; internal set; }

        public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Donations(Donation entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Donations(Donation entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Totals")]
	public partial class Total : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserId;
		
		private int _TotalBlood;
		
		private System.TimeSpan _TotalDuration;
		
		private int _TotalDonations;
		
		private int _SavedLives;
		
		private int _Id;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnTotalBloodChanging(int value);
    partial void OnTotalBloodChanged();
    partial void OnTotalDurationChanging(System.TimeSpan value);
    partial void OnTotalDurationChanged();
    partial void OnTotalDonationsChanging(int value);
    partial void OnTotalDonationsChanged();
    partial void OnSavedLivesChanging(int value);
    partial void OnSavedLivesChanged();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    #endregion
		
		public Total()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalBlood", DbType="Int NOT NULL")]
		public int TotalBlood
		{
			get
			{
				return this._TotalBlood;
			}
			set
			{
				if ((this._TotalBlood != value))
				{
					this.OnTotalBloodChanging(value);
					this.SendPropertyChanging();
					this._TotalBlood = value;
					this.SendPropertyChanged("TotalBlood");
					this.OnTotalBloodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalDuration", DbType="Time NOT NULL")]
		public System.TimeSpan TotalDuration
		{
			get
			{
				return this._TotalDuration;
			}
			set
			{
				if ((this._TotalDuration != value))
				{
					this.OnTotalDurationChanging(value);
					this.SendPropertyChanging();
					this._TotalDuration = value;
					this.SendPropertyChanged("TotalDuration");
					this.OnTotalDurationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalDonations", DbType="Int NOT NULL")]
		public int TotalDonations
		{
			get
			{
				return this._TotalDonations;
			}
			set
			{
				if ((this._TotalDonations != value))
				{
					this.OnTotalDonationsChanging(value);
					this.SendPropertyChanging();
					this._TotalDonations = value;
					this.SendPropertyChanged("TotalDonations");
					this.OnTotalDonationsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SavedLives", DbType="Int NOT NULL")]
		public int SavedLives
		{
			get
			{
				return this._SavedLives;
			}
			set
			{
				if ((this._SavedLives != value))
				{
					this.OnSavedLivesChanging(value);
					this.SendPropertyChanging();
					this._SavedLives = value;
					this.SendPropertyChanged("SavedLives");
					this.OnSavedLivesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Total", Storage="_User", ThisKey="UserId", OtherKey="UserId", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Totals = null;
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Totals = this;
						this._UserId = value.UserId;
					}
					else
					{
						this._UserId = default(int);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Donation")]
	public partial class Donation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserId;
		
		private System.Nullable<double> _Amount;
		
		private string _BloodbagNumber;
		
		private System.Nullable<double> _Bloodsugar;
		
		private string _DonationLocation;
		
		private System.Nullable<System.DateTime> _DonationDate;
		
		private System.Nullable<System.TimeSpan> _Duration;
		
		private int _Id;
		
		private string _DonationType;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnAmountChanging(System.Nullable<double> value);
    partial void OnAmountChanged();
    partial void OnBloodbagNumberChanging(string value);
    partial void OnBloodbagNumberChanged();
    partial void OnBloodsugarChanging(System.Nullable<double> value);
    partial void OnBloodsugarChanged();
    partial void OnDonationLocationChanging(string value);
    partial void OnDonationLocationChanged();
    partial void OnDonationDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDonationDateChanged();
    partial void OnDurationChanging(System.Nullable<System.TimeSpan> value);
    partial void OnDurationChanged();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDonationTypeChanging(string value);
    partial void OnDonationTypeChanged();
    #endregion
		
		public Donation()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Float")]
		public System.Nullable<double> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BloodbagNumber", DbType="NChar(10)")]
		public string BloodbagNumber
		{
			get
			{
				return this._BloodbagNumber;
			}
			set
			{
				if ((this._BloodbagNumber != value))
				{
					this.OnBloodbagNumberChanging(value);
					this.SendPropertyChanging();
					this._BloodbagNumber = value;
					this.SendPropertyChanged("BloodbagNumber");
					this.OnBloodbagNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bloodsugar", DbType="Float")]
		public System.Nullable<double> Bloodsugar
		{
			get
			{
				return this._Bloodsugar;
			}
			set
			{
				if ((this._Bloodsugar != value))
				{
					this.OnBloodsugarChanging(value);
					this.SendPropertyChanging();
					this._Bloodsugar = value;
					this.SendPropertyChanged("Bloodsugar");
					this.OnBloodsugarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonationLocation", DbType="NVarChar(30)")]
		public string DonationLocation
		{
			get
			{
				return this._DonationLocation;
			}
			set
			{
				if ((this._DonationLocation != value))
				{
					this.OnDonationLocationChanging(value);
					this.SendPropertyChanging();
					this._DonationLocation = value;
					this.SendPropertyChanged("DonationLocation");
					this.OnDonationLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonationDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> DonationDate
		{
			get
			{
				return this._DonationDate;
			}
			set
			{
				if ((this._DonationDate != value))
				{
					this.OnDonationDateChanging(value);
					this.SendPropertyChanging();
					this._DonationDate = value;
					this.SendPropertyChanged("DonationDate");
					this.OnDonationDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duration", DbType="Time")]
		public System.Nullable<System.TimeSpan> Duration
		{
			get
			{
				return this._Duration;
			}
			set
			{
				if ((this._Duration != value))
				{
					this.OnDurationChanging(value);
					this.SendPropertyChanging();
					this._Duration = value;
					this.SendPropertyChanged("Duration");
					this.OnDurationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonationType", DbType="NVarChar(20)")]
		public string DonationType
		{
			get
			{
				return this._DonationType;
			}
			set
			{
				if ((this._DonationType != value))
				{
					this.OnDonationTypeChanging(value);
					this.SendPropertyChanging();
					this._DonationType = value;
					this.SendPropertyChanged("DonationType");
					this.OnDonationTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Donation", Storage="_User", ThisKey="UserId", OtherKey="UserId", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Donations.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Donations.Add(this);
						this._UserId = value.UserId;
					}
					else
					{
						this._UserId = default(int);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591