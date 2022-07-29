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

namespace Artsofte.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="test_database")]
	public partial class ArtsofteDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmployees_info(Employees_info instance);
    partial void UpdateEmployees_info(Employees_info instance);
    partial void DeleteEmployees_info(Employees_info instance);
    partial void Insertspr_department(spr_department instance);
    partial void Updatespr_department(spr_department instance);
    partial void Deletespr_department(spr_department instance);
    partial void Insertspr_programming_language(spr_programming_language instance);
    partial void Updatespr_programming_language(spr_programming_language instance);
    partial void Deletespr_programming_language(spr_programming_language instance);
    #endregion
		
		public ArtsofteDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["test_databaseConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ArtsofteDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ArtsofteDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ArtsofteDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ArtsofteDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Employees_info> Employees_infos
		{
			get
			{
				return this.GetTable<Employees_info>();
			}
		}
		
		public System.Data.Linq.Table<spr_department> spr_departments
		{
			get
			{
				return this.GetTable<spr_department>();
			}
		}
		
		public System.Data.Linq.Table<spr_programming_language> spr_programming_languages
		{
			get
			{
				return this.GetTable<spr_programming_language>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employees_info")]
	public partial class Employees_info : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _Name;
		
		private string _Surname;
		
		private int _Age;
		
		private int _Department;
		
		private int _Programming_language;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnAgeChanging(int value);
    partial void OnAgeChanged();
    partial void OnDepartmentChanging(int value);
    partial void OnDepartmentChanged();
    partial void OnProgramming_languageChanging(int value);
    partial void OnProgramming_languageChanged();
    #endregion
		
		public Employees_info()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int NOT NULL")]
		public int Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this.OnDepartmentChanging(value);
					this.SendPropertyChanging();
					this._Department = value;
					this.SendPropertyChanged("Department");
					this.OnDepartmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Programming_language", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Programming_language
		{
			get
			{
				return this._Programming_language;
			}
			set
			{
				if ((this._Programming_language != value))
				{
					this.OnProgramming_languageChanging(value);
					this.SendPropertyChanging();
					this._Programming_language = value;
					this.SendPropertyChanged("Programming_language");
					this.OnProgramming_languageChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.spr_department")]
	public partial class spr_department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _department_name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Ondepartment_nameChanging(string value);
    partial void Ondepartment_nameChanged();
    #endregion
		
		public spr_department()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_department_name", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string department_name
		{
			get
			{
				return this._department_name;
			}
			set
			{
				if ((this._department_name != value))
				{
					this.Ondepartment_nameChanging(value);
					this.SendPropertyChanging();
					this._department_name = value;
					this.SendPropertyChanged("department_name");
					this.Ondepartment_nameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.spr_programming_languages")]
	public partial class spr_programming_language : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _PL_name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnPL_nameChanging(string value);
    partial void OnPL_nameChanged();
    #endregion
		
		public spr_programming_language()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PL_name", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string PL_name
		{
			get
			{
				return this._PL_name;
			}
			set
			{
				if ((this._PL_name != value))
				{
					this.OnPL_nameChanging(value);
					this.SendPropertyChanging();
					this._PL_name = value;
					this.SendPropertyChanged("PL_name");
					this.OnPL_nameChanged();
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