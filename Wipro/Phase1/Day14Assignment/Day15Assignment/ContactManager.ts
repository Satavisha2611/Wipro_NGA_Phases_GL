//interface to store properties
interface Contact
{
    id : number,
    name : string,
    email : string,
    phone : string
}

//class Contact Manager contains the behaviour and methods
class ContactManager 
{
    //private member Contacts to store the contacts
    private Contacts :any[] =[];

    //Adding new contact
    addContact(contact : Contact) : void {
        this.Contacts.push(contact);
        console.log('contact has been pushed.');
    }

    //Viewing the contacts in the list
    viewContacts() : Contact[]
    {
         return this.Contacts;
    }

    //Modifying the contact according to the need
    modifyContact(id: number, updatedContact: Partial<Contact>): void
    {
        const con = this.Contacts.find( c => c.id == id);
        if(!con)
        {
            console.log('Error in finding contact or contact does not exist.');
        }
        else
        {
           Object.assign(con , updatedContact);
           console.log('Contact has been successfully updated.');
        }
    }

    //Deleting contact
    deleteContact(id: number): void
    {
        const index = this.Contacts.findIndex( c => c.id == id);
        if(index == -1)
        {
            console.log('Error in finding contact or contact does not exist.');
        }
        else
        {
            delete this.Contacts[index];
            console.log("Contact deleted successfully.");
        }
        
    }
}

//Test cases
const manager = new ContactManager();
manager.addContact({ id: 1, name: "Priya", email: "priya@example.com", phone: "8989898989" });
manager.addContact({ id: 2, name: "Jhanvi", email: "jhanvi@example.com", phone: "78797979797" });

console.log("Contacts List:", manager.viewContacts());
manager.modifyContact(1, { phone: "909090909090" });
manager.deleteContact(2);
console.log("Updated Contacts List:", manager.viewContacts());