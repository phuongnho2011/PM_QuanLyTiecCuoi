using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WeddingApp.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool Isloaded = false;
        public ICommand FoodCommand { get; set; }
        public ICommand ServiceCommand { get; set; }
        public ICommand LoadedWindowCommand { get; set; }

        public MainViewModel()
        {
                LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) => {
                Isloaded = true;
                //if (p == null)
                //    return;
                //p.Hide();
                //LoginWindow loginWindow = new LoginWindow();
                //loginWindow.ShowDialog();

                //if (loginWindow.DataContext == null)
                //    return;
                //var loginVM = loginWindow.DataContext as LoginViewModel;

                //if (loginVM.IsLogin)
                //{
                //    p.Show();
                //}
                //else
                //{
                //    p.Close();
                //}
        }
              );          
            FoodCommand = new RelayCommand<object>((p) => { return true; }, (p) => { FoodWindow wd = new FoodWindow(); wd.ShowDialog(); });
            ServiceCommand = new RelayCommand<object>((p) => { return true; }, (p) => { ServiceWindow wd = new ServiceWindow(); wd.ShowDialog(); });
        }
    }
}
