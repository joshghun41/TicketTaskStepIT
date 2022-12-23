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

namespace TicketTaskWithCodeFirst
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TicketDb")]
	public partial class TicketDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAirplane(Airplane instance);
    partial void UpdateAirplane(Airplane instance);
    partial void DeleteAirplane(Airplane instance);
    partial void InsertCity(City instance);
    partial void UpdateCity(City instance);
    partial void DeleteCity(City instance);
    partial void InsertPilot(Pilot instance);
    partial void UpdatePilot(Pilot instance);
    partial void DeletePilot(Pilot instance);
    partial void InsertSchedule(Schedule instance);
    partial void UpdateSchedule(Schedule instance);
    partial void DeleteSchedule(Schedule instance);
    partial void InsertTicket(Ticket instance);
    partial void UpdateTicket(Ticket instance);
    partial void DeleteTicket(Ticket instance);
    #endregion
		
		public TicketDataClassesDataContext() : 
				base(global::TicketTaskWithCodeFirst.Properties.Settings.Default.TicketDbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TicketDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TicketDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TicketDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TicketDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Airplane> Airplanes
		{
			get
			{
				return this.GetTable<Airplane>();
			}
		}
		
		public System.Data.Linq.Table<City> Cities
		{
			get
			{
				return this.GetTable<City>();
			}
		}
		
		public System.Data.Linq.Table<Pilot> Pilots
		{
			get
			{
				return this.GetTable<Pilot>();
			}
		}
		
		public System.Data.Linq.Table<Schedule> Schedules
		{
			get
			{
				return this.GetTable<Schedule>();
			}
		}
		
		public System.Data.Linq.Table<Ticket> Tickets
		{
			get
			{
				return this.GetTable<Ticket>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Airplanes")]
	public partial class Airplane : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _PlaneName;
		
		private int _PassengerCount;
		
		private System.Nullable<int> _PilotId;
		
		private EntitySet<City> _Cities;
		
		private EntitySet<Ticket> _Tickets;
		
		private EntityRef<Pilot> _Pilot;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnPlaneNameChanging(string value);
    partial void OnPlaneNameChanged();
    partial void OnPassengerCountChanging(int value);
    partial void OnPassengerCountChanged();
    partial void OnPilotIdChanging(System.Nullable<int> value);
    partial void OnPilotIdChanged();
    #endregion
		
		public Airplane()
		{
			this._Cities = new EntitySet<City>(new Action<City>(this.attach_Cities), new Action<City>(this.detach_Cities));
			this._Tickets = new EntitySet<Ticket>(new Action<Ticket>(this.attach_Tickets), new Action<Ticket>(this.detach_Tickets));
			this._Pilot = default(EntityRef<Pilot>);
			OnCreated();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlaneName", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string PlaneName
		{
			get
			{
				return this._PlaneName;
			}
			set
			{
				if ((this._PlaneName != value))
				{
					this.OnPlaneNameChanging(value);
					this.SendPropertyChanging();
					this._PlaneName = value;
					this.SendPropertyChanged("PlaneName");
					this.OnPlaneNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PassengerCount", DbType="Int NOT NULL")]
		public int PassengerCount
		{
			get
			{
				return this._PassengerCount;
			}
			set
			{
				if ((this._PassengerCount != value))
				{
					this.OnPassengerCountChanging(value);
					this.SendPropertyChanging();
					this._PassengerCount = value;
					this.SendPropertyChanged("PassengerCount");
					this.OnPassengerCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PilotId", DbType="Int")]
		public System.Nullable<int> PilotId
		{
			get
			{
				return this._PilotId;
			}
			set
			{
				if ((this._PilotId != value))
				{
					if (this._Pilot.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPilotIdChanging(value);
					this.SendPropertyChanging();
					this._PilotId = value;
					this.SendPropertyChanged("PilotId");
					this.OnPilotIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Airplane_City", Storage="_Cities", ThisKey="Id", OtherKey="AirplaneId")]
		public EntitySet<City> Cities
		{
			get
			{
				return this._Cities;
			}
			set
			{
				this._Cities.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Airplane_Ticket", Storage="_Tickets", ThisKey="Id", OtherKey="AirplaneId")]
		public EntitySet<Ticket> Tickets
		{
			get
			{
				return this._Tickets;
			}
			set
			{
				this._Tickets.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pilot_Airplane", Storage="_Pilot", ThisKey="PilotId", OtherKey="Id", IsForeignKey=true, DeleteRule="CASCADE")]
		public Pilot Pilot
		{
			get
			{
				return this._Pilot.Entity;
			}
			set
			{
				Pilot previousValue = this._Pilot.Entity;
				if (((previousValue != value) 
							|| (this._Pilot.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Pilot.Entity = null;
						previousValue.Airplanes.Remove(this);
					}
					this._Pilot.Entity = value;
					if ((value != null))
					{
						value.Airplanes.Add(this);
						this._PilotId = value.Id;
					}
					else
					{
						this._PilotId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Pilot");
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
		
		private void attach_Cities(City entity)
		{
			this.SendPropertyChanging();
			entity.Airplane = this;
		}
		
		private void detach_Cities(City entity)
		{
			this.SendPropertyChanging();
			entity.Airplane = null;
		}
		
		private void attach_Tickets(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.Airplane = this;
		}
		
		private void detach_Tickets(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.Airplane = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cities")]
	public partial class City : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _CityName;
		
		private System.Nullable<int> _ScheduleId;
		
		private System.Nullable<int> _AirplaneId;
		
		private EntitySet<Ticket> _Tickets;
		
		private EntityRef<Airplane> _Airplane;
		
		private EntityRef<Schedule> _Schedule;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCityNameChanging(string value);
    partial void OnCityNameChanged();
    partial void OnScheduleIdChanging(System.Nullable<int> value);
    partial void OnScheduleIdChanged();
    partial void OnAirplaneIdChanging(System.Nullable<int> value);
    partial void OnAirplaneIdChanged();
    #endregion
		
		public City()
		{
			this._Tickets = new EntitySet<Ticket>(new Action<Ticket>(this.attach_Tickets), new Action<Ticket>(this.detach_Tickets));
			this._Airplane = default(EntityRef<Airplane>);
			this._Schedule = default(EntityRef<Schedule>);
			OnCreated();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityName", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string CityName
		{
			get
			{
				return this._CityName;
			}
			set
			{
				if ((this._CityName != value))
				{
					this.OnCityNameChanging(value);
					this.SendPropertyChanging();
					this._CityName = value;
					this.SendPropertyChanged("CityName");
					this.OnCityNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ScheduleId", DbType="Int")]
		public System.Nullable<int> ScheduleId
		{
			get
			{
				return this._ScheduleId;
			}
			set
			{
				if ((this._ScheduleId != value))
				{
					if (this._Schedule.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnScheduleIdChanging(value);
					this.SendPropertyChanging();
					this._ScheduleId = value;
					this.SendPropertyChanged("ScheduleId");
					this.OnScheduleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AirplaneId", DbType="Int")]
		public System.Nullable<int> AirplaneId
		{
			get
			{
				return this._AirplaneId;
			}
			set
			{
				if ((this._AirplaneId != value))
				{
					if (this._Airplane.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAirplaneIdChanging(value);
					this.SendPropertyChanging();
					this._AirplaneId = value;
					this.SendPropertyChanged("AirplaneId");
					this.OnAirplaneIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="City_Ticket", Storage="_Tickets", ThisKey="Id", OtherKey="CityId")]
		public EntitySet<Ticket> Tickets
		{
			get
			{
				return this._Tickets;
			}
			set
			{
				this._Tickets.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Airplane_City", Storage="_Airplane", ThisKey="AirplaneId", OtherKey="Id", IsForeignKey=true, DeleteRule="CASCADE")]
		public Airplane Airplane
		{
			get
			{
				return this._Airplane.Entity;
			}
			set
			{
				Airplane previousValue = this._Airplane.Entity;
				if (((previousValue != value) 
							|| (this._Airplane.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Airplane.Entity = null;
						previousValue.Cities.Remove(this);
					}
					this._Airplane.Entity = value;
					if ((value != null))
					{
						value.Cities.Add(this);
						this._AirplaneId = value.Id;
					}
					else
					{
						this._AirplaneId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Airplane");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Schedule_City", Storage="_Schedule", ThisKey="ScheduleId", OtherKey="Id", IsForeignKey=true, DeleteRule="CASCADE")]
		public Schedule Schedule
		{
			get
			{
				return this._Schedule.Entity;
			}
			set
			{
				Schedule previousValue = this._Schedule.Entity;
				if (((previousValue != value) 
							|| (this._Schedule.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Schedule.Entity = null;
						previousValue.Cities.Remove(this);
					}
					this._Schedule.Entity = value;
					if ((value != null))
					{
						value.Cities.Add(this);
						this._ScheduleId = value.Id;
					}
					else
					{
						this._ScheduleId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Schedule");
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
		
		private void attach_Tickets(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.City = this;
		}
		
		private void detach_Tickets(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.City = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pilots")]
	public partial class Pilot : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _FirstName;
		
		private string _LastName;
		
		private EntitySet<Airplane> _Airplanes;
		
		private EntitySet<Ticket> _Tickets;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    #endregion
		
		public Pilot()
		{
			this._Airplanes = new EntitySet<Airplane>(new Action<Airplane>(this.attach_Airplanes), new Action<Airplane>(this.detach_Airplanes));
			this._Tickets = new EntitySet<Ticket>(new Action<Ticket>(this.attach_Tickets), new Action<Ticket>(this.detach_Tickets));
			OnCreated();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pilot_Airplane", Storage="_Airplanes", ThisKey="Id", OtherKey="PilotId")]
		public EntitySet<Airplane> Airplanes
		{
			get
			{
				return this._Airplanes;
			}
			set
			{
				this._Airplanes.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pilot_Ticket", Storage="_Tickets", ThisKey="Id", OtherKey="PilotId")]
		public EntitySet<Ticket> Tickets
		{
			get
			{
				return this._Tickets;
			}
			set
			{
				this._Tickets.Assign(value);
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
		
		private void attach_Airplanes(Airplane entity)
		{
			this.SendPropertyChanging();
			entity.Pilot = this;
		}
		
		private void detach_Airplanes(Airplane entity)
		{
			this.SendPropertyChanging();
			entity.Pilot = null;
		}
		
		private void attach_Tickets(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.Pilot = this;
		}
		
		private void detach_Tickets(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.Pilot = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Schedules")]
	public partial class Schedule : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Date;
		
		private EntitySet<City> _Cities;
		
		private EntitySet<Ticket> _Tickets;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDateChanging(string value);
    partial void OnDateChanged();
    #endregion
		
		public Schedule()
		{
			this._Cities = new EntitySet<City>(new Action<City>(this.attach_Cities), new Action<City>(this.detach_Cities));
			this._Tickets = new EntitySet<Ticket>(new Action<Ticket>(this.attach_Tickets), new Action<Ticket>(this.detach_Tickets));
			OnCreated();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Schedule_City", Storage="_Cities", ThisKey="Id", OtherKey="ScheduleId")]
		public EntitySet<City> Cities
		{
			get
			{
				return this._Cities;
			}
			set
			{
				this._Cities.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Schedule_Ticket", Storage="_Tickets", ThisKey="Id", OtherKey="ScheduleId")]
		public EntitySet<Ticket> Tickets
		{
			get
			{
				return this._Tickets;
			}
			set
			{
				this._Tickets.Assign(value);
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
		
		private void attach_Cities(City entity)
		{
			this.SendPropertyChanging();
			entity.Schedule = this;
		}
		
		private void detach_Cities(City entity)
		{
			this.SendPropertyChanging();
			entity.Schedule = null;
		}
		
		private void attach_Tickets(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.Schedule = this;
		}
		
		private void detach_Tickets(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.Schedule = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tickets")]
	public partial class Ticket : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _PilotId;
		
		private System.Nullable<int> _ScheduleId;
		
		private System.Nullable<int> _AirplaneId;
		
		private System.Nullable<int> _CityId;
		
		private EntityRef<Airplane> _Airplane;
		
		private EntityRef<City> _City;
		
		private EntityRef<Pilot> _Pilot;
		
		private EntityRef<Schedule> _Schedule;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnPilotIdChanging(System.Nullable<int> value);
    partial void OnPilotIdChanged();
    partial void OnScheduleIdChanging(System.Nullable<int> value);
    partial void OnScheduleIdChanged();
    partial void OnAirplaneIdChanging(System.Nullable<int> value);
    partial void OnAirplaneIdChanged();
    partial void OnCityIdChanging(System.Nullable<int> value);
    partial void OnCityIdChanged();
    #endregion
		
		public Ticket()
		{
			this._Airplane = default(EntityRef<Airplane>);
			this._City = default(EntityRef<City>);
			this._Pilot = default(EntityRef<Pilot>);
			this._Schedule = default(EntityRef<Schedule>);
			OnCreated();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PilotId", DbType="Int")]
		public System.Nullable<int> PilotId
		{
			get
			{
				return this._PilotId;
			}
			set
			{
				if ((this._PilotId != value))
				{
					if (this._Pilot.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPilotIdChanging(value);
					this.SendPropertyChanging();
					this._PilotId = value;
					this.SendPropertyChanged("PilotId");
					this.OnPilotIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ScheduleId", DbType="Int")]
		public System.Nullable<int> ScheduleId
		{
			get
			{
				return this._ScheduleId;
			}
			set
			{
				if ((this._ScheduleId != value))
				{
					if (this._Schedule.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnScheduleIdChanging(value);
					this.SendPropertyChanging();
					this._ScheduleId = value;
					this.SendPropertyChanged("ScheduleId");
					this.OnScheduleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AirplaneId", DbType="Int")]
		public System.Nullable<int> AirplaneId
		{
			get
			{
				return this._AirplaneId;
			}
			set
			{
				if ((this._AirplaneId != value))
				{
					if (this._Airplane.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAirplaneIdChanging(value);
					this.SendPropertyChanging();
					this._AirplaneId = value;
					this.SendPropertyChanged("AirplaneId");
					this.OnAirplaneIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityId", DbType="Int")]
		public System.Nullable<int> CityId
		{
			get
			{
				return this._CityId;
			}
			set
			{
				if ((this._CityId != value))
				{
					if (this._City.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCityIdChanging(value);
					this.SendPropertyChanging();
					this._CityId = value;
					this.SendPropertyChanged("CityId");
					this.OnCityIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Airplane_Ticket", Storage="_Airplane", ThisKey="AirplaneId", OtherKey="Id", IsForeignKey=true)]
		public Airplane Airplane
		{
			get
			{
				return this._Airplane.Entity;
			}
			set
			{
				Airplane previousValue = this._Airplane.Entity;
				if (((previousValue != value) 
							|| (this._Airplane.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Airplane.Entity = null;
						previousValue.Tickets.Remove(this);
					}
					this._Airplane.Entity = value;
					if ((value != null))
					{
						value.Tickets.Add(this);
						this._AirplaneId = value.Id;
					}
					else
					{
						this._AirplaneId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Airplane");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="City_Ticket", Storage="_City", ThisKey="CityId", OtherKey="Id", IsForeignKey=true)]
		public City City
		{
			get
			{
				return this._City.Entity;
			}
			set
			{
				City previousValue = this._City.Entity;
				if (((previousValue != value) 
							|| (this._City.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._City.Entity = null;
						previousValue.Tickets.Remove(this);
					}
					this._City.Entity = value;
					if ((value != null))
					{
						value.Tickets.Add(this);
						this._CityId = value.Id;
					}
					else
					{
						this._CityId = default(Nullable<int>);
					}
					this.SendPropertyChanged("City");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pilot_Ticket", Storage="_Pilot", ThisKey="PilotId", OtherKey="Id", IsForeignKey=true, DeleteRule="CASCADE")]
		public Pilot Pilot
		{
			get
			{
				return this._Pilot.Entity;
			}
			set
			{
				Pilot previousValue = this._Pilot.Entity;
				if (((previousValue != value) 
							|| (this._Pilot.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Pilot.Entity = null;
						previousValue.Tickets.Remove(this);
					}
					this._Pilot.Entity = value;
					if ((value != null))
					{
						value.Tickets.Add(this);
						this._PilotId = value.Id;
					}
					else
					{
						this._PilotId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Pilot");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Schedule_Ticket", Storage="_Schedule", ThisKey="ScheduleId", OtherKey="Id", IsForeignKey=true)]
		public Schedule Schedule
		{
			get
			{
				return this._Schedule.Entity;
			}
			set
			{
				Schedule previousValue = this._Schedule.Entity;
				if (((previousValue != value) 
							|| (this._Schedule.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Schedule.Entity = null;
						previousValue.Tickets.Remove(this);
					}
					this._Schedule.Entity = value;
					if ((value != null))
					{
						value.Tickets.Add(this);
						this._ScheduleId = value.Id;
					}
					else
					{
						this._ScheduleId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Schedule");
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
