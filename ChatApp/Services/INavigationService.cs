using ChatApp.ViewModels;
using ChatApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Services
{
    public interface INavigationService
    {

             Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase;
            

             Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase;
           
            

             Task NavigateToAsync(Type viewModelType);
          
              Task NavigateBackAsync();
            



        }
    }
