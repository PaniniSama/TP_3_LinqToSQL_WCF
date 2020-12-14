﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceEnseignement
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="tp3_webservices")]
	public partial class DataClassesEnseignementDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void InsertEleves(Eleves instance);
    partial void UpdateEleves(Eleves instance);
    partial void DeleteEleves(Eleves instance);
    #endregion
		
		public DataClassesEnseignementDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["tp3_webservicesConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesEnseignementDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesEnseignementDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesEnseignementDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesEnseignementDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Eleves> Eleves
		{
			get
			{
				return this.GetTable<Eleves>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Eleves")]
	public partial class Eleves : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_Eleve;
		
		private string _CNE;
		
		private string _Nom;
		
		private string _Prénom;
		
		private System.Data.Linq.Binary _Photo;
		
		private string _Tel;
		
		private string _Email;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_EleveChanging(int value);
    partial void OnID_EleveChanged();
    partial void OnCNEChanging(string value);
    partial void OnCNEChanged();
    partial void OnNomChanging(string value);
    partial void OnNomChanged();
    partial void OnPrénomChanging(string value);
    partial void OnPrénomChanged();
    partial void OnPhotoChanging(System.Data.Linq.Binary value);
    partial void OnPhotoChanged();
    partial void OnTelChanging(string value);
    partial void OnTelChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public Eleves()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Eleve", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID_Eleve
		{
			get
			{
				return this._ID_Eleve;
			}
			set
			{
				if ((this._ID_Eleve != value))
				{
					this.OnID_EleveChanging(value);
					this.SendPropertyChanging();
					this._ID_Eleve = value;
					this.SendPropertyChanged("ID_Eleve");
					this.OnID_EleveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CNE", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string CNE
		{
			get
			{
				return this._CNE;
			}
			set
			{
				if ((this._CNE != value))
				{
					this.OnCNEChanging(value);
					this.SendPropertyChanging();
					this._CNE = value;
					this.SendPropertyChanged("CNE");
					this.OnCNEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string Nom
		{
			get
			{
				return this._Nom;
			}
			set
			{
				if ((this._Nom != value))
				{
					this.OnNomChanging(value);
					this.SendPropertyChanging();
					this._Nom = value;
					this.SendPropertyChanged("Nom");
					this.OnNomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prénom", DbType="NChar(30) NOT NULL", CanBeNull=false)]
		public string Prénom
		{
			get
			{
				return this._Prénom;
			}
			set
			{
				if ((this._Prénom != value))
				{
					this.OnPrénomChanging(value);
					this.SendPropertyChanging();
					this._Prénom = value;
					this.SendPropertyChanged("Prénom");
					this.OnPrénomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Photo", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Photo
		{
			get
			{
				return this._Photo;
			}
			set
			{
				if ((this._Photo != value))
				{
					this.OnPhotoChanging(value);
					this.SendPropertyChanging();
					this._Photo = value;
					this.SendPropertyChanged("Photo");
					this.OnPhotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tel", DbType="NChar(25) NOT NULL", CanBeNull=false)]
		public string Tel
		{
			get
			{
				return this._Tel;
			}
			set
			{
				if ((this._Tel != value))
				{
					this.OnTelChanging(value);
					this.SendPropertyChanging();
					this._Tel = value;
					this.SendPropertyChanged("Tel");
					this.OnTelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NChar(30) NOT NULL", CanBeNull=false)]
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
