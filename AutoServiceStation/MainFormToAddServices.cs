
namespace AutoServiceStation
{
    static class MainFormToAddServices
    {
        public static string idQuery="", idCar="", idClient="", ClientPhone="", GRZCar="", ModelCar="", ClientBirthday="", ClientName="", ClientSurName="", LastCarID="";
        public static string[] QueryServicesUpdate;

        public static void Reset()
        {
            idQuery = "";
            idCar = "";
            idClient = "";
            ClientPhone = ""; 
            GRZCar = "";
            ModelCar = "";
            ClientBirthday = ""; 
            ClientName = "";
            ClientSurName = "";
            LastCarID = "";
        }
    }
}
