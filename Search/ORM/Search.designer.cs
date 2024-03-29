﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.4959
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ORM
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="searchplatform")]
	public partial class SearchDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertbaiduhuizhou(baiduhuizhou instance);
    partial void Updatebaiduhuizhou(baiduhuizhou instance);
    partial void Deletebaiduhuizhou(baiduhuizhou instance);
    partial void Insertjunengposition(junengposition instance);
    partial void Updatejunengposition(junengposition instance);
    partial void Deletejunengposition(junengposition instance);
    partial void Insertfuhaiposition(fuhaiposition instance);
    partial void Updatefuhaiposition(fuhaiposition instance);
    partial void Deletefuhaiposition(fuhaiposition instance);
    partial void Insertposition(position instance);
    partial void Updateposition(position instance);
    partial void Deleteposition(position instance);
    #endregion
		
		public SearchDataContext() : 
				base(global::ORM.Properties.Settings.Default.searchplatformConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SearchDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SearchDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SearchDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SearchDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<baiduhuizhou> baiduhuizhou
		{
			get
			{
				return this.GetTable<baiduhuizhou>();
			}
		}
		
		public System.Data.Linq.Table<junengposition> junengposition
		{
			get
			{
				return this.GetTable<junengposition>();
			}
		}
		
		public System.Data.Linq.Table<fuhaiposition> fuhaiposition
		{
			get
			{
				return this.GetTable<fuhaiposition>();
			}
		}
		
		public System.Data.Linq.Table<position> position
		{
			get
			{
				return this.GetTable<position>();
			}
		}
	}
	
	[Table(Name="dbo.baiduhuizhou")]
	public partial class baiduhuizhou : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _pos_id;
		
		private string _pos_position;
		
		private string _pos_positionurl;
		
		private string _pos_business;
		
		private string _pos_company;
		
		private string _pos_companyurl;
		
		private string _pos_address;
		
		private string _pos_degree;
		
		private string _pos_workexperience;
		
		private System.Nullable<System.DateTime> _pos_time;
		
		private System.Nullable<int> _pos_count;
		
		private string _pos_salary;
		
		private string _pos_from;
		
		private string _pos_fromurl;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onpos_idChanging(int value);
    partial void Onpos_idChanged();
    partial void Onpos_positionChanging(string value);
    partial void Onpos_positionChanged();
    partial void Onpos_positionurlChanging(string value);
    partial void Onpos_positionurlChanged();
    partial void Onpos_businessChanging(string value);
    partial void Onpos_businessChanged();
    partial void Onpos_companyChanging(string value);
    partial void Onpos_companyChanged();
    partial void Onpos_companyurlChanging(string value);
    partial void Onpos_companyurlChanged();
    partial void Onpos_addressChanging(string value);
    partial void Onpos_addressChanged();
    partial void Onpos_degreeChanging(string value);
    partial void Onpos_degreeChanged();
    partial void Onpos_workexperienceChanging(string value);
    partial void Onpos_workexperienceChanged();
    partial void Onpos_timeChanging(System.Nullable<System.DateTime> value);
    partial void Onpos_timeChanged();
    partial void Onpos_countChanging(System.Nullable<int> value);
    partial void Onpos_countChanged();
    partial void Onpos_salaryChanging(string value);
    partial void Onpos_salaryChanged();
    partial void Onpos_fromChanging(string value);
    partial void Onpos_fromChanged();
    partial void Onpos_fromurlChanging(string value);
    partial void Onpos_fromurlChanged();
    #endregion
		
		public baiduhuizhou()
		{
			OnCreated();
		}
		
		[Column(Storage="_pos_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int pos_id
		{
			get
			{
				return this._pos_id;
			}
			set
			{
				if ((this._pos_id != value))
				{
					this.Onpos_idChanging(value);
					this.SendPropertyChanging();
					this._pos_id = value;
					this.SendPropertyChanged("pos_id");
					this.Onpos_idChanged();
				}
			}
		}
		
		[Column(Storage="_pos_position", DbType="NVarChar(50)")]
		public string pos_position
		{
			get
			{
				return this._pos_position;
			}
			set
			{
				if ((this._pos_position != value))
				{
					this.Onpos_positionChanging(value);
					this.SendPropertyChanging();
					this._pos_position = value;
					this.SendPropertyChanged("pos_position");
					this.Onpos_positionChanged();
				}
			}
		}
		
		[Column(Storage="_pos_positionurl", DbType="NVarChar(500)")]
		public string pos_positionurl
		{
			get
			{
				return this._pos_positionurl;
			}
			set
			{
				if ((this._pos_positionurl != value))
				{
					this.Onpos_positionurlChanging(value);
					this.SendPropertyChanging();
					this._pos_positionurl = value;
					this.SendPropertyChanged("pos_positionurl");
					this.Onpos_positionurlChanged();
				}
			}
		}
		
		[Column(Storage="_pos_business", DbType="NVarChar(50)")]
		public string pos_business
		{
			get
			{
				return this._pos_business;
			}
			set
			{
				if ((this._pos_business != value))
				{
					this.Onpos_businessChanging(value);
					this.SendPropertyChanging();
					this._pos_business = value;
					this.SendPropertyChanged("pos_business");
					this.Onpos_businessChanged();
				}
			}
		}
		
		[Column(Storage="_pos_company", DbType="NVarChar(50)")]
		public string pos_company
		{
			get
			{
				return this._pos_company;
			}
			set
			{
				if ((this._pos_company != value))
				{
					this.Onpos_companyChanging(value);
					this.SendPropertyChanging();
					this._pos_company = value;
					this.SendPropertyChanged("pos_company");
					this.Onpos_companyChanged();
				}
			}
		}
		
		[Column(Storage="_pos_companyurl", DbType="NVarChar(500)")]
		public string pos_companyurl
		{
			get
			{
				return this._pos_companyurl;
			}
			set
			{
				if ((this._pos_companyurl != value))
				{
					this.Onpos_companyurlChanging(value);
					this.SendPropertyChanging();
					this._pos_companyurl = value;
					this.SendPropertyChanged("pos_companyurl");
					this.Onpos_companyurlChanged();
				}
			}
		}
		
		[Column(Storage="_pos_address", DbType="NVarChar(100)")]
		public string pos_address
		{
			get
			{
				return this._pos_address;
			}
			set
			{
				if ((this._pos_address != value))
				{
					this.Onpos_addressChanging(value);
					this.SendPropertyChanging();
					this._pos_address = value;
					this.SendPropertyChanged("pos_address");
					this.Onpos_addressChanged();
				}
			}
		}
		
		[Column(Storage="_pos_degree", DbType="NVarChar(50)")]
		public string pos_degree
		{
			get
			{
				return this._pos_degree;
			}
			set
			{
				if ((this._pos_degree != value))
				{
					this.Onpos_degreeChanging(value);
					this.SendPropertyChanging();
					this._pos_degree = value;
					this.SendPropertyChanged("pos_degree");
					this.Onpos_degreeChanged();
				}
			}
		}
		
		[Column(Storage="_pos_workexperience", DbType="NVarChar(20)")]
		public string pos_workexperience
		{
			get
			{
				return this._pos_workexperience;
			}
			set
			{
				if ((this._pos_workexperience != value))
				{
					this.Onpos_workexperienceChanging(value);
					this.SendPropertyChanging();
					this._pos_workexperience = value;
					this.SendPropertyChanged("pos_workexperience");
					this.Onpos_workexperienceChanged();
				}
			}
		}
		
		[Column(Storage="_pos_time", DbType="DateTime")]
		public System.Nullable<System.DateTime> pos_time
		{
			get
			{
				return this._pos_time;
			}
			set
			{
				if ((this._pos_time != value))
				{
					this.Onpos_timeChanging(value);
					this.SendPropertyChanging();
					this._pos_time = value;
					this.SendPropertyChanged("pos_time");
					this.Onpos_timeChanged();
				}
			}
		}
		
		[Column(Storage="_pos_count", DbType="Int")]
		public System.Nullable<int> pos_count
		{
			get
			{
				return this._pos_count;
			}
			set
			{
				if ((this._pos_count != value))
				{
					this.Onpos_countChanging(value);
					this.SendPropertyChanging();
					this._pos_count = value;
					this.SendPropertyChanged("pos_count");
					this.Onpos_countChanged();
				}
			}
		}
		
		[Column(Storage="_pos_salary", DbType="NVarChar(20)")]
		public string pos_salary
		{
			get
			{
				return this._pos_salary;
			}
			set
			{
				if ((this._pos_salary != value))
				{
					this.Onpos_salaryChanging(value);
					this.SendPropertyChanging();
					this._pos_salary = value;
					this.SendPropertyChanged("pos_salary");
					this.Onpos_salaryChanged();
				}
			}
		}
		
		[Column(Storage="_pos_from", DbType="NVarChar(100)")]
		public string pos_from
		{
			get
			{
				return this._pos_from;
			}
			set
			{
				if ((this._pos_from != value))
				{
					this.Onpos_fromChanging(value);
					this.SendPropertyChanging();
					this._pos_from = value;
					this.SendPropertyChanged("pos_from");
					this.Onpos_fromChanged();
				}
			}
		}
		
		[Column(Storage="_pos_fromurl", DbType="NVarChar(500)")]
		public string pos_fromurl
		{
			get
			{
				return this._pos_fromurl;
			}
			set
			{
				if ((this._pos_fromurl != value))
				{
					this.Onpos_fromurlChanging(value);
					this.SendPropertyChanging();
					this._pos_fromurl = value;
					this.SendPropertyChanged("pos_fromurl");
					this.Onpos_fromurlChanged();
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
	
	[Table(Name="dbo.junengposition")]
	public partial class junengposition : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _pos_id;
		
		private string _pos_position;
		
		private string _pos_positionurl;
		
		private string _pos_business;
		
		private string _pos_company;
		
		private string _pos_companyurl;
		
		private string _pos_address;
		
		private string _pos_degree;
		
		private string _pos_workexperience;
		
		private System.Nullable<System.DateTime> _pos_time;
		
		private System.Nullable<int> _pos_count;
		
		private string _pos_salary;
		
		private string _pos_from;
		
		private string _pos_fromurl;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onpos_idChanging(int value);
    partial void Onpos_idChanged();
    partial void Onpos_positionChanging(string value);
    partial void Onpos_positionChanged();
    partial void Onpos_positionurlChanging(string value);
    partial void Onpos_positionurlChanged();
    partial void Onpos_businessChanging(string value);
    partial void Onpos_businessChanged();
    partial void Onpos_companyChanging(string value);
    partial void Onpos_companyChanged();
    partial void Onpos_companyurlChanging(string value);
    partial void Onpos_companyurlChanged();
    partial void Onpos_addressChanging(string value);
    partial void Onpos_addressChanged();
    partial void Onpos_degreeChanging(string value);
    partial void Onpos_degreeChanged();
    partial void Onpos_workexperienceChanging(string value);
    partial void Onpos_workexperienceChanged();
    partial void Onpos_timeChanging(System.Nullable<System.DateTime> value);
    partial void Onpos_timeChanged();
    partial void Onpos_countChanging(System.Nullable<int> value);
    partial void Onpos_countChanged();
    partial void Onpos_salaryChanging(string value);
    partial void Onpos_salaryChanged();
    partial void Onpos_fromChanging(string value);
    partial void Onpos_fromChanged();
    partial void Onpos_fromurlChanging(string value);
    partial void Onpos_fromurlChanged();
    #endregion
		
		public junengposition()
		{
			OnCreated();
		}
		
		[Column(Storage="_pos_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int pos_id
		{
			get
			{
				return this._pos_id;
			}
			set
			{
				if ((this._pos_id != value))
				{
					this.Onpos_idChanging(value);
					this.SendPropertyChanging();
					this._pos_id = value;
					this.SendPropertyChanged("pos_id");
					this.Onpos_idChanged();
				}
			}
		}
		
		[Column(Storage="_pos_position", DbType="NVarChar(50)")]
		public string pos_position
		{
			get
			{
				return this._pos_position;
			}
			set
			{
				if ((this._pos_position != value))
				{
					this.Onpos_positionChanging(value);
					this.SendPropertyChanging();
					this._pos_position = value;
					this.SendPropertyChanged("pos_position");
					this.Onpos_positionChanged();
				}
			}
		}
		
		[Column(Storage="_pos_positionurl", DbType="NVarChar(500)")]
		public string pos_positionurl
		{
			get
			{
				return this._pos_positionurl;
			}
			set
			{
				if ((this._pos_positionurl != value))
				{
					this.Onpos_positionurlChanging(value);
					this.SendPropertyChanging();
					this._pos_positionurl = value;
					this.SendPropertyChanged("pos_positionurl");
					this.Onpos_positionurlChanged();
				}
			}
		}
		
		[Column(Storage="_pos_business", DbType="NVarChar(50)")]
		public string pos_business
		{
			get
			{
				return this._pos_business;
			}
			set
			{
				if ((this._pos_business != value))
				{
					this.Onpos_businessChanging(value);
					this.SendPropertyChanging();
					this._pos_business = value;
					this.SendPropertyChanged("pos_business");
					this.Onpos_businessChanged();
				}
			}
		}
		
		[Column(Storage="_pos_company", DbType="NVarChar(50)")]
		public string pos_company
		{
			get
			{
				return this._pos_company;
			}
			set
			{
				if ((this._pos_company != value))
				{
					this.Onpos_companyChanging(value);
					this.SendPropertyChanging();
					this._pos_company = value;
					this.SendPropertyChanged("pos_company");
					this.Onpos_companyChanged();
				}
			}
		}
		
		[Column(Storage="_pos_companyurl", DbType="NVarChar(500)")]
		public string pos_companyurl
		{
			get
			{
				return this._pos_companyurl;
			}
			set
			{
				if ((this._pos_companyurl != value))
				{
					this.Onpos_companyurlChanging(value);
					this.SendPropertyChanging();
					this._pos_companyurl = value;
					this.SendPropertyChanged("pos_companyurl");
					this.Onpos_companyurlChanged();
				}
			}
		}
		
		[Column(Storage="_pos_address", DbType="NVarChar(100)")]
		public string pos_address
		{
			get
			{
				return this._pos_address;
			}
			set
			{
				if ((this._pos_address != value))
				{
					this.Onpos_addressChanging(value);
					this.SendPropertyChanging();
					this._pos_address = value;
					this.SendPropertyChanged("pos_address");
					this.Onpos_addressChanged();
				}
			}
		}
		
		[Column(Storage="_pos_degree", DbType="NVarChar(50)")]
		public string pos_degree
		{
			get
			{
				return this._pos_degree;
			}
			set
			{
				if ((this._pos_degree != value))
				{
					this.Onpos_degreeChanging(value);
					this.SendPropertyChanging();
					this._pos_degree = value;
					this.SendPropertyChanged("pos_degree");
					this.Onpos_degreeChanged();
				}
			}
		}
		
		[Column(Storage="_pos_workexperience", DbType="NVarChar(20)")]
		public string pos_workexperience
		{
			get
			{
				return this._pos_workexperience;
			}
			set
			{
				if ((this._pos_workexperience != value))
				{
					this.Onpos_workexperienceChanging(value);
					this.SendPropertyChanging();
					this._pos_workexperience = value;
					this.SendPropertyChanged("pos_workexperience");
					this.Onpos_workexperienceChanged();
				}
			}
		}
		
		[Column(Storage="_pos_time", DbType="DateTime")]
		public System.Nullable<System.DateTime> pos_time
		{
			get
			{
				return this._pos_time;
			}
			set
			{
				if ((this._pos_time != value))
				{
					this.Onpos_timeChanging(value);
					this.SendPropertyChanging();
					this._pos_time = value;
					this.SendPropertyChanged("pos_time");
					this.Onpos_timeChanged();
				}
			}
		}
		
		[Column(Storage="_pos_count", DbType="Int")]
		public System.Nullable<int> pos_count
		{
			get
			{
				return this._pos_count;
			}
			set
			{
				if ((this._pos_count != value))
				{
					this.Onpos_countChanging(value);
					this.SendPropertyChanging();
					this._pos_count = value;
					this.SendPropertyChanged("pos_count");
					this.Onpos_countChanged();
				}
			}
		}
		
		[Column(Storage="_pos_salary", DbType="NVarChar(20)")]
		public string pos_salary
		{
			get
			{
				return this._pos_salary;
			}
			set
			{
				if ((this._pos_salary != value))
				{
					this.Onpos_salaryChanging(value);
					this.SendPropertyChanging();
					this._pos_salary = value;
					this.SendPropertyChanged("pos_salary");
					this.Onpos_salaryChanged();
				}
			}
		}
		
		[Column(Storage="_pos_from", DbType="NVarChar(100)")]
		public string pos_from
		{
			get
			{
				return this._pos_from;
			}
			set
			{
				if ((this._pos_from != value))
				{
					this.Onpos_fromChanging(value);
					this.SendPropertyChanging();
					this._pos_from = value;
					this.SendPropertyChanged("pos_from");
					this.Onpos_fromChanged();
				}
			}
		}
		
		[Column(Storage="_pos_fromurl", DbType="NVarChar(500)")]
		public string pos_fromurl
		{
			get
			{
				return this._pos_fromurl;
			}
			set
			{
				if ((this._pos_fromurl != value))
				{
					this.Onpos_fromurlChanging(value);
					this.SendPropertyChanging();
					this._pos_fromurl = value;
					this.SendPropertyChanged("pos_fromurl");
					this.Onpos_fromurlChanged();
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
	
	[Table(Name="dbo.fuhaiposition")]
	public partial class fuhaiposition : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _pos_id;
		
		private string _pos_position;
		
		private string _pos_positionurl;
		
		private string _pos_business;
		
		private string _pos_company;
		
		private string _pos_companyurl;
		
		private string _pos_address;
		
		private string _pos_degree;
		
		private string _pos_workexperience;
		
		private System.Nullable<System.DateTime> _pos_time;
		
		private System.Nullable<int> _pos_count;
		
		private string _pos_salary;
		
		private string _pos_from;
		
		private string _pos_fromurl;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onpos_idChanging(int value);
    partial void Onpos_idChanged();
    partial void Onpos_positionChanging(string value);
    partial void Onpos_positionChanged();
    partial void Onpos_positionurlChanging(string value);
    partial void Onpos_positionurlChanged();
    partial void Onpos_businessChanging(string value);
    partial void Onpos_businessChanged();
    partial void Onpos_companyChanging(string value);
    partial void Onpos_companyChanged();
    partial void Onpos_companyurlChanging(string value);
    partial void Onpos_companyurlChanged();
    partial void Onpos_addressChanging(string value);
    partial void Onpos_addressChanged();
    partial void Onpos_degreeChanging(string value);
    partial void Onpos_degreeChanged();
    partial void Onpos_workexperienceChanging(string value);
    partial void Onpos_workexperienceChanged();
    partial void Onpos_timeChanging(System.Nullable<System.DateTime> value);
    partial void Onpos_timeChanged();
    partial void Onpos_countChanging(System.Nullable<int> value);
    partial void Onpos_countChanged();
    partial void Onpos_salaryChanging(string value);
    partial void Onpos_salaryChanged();
    partial void Onpos_fromChanging(string value);
    partial void Onpos_fromChanged();
    partial void Onpos_fromurlChanging(string value);
    partial void Onpos_fromurlChanged();
    #endregion
		
		public fuhaiposition()
		{
			OnCreated();
		}
		
		[Column(Storage="_pos_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int pos_id
		{
			get
			{
				return this._pos_id;
			}
			set
			{
				if ((this._pos_id != value))
				{
					this.Onpos_idChanging(value);
					this.SendPropertyChanging();
					this._pos_id = value;
					this.SendPropertyChanged("pos_id");
					this.Onpos_idChanged();
				}
			}
		}
		
		[Column(Storage="_pos_position", DbType="NVarChar(50)")]
		public string pos_position
		{
			get
			{
				return this._pos_position;
			}
			set
			{
				if ((this._pos_position != value))
				{
					this.Onpos_positionChanging(value);
					this.SendPropertyChanging();
					this._pos_position = value;
					this.SendPropertyChanged("pos_position");
					this.Onpos_positionChanged();
				}
			}
		}
		
		[Column(Storage="_pos_positionurl", DbType="NVarChar(500)")]
		public string pos_positionurl
		{
			get
			{
				return this._pos_positionurl;
			}
			set
			{
				if ((this._pos_positionurl != value))
				{
					this.Onpos_positionurlChanging(value);
					this.SendPropertyChanging();
					this._pos_positionurl = value;
					this.SendPropertyChanged("pos_positionurl");
					this.Onpos_positionurlChanged();
				}
			}
		}
		
		[Column(Storage="_pos_business", DbType="NVarChar(50)")]
		public string pos_business
		{
			get
			{
				return this._pos_business;
			}
			set
			{
				if ((this._pos_business != value))
				{
					this.Onpos_businessChanging(value);
					this.SendPropertyChanging();
					this._pos_business = value;
					this.SendPropertyChanged("pos_business");
					this.Onpos_businessChanged();
				}
			}
		}
		
		[Column(Storage="_pos_company", DbType="NVarChar(50)")]
		public string pos_company
		{
			get
			{
				return this._pos_company;
			}
			set
			{
				if ((this._pos_company != value))
				{
					this.Onpos_companyChanging(value);
					this.SendPropertyChanging();
					this._pos_company = value;
					this.SendPropertyChanged("pos_company");
					this.Onpos_companyChanged();
				}
			}
		}
		
		[Column(Storage="_pos_companyurl", DbType="NVarChar(500)")]
		public string pos_companyurl
		{
			get
			{
				return this._pos_companyurl;
			}
			set
			{
				if ((this._pos_companyurl != value))
				{
					this.Onpos_companyurlChanging(value);
					this.SendPropertyChanging();
					this._pos_companyurl = value;
					this.SendPropertyChanged("pos_companyurl");
					this.Onpos_companyurlChanged();
				}
			}
		}
		
		[Column(Storage="_pos_address", DbType="NVarChar(100)")]
		public string pos_address
		{
			get
			{
				return this._pos_address;
			}
			set
			{
				if ((this._pos_address != value))
				{
					this.Onpos_addressChanging(value);
					this.SendPropertyChanging();
					this._pos_address = value;
					this.SendPropertyChanged("pos_address");
					this.Onpos_addressChanged();
				}
			}
		}
		
		[Column(Storage="_pos_degree", DbType="NVarChar(50)")]
		public string pos_degree
		{
			get
			{
				return this._pos_degree;
			}
			set
			{
				if ((this._pos_degree != value))
				{
					this.Onpos_degreeChanging(value);
					this.SendPropertyChanging();
					this._pos_degree = value;
					this.SendPropertyChanged("pos_degree");
					this.Onpos_degreeChanged();
				}
			}
		}
		
		[Column(Storage="_pos_workexperience", DbType="NVarChar(20)")]
		public string pos_workexperience
		{
			get
			{
				return this._pos_workexperience;
			}
			set
			{
				if ((this._pos_workexperience != value))
				{
					this.Onpos_workexperienceChanging(value);
					this.SendPropertyChanging();
					this._pos_workexperience = value;
					this.SendPropertyChanged("pos_workexperience");
					this.Onpos_workexperienceChanged();
				}
			}
		}
		
		[Column(Storage="_pos_time", DbType="DateTime")]
		public System.Nullable<System.DateTime> pos_time
		{
			get
			{
				return this._pos_time;
			}
			set
			{
				if ((this._pos_time != value))
				{
					this.Onpos_timeChanging(value);
					this.SendPropertyChanging();
					this._pos_time = value;
					this.SendPropertyChanged("pos_time");
					this.Onpos_timeChanged();
				}
			}
		}
		
		[Column(Storage="_pos_count", DbType="Int")]
		public System.Nullable<int> pos_count
		{
			get
			{
				return this._pos_count;
			}
			set
			{
				if ((this._pos_count != value))
				{
					this.Onpos_countChanging(value);
					this.SendPropertyChanging();
					this._pos_count = value;
					this.SendPropertyChanged("pos_count");
					this.Onpos_countChanged();
				}
			}
		}
		
		[Column(Storage="_pos_salary", DbType="NVarChar(20)")]
		public string pos_salary
		{
			get
			{
				return this._pos_salary;
			}
			set
			{
				if ((this._pos_salary != value))
				{
					this.Onpos_salaryChanging(value);
					this.SendPropertyChanging();
					this._pos_salary = value;
					this.SendPropertyChanged("pos_salary");
					this.Onpos_salaryChanged();
				}
			}
		}
		
		[Column(Storage="_pos_from", DbType="NVarChar(100)")]
		public string pos_from
		{
			get
			{
				return this._pos_from;
			}
			set
			{
				if ((this._pos_from != value))
				{
					this.Onpos_fromChanging(value);
					this.SendPropertyChanging();
					this._pos_from = value;
					this.SendPropertyChanged("pos_from");
					this.Onpos_fromChanged();
				}
			}
		}
		
		[Column(Storage="_pos_fromurl", DbType="NVarChar(500)")]
		public string pos_fromurl
		{
			get
			{
				return this._pos_fromurl;
			}
			set
			{
				if ((this._pos_fromurl != value))
				{
					this.Onpos_fromurlChanging(value);
					this.SendPropertyChanging();
					this._pos_fromurl = value;
					this.SendPropertyChanged("pos_fromurl");
					this.Onpos_fromurlChanged();
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
	
	[Table(Name="dbo.position")]
	public partial class position : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _pos_id;
		
		private string _pos_position;
		
		private string _pos_positionurl;
		
		private string _pos_business;
		
		private string _pos_company;
		
		private string _pos_companyurl;
		
		private string _pos_address;
		
		private string _pos_degree;
		
		private string _pos_workexperience;
		
		private System.Nullable<System.DateTime> _pos_time;
		
		private System.Nullable<int> _pos_count;
		
		private string _pos_salary;
		
		private string _pos_from;
		
		private string _pos_fromurl;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onpos_idChanging(int value);
    partial void Onpos_idChanged();
    partial void Onpos_positionChanging(string value);
    partial void Onpos_positionChanged();
    partial void Onpos_positionurlChanging(string value);
    partial void Onpos_positionurlChanged();
    partial void Onpos_businessChanging(string value);
    partial void Onpos_businessChanged();
    partial void Onpos_companyChanging(string value);
    partial void Onpos_companyChanged();
    partial void Onpos_companyurlChanging(string value);
    partial void Onpos_companyurlChanged();
    partial void Onpos_addressChanging(string value);
    partial void Onpos_addressChanged();
    partial void Onpos_degreeChanging(string value);
    partial void Onpos_degreeChanged();
    partial void Onpos_workexperienceChanging(string value);
    partial void Onpos_workexperienceChanged();
    partial void Onpos_timeChanging(System.Nullable<System.DateTime> value);
    partial void Onpos_timeChanged();
    partial void Onpos_countChanging(System.Nullable<int> value);
    partial void Onpos_countChanged();
    partial void Onpos_salaryChanging(string value);
    partial void Onpos_salaryChanged();
    partial void Onpos_fromChanging(string value);
    partial void Onpos_fromChanged();
    partial void Onpos_fromurlChanging(string value);
    partial void Onpos_fromurlChanged();
    #endregion
		
		public position()
		{
			OnCreated();
		}
		
		[Column(Storage="_pos_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int pos_id
		{
			get
			{
				return this._pos_id;
			}
			set
			{
				if ((this._pos_id != value))
				{
					this.Onpos_idChanging(value);
					this.SendPropertyChanging();
					this._pos_id = value;
					this.SendPropertyChanged("pos_id");
					this.Onpos_idChanged();
				}
			}
		}
		
		[Column(Storage="_pos_position", DbType="NVarChar(50)")]
		public string pos_position
		{
			get
			{
				return this._pos_position;
			}
			set
			{
				if ((this._pos_position != value))
				{
					this.Onpos_positionChanging(value);
					this.SendPropertyChanging();
					this._pos_position = value;
					this.SendPropertyChanged("pos_position");
					this.Onpos_positionChanged();
				}
			}
		}
		
		[Column(Storage="_pos_positionurl", DbType="NVarChar(500)")]
		public string pos_positionurl
		{
			get
			{
				return this._pos_positionurl;
			}
			set
			{
				if ((this._pos_positionurl != value))
				{
					this.Onpos_positionurlChanging(value);
					this.SendPropertyChanging();
					this._pos_positionurl = value;
					this.SendPropertyChanged("pos_positionurl");
					this.Onpos_positionurlChanged();
				}
			}
		}
		
		[Column(Storage="_pos_business", DbType="NVarChar(50)")]
		public string pos_business
		{
			get
			{
				return this._pos_business;
			}
			set
			{
				if ((this._pos_business != value))
				{
					this.Onpos_businessChanging(value);
					this.SendPropertyChanging();
					this._pos_business = value;
					this.SendPropertyChanged("pos_business");
					this.Onpos_businessChanged();
				}
			}
		}
		
		[Column(Storage="_pos_company", DbType="NVarChar(50)")]
		public string pos_company
		{
			get
			{
				return this._pos_company;
			}
			set
			{
				if ((this._pos_company != value))
				{
					this.Onpos_companyChanging(value);
					this.SendPropertyChanging();
					this._pos_company = value;
					this.SendPropertyChanged("pos_company");
					this.Onpos_companyChanged();
				}
			}
		}
		
		[Column(Storage="_pos_companyurl", DbType="NVarChar(500)")]
		public string pos_companyurl
		{
			get
			{
				return this._pos_companyurl;
			}
			set
			{
				if ((this._pos_companyurl != value))
				{
					this.Onpos_companyurlChanging(value);
					this.SendPropertyChanging();
					this._pos_companyurl = value;
					this.SendPropertyChanged("pos_companyurl");
					this.Onpos_companyurlChanged();
				}
			}
		}
		
		[Column(Storage="_pos_address", DbType="NVarChar(100)")]
		public string pos_address
		{
			get
			{
				return this._pos_address;
			}
			set
			{
				if ((this._pos_address != value))
				{
					this.Onpos_addressChanging(value);
					this.SendPropertyChanging();
					this._pos_address = value;
					this.SendPropertyChanged("pos_address");
					this.Onpos_addressChanged();
				}
			}
		}
		
		[Column(Storage="_pos_degree", DbType="NVarChar(50)")]
		public string pos_degree
		{
			get
			{
				return this._pos_degree;
			}
			set
			{
				if ((this._pos_degree != value))
				{
					this.Onpos_degreeChanging(value);
					this.SendPropertyChanging();
					this._pos_degree = value;
					this.SendPropertyChanged("pos_degree");
					this.Onpos_degreeChanged();
				}
			}
		}
		
		[Column(Storage="_pos_workexperience", DbType="NVarChar(20)")]
		public string pos_workexperience
		{
			get
			{
				return this._pos_workexperience;
			}
			set
			{
				if ((this._pos_workexperience != value))
				{
					this.Onpos_workexperienceChanging(value);
					this.SendPropertyChanging();
					this._pos_workexperience = value;
					this.SendPropertyChanged("pos_workexperience");
					this.Onpos_workexperienceChanged();
				}
			}
		}
		
		[Column(Storage="_pos_time", DbType="DateTime")]
		public System.Nullable<System.DateTime> pos_time
		{
			get
			{
				return this._pos_time;
			}
			set
			{
				if ((this._pos_time != value))
				{
					this.Onpos_timeChanging(value);
					this.SendPropertyChanging();
					this._pos_time = value;
					this.SendPropertyChanged("pos_time");
					this.Onpos_timeChanged();
				}
			}
		}
		
		[Column(Storage="_pos_count", DbType="Int")]
		public System.Nullable<int> pos_count
		{
			get
			{
				return this._pos_count;
			}
			set
			{
				if ((this._pos_count != value))
				{
					this.Onpos_countChanging(value);
					this.SendPropertyChanging();
					this._pos_count = value;
					this.SendPropertyChanged("pos_count");
					this.Onpos_countChanged();
				}
			}
		}
		
		[Column(Storage="_pos_salary", DbType="NVarChar(20)")]
		public string pos_salary
		{
			get
			{
				return this._pos_salary;
			}
			set
			{
				if ((this._pos_salary != value))
				{
					this.Onpos_salaryChanging(value);
					this.SendPropertyChanging();
					this._pos_salary = value;
					this.SendPropertyChanged("pos_salary");
					this.Onpos_salaryChanged();
				}
			}
		}
		
		[Column(Storage="_pos_from", DbType="NVarChar(100)")]
		public string pos_from
		{
			get
			{
				return this._pos_from;
			}
			set
			{
				if ((this._pos_from != value))
				{
					this.Onpos_fromChanging(value);
					this.SendPropertyChanging();
					this._pos_from = value;
					this.SendPropertyChanged("pos_from");
					this.Onpos_fromChanged();
				}
			}
		}
		
		[Column(Storage="_pos_fromurl", DbType="NVarChar(500)")]
		public string pos_fromurl
		{
			get
			{
				return this._pos_fromurl;
			}
			set
			{
				if ((this._pos_fromurl != value))
				{
					this.Onpos_fromurlChanging(value);
					this.SendPropertyChanging();
					this._pos_fromurl = value;
					this.SendPropertyChanged("pos_fromurl");
					this.Onpos_fromurlChanged();
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
