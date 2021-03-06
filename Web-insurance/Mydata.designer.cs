﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_insurance
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="insurance")]
	public partial class MydataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void Insertdata(data instance);
    partial void Updatedata(data instance);
    partial void Deletedata(data instance);
    partial void Insertmanpower(manpower instance);
    partial void Updatemanpower(manpower instance);
    partial void Deletemanpower(manpower instance);
    partial void Insertlogin(login instance);
    partial void Updatelogin(login instance);
    partial void Deletelogin(login instance);
    partial void Insertgus(gus instance);
    partial void Updategus(gus instance);
    partial void Deletegus(gus instance);
    #endregion
		
		public MydataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["insuranceConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MydataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MydataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MydataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MydataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<data> data
		{
			get
			{
				return this.GetTable<data>();
			}
		}
		
		public System.Data.Linq.Table<manpower> manpower
		{
			get
			{
				return this.GetTable<manpower>();
			}
		}
		
		public System.Data.Linq.Table<login> login
		{
			get
			{
				return this.GetTable<login>();
			}
		}
		
		public System.Data.Linq.Table<gus> gus
		{
			get
			{
				return this.GetTable<gus>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.data")]
	public partial class data : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _mouth;
		
		private string _name;
		
		private string _number;
		
		private string _data1;
		
		private string _data2;
		
		private string _data3;
		
		private string _data4;
		
		private int _id;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmouthChanging(string value);
    partial void OnmouthChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnnumberChanging(string value);
    partial void OnnumberChanged();
    partial void Ondata1Changing(string value);
    partial void Ondata1Changed();
    partial void Ondata2Changing(string value);
    partial void Ondata2Changed();
    partial void Ondata3Changing(string value);
    partial void Ondata3Changed();
    partial void Ondata4Changing(string value);
    partial void Ondata4Changed();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    #endregion
		
		public data()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mouth", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string mouth
		{
			get
			{
				return this._mouth;
			}
			set
			{
				if ((this._mouth != value))
				{
					this.OnmouthChanging(value);
					this.SendPropertyChanging();
					this._mouth = value;
					this.SendPropertyChanged("mouth");
					this.OnmouthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_number", DbType="NVarChar(50)")]
		public string number
		{
			get
			{
				return this._number;
			}
			set
			{
				if ((this._number != value))
				{
					this.OnnumberChanging(value);
					this.SendPropertyChanging();
					this._number = value;
					this.SendPropertyChanged("number");
					this.OnnumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data1", DbType="NVarChar(50)")]
		public string data1
		{
			get
			{
				return this._data1;
			}
			set
			{
				if ((this._data1 != value))
				{
					this.Ondata1Changing(value);
					this.SendPropertyChanging();
					this._data1 = value;
					this.SendPropertyChanged("data1");
					this.Ondata1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data2", DbType="NVarChar(50)")]
		public string data2
		{
			get
			{
				return this._data2;
			}
			set
			{
				if ((this._data2 != value))
				{
					this.Ondata2Changing(value);
					this.SendPropertyChanging();
					this._data2 = value;
					this.SendPropertyChanged("data2");
					this.Ondata2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data3", DbType="NVarChar(50)")]
		public string data3
		{
			get
			{
				return this._data3;
			}
			set
			{
				if ((this._data3 != value))
				{
					this.Ondata3Changing(value);
					this.SendPropertyChanging();
					this._data3 = value;
					this.SendPropertyChanged("data3");
					this.Ondata3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data4", DbType="NVarChar(50)")]
		public string data4
		{
			get
			{
				return this._data4;
			}
			set
			{
				if ((this._data4 != value))
				{
					this.Ondata4Changing(value);
					this.SendPropertyChanging();
					this._data4 = value;
					this.SendPropertyChanged("data4");
					this.Ondata4Changed();
				}
			}
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.manpower")]
	public partial class manpower : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _username;
		
		private string _sext;
		
		private string _datet;
		
		private string _phone;
		
		private string _jiguan;
		
		private string _numbernew;
		
		private string _number;
		
		private string _datel;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnsextChanging(string value);
    partial void OnsextChanged();
    partial void OndatetChanging(string value);
    partial void OndatetChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    partial void OnjiguanChanging(string value);
    partial void OnjiguanChanged();
    partial void OnnumbernewChanging(string value);
    partial void OnnumbernewChanged();
    partial void OnnumberChanging(string value);
    partial void OnnumberChanged();
    partial void OndatelChanging(string value);
    partial void OndatelChanged();
    #endregion
		
		public manpower()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sext", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string sext
		{
			get
			{
				return this._sext;
			}
			set
			{
				if ((this._sext != value))
				{
					this.OnsextChanging(value);
					this.SendPropertyChanging();
					this._sext = value;
					this.SendPropertyChanged("sext");
					this.OnsextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datet", DbType="NVarChar(50)")]
		public string datet
		{
			get
			{
				return this._datet;
			}
			set
			{
				if ((this._datet != value))
				{
					this.OndatetChanging(value);
					this.SendPropertyChanging();
					this._datet = value;
					this.SendPropertyChanged("datet");
					this.OndatetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="NVarChar(50)")]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_jiguan", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string jiguan
		{
			get
			{
				return this._jiguan;
			}
			set
			{
				if ((this._jiguan != value))
				{
					this.OnjiguanChanging(value);
					this.SendPropertyChanging();
					this._jiguan = value;
					this.SendPropertyChanged("jiguan");
					this.OnjiguanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numbernew", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string numbernew
		{
			get
			{
				return this._numbernew;
			}
			set
			{
				if ((this._numbernew != value))
				{
					this.OnnumbernewChanging(value);
					this.SendPropertyChanging();
					this._numbernew = value;
					this.SendPropertyChanged("numbernew");
					this.OnnumbernewChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_number", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string number
		{
			get
			{
				return this._number;
			}
			set
			{
				if ((this._number != value))
				{
					this.OnnumberChanging(value);
					this.SendPropertyChanging();
					this._number = value;
					this.SendPropertyChanged("number");
					this.OnnumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datel", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string datel
		{
			get
			{
				return this._datel;
			}
			set
			{
				if ((this._datel != value))
				{
					this.OndatelChanging(value);
					this.SendPropertyChanging();
					this._datel = value;
					this.SendPropertyChanged("datel");
					this.OndatelChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.login")]
	public partial class login : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _username;
		
		private string _password;
		
		private string _number;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnnumberChanging(string value);
    partial void OnnumberChanged();
    #endregion
		
		public login()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_number", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string number
		{
			get
			{
				return this._number;
			}
			set
			{
				if ((this._number != value))
				{
					this.OnnumberChanging(value);
					this.SendPropertyChanging();
					this._number = value;
					this.SendPropertyChanged("number");
					this.OnnumberChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.gus")]
	public partial class gus : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _baodanid;
		
		private string _usernamet;
		
		private string _phonet;
		
		private string _sexb;
		
		private string _usernameb;
		
		private string _money;
		
		private string _number;
		
		private string _datel;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnbaodanidChanging(string value);
    partial void OnbaodanidChanged();
    partial void OnusernametChanging(string value);
    partial void OnusernametChanged();
    partial void OnphonetChanging(string value);
    partial void OnphonetChanged();
    partial void OnsexbChanging(string value);
    partial void OnsexbChanged();
    partial void OnusernamebChanging(string value);
    partial void OnusernamebChanged();
    partial void OnmoneyChanging(string value);
    partial void OnmoneyChanged();
    partial void OnnumberChanging(string value);
    partial void OnnumberChanged();
    partial void OndatelChanging(string value);
    partial void OndatelChanged();
    #endregion
		
		public gus()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_baodanid", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string baodanid
		{
			get
			{
				return this._baodanid;
			}
			set
			{
				if ((this._baodanid != value))
				{
					this.OnbaodanidChanging(value);
					this.SendPropertyChanging();
					this._baodanid = value;
					this.SendPropertyChanged("baodanid");
					this.OnbaodanidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usernamet", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string usernamet
		{
			get
			{
				return this._usernamet;
			}
			set
			{
				if ((this._usernamet != value))
				{
					this.OnusernametChanging(value);
					this.SendPropertyChanging();
					this._usernamet = value;
					this.SendPropertyChanged("usernamet");
					this.OnusernametChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phonet", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string phonet
		{
			get
			{
				return this._phonet;
			}
			set
			{
				if ((this._phonet != value))
				{
					this.OnphonetChanging(value);
					this.SendPropertyChanging();
					this._phonet = value;
					this.SendPropertyChanged("phonet");
					this.OnphonetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sexb", DbType="NVarChar(50)")]
		public string sexb
		{
			get
			{
				return this._sexb;
			}
			set
			{
				if ((this._sexb != value))
				{
					this.OnsexbChanging(value);
					this.SendPropertyChanging();
					this._sexb = value;
					this.SendPropertyChanged("sexb");
					this.OnsexbChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usernameb", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string usernameb
		{
			get
			{
				return this._usernameb;
			}
			set
			{
				if ((this._usernameb != value))
				{
					this.OnusernamebChanging(value);
					this.SendPropertyChanging();
					this._usernameb = value;
					this.SendPropertyChanged("usernameb");
					this.OnusernamebChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_money", DbType="NVarChar(50)")]
		public string money
		{
			get
			{
				return this._money;
			}
			set
			{
				if ((this._money != value))
				{
					this.OnmoneyChanging(value);
					this.SendPropertyChanging();
					this._money = value;
					this.SendPropertyChanged("money");
					this.OnmoneyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_number", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string number
		{
			get
			{
				return this._number;
			}
			set
			{
				if ((this._number != value))
				{
					this.OnnumberChanging(value);
					this.SendPropertyChanging();
					this._number = value;
					this.SendPropertyChanged("number");
					this.OnnumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datel", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string datel
		{
			get
			{
				return this._datel;
			}
			set
			{
				if ((this._datel != value))
				{
					this.OndatelChanging(value);
					this.SendPropertyChanging();
					this._datel = value;
					this.SendPropertyChanged("datel");
					this.OndatelChanged();
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
