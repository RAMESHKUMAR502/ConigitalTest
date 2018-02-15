using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConigitalTestMobileApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        private string _inputnumber;
        public string Inputnumber
        {
            get { return _inputnumber; }
            set { SetProperty(ref _inputnumber, value); }
        }

        private string _Results;
        public string Results
        {
            get { return _Results; }
            set { SetProperty(ref _Results, value); }
        }

        public ICommand SubmitCommand { get; }

        public MainViewModel()
        {
            HttpRequRes.RunAsync();
            SubmitCommand = new Command(async () => await Submit());
        }

        public async Task Submit()
        {
            try
            {
                if (Inputnumber != null)
                {
                    var res = await HttpRequRes.GetMultitleNumResults(Convert.ToInt32(Inputnumber));
                    if (res != null && res.Error == false)
                        this.Results = res.Results;
                    else
                        this.Results = res.message;
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Please Enter Number", "OK");
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
