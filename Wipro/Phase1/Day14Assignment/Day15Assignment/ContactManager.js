//class Contact Manager contains the behaviour and methods
var ContactManager = /** @class */ (function () {
    function ContactManager() {
        //private member Contacts to store the contacts
        this.Contacts = [];
    }
    //Adding new contact
    ContactManager.prototype.addContact = function (contact) {
        this.Contacts.push(contact);
        console.log('contact has been pushed.');
    };
    //Viewing the contacts in the list
    ContactManager.prototype.viewContacts = function () {
        return this.Contacts;
    };
    //Modifying the contact according to the need
    ContactManager.prototype.modifyContact = function (id, updatedContact) {
        var con = this.Contacts.find(function (c) { return c.id == id; });
        if (!con) {
            console.log('Error in finding contact or contact does not exist.');
        }
        else {
            Object.assign(con, updatedContact);
            console.log('Contact has been successfully updated.');
        }
    };
    //Deleting contact
    ContactManager.prototype.deleteContact = function (id) {
        var index = this.Contacts.findIndex(function (c) { return c.id == id; });
        if (index == -1) {
            console.log('Error in finding contact or contact does not exist.');
        }
        else {
            delete this.Contacts[index];
            console.log("Contact deleted successfully.");
        }
    };
    return ContactManager;
}());
//Test cases
var manager = new ContactManager();
manager.addContact({ id: 1, name: "Priya", email: "priya@example.com", phone: "8989898989" });
manager.addContact({ id: 2, name: "Jhanvi", email: "jhanvi@example.com", phone: "78797979797" });
console.log("Contacts List:", manager.viewContacts());
manager.modifyContact(1, { phone: "909090909090" });
manager.deleteContact(2);
console.log("Updated Contacts List:", manager.viewContacts());
