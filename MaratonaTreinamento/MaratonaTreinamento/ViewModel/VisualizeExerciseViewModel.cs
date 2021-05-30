using System;
using MaratonaTreinamento.Model;

namespace MaratonaTreinamento.ViewModel
{
    public class VisualizeExerciseViewModel : BaseViewModel
    {
        #region -> Propriedades <-
        private Exercise _exercise;
        private string _exerciseName;
        #endregion


        #region -> Construtor <-
        public VisualizeExerciseViewModel(Exercise exercise)
        {
            _exercise = exercise;
        }
        #endregion


        #region -> Encapsulamentos <-
        public Exercise Exercise { get { return _exercise; } set { _exercise = value; OnPropertyChanged("Exercise"); } }

        #endregion


        #region -> Command's <-

        #endregion


        #region -> Metodos <-
        #endregion


        #region -> Enuns <-

        #endregion
    }
}
