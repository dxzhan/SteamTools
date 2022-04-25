using ReactiveUI;
using System.Application.Models;
using System.Application.Services;
using System.Application.UI.Resx;
using System.Collections.ObjectModel;

// ReSharper disable once CheckNamespace
namespace System.Application.UI.ViewModels
{
    public sealed class GameRelated_BorderlessPageViewModel : ItemViewModel
    {
        readonly INativeWindowApiService windowApi = INativeWindowApiService.Instance!;

        public override string Name
        {
            get => AppResources.GameRelated_Borderless;
        }

        #region SelectWindow 变更通知 

        private NativeWindowModel? _SelectWindow;

        public NativeWindowModel? SelectWindow
        {
            get => _SelectWindow;
            set
            {
                if (_SelectWindow != value)
                {
                    _SelectWindow = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        #endregion

        ObservableCollection<NativeWindowModel> _WindowList = new();

        public ObservableCollection<NativeWindowModel> WindowList
        {
            get => _WindowList;
            set
            {
                if (_WindowList != value)
                {
                    _WindowList = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        public void Cross_MouseDown()
        {
            windowApi.GetMoveMouseDownWindow((window) =>
            {
                SelectWindow = window;
                WindowList.Insert(0, window);
            });
        }

        public void BorderlessWindow_Click()
        {
            if (SelectWindow == null)
            {
                return;
            }
            windowApi.BorderlessWindow(SelectWindow);
        }

        public void MaximizeWindow_Click()
        {
            if (SelectWindow == null)
            {
                return;
            }
            windowApi.MaximizeWindow(SelectWindow);
        }

        public void NormalWindow_Click()
        {
            if (SelectWindow == null)
            {
                return;
            }
            windowApi.NormalWindow(SelectWindow);
        }

        public void WindowKill_Click()
        {
            if (SelectWindow == null)
            {
                return;
            }
            SelectWindow.Kill();
        }

        public void ShowWindow_Click()
        {
            if (SelectWindow == null)
            {
                return;
            }
            windowApi.ShowWindow(SelectWindow);
        }

        public void HideWindow_Click()
        {
            if (SelectWindow == null)
            {
                return;
            }
            windowApi.HideWindow(SelectWindow);
        }

        public void ToWallerpaperWindow_Click()
        {
            if (SelectWindow == null)
            {
                return;
            }
            windowApi.ToWallerpaperWindow(SelectWindow);
        }

        public void ResetWallerpaper_Click()
        {
            windowApi.ResetWallerpaper();
        }
    }
}