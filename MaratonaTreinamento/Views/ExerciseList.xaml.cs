using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acr.UserDialogs;
using MaratonaTreinamento.Model;
using MaratonaTreinamento.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace MaratonaTreinamento.Views
{
    public partial class ExerciseList : ContentPage
    {
        #region -> Propriedades <-
        private ExerciseListViewModel _exerciseListViewMode;
        private int _lastItemVisible;
        #endregion

        #region -> Construtor <-
        public ExerciseList()
        {
            InitializeComponent();
            On<iOS>().SetUseSafeArea(true);
            _lastItemVisible = 0;
            _exerciseListViewMode = new ExerciseListViewModel();
            BindingContext = _exerciseListViewMode;
            LoadCollectionList();
        }
        #endregion

        #region -> Metodos <-
        void LoadCollectionList()
        {
            if (Device.Idiom == TargetIdiom.Tablet)
            {
                CollectionList.ItemsLayout = new GridItemsLayout(2, ItemsLayoutOrientation.Vertical)
                {
                    VerticalItemSpacing = 20,
                    HorizontalItemSpacing = 30,
                    SnapPointsType = SnapPointsType.Mandatory,
                    SnapPointsAlignment = SnapPointsAlignment.End
                };
            }
            else if (Device.Idiom == TargetIdiom.Phone)
            {
                CollectionList.ItemsLayout = new GridItemsLayout(1, ItemsLayoutOrientation.Vertical)
                {
                    VerticalItemSpacing = 20,
                    HorizontalItemSpacing = 30,
                    SnapPointsType = SnapPointsType.Mandatory,
                    SnapPointsAlignment = SnapPointsAlignment.End
                };
            }
        }

        void FocusEntryExercise(System.Object sender, System.EventArgs e)
        {
            InputExerciseName.Focus();
        }

        void GetFocusToPicker(System.Object sender, System.EventArgs e)
        {
            InputPickerDifficulty.Focus();
        }

        async void ExerciseSelected(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            UserDialogs.Instance.ShowLoading("");
            var item = (Exercise)CollectionList.SelectedItem;
            if (item == null)
                return;
            (sender as CollectionView).SelectedItem = null;
            await Navigation.PushAsync(new VisualizeExercise(item));
            UserDialogs.Instance.HideLoading();
        }

        void ItemSelected(System.Object sender, System.EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("");

            UserDialogs.Instance.HideLoading();
        }

        void Refresh(System.Object sender, System.EventArgs e)
        {
            _exerciseListViewMode.loadData();
            CollectionList.ItemsSource = null;
            CollectionList.ItemsSource = _exerciseListViewMode.ExerciseList;
            RefreshList.IsRefreshing = false;
        }

        async void MakeFavorite(System.Object sender, System.EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("");
            await Task.Delay(100);
            var exerciseSelected = (sender as Xamarin.Forms.SwipeItem).CommandParameter as Exercise;
            _exerciseListViewMode.MakeFavoriteExercise(exerciseSelected);
            CollectionList.ItemsSource = null;
            CollectionList.ItemsSource = _exerciseListViewMode.ExerciseList;
            CollectionList.ScrollTo(_lastItemVisible, animate: false, position: ScrollToPosition.End);
            UserDialogs.Instance.HideLoading();
        }

        void ListScrolled(System.Object sender, Xamarin.Forms.ItemsViewScrolledEventArgs e)
        {
            _lastItemVisible = e.LastVisibleItemIndex;
        }
        #endregion
    }
}
