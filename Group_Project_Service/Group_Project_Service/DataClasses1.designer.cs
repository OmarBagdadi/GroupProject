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

namespace Group_Project_Service
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SalonDB")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertCart(Cart instance);
    partial void UpdateCart(Cart instance);
    partial void DeleteCart(Cart instance);
    partial void InsertInvoice(Invoice instance);
    partial void UpdateInvoice(Invoice instance);
    partial void DeleteInvoice(Invoice instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertProductReport(ProductReport instance);
    partial void UpdateProductReport(ProductReport instance);
    partial void DeleteProductReport(ProductReport instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SalonDBConnectionString"].ConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Cart> Carts
		{
			get
			{
				return this.GetTable<Cart>();
			}
		}
		
		public System.Data.Linq.Table<Invoice> Invoices
		{
			get
			{
				return this.GetTable<Invoice>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<ProductReport> ProductReports
		{
			get
			{
				return this.GetTable<ProductReport>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Surname;
		
		private string _Email;
		
		private string _Password;
		
		private string _Usertype;
		
		private string _PhoneNo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnUsertypeChanging(string value);
    partial void OnUsertypeChanged();
    partial void OnPhoneNoChanging(string value);
    partial void OnPhoneNoChanged();
    #endregion
		
		public User()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Usertype", DbType="Char(2) NOT NULL", CanBeNull=false)]
		public string Usertype
		{
			get
			{
				return this._Usertype;
			}
			set
			{
				if ((this._Usertype != value))
				{
					this.OnUsertypeChanging(value);
					this.SendPropertyChanging();
					this._Usertype = value;
					this.SendPropertyChanged("Usertype");
					this.OnUsertypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNo", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string PhoneNo
		{
			get
			{
				return this._PhoneNo;
			}
			set
			{
				if ((this._PhoneNo != value))
				{
					this.OnPhoneNoChanging(value);
					this.SendPropertyChanging();
					this._PhoneNo = value;
					this.SendPropertyChanged("PhoneNo");
					this.OnPhoneNoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cart")]
	public partial class Cart : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _userID;
		
		private int _productID;
		
		private int _Quantity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnuserIDChanging(int value);
    partial void OnuserIDChanged();
    partial void OnproductIDChanging(int value);
    partial void OnproductIDChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    #endregion
		
		public Cart()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", DbType="Int NOT NULL")]
		public int userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productID", DbType="Int NOT NULL")]
		public int productID
		{
			get
			{
				return this._productID;
			}
			set
			{
				if ((this._productID != value))
				{
					this.OnproductIDChanging(value);
					this.SendPropertyChanging();
					this._productID = value;
					this.SendPropertyChanged("productID");
					this.OnproductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Invoice")]
	public partial class Invoice : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _userID;
		
		private string _Products;
		
		private decimal _Subtotal;
		
		private decimal _VAT;
		
		private decimal _Discount;
		
		private decimal _ShippingFee;
		
		private decimal _GrandTotal;
		
		private System.Nullable<int> _isPaid;
		
		private System.Nullable<System.DateTime> _Date;
		
		private string _Address;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnuserIDChanging(int value);
    partial void OnuserIDChanged();
    partial void OnProductsChanging(string value);
    partial void OnProductsChanged();
    partial void OnSubtotalChanging(decimal value);
    partial void OnSubtotalChanged();
    partial void OnVATChanging(decimal value);
    partial void OnVATChanged();
    partial void OnDiscountChanging(decimal value);
    partial void OnDiscountChanged();
    partial void OnShippingFeeChanging(decimal value);
    partial void OnShippingFeeChanged();
    partial void OnGrandTotalChanging(decimal value);
    partial void OnGrandTotalChanged();
    partial void OnisPaidChanging(System.Nullable<int> value);
    partial void OnisPaidChanged();
    partial void OnDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDateChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    #endregion
		
		public Invoice()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", DbType="Int NOT NULL")]
		public int userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Products", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Products
		{
			get
			{
				return this._Products;
			}
			set
			{
				if ((this._Products != value))
				{
					this.OnProductsChanging(value);
					this.SendPropertyChanging();
					this._Products = value;
					this.SendPropertyChanged("Products");
					this.OnProductsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Subtotal", DbType="Money NOT NULL")]
		public decimal Subtotal
		{
			get
			{
				return this._Subtotal;
			}
			set
			{
				if ((this._Subtotal != value))
				{
					this.OnSubtotalChanging(value);
					this.SendPropertyChanging();
					this._Subtotal = value;
					this.SendPropertyChanged("Subtotal");
					this.OnSubtotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VAT", DbType="Money NOT NULL")]
		public decimal VAT
		{
			get
			{
				return this._VAT;
			}
			set
			{
				if ((this._VAT != value))
				{
					this.OnVATChanging(value);
					this.SendPropertyChanging();
					this._VAT = value;
					this.SendPropertyChanged("VAT");
					this.OnVATChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Discount", DbType="Money NOT NULL")]
		public decimal Discount
		{
			get
			{
				return this._Discount;
			}
			set
			{
				if ((this._Discount != value))
				{
					this.OnDiscountChanging(value);
					this.SendPropertyChanging();
					this._Discount = value;
					this.SendPropertyChanged("Discount");
					this.OnDiscountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShippingFee", DbType="Money NOT NULL")]
		public decimal ShippingFee
		{
			get
			{
				return this._ShippingFee;
			}
			set
			{
				if ((this._ShippingFee != value))
				{
					this.OnShippingFeeChanging(value);
					this.SendPropertyChanging();
					this._ShippingFee = value;
					this.SendPropertyChanged("ShippingFee");
					this.OnShippingFeeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GrandTotal", DbType="Money NOT NULL")]
		public decimal GrandTotal
		{
			get
			{
				return this._GrandTotal;
			}
			set
			{
				if ((this._GrandTotal != value))
				{
					this.OnGrandTotalChanging(value);
					this.SendPropertyChanging();
					this._GrandTotal = value;
					this.SendPropertyChanged("GrandTotal");
					this.OnGrandTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isPaid", DbType="Int")]
		public System.Nullable<int> isPaid
		{
			get
			{
				return this._isPaid;
			}
			set
			{
				if ((this._isPaid != value))
				{
					this.OnisPaidChanging(value);
					this.SendPropertyChanging();
					this._isPaid = value;
					this.SendPropertyChanged("isPaid");
					this.OnisPaidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Date
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(MAX)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Description;
		
		private decimal _Price;
		
		private string _ImageLocation;
		
		private int _Quantity;
		
		private string _Category;
		
		private System.Nullable<int> _LatestProduct;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnImageLocationChanging(string value);
    partial void OnImageLocationChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    partial void OnCategoryChanging(string value);
    partial void OnCategoryChanged();
    partial void OnLatestProductChanging(System.Nullable<int> value);
    partial void OnLatestProductChanged();
    #endregion
		
		public Product()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageLocation", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string ImageLocation
		{
			get
			{
				return this._ImageLocation;
			}
			set
			{
				if ((this._ImageLocation != value))
				{
					this.OnImageLocationChanging(value);
					this.SendPropertyChanging();
					this._ImageLocation = value;
					this.SendPropertyChanged("ImageLocation");
					this.OnImageLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LatestProduct", DbType="Int")]
		public System.Nullable<int> LatestProduct
		{
			get
			{
				return this._LatestProduct;
			}
			set
			{
				if ((this._LatestProduct != value))
				{
					this.OnLatestProductChanging(value);
					this.SendPropertyChanging();
					this._LatestProduct = value;
					this.SendPropertyChanged("LatestProduct");
					this.OnLatestProductChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ProductReport")]
	public partial class ProductReport : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _totalHA;
		
		private System.Nullable<int> _totalHP;
		
		private System.Nullable<int> _totalHAP;
		
		private System.Nullable<int> _totalHASold;
		
		private System.Nullable<int> _totalHPSold;
		
		private System.Nullable<int> _totalHAPSold;
		
		private System.Nullable<int> _TotalProdsSold;
		
		private System.Nullable<int> _TotalProdsAvaliable;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OntotalHAChanging(System.Nullable<int> value);
    partial void OntotalHAChanged();
    partial void OntotalHPChanging(System.Nullable<int> value);
    partial void OntotalHPChanged();
    partial void OntotalHAPChanging(System.Nullable<int> value);
    partial void OntotalHAPChanged();
    partial void OntotalHASoldChanging(System.Nullable<int> value);
    partial void OntotalHASoldChanged();
    partial void OntotalHPSoldChanging(System.Nullable<int> value);
    partial void OntotalHPSoldChanged();
    partial void OntotalHAPSoldChanging(System.Nullable<int> value);
    partial void OntotalHAPSoldChanged();
    partial void OnTotalProdsSoldChanging(System.Nullable<int> value);
    partial void OnTotalProdsSoldChanged();
    partial void OnTotalProdsAvaliableChanging(System.Nullable<int> value);
    partial void OnTotalProdsAvaliableChanged();
    #endregion
		
		public ProductReport()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_totalHA", DbType="Int")]
		public System.Nullable<int> totalHA
		{
			get
			{
				return this._totalHA;
			}
			set
			{
				if ((this._totalHA != value))
				{
					this.OntotalHAChanging(value);
					this.SendPropertyChanging();
					this._totalHA = value;
					this.SendPropertyChanged("totalHA");
					this.OntotalHAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_totalHP", DbType="Int")]
		public System.Nullable<int> totalHP
		{
			get
			{
				return this._totalHP;
			}
			set
			{
				if ((this._totalHP != value))
				{
					this.OntotalHPChanging(value);
					this.SendPropertyChanging();
					this._totalHP = value;
					this.SendPropertyChanged("totalHP");
					this.OntotalHPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_totalHAP", DbType="Int")]
		public System.Nullable<int> totalHAP
		{
			get
			{
				return this._totalHAP;
			}
			set
			{
				if ((this._totalHAP != value))
				{
					this.OntotalHAPChanging(value);
					this.SendPropertyChanging();
					this._totalHAP = value;
					this.SendPropertyChanged("totalHAP");
					this.OntotalHAPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_totalHASold", DbType="Int")]
		public System.Nullable<int> totalHASold
		{
			get
			{
				return this._totalHASold;
			}
			set
			{
				if ((this._totalHASold != value))
				{
					this.OntotalHASoldChanging(value);
					this.SendPropertyChanging();
					this._totalHASold = value;
					this.SendPropertyChanged("totalHASold");
					this.OntotalHASoldChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_totalHPSold", DbType="Int")]
		public System.Nullable<int> totalHPSold
		{
			get
			{
				return this._totalHPSold;
			}
			set
			{
				if ((this._totalHPSold != value))
				{
					this.OntotalHPSoldChanging(value);
					this.SendPropertyChanging();
					this._totalHPSold = value;
					this.SendPropertyChanged("totalHPSold");
					this.OntotalHPSoldChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_totalHAPSold", DbType="Int")]
		public System.Nullable<int> totalHAPSold
		{
			get
			{
				return this._totalHAPSold;
			}
			set
			{
				if ((this._totalHAPSold != value))
				{
					this.OntotalHAPSoldChanging(value);
					this.SendPropertyChanging();
					this._totalHAPSold = value;
					this.SendPropertyChanged("totalHAPSold");
					this.OntotalHAPSoldChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalProdsSold", DbType="Int")]
		public System.Nullable<int> TotalProdsSold
		{
			get
			{
				return this._TotalProdsSold;
			}
			set
			{
				if ((this._TotalProdsSold != value))
				{
					this.OnTotalProdsSoldChanging(value);
					this.SendPropertyChanging();
					this._TotalProdsSold = value;
					this.SendPropertyChanged("TotalProdsSold");
					this.OnTotalProdsSoldChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalProdsAvaliable", DbType="Int")]
		public System.Nullable<int> TotalProdsAvaliable
		{
			get
			{
				return this._TotalProdsAvaliable;
			}
			set
			{
				if ((this._TotalProdsAvaliable != value))
				{
					this.OnTotalProdsAvaliableChanging(value);
					this.SendPropertyChanging();
					this._TotalProdsAvaliable = value;
					this.SendPropertyChanged("TotalProdsAvaliable");
					this.OnTotalProdsAvaliableChanged();
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
