﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    public sealed partial class ClientUserMap : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the ClientUserMap entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public ClientUserMap()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public ClientUserMap(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.ClientUserMap> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.ClientUserMap.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ClientUserMap_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ClientUserMap_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int Id
        {
            get
            {
                return global::LightSwitchApplication.ClientUserMap.DetailsClass.GetValue(this, global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties.Id);
            }
            set
            {
                global::LightSwitchApplication.ClientUserMap.DetailsClass.SetValue(this, global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties.Id, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public byte[] RowVersion
        {
            get
            {
                return global::LightSwitchApplication.ClientUserMap.DetailsClass.GetValue(this, global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties.RowVersion);
            }
            set
            {
                global::LightSwitchApplication.ClientUserMap.DetailsClass.SetValue(this, global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties.RowVersion, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.User User
        {
            get
            {
                return global::LightSwitchApplication.ClientUserMap.DetailsClass.GetValue(this, global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties.User);
            }
            set
            {
                global::LightSwitchApplication.ClientUserMap.DetailsClass.SetValue(this, global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties.User, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void User_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void User_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void User_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.Client Client
        {
            get
            {
                return global::LightSwitchApplication.ClientUserMap.DetailsClass.GetValue(this, global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties.Client);
            }
            set
            {
                global::LightSwitchApplication.ClientUserMap.DetailsClass.SetValue(this, global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties.Client, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Client_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Client_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Client_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.ClientUserMap,
                global::LightSwitchApplication.ClientUserMap.DetailsClass,
                global::LightSwitchApplication.ClientUserMap.DetailsClass.IImplementation,
                global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties.Id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass>.Entry
                __ClientUserMapEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass>.Entry(
                    global::LightSwitchApplication.ClientUserMap.DetailsClass.__ClientUserMap_CreateNew,
                    global::LightSwitchApplication.ClientUserMap.DetailsClass.__ClientUserMap_Created,
                    global::LightSwitchApplication.ClientUserMap.DetailsClass.__ClientUserMap_AllowSaveWithErrors);
            private static global::LightSwitchApplication.ClientUserMap __ClientUserMap_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.ClientUserMap> es)
            {
                return new global::LightSwitchApplication.ClientUserMap(es);
            }
            private static void __ClientUserMap_Created(global::LightSwitchApplication.ClientUserMap e)
            {
                e.ClientUserMap_Created();
            }
            private static bool __ClientUserMap_AllowSaveWithErrors(global::LightSwitchApplication.ClientUserMap e)
            {
                bool result = false;
                e.ClientUserMap_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, byte[]> RowVersion
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties.RowVersion) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, byte[]>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, global::LightSwitchApplication.User> User
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties.User) as global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, global::LightSwitchApplication.User>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, global::LightSwitchApplication.Client> Client
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties.Client) as global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, global::LightSwitchApplication.Client>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Id { get; set; }
                new byte[] RowVersion { get; set; }
                new global::Microsoft.LightSwitch.Internal.IEntityImplementation User { get; set; }
                new global::Microsoft.LightSwitch.Internal.IEntityImplementation Client { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._Id_SetImplementationValue,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.ClientUserMap.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, int>.Data> c, global::LightSwitchApplication.ClientUserMap.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.ClientUserMap e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.ClientUserMap e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.ClientUserMap.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_SetImplementationValue(global::LightSwitchApplication.ClientUserMap.DetailsClass d, int v)
                {
                    d.ImplementationEntity.Id = v;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.ClientUserMap e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, byte[]>.Entry
                    RowVersion = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, byte[]>.Entry(
                        "RowVersion",
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._RowVersion_Stub,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._RowVersion_ComputeIsReadOnly,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._RowVersion_Validate,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._RowVersion_GetImplementationValue,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._RowVersion_SetImplementationValue,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._RowVersion_OnValueChanged);
                private static void _RowVersion_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.ClientUserMap.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, byte[]>.Data> c, global::LightSwitchApplication.ClientUserMap.DetailsClass d, object sf)
                {
                    c(d, ref d._RowVersion, sf);
                }
                private static bool _RowVersion_ComputeIsReadOnly(global::LightSwitchApplication.ClientUserMap e)
                {
                    bool result = false;
                    e.RowVersion_IsReadOnly(ref result);
                    return result;
                }
                private static void _RowVersion_Validate(global::LightSwitchApplication.ClientUserMap e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.RowVersion_Validate(r);
                }
                private static byte[] _RowVersion_GetImplementationValue(global::LightSwitchApplication.ClientUserMap.DetailsClass d)
                {
                    return d.ImplementationEntity.RowVersion;
                }
                private static void _RowVersion_SetImplementationValue(global::LightSwitchApplication.ClientUserMap.DetailsClass d, byte[] v)
                {
                    d.ImplementationEntity.RowVersion = v;
                }
                private static void _RowVersion_OnValueChanged(global::LightSwitchApplication.ClientUserMap e)
                {
                    e.RowVersion_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, global::LightSwitchApplication.User>.Entry
                    User = new global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, global::LightSwitchApplication.User>.Entry(
                        "User",
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._User_Stub,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._User_ComputeIsReadOnly,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._User_Validate,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._User_GetCoreImplementationValue,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._User_GetImplementationValue,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._User_SetImplementationValue,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._User_Refresh,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._User_OnValueChanged);
                private static void _User_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.ClientUserMap.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, global::LightSwitchApplication.User>.Data> c, global::LightSwitchApplication.ClientUserMap.DetailsClass d, object sf)
                {
                    c(d, ref d._User, sf);
                }
                private static bool _User_ComputeIsReadOnly(global::LightSwitchApplication.ClientUserMap e)
                {
                    bool result = false;
                    e.User_IsReadOnly(ref result);
                    return result;
                }
                private static void _User_Validate(global::LightSwitchApplication.ClientUserMap e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.User_Validate(r);
                }
                private static global::Microsoft.LightSwitch.Internal.IEntityImplementation _User_GetCoreImplementationValue(global::LightSwitchApplication.ClientUserMap.DetailsClass d)
                {
                    return d.ImplementationEntity.User;
                }
                private static global::LightSwitchApplication.User _User_GetImplementationValue(global::LightSwitchApplication.ClientUserMap.DetailsClass d)
                {
                    return d.GetImplementationValue<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass>(global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties.User, ref d._User);
                }
                private static void _User_SetImplementationValue(global::LightSwitchApplication.ClientUserMap.DetailsClass d, global::LightSwitchApplication.User v)
                {
                    d.SetImplementationValue(global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties.User, ref d._User, (i, ev) => i.User = ev, v);
                }
                private static void _User_Refresh(global::LightSwitchApplication.ClientUserMap.DetailsClass d)
                {
                    d.RefreshNavigationProperty(global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties.User, ref d._User);
                }
                private static void _User_OnValueChanged(global::LightSwitchApplication.ClientUserMap e)
                {
                    e.User_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, global::LightSwitchApplication.Client>.Entry
                    Client = new global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, global::LightSwitchApplication.Client>.Entry(
                        "Client",
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._Client_Stub,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._Client_ComputeIsReadOnly,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._Client_Validate,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._Client_GetCoreImplementationValue,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._Client_GetImplementationValue,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._Client_SetImplementationValue,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._Client_Refresh,
                        global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties._Client_OnValueChanged);
                private static void _Client_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.ClientUserMap.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, global::LightSwitchApplication.Client>.Data> c, global::LightSwitchApplication.ClientUserMap.DetailsClass d, object sf)
                {
                    c(d, ref d._Client, sf);
                }
                private static bool _Client_ComputeIsReadOnly(global::LightSwitchApplication.ClientUserMap e)
                {
                    bool result = false;
                    e.Client_IsReadOnly(ref result);
                    return result;
                }
                private static void _Client_Validate(global::LightSwitchApplication.ClientUserMap e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Client_Validate(r);
                }
                private static global::Microsoft.LightSwitch.Internal.IEntityImplementation _Client_GetCoreImplementationValue(global::LightSwitchApplication.ClientUserMap.DetailsClass d)
                {
                    return d.ImplementationEntity.Client;
                }
                private static global::LightSwitchApplication.Client _Client_GetImplementationValue(global::LightSwitchApplication.ClientUserMap.DetailsClass d)
                {
                    return d.GetImplementationValue<global::LightSwitchApplication.Client, global::LightSwitchApplication.Client.DetailsClass>(global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties.Client, ref d._Client);
                }
                private static void _Client_SetImplementationValue(global::LightSwitchApplication.ClientUserMap.DetailsClass d, global::LightSwitchApplication.Client v)
                {
                    d.SetImplementationValue(global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties.Client, ref d._Client, (i, ev) => i.Client = ev, v);
                }
                private static void _Client_Refresh(global::LightSwitchApplication.ClientUserMap.DetailsClass d)
                {
                    d.RefreshNavigationProperty(global::LightSwitchApplication.ClientUserMap.DetailsClass.PropertySetProperties.Client, ref d._Client);
                }
                private static void _Client_OnValueChanged(global::LightSwitchApplication.ClientUserMap e)
                {
                    e.Client_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, byte[]>.Data _RowVersion;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, global::LightSwitchApplication.User>.Data _User;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.ClientUserMap, global::LightSwitchApplication.ClientUserMap.DetailsClass, global::LightSwitchApplication.Client>.Data _Client;
            
        }
    
        #endregion
    }
    
    #endregion
}