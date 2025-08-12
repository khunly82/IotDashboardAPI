using IotDashboardApplication.Entities;

namespace IotDashboardApplication.Services
{
    public class DataService(IotContext context)
    {

        public List<Data> GetLastDatas(int quantity)
        {
            return context.Datas
                // ordonner par ordre decroissant sur la date
                .OrderByDescending(d => d.Date)
                // prendre les x premières données enregistrées
                .Take(quantity).ToList();
        } 

        public Data AddData(DateTime date, double temperature, double humidity)
        {
            Data newData = context.Add(new Data
            {
                Date = date,
                Temperature = temperature,
                Humidity = humidity
                // .Entity Permet de récupérer la données qui a été sauvergardée (et qui contient l'Id)
            }).Entity;
            context.SaveChanges();
            return newData;
        }
    }
}
