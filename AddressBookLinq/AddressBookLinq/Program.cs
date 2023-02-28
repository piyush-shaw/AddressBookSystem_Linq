using AddressBookLinq;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book System With Linq");
        //Create Object for DataTable
        ContactDataManager contactDataManager = new ContactDataManager();
        ContactDataManager contactDataManagers = new ContactDataManager();
        DataTableManager dataTableManger = new DataTableManager();
        dataTableManger.CreateDataTable();

        //Insert Values into Table
        contactDataManager.FirstName = "Piyush";
        contactDataManager.LastName = "Shaw";
        contactDataManager.PhoneNumber = 9841205050;
        contactDataManager.Email = "piyush@gmail.com";
        contactDataManager.Address = "15 MG Road";
        contactDataManager.City = "Kolkata";
        contactDataManager.State = "WestBengal";
        contactDataManager.zip = 700072;
        dataTableManger.InsertintoDataTable(contactDataManager);

        //Insert Values into Table
        contactDataManagers.FirstName = "Ankita";
        contactDataManagers.LastName = "Singh";
        contactDataManagers.PhoneNumber = 7765405050;
        contactDataManagers.Email = "ankita@gmail.com";
        contactDataManagers.Address = "34 Street Road";
        contactDataManagers.City = "Howrah";
        contactDataManagers.State = "West Bengal";
        contactDataManagers.zip = 123001;
        dataTableManger.InsertintoDataTable(contactDataManagers);
        dataTableManger.Display();
    }
}