using System;
using System.Collections.Generic;
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
        #endregion

        #region -> Construtor <-
        public ExerciseList()
        {
            InitializeComponent();
            On<iOS>().SetUseSafeArea(true);
            _exerciseListViewMode = new ExerciseListViewModel();
            BindingContext = _exerciseListViewMode;
            LoadCollectionList();
        }
        #endregion

        #region -> Metodos <-
        void LoadCollectionList()
        {
            if(Device.Idiom == TargetIdiom.Tablet)
            {
                CollectionList.ItemsLayout = new GridItemsLayout(2, ItemsLayoutOrientation.Vertical)
                {
                    VerticalItemSpacing = 20,
                    HorizontalItemSpacing = 30
                };
            }
            else if (Device.Idiom == TargetIdiom.Phone)
            {
                CollectionList.ItemsLayout = new GridItemsLayout(1, ItemsLayoutOrientation.Vertical)
                {
                    VerticalItemSpacing = 20,
                    HorizontalItemSpacing = 30
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

        void ExerciseSelected(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            var item = (Exercise)CollectionList.SelectedItem;
            if (item == null)
                return;
            (sender as CollectionView).SelectedItem = null;
            Navigation.PushAsync(new VisualizeExercise(item));
        }

        void ItemSelected(System.Object sender, System.EventArgs e)
        {
        }
        #endregion
    }
}
