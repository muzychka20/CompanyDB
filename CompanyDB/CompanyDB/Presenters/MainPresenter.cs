using CompanyDB._Repositories;
using CompanyDB.Views;
using CompanyDB.Models;

namespace CompanyDB.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowEmployeeView += ShowEmployeesView;
        }

        private void ShowEmployeesView(object? sender, EventArgs e)
        {
            IEmployeeView view = EmployeeView.GetInstance((MainView)mainView);
            IEmployeeRepository employeeRepository = new EmployeeRepository(sqlConnectionString);
            ICountryRepository countryRepository = new CountryRepository(sqlConnectionString);
            ICityRepository cityRepository = new CityRepository(sqlConnectionString);
            IStreetRepository streetRepository = new StreetRepository(sqlConnectionString);
            IHouseRepository houseRepository = new HouseRepository(sqlConnectionString);
            IApartmentRepository apartmentRepository = new ApartmentRepository(sqlConnectionString);
            new EmployeePresenter(view, employeeRepository, countryRepository, cityRepository, streetRepository, houseRepository, apartmentRepository);
        }
    }
}
