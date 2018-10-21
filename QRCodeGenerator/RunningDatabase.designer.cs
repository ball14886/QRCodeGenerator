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

namespace QRCodeGenerator
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="RunningQR")]
	public partial class RunningDatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertRunnerInfo(RunnerInfo instance);
    partial void UpdateRunnerInfo(RunnerInfo instance);
    partial void DeleteRunnerInfo(RunnerInfo instance);
    partial void InsertRunnerScanDateTime(RunnerScanDateTime instance);
    partial void UpdateRunnerScanDateTime(RunnerScanDateTime instance);
    partial void DeleteRunnerScanDateTime(RunnerScanDateTime instance);
    #endregion
		
		public RunningDatabaseDataContext() : 
				base(global::QRCodeGenerator.Properties.Settings.Default.RunningQRConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public RunningDatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RunningDatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RunningDatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RunningDatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<RunnerInfo> RunnerInfos
		{
			get
			{
				return this.GetTable<RunnerInfo>();
			}
		}
		
		public System.Data.Linq.Table<RunnerScanDateTime> RunnerScanDateTimes
		{
			get
			{
				return this.GetTable<RunnerScanDateTime>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RunnerInfo")]
	public partial class RunnerInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _RunnerID;
		
		private string _RunnerBIB;
		
		private string _TicketType;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _ShirtSize;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRunnerIDChanging(long value);
    partial void OnRunnerIDChanged();
    partial void OnRunnerBIBChanging(string value);
    partial void OnRunnerBIBChanged();
    partial void OnTicketTypeChanging(string value);
    partial void OnTicketTypeChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnShirtSizeChanging(string value);
    partial void OnShirtSizeChanged();
    #endregion
		
		public RunnerInfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RunnerID", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long RunnerID
		{
			get
			{
				return this._RunnerID;
			}
			set
			{
				if ((this._RunnerID != value))
				{
					this.OnRunnerIDChanging(value);
					this.SendPropertyChanging();
					this._RunnerID = value;
					this.SendPropertyChanged("RunnerID");
					this.OnRunnerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RunnerBIB", DbType="NVarChar(50)")]
		public string RunnerBIB
		{
			get
			{
				return this._RunnerBIB;
			}
			set
			{
				if ((this._RunnerBIB != value))
				{
					this.OnRunnerBIBChanging(value);
					this.SendPropertyChanging();
					this._RunnerBIB = value;
					this.SendPropertyChanged("RunnerBIB");
					this.OnRunnerBIBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TicketType", DbType="NVarChar(50)")]
		public string TicketType
		{
			get
			{
				return this._TicketType;
			}
			set
			{
				if ((this._TicketType != value))
				{
					this.OnTicketTypeChanging(value);
					this.SendPropertyChanging();
					this._TicketType = value;
					this.SendPropertyChanged("TicketType");
					this.OnTicketTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(100)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(100)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShirtSize", DbType="NVarChar(100)")]
		public string ShirtSize
		{
			get
			{
				return this._ShirtSize;
			}
			set
			{
				if ((this._ShirtSize != value))
				{
					this.OnShirtSizeChanging(value);
					this.SendPropertyChanging();
					this._ShirtSize = value;
					this.SendPropertyChanged("ShirtSize");
					this.OnShirtSizeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RunnerScanDateTime")]
	public partial class RunnerScanDateTime : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _RunnerScanDateTimeID;
		
		private string _RunnerIdentification;
		
		private System.DateTime _ScannedDateTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRunnerScanDateTimeIDChanging(long value);
    partial void OnRunnerScanDateTimeIDChanged();
    partial void OnRunnerIdentificationChanging(string value);
    partial void OnRunnerIdentificationChanged();
    partial void OnScannedDateTimeChanging(System.DateTime value);
    partial void OnScannedDateTimeChanged();
    #endregion
		
		public RunnerScanDateTime()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RunnerScanDateTimeID", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long RunnerScanDateTimeID
		{
			get
			{
				return this._RunnerScanDateTimeID;
			}
			set
			{
				if ((this._RunnerScanDateTimeID != value))
				{
					this.OnRunnerScanDateTimeIDChanging(value);
					this.SendPropertyChanging();
					this._RunnerScanDateTimeID = value;
					this.SendPropertyChanged("RunnerScanDateTimeID");
					this.OnRunnerScanDateTimeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RunnerIdentification", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string RunnerIdentification
		{
			get
			{
				return this._RunnerIdentification;
			}
			set
			{
				if ((this._RunnerIdentification != value))
				{
					this.OnRunnerIdentificationChanging(value);
					this.SendPropertyChanging();
					this._RunnerIdentification = value;
					this.SendPropertyChanged("RunnerIdentification");
					this.OnRunnerIdentificationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ScannedDateTime", DbType="DateTime NOT NULL")]
		public System.DateTime ScannedDateTime
		{
			get
			{
				return this._ScannedDateTime;
			}
			set
			{
				if ((this._ScannedDateTime != value))
				{
					this.OnScannedDateTimeChanging(value);
					this.SendPropertyChanging();
					this._ScannedDateTime = value;
					this.SendPropertyChanged("ScannedDateTime");
					this.OnScannedDateTimeChanged();
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
