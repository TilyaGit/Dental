using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental.WPF.Architecture
{
    public interface INavigationService
    {
        void Navigate(Type type);
        void Navigate(Type type, object parameter);
        void EnsureNavigated(Type pageType, object parameter);

        bool CanGoBack { get; }
        bool CanGoForward { get; }
        void GoBack();
        void GoForward();

        IView CurrentView { get; }
    }
}
