/// <reference path="../Scripts/msls-1.0.0.js" />

window.myapp = msls.application;

(function (lightSwitchApplication) {

    var $Entity = msls.Entity,
        $DataService = msls.DataService,
        $DataWorkspace = msls.DataWorkspace,
        $defineEntity = msls._defineEntity,
        $defineDataService = msls._defineDataService,
        $defineDataWorkspace = msls._defineDataWorkspace,
        $DataServiceQuery = msls.DataServiceQuery,
        $toODataString = msls._toODataString;

    function Ticket(entitySet) {
        /// <summary>
        /// Represents the Ticket entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this ticket.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this ticket.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this ticket.
        /// </field>
        /// <field name="ShortDescription" type="String">
        /// Gets or sets the shortDescription for this ticket.
        /// </field>
        /// <field name="Description" type="String">
        /// Gets or sets the description for this ticket.
        /// </field>
        /// <field name="DateOpened" type="Date">
        /// Gets or sets the dateOpened for this ticket.
        /// </field>
        /// <field name="DateClosed" type="Date">
        /// Gets or sets the dateClosed for this ticket.
        /// </field>
        /// <field name="Actions" type="msls.EntityCollection" elementType="msls.application.Action">
        /// Gets the actions for this ticket.
        /// </field>
        /// <field name="Client" type="msls.application.Client">
        /// Gets or sets the client for this ticket.
        /// </field>
        /// <field name="User" type="msls.application.User">
        /// Gets or sets the user for this ticket.
        /// </field>
        /// <field name="Project" type="msls.application.Project">
        /// Gets or sets the project for this ticket.
        /// </field>
        /// <field name="details" type="msls.application.Ticket.Details">
        /// Gets the details for this ticket.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function Action(entitySet) {
        /// <summary>
        /// Represents the Action entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this action.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this action.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this action.
        /// </field>
        /// <field name="ActionDate" type="Date">
        /// Gets or sets the actionDate for this action.
        /// </field>
        /// <field name="ActionText" type="String">
        /// Gets or sets the actionText for this action.
        /// </field>
        /// <field name="Time" type="Number">
        /// Gets or sets the time for this action.
        /// </field>
        /// <field name="Ticket" type="msls.application.Ticket">
        /// Gets or sets the ticket for this action.
        /// </field>
        /// <field name="details" type="msls.application.Action.Details">
        /// Gets the details for this action.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function Client(entitySet) {
        /// <summary>
        /// Represents the Client entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this client.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this client.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this client.
        /// </field>
        /// <field name="Name" type="String">
        /// Gets or sets the name for this client.
        /// </field>
        /// <field name="IsExternal" type="Boolean">
        /// Gets or sets the isExternal for this client.
        /// </field>
        /// <field name="ClientUserMaps" type="msls.EntityCollection" elementType="msls.application.ClientUserMap">
        /// Gets the clientUserMaps for this client.
        /// </field>
        /// <field name="Tickets" type="msls.EntityCollection" elementType="msls.application.Ticket">
        /// Gets the tickets for this client.
        /// </field>
        /// <field name="ProjectClientMaps" type="msls.EntityCollection" elementType="msls.application.ProjectClientMap">
        /// Gets the projectClientMaps for this client.
        /// </field>
        /// <field name="details" type="msls.application.Client.Details">
        /// Gets the details for this client.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function User(entitySet) {
        /// <summary>
        /// Represents the User entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this user.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this user.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this user.
        /// </field>
        /// <field name="FirstName" type="String">
        /// Gets or sets the firstName for this user.
        /// </field>
        /// <field name="LastName" type="String">
        /// Gets or sets the lastName for this user.
        /// </field>
        /// <field name="MiddleName" type="String">
        /// Gets or sets the middleName for this user.
        /// </field>
        /// <field name="ADUserName" type="String">
        /// Gets or sets the aDUserName for this user.
        /// </field>
        /// <field name="ADsid" type="String">
        /// Gets or sets the aDsid for this user.
        /// </field>
        /// <field name="Email" type="String">
        /// Gets or sets the email for this user.
        /// </field>
        /// <field name="IsAD" type="Boolean">
        /// Gets or sets the isAD for this user.
        /// </field>
        /// <field name="IsTech" type="Boolean">
        /// Gets or sets the isTech for this user.
        /// </field>
        /// <field name="IsQueue" type="Boolean">
        /// Gets or sets the isQueue for this user.
        /// </field>
        /// <field name="ClientUserMaps" type="msls.EntityCollection" elementType="msls.application.ClientUserMap">
        /// Gets the clientUserMaps for this user.
        /// </field>
        /// <field name="Tickets" type="msls.EntityCollection" elementType="msls.application.Ticket">
        /// Gets the tickets for this user.
        /// </field>
        /// <field name="details" type="msls.application.User.Details">
        /// Gets the details for this user.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function ClientUserMap(entitySet) {
        /// <summary>
        /// Represents the ClientUserMap entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this clientUserMap.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this clientUserMap.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this clientUserMap.
        /// </field>
        /// <field name="User" type="msls.application.User">
        /// Gets or sets the user for this clientUserMap.
        /// </field>
        /// <field name="Client" type="msls.application.Client">
        /// Gets or sets the client for this clientUserMap.
        /// </field>
        /// <field name="details" type="msls.application.ClientUserMap.Details">
        /// Gets the details for this clientUserMap.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function Project(entitySet) {
        /// <summary>
        /// Represents the Project entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this project.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this project.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this project.
        /// </field>
        /// <field name="Name" type="String">
        /// Gets or sets the name for this project.
        /// </field>
        /// <field name="ProjectClientMaps" type="msls.EntityCollection" elementType="msls.application.ProjectClientMap">
        /// Gets the projectClientMaps for this project.
        /// </field>
        /// <field name="Tickets" type="msls.EntityCollection" elementType="msls.application.Ticket">
        /// Gets the tickets for this project.
        /// </field>
        /// <field name="details" type="msls.application.Project.Details">
        /// Gets the details for this project.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function ProjectClientMap(entitySet) {
        /// <summary>
        /// Represents the ProjectClientMap entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this projectClientMap.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this projectClientMap.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this projectClientMap.
        /// </field>
        /// <field name="Client" type="msls.application.Client">
        /// Gets or sets the client for this projectClientMap.
        /// </field>
        /// <field name="Project" type="msls.application.Project">
        /// Gets or sets the project for this projectClientMap.
        /// </field>
        /// <field name="details" type="msls.application.ProjectClientMap.Details">
        /// Gets the details for this projectClientMap.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function ApplicationData(dataWorkspace) {
        /// <summary>
        /// Represents the ApplicationData data service.
        /// </summary>
        /// <param name="dataWorkspace" type="msls.DataWorkspace">
        /// The data workspace that created this data service.
        /// </param>
        /// <field name="Tickets" type="msls.EntitySet">
        /// Gets the Tickets entity set.
        /// </field>
        /// <field name="Actions" type="msls.EntitySet">
        /// Gets the Actions entity set.
        /// </field>
        /// <field name="Clients" type="msls.EntitySet">
        /// Gets the Clients entity set.
        /// </field>
        /// <field name="Users" type="msls.EntitySet">
        /// Gets the Users entity set.
        /// </field>
        /// <field name="ClientUserMaps" type="msls.EntitySet">
        /// Gets the ClientUserMaps entity set.
        /// </field>
        /// <field name="Projects" type="msls.EntitySet">
        /// Gets the Projects entity set.
        /// </field>
        /// <field name="ProjectClientMaps" type="msls.EntitySet">
        /// Gets the ProjectClientMaps entity set.
        /// </field>
        /// <field name="details" type="msls.application.ApplicationData.Details">
        /// Gets the details for this data service.
        /// </field>
        $DataService.call(this, dataWorkspace);
    };
    function DataWorkspace() {
        /// <summary>
        /// Represents the data workspace.
        /// </summary>
        /// <field name="ApplicationData" type="msls.application.ApplicationData">
        /// Gets the ApplicationData data service.
        /// </field>
        /// <field name="details" type="msls.application.DataWorkspace.Details">
        /// Gets the details for this data workspace.
        /// </field>
        $DataWorkspace.call(this);
    };

    msls._addToNamespace("msls.application", {

        Ticket: $defineEntity(Ticket, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "ShortDescription", type: String },
            { name: "Description", type: String },
            { name: "DateOpened", type: Date },
            { name: "DateClosed", type: Date },
            { name: "Actions", kind: "collection", elementType: Action },
            { name: "Client", kind: "reference", type: Client },
            { name: "User", kind: "reference", type: User },
            { name: "Project", kind: "reference", type: Project }
        ]),

        Action: $defineEntity(Action, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "ActionDate", type: Date },
            { name: "ActionText", type: String },
            { name: "Time", type: Number },
            { name: "Ticket", kind: "reference", type: Ticket }
        ]),

        Client: $defineEntity(Client, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "Name", type: String },
            { name: "IsExternal", type: Boolean },
            { name: "ClientUserMaps", kind: "collection", elementType: ClientUserMap },
            { name: "Tickets", kind: "collection", elementType: Ticket },
            { name: "ProjectClientMaps", kind: "collection", elementType: ProjectClientMap }
        ]),

        User: $defineEntity(User, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "FirstName", type: String },
            { name: "LastName", type: String },
            { name: "MiddleName", type: String },
            { name: "ADUserName", type: String },
            { name: "ADsid", type: String },
            { name: "Email", type: String },
            { name: "IsAD", type: Boolean },
            { name: "IsTech", type: Boolean },
            { name: "IsQueue", type: Boolean },
            { name: "ClientUserMaps", kind: "collection", elementType: ClientUserMap },
            { name: "Tickets", kind: "collection", elementType: Ticket }
        ]),

        ClientUserMap: $defineEntity(ClientUserMap, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "User", kind: "reference", type: User },
            { name: "Client", kind: "reference", type: Client }
        ]),

        Project: $defineEntity(Project, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "Name", type: String },
            { name: "ProjectClientMaps", kind: "collection", elementType: ProjectClientMap },
            { name: "Tickets", kind: "collection", elementType: Ticket }
        ]),

        ProjectClientMap: $defineEntity(ProjectClientMap, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "Client", kind: "reference", type: Client },
            { name: "Project", kind: "reference", type: Project }
        ]),

        ApplicationData: $defineDataService(ApplicationData, lightSwitchApplication.rootUri + "/ApplicationData.svc", [
            { name: "Tickets", elementType: Ticket },
            { name: "Actions", elementType: Action },
            { name: "Clients", elementType: Client },
            { name: "Users", elementType: User },
            { name: "ClientUserMaps", elementType: ClientUserMap },
            { name: "Projects", elementType: Project },
            { name: "ProjectClientMaps", elementType: ProjectClientMap }
        ], [
            {
                name: "Tickets_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.Tickets },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/Tickets(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "Actions_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.Actions },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/Actions(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "Clients_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.Clients },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/Clients(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "Users_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.Users },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/Users(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "ClientUserMaps_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.ClientUserMaps },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/ClientUserMaps(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "Projects_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.Projects },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/Projects(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "ProjectClientMaps_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.ProjectClientMaps },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/ProjectClientMaps(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "UsersByClients", value: function (Client) {
                    return new $DataServiceQuery({ _entitySet: this.ClientUserMaps },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/UsersByClients()",
                        {
                            Client: $toODataString(Client, "Int32?")
                        });
                }
            }
        ]),

        DataWorkspace: $defineDataWorkspace(DataWorkspace, [
            { name: "ApplicationData", type: ApplicationData }
        ])

    });

}(msls.application));
