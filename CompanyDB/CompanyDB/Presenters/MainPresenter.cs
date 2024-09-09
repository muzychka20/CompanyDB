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
            IEmployeeRepository repository = new EmployeeRepository(sqlConnectionString);
            new EmployeePresenter(view, repository);
        }
    }
}
