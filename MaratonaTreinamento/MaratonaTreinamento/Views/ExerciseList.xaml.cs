using System;
using System.Collections.Generic;
using MaratonaTreinamento.Model;
using MaratonaTreinamento.ViewModel;
using Xamarin.Forms;

namespace MaratonaTreinamento.Views
{
    public partial class ExerciseList : ContentPage
    {
        private ExerciseListViewModel _exerciseListViewMode;
        public ExerciseList()
        {
            InitializeComponent();
            _exerciseListViewMode = new ExerciseListViewModel();
            BindingContext = _exerciseListViewMode;
        }

        void ItemSelected(System.Object sender, System.EventArgs e)
        {

        }

        void FocusEntryExercise(System.Object sender, System.EventArgs e)
        {
            InputExerciseName.Focus();
        }

        void GetFocusToPicker(System.Object sender, System.EventArgs e)
        {
            InputPickerDifficulty.Focus();
        }

        void ExerciseSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var item = (Exercise)e.SelectedItem;
            if (item == null)
                return;
            (sender as ListView).SelectedItem = null;
            Navigation.PushAsync(new VisualizeExercise(item));
        }
    }
}
