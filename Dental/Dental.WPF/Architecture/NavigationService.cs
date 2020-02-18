using System;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Dental.WPF.Architecture
{
    public class NavigationService : INavigationService
    {
        private readonly Frame _frame;

        public NavigationService(Frame frame)
        {
            _frame = frame;
            _frame.Navigated  += OnFrameNavigated;
        }

        private void _frame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnFrameNavigated1(object sender, NavigationEventArgs e)
        {
            var view = e.Content as IView;
            if (view == null)
                return;

            var navMsg = new NavigationMessage()
            {
                Sender = this,
                NewView = view,
                Parameter = e.Parameter,
                NavigationMode = (int)e.NavigationMode
            };

            EventManager.Current.Publish(navMsg);

            var viewModel = view.ViewModel;
            if (viewModel != null)
                viewModel.Initialise(e.Parameter);
        }

        public void Navigate(Type pageType)
        {
            DisposePreviousView();
            _frame.Navigate(pageType);
        }

        public void Navigate(Type pageType, object parameter)
        {
            DisposePreviousView();
            _frame.Navigate(pageType, parameter);
        }

        private void DisposePreviousView()
        {
            var currentView = this.CurrentView;
            var currentViewDisposable = currentView as IDisposable;
            if (currentViewDisposable != null)
            {
                currentViewDisposable.Dispose();
                currentViewDisposable = null;
            }
        }

        public void EnsureNavigated(Type pageType, object parameter)
        {
            var currentView = this.CurrentView;
            if (currentView == null || currentView.GetType() != pageType)
            {
                Navigate(pageType, parameter);
            }
        }

        public IView CurrentView
        {
            get { return _frame.Content as IView; }
        }


        public bool CanGoBack
        {
            get { return _frame != null && _frame.CanGoBack; }
        }

        public void GoBack()
        {
            if (_frame != null && _frame.CanGoBack) _frame.GoBack();
        }

        public bool CanGoForward
        {
            get { return _frame != null && _frame.CanGoForward; }
        }

        public void GoForward()
        {
            if (_frame != null && _frame.CanGoForward) _frame.GoForward();
        }

    }
}
