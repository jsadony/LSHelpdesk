/// <reference path="data.js" />

(function (lightSwitchApplication) {

    msls._addEntryPoints(lightSwitchApplication.Ticket, {
        /// <field>
        /// Called when a new ticket is created.
        /// <br/>created(msls.application.Ticket entity)
        /// </field>
        created: [lightSwitchApplication.Ticket]
    });

    msls._addEntryPoints(lightSwitchApplication.Action, {
        /// <field>
        /// Called when a new action is created.
        /// <br/>created(msls.application.Action entity)
        /// </field>
        created: [lightSwitchApplication.Action]
    });

    msls._addEntryPoints(lightSwitchApplication.Client, {
        /// <field>
        /// Called when a new client is created.
        /// <br/>created(msls.application.Client entity)
        /// </field>
        created: [lightSwitchApplication.Client]
    });

    msls._addEntryPoints(lightSwitchApplication.User, {
        /// <field>
        /// Called when a new user is created.
        /// <br/>created(msls.application.User entity)
        /// </field>
        created: [lightSwitchApplication.User]
    });

    msls._addEntryPoints(lightSwitchApplication.ClientUserMap, {
        /// <field>
        /// Called when a new clientUserMap is created.
        /// <br/>created(msls.application.ClientUserMap entity)
        /// </field>
        created: [lightSwitchApplication.ClientUserMap]
    });

    msls._addEntryPoints(lightSwitchApplication.Project, {
        /// <field>
        /// Called when a new project is created.
        /// <br/>created(msls.application.Project entity)
        /// </field>
        created: [lightSwitchApplication.Project]
    });

    msls._addEntryPoints(lightSwitchApplication.ProjectClientMap, {
        /// <field>
        /// Called when a new projectClientMap is created.
        /// <br/>created(msls.application.ProjectClientMap entity)
        /// </field>
        created: [lightSwitchApplication.ProjectClientMap]
    });

}(msls.application));
