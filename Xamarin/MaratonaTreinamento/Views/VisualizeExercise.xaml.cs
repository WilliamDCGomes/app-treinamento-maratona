using System;
using System.Collections.Generic;
using MaratonaTreinamento.Model;
using MaratonaTreinamento.ViewModel;
using Xamarin.Forms;

namespace MaratonaTreinamento.Views
{
    public partial class VisualizeExercise : ContentPage
    {
        private VisualizeExerciseViewModel _visualizeExerciseViewModel;
        public VisualizeExercise(Exercise exercise)
        {
            InitializeComponent();
            _visualizeExerciseViewModel = new VisualizeExerciseViewModel(exercise);
            BindingContext = _visualizeExerciseViewModel;
        }
    }
}
