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
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("PolitiqModel", "MemberParty", "Member", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Politiq.Models.DB.Member), "Party", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Politiq.Models.DB.Party))]

#endregion

namespace Politiq.Models.DB
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class PolitiqEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new PolitiqEntities object using the connection string found in the 'PolitiqEntities' section of the application configuration file.
        /// </summary>
        public PolitiqEntities() : base("name=PolitiqEntities", "PolitiqEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PolitiqEntities object.
        /// </summary>
        public PolitiqEntities(string connectionString) : base(connectionString, "PolitiqEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PolitiqEntities object.
        /// </summary>
        public PolitiqEntities(EntityConnection connection) : base(connection, "PolitiqEntities")
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
        public ObjectSet<Member> Members
        {
            get
            {
                if ((_Members == null))
                {
                    _Members = base.CreateObjectSet<Member>("Members");
                }
                return _Members;
            }
        }
        private ObjectSet<Member> _Members;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Party> Parties
        {
            get
            {
                if ((_Parties == null))
                {
                    _Parties = base.CreateObjectSet<Party>("Parties");
                }
                return _Parties;
            }
        }
        private ObjectSet<Party> _Parties;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Members EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMembers(Member member)
        {
            base.AddObject("Members", member);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Parties EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToParties(Party party)
        {
            base.AddObject("Parties", party);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PolitiqModel", Name="Member")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Member : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Member object.
        /// </summary>
        /// <param name="memberID">Initial value of the MemberID property.</param>
        /// <param name="loginID">Initial value of the LoginID property.</param>
        /// <param name="password">Initial value of the Password property.</param>
        /// <param name="email">Initial value of the Email property.</param>
        public static Member CreateMember(global::System.Int32 memberID, global::System.String loginID, global::System.String password, global::System.String email)
        {
            Member member = new Member();
            member.MemberID = memberID;
            member.LoginID = loginID;
            member.Password = password;
            member.Email = email;
            return member;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 MemberID
        {
            get
            {
                return _MemberID;
            }
            set
            {
                if (_MemberID != value)
                {
                    OnMemberIDChanging(value);
                    ReportPropertyChanging("MemberID");
                    _MemberID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("MemberID");
                    OnMemberIDChanged();
                }
            }
        }
        private global::System.Int32 _MemberID;
        partial void OnMemberIDChanging(global::System.Int32 value);
        partial void OnMemberIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LoginID
        {
            get
            {
                return _LoginID;
            }
            set
            {
                OnLoginIDChanging(value);
                ReportPropertyChanging("LoginID");
                _LoginID = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LoginID");
                OnLoginIDChanged();
            }
        }
        private global::System.String _LoginID;
        partial void OnLoginIDChanging(global::System.String value);
        partial void OnLoginIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Password
        {
            get
            {
                return _Password;
            }
            set
            {
                OnPasswordChanging(value);
                ReportPropertyChanging("Password");
                _Password = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Password");
                OnPasswordChanged();
            }
        }
        private global::System.String _Password;
        partial void OnPasswordChanging(global::System.String value);
        partial void OnPasswordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PolitiqModel", "MemberParty", "Party")]
        public Party Party
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Party>("PolitiqModel.MemberParty", "Party").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Party>("PolitiqModel.MemberParty", "Party").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Party> PartyReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Party>("PolitiqModel.MemberParty", "Party");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Party>("PolitiqModel.MemberParty", "Party", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PolitiqModel", Name="Party")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Party : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Party object.
        /// </summary>
        /// <param name="partyID">Initial value of the PartyID property.</param>
        /// <param name="partyName">Initial value of the PartyName property.</param>
        /// <param name="partyLongName">Initial value of the PartyLongName property.</param>
        /// <param name="seats">Initial value of the Seats property.</param>
        /// <param name="side">Initial value of the Side property.</param>
        public static Party CreateParty(global::System.Int32 partyID, global::System.String partyName, global::System.String partyLongName, global::System.Int32 seats, global::System.Int32 side)
        {
            Party party = new Party();
            party.PartyID = partyID;
            party.PartyName = partyName;
            party.PartyLongName = partyLongName;
            party.Seats = seats;
            party.Side = side;
            return party;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PartyID
        {
            get
            {
                return _PartyID;
            }
            set
            {
                if (_PartyID != value)
                {
                    OnPartyIDChanging(value);
                    ReportPropertyChanging("PartyID");
                    _PartyID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("PartyID");
                    OnPartyIDChanged();
                }
            }
        }
        private global::System.Int32 _PartyID;
        partial void OnPartyIDChanging(global::System.Int32 value);
        partial void OnPartyIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PartyName
        {
            get
            {
                return _PartyName;
            }
            set
            {
                OnPartyNameChanging(value);
                ReportPropertyChanging("PartyName");
                _PartyName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PartyName");
                OnPartyNameChanged();
            }
        }
        private global::System.String _PartyName;
        partial void OnPartyNameChanging(global::System.String value);
        partial void OnPartyNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PartyLongName
        {
            get
            {
                return _PartyLongName;
            }
            set
            {
                OnPartyLongNameChanging(value);
                ReportPropertyChanging("PartyLongName");
                _PartyLongName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PartyLongName");
                OnPartyLongNameChanged();
            }
        }
        private global::System.String _PartyLongName;
        partial void OnPartyLongNameChanging(global::System.String value);
        partial void OnPartyLongNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Seats
        {
            get
            {
                return _Seats;
            }
            set
            {
                OnSeatsChanging(value);
                ReportPropertyChanging("Seats");
                _Seats = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Seats");
                OnSeatsChanged();
            }
        }
        private global::System.Int32 _Seats;
        partial void OnSeatsChanging(global::System.Int32 value);
        partial void OnSeatsChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Side
        {
            get
            {
                return _Side;
            }
            set
            {
                OnSideChanging(value);
                ReportPropertyChanging("Side");
                _Side = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Side");
                OnSideChanged();
            }
        }
        private global::System.Int32 _Side;
        partial void OnSideChanging(global::System.Int32 value);
        partial void OnSideChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PolitiqModel", "MemberParty", "Member")]
        public EntityCollection<Member> Members
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Member>("PolitiqModel.MemberParty", "Member");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Member>("PolitiqModel.MemberParty", "Member", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}