﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace D3SharpDatabase
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DBEntities object using the connection string found in the 'DBEntities' section of the application configuration file.
        /// </summary>
        public DBEntities() : base("name=DBEntities", "DBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DBEntities object.
        /// </summary>
        public DBEntities(string connectionString) : base(connectionString, "DBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DBEntities object.
        /// </summary>
        public DBEntities(EntityConnection connection) : base(connection, "DBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<D3AccountBannerConfiguration> D3AccountBannerConfiguration
        {
            get
            {
                if ((_D3AccountBannerConfiguration == null))
                {
                    _D3AccountBannerConfiguration = base.CreateObjectSet<D3AccountBannerConfiguration>("D3AccountBannerConfiguration");
                }
                return _D3AccountBannerConfiguration;
            }
        }
        private ObjectSet<D3AccountBannerConfiguration> _D3AccountBannerConfiguration;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<D3AccountDigest> D3AccountDigest
        {
            get
            {
                if ((_D3AccountDigest == null))
                {
                    _D3AccountDigest = base.CreateObjectSet<D3AccountDigest>("D3AccountDigest");
                }
                return _D3AccountDigest;
            }
        }
        private ObjectSet<D3AccountDigest> _D3AccountDigest;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<D3AccountSavedDefinition> D3AccountSavedDefinition
        {
            get
            {
                if ((_D3AccountSavedDefinition == null))
                {
                    _D3AccountSavedDefinition = base.CreateObjectSet<D3AccountSavedDefinition>("D3AccountSavedDefinition");
                }
                return _D3AccountSavedDefinition;
            }
        }
        private ObjectSet<D3AccountSavedDefinition> _D3AccountSavedDefinition;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<D3AccountSavedDefinition_seen_tutorials> D3AccountSavedDefinition_seen_tutorials
        {
            get
            {
                if ((_D3AccountSavedDefinition_seen_tutorials == null))
                {
                    _D3AccountSavedDefinition_seen_tutorials = base.CreateObjectSet<D3AccountSavedDefinition_seen_tutorials>("D3AccountSavedDefinition_seen_tutorials");
                }
                return _D3AccountSavedDefinition_seen_tutorials;
            }
        }
        private ObjectSet<D3AccountSavedDefinition_seen_tutorials> _D3AccountSavedDefinition_seen_tutorials;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the D3AccountBannerConfiguration EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToD3AccountBannerConfiguration(D3AccountBannerConfiguration d3AccountBannerConfiguration)
        {
            base.AddObject("D3AccountBannerConfiguration", d3AccountBannerConfiguration);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the D3AccountDigest EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToD3AccountDigest(D3AccountDigest d3AccountDigest)
        {
            base.AddObject("D3AccountDigest", d3AccountDigest);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the D3AccountSavedDefinition EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToD3AccountSavedDefinition(D3AccountSavedDefinition d3AccountSavedDefinition)
        {
            base.AddObject("D3AccountSavedDefinition", d3AccountSavedDefinition);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the D3AccountSavedDefinition_seen_tutorials EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToD3AccountSavedDefinition_seen_tutorials(D3AccountSavedDefinition_seen_tutorials d3AccountSavedDefinition_seen_tutorials)
        {
            base.AddObject("D3AccountSavedDefinition_seen_tutorials", d3AccountSavedDefinition_seen_tutorials);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DBModel", Name="D3AccountBannerConfiguration")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class D3AccountBannerConfiguration : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new D3AccountBannerConfiguration object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="banner_index">Initial value of the banner_index property.</param>
        /// <param name="sigil_main">Initial value of the sigil_main property.</param>
        /// <param name="sigil_accent">Initial value of the sigil_accent property.</param>
        /// <param name="pattern_color_index">Initial value of the pattern_color_index property.</param>
        /// <param name="background_color_index">Initial value of the background_color_index property.</param>
        /// <param name="sigil_color_index">Initial value of the sigil_color_index property.</param>
        /// <param name="placement_index">Initial value of the placement_index property.</param>
        /// <param name="pattern">Initial value of the pattern property.</param>
        /// <param name="use_sigil_variant">Initial value of the use_sigil_variant property.</param>
        /// <param name="account_digest_id">Initial value of the account_digest_id property.</param>
        public static D3AccountBannerConfiguration CreateD3AccountBannerConfiguration(global::System.Guid id, global::System.Int32 banner_index, global::System.Int32 sigil_main, global::System.Int32 sigil_accent, global::System.Int32 pattern_color_index, global::System.Int32 background_color_index, global::System.Int32 sigil_color_index, global::System.Int32 placement_index, global::System.Int32 pattern, global::System.Int32 use_sigil_variant, global::System.Guid account_digest_id)
        {
            D3AccountBannerConfiguration d3AccountBannerConfiguration = new D3AccountBannerConfiguration();
            d3AccountBannerConfiguration.id = id;
            d3AccountBannerConfiguration.banner_index = banner_index;
            d3AccountBannerConfiguration.sigil_main = sigil_main;
            d3AccountBannerConfiguration.sigil_accent = sigil_accent;
            d3AccountBannerConfiguration.pattern_color_index = pattern_color_index;
            d3AccountBannerConfiguration.background_color_index = background_color_index;
            d3AccountBannerConfiguration.sigil_color_index = sigil_color_index;
            d3AccountBannerConfiguration.placement_index = placement_index;
            d3AccountBannerConfiguration.pattern = pattern;
            d3AccountBannerConfiguration.use_sigil_variant = use_sigil_variant;
            d3AccountBannerConfiguration.account_digest_id = account_digest_id;
            return d3AccountBannerConfiguration;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Guid _id;
        partial void OnidChanging(global::System.Guid value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 banner_index
        {
            get
            {
                return _banner_index;
            }
            set
            {
                Onbanner_indexChanging(value);
                ReportPropertyChanging("banner_index");
                _banner_index = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("banner_index");
                Onbanner_indexChanged();
            }
        }
        private global::System.Int32 _banner_index;
        partial void Onbanner_indexChanging(global::System.Int32 value);
        partial void Onbanner_indexChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 sigil_main
        {
            get
            {
                return _sigil_main;
            }
            set
            {
                Onsigil_mainChanging(value);
                ReportPropertyChanging("sigil_main");
                _sigil_main = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("sigil_main");
                Onsigil_mainChanged();
            }
        }
        private global::System.Int32 _sigil_main;
        partial void Onsigil_mainChanging(global::System.Int32 value);
        partial void Onsigil_mainChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 sigil_accent
        {
            get
            {
                return _sigil_accent;
            }
            set
            {
                Onsigil_accentChanging(value);
                ReportPropertyChanging("sigil_accent");
                _sigil_accent = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("sigil_accent");
                Onsigil_accentChanged();
            }
        }
        private global::System.Int32 _sigil_accent;
        partial void Onsigil_accentChanging(global::System.Int32 value);
        partial void Onsigil_accentChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 pattern_color_index
        {
            get
            {
                return _pattern_color_index;
            }
            set
            {
                Onpattern_color_indexChanging(value);
                ReportPropertyChanging("pattern_color_index");
                _pattern_color_index = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("pattern_color_index");
                Onpattern_color_indexChanged();
            }
        }
        private global::System.Int32 _pattern_color_index;
        partial void Onpattern_color_indexChanging(global::System.Int32 value);
        partial void Onpattern_color_indexChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 background_color_index
        {
            get
            {
                return _background_color_index;
            }
            set
            {
                Onbackground_color_indexChanging(value);
                ReportPropertyChanging("background_color_index");
                _background_color_index = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("background_color_index");
                Onbackground_color_indexChanged();
            }
        }
        private global::System.Int32 _background_color_index;
        partial void Onbackground_color_indexChanging(global::System.Int32 value);
        partial void Onbackground_color_indexChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 sigil_color_index
        {
            get
            {
                return _sigil_color_index;
            }
            set
            {
                Onsigil_color_indexChanging(value);
                ReportPropertyChanging("sigil_color_index");
                _sigil_color_index = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("sigil_color_index");
                Onsigil_color_indexChanged();
            }
        }
        private global::System.Int32 _sigil_color_index;
        partial void Onsigil_color_indexChanging(global::System.Int32 value);
        partial void Onsigil_color_indexChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 placement_index
        {
            get
            {
                return _placement_index;
            }
            set
            {
                Onplacement_indexChanging(value);
                ReportPropertyChanging("placement_index");
                _placement_index = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("placement_index");
                Onplacement_indexChanged();
            }
        }
        private global::System.Int32 _placement_index;
        partial void Onplacement_indexChanging(global::System.Int32 value);
        partial void Onplacement_indexChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 pattern
        {
            get
            {
                return _pattern;
            }
            set
            {
                OnpatternChanging(value);
                ReportPropertyChanging("pattern");
                _pattern = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("pattern");
                OnpatternChanged();
            }
        }
        private global::System.Int32 _pattern;
        partial void OnpatternChanging(global::System.Int32 value);
        partial void OnpatternChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 use_sigil_variant
        {
            get
            {
                return _use_sigil_variant;
            }
            set
            {
                Onuse_sigil_variantChanging(value);
                ReportPropertyChanging("use_sigil_variant");
                _use_sigil_variant = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("use_sigil_variant");
                Onuse_sigil_variantChanged();
            }
        }
        private global::System.Int32 _use_sigil_variant;
        partial void Onuse_sigil_variantChanging(global::System.Int32 value);
        partial void Onuse_sigil_variantChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid account_digest_id
        {
            get
            {
                return _account_digest_id;
            }
            set
            {
                Onaccount_digest_idChanging(value);
                ReportPropertyChanging("account_digest_id");
                _account_digest_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("account_digest_id");
                Onaccount_digest_idChanged();
            }
        }
        private global::System.Guid _account_digest_id;
        partial void Onaccount_digest_idChanging(global::System.Guid value);
        partial void Onaccount_digest_idChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DBModel", Name="D3AccountDigest")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class D3AccountDigest : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new D3AccountDigest object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="last_played_hero_id">Initial value of the last_played_hero_id property.</param>
        /// <param name="accountid">Initial value of the accountid property.</param>
        public static D3AccountDigest CreateD3AccountDigest(global::System.Guid id, global::System.Guid last_played_hero_id, global::System.Guid accountid)
        {
            D3AccountDigest d3AccountDigest = new D3AccountDigest();
            d3AccountDigest.id = id;
            d3AccountDigest.last_played_hero_id = last_played_hero_id;
            d3AccountDigest.accountid = accountid;
            return d3AccountDigest;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Guid _id;
        partial void OnidChanging(global::System.Guid value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> version
        {
            get
            {
                return _version;
            }
            set
            {
                OnversionChanging(value);
                ReportPropertyChanging("version");
                _version = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("version");
                OnversionChanged();
            }
        }
        private Nullable<global::System.Int32> _version;
        partial void OnversionChanging(Nullable<global::System.Int32> value);
        partial void OnversionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid last_played_hero_id
        {
            get
            {
                return _last_played_hero_id;
            }
            set
            {
                Onlast_played_hero_idChanging(value);
                ReportPropertyChanging("last_played_hero_id");
                _last_played_hero_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("last_played_hero_id");
                Onlast_played_hero_idChanged();
            }
        }
        private global::System.Guid _last_played_hero_id;
        partial void Onlast_played_hero_idChanging(global::System.Guid value);
        partial void Onlast_played_hero_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> flags
        {
            get
            {
                return _flags;
            }
            set
            {
                OnflagsChanging(value);
                ReportPropertyChanging("flags");
                _flags = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("flags");
                OnflagsChanged();
            }
        }
        private Nullable<global::System.Int32> _flags;
        partial void OnflagsChanging(Nullable<global::System.Int32> value);
        partial void OnflagsChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid accountid
        {
            get
            {
                return _accountid;
            }
            set
            {
                OnaccountidChanging(value);
                ReportPropertyChanging("accountid");
                _accountid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("accountid");
                OnaccountidChanged();
            }
        }
        private global::System.Guid _accountid;
        partial void OnaccountidChanging(global::System.Guid value);
        partial void OnaccountidChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DBModel", Name="D3AccountSavedDefinition")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class D3AccountSavedDefinition : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new D3AccountSavedDefinition object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="email">Initial value of the email property.</param>
        /// <param name="password">Initial value of the password property.</param>
        public static D3AccountSavedDefinition CreateD3AccountSavedDefinition(global::System.Guid id, global::System.String email, global::System.String password)
        {
            D3AccountSavedDefinition d3AccountSavedDefinition = new D3AccountSavedDefinition();
            d3AccountSavedDefinition.id = id;
            d3AccountSavedDefinition.email = email;
            d3AccountSavedDefinition.password = password;
            return d3AccountSavedDefinition;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Guid _id;
        partial void OnidChanging(global::System.Guid value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> version
        {
            get
            {
                return _version;
            }
            set
            {
                OnversionChanging(value);
                ReportPropertyChanging("version");
                _version = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("version");
                OnversionChanged();
            }
        }
        private Nullable<global::System.Int32> _version;
        partial void OnversionChanging(Nullable<global::System.Int32> value);
        partial void OnversionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String email
        {
            get
            {
                return _email;
            }
            set
            {
                OnemailChanging(value);
                ReportPropertyChanging("email");
                _email = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("email");
                OnemailChanged();
            }
        }
        private global::System.String _email;
        partial void OnemailChanging(global::System.String value);
        partial void OnemailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String password
        {
            get
            {
                return _password;
            }
            set
            {
                OnpasswordChanging(value);
                ReportPropertyChanging("password");
                _password = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("password");
                OnpasswordChanged();
            }
        }
        private global::System.String _password;
        partial void OnpasswordChanging(global::System.String value);
        partial void OnpasswordChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DBModel", Name="D3AccountSavedDefinition_seen_tutorials")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class D3AccountSavedDefinition_seen_tutorials : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new D3AccountSavedDefinition_seen_tutorials object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="accountid">Initial value of the accountid property.</param>
        /// <param name="tutorialnumber">Initial value of the tutorialnumber property.</param>
        public static D3AccountSavedDefinition_seen_tutorials CreateD3AccountSavedDefinition_seen_tutorials(global::System.Guid id, global::System.Guid accountid, global::System.Int32 tutorialnumber)
        {
            D3AccountSavedDefinition_seen_tutorials d3AccountSavedDefinition_seen_tutorials = new D3AccountSavedDefinition_seen_tutorials();
            d3AccountSavedDefinition_seen_tutorials.id = id;
            d3AccountSavedDefinition_seen_tutorials.accountid = accountid;
            d3AccountSavedDefinition_seen_tutorials.tutorialnumber = tutorialnumber;
            return d3AccountSavedDefinition_seen_tutorials;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Guid _id;
        partial void OnidChanging(global::System.Guid value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid accountid
        {
            get
            {
                return _accountid;
            }
            set
            {
                OnaccountidChanging(value);
                ReportPropertyChanging("accountid");
                _accountid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("accountid");
                OnaccountidChanged();
            }
        }
        private global::System.Guid _accountid;
        partial void OnaccountidChanging(global::System.Guid value);
        partial void OnaccountidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 tutorialnumber
        {
            get
            {
                return _tutorialnumber;
            }
            set
            {
                OntutorialnumberChanging(value);
                ReportPropertyChanging("tutorialnumber");
                _tutorialnumber = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("tutorialnumber");
                OntutorialnumberChanged();
            }
        }
        private global::System.Int32 _tutorialnumber;
        partial void OntutorialnumberChanging(global::System.Int32 value);
        partial void OntutorialnumberChanged();

        #endregion
    
    }

    #endregion
    
}
