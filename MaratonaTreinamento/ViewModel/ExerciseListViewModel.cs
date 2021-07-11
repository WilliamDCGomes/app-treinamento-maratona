﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acr.UserDialogs;
using MaratonaTreinamento.Model;
using Xamarin.Forms;

namespace MaratonaTreinamento.ViewModel
{
    public class ExerciseListViewModel : BaseViewModel
    {
        #region -> Propriedades <-
        private List<string> _difficultyLevel;
        private List<Exercise> _exerciseList;
        private List<Exercise> _allExercises;
        private Exercise _selectedExercise;
        private Command _refreshList;
        private CollectionView _collectionView;
        private string _titlePage;
        private string _searchPhrase;
        private bool _isBusy;
        int _selectedIndex;
        #endregion


        #region -> Construtor <-
        public ExerciseListViewModel(CollectionView collectionView)
        {
            _collectionView = collectionView;
            _difficultyLevel = new List<string>();
            _exerciseList = new List<Exercise>();
            loadData();
        }
        #endregion


        #region -> Encapsulamentos <-
        public List<string> DifficultyLevel { get { return _difficultyLevel; } set { _difficultyLevel = value; OnPropertyChanged("DifficultyLevel"); } }
        public List<Exercise> ExerciseList { get { return _exerciseList; } set { _exerciseList = value; OnPropertyChanged("ExerciseList"); } }
        public Exercise SelectedExercise { get { return _selectedExercise; } set { _selectedExercise = value; OnPropertyChanged("SelectedExercise"); } }
        public string TitlePage { get { return _titlePage; } set { _titlePage = value; OnPropertyChanged("TitlePage"); } }
        public string SearchPhrase { get { return _searchPhrase; } set { _searchPhrase = value; OnPropertyChanged("SearchPhrase"); } }
        public int SelectedIndex { get { return _selectedIndex; } set { _selectedIndex = value; OnPropertyChanged("SelectedIndex"); } }
        public bool IsBusy { get { return _isBusy; } set { _isBusy = value; OnPropertyChanged("IsBusy"); } }
        #endregion


        #region -> Command's <-
        public Command RefreshList => _refreshList ?? (_refreshList = new Command(async () => Refresh()));
        #endregion


        #region -> Metodos <-
        public List<Exercise> listFilter()
        {
            switch (SelectedIndex)
            {
                case 0:
                    ExerciseList = _allExercises.Where(ex => ex.DifficultyLevel == 1).ToList();
                    break;
                case 1:
                    ExerciseList = _allExercises.Where(ex => ex.DifficultyLevel == 2).ToList();
                    break;
                case 2:
                    ExerciseList = _allExercises.Where(ex => ex.DifficultyLevel == 3).ToList();
                    break;
                case 3:
                    ExerciseList = _allExercises.Where(ex => ex.DifficultyLevel == 4).ToList();
                    break;
                case 4:
                    ExerciseList = _allExercises.Where(ex => ex.DifficultyLevel == 5).ToList();
                    break;
                case 5:
                    ExerciseList = _allExercises;
                    break;
            }
            return ExerciseList;
        }

        public void SearchingExercise()
        {
            if (string.IsNullOrEmpty(SearchPhrase.Trim()))
                _exerciseList = _allExercises;
            else
                _exerciseList = _allExercises.Where(ex => ex.Title.ToLower().Contains(SearchPhrase.Trim().ToLower())).ToList();
            _collectionView.ItemsSource = null;
            _collectionView.ItemsSource = _exerciseList;
        }

        public List<Exercise> MakeFavoriteExercise()
        {
            UserDialogs.Instance.ShowLoading("");
            Task.Delay(100);
            ExerciseList.FirstOrDefault(el => el.Id == SelectedExercise.Id).IsFavorited = !ExerciseList.FirstOrDefault(el => el.Id == SelectedExercise.Id).IsFavorited;
            UserDialogs.Instance.HideLoading();
            return _exerciseList;
        }

        public void Refresh()
        {
            IsBusy = true;
            loadData();
            _collectionView.ItemsSource = null;
            _collectionView.ItemsSource = _exerciseList;
            IsBusy = false;
        }

        public void loadData()
        {
            _difficultyLevel.Add("Iniciante");
            _difficultyLevel.Add("Pós Iniciante");
            _difficultyLevel.Add("Intermediário");
            _difficultyLevel.Add("Pós Intermediário");
            _difficultyLevel.Add("Difícil");
            _difficultyLevel.Add("Todos");

            _selectedIndex = -1;

            switch (App.ListType)
            {
                case 0:
                    _titlePage = "Exercícios";
                    break;
                case 1:
                    _titlePage = "Exercícios Recomendados";
                    break;
                case 2:
                    _titlePage = "Exercícios Favoritos";
                    break;
            }
            _exerciseList.Add(new Exercise()
            {
                Id = 0,
                Title = "Programação de Viagem",
                DifficultyLevel = 4,
                NecessaryKnowledge = "Grafos;Lógica de Programação;Programação Dinâmica",
                Description = "A entrada consiste em diversas casos de teste. A primeira linha de cada caso contém dois inteiros C (1 ≤ C ≤ 15) e E (1 ≤ E ≤ 225), que indicam a quantidade de cidades e estradas. As E linhas seguintes contém três inteiros C1, C2 e T, que identificam o tempo médio T de deslocamento entre as cidades C1, C2. Por fim, um inteiro D identifica a cidade em que Valentina se encontra no momento. Uma linha com 0 0 finaliza a entrada.",
                AuthorsComment = "William Douglas",
                SiteOrigem = "www.urionlinejudge.com.br"
            });
            _exerciseList.Add(new Exercise()
            {
                Id = 1,
                Title = "Desenhando Labirintos",
                DifficultyLevel = 5,
                NecessaryKnowledge = "C#;Ruby;Programação Orientada a Objetos;Lógica de Programação;Programação Dinâmica",
                Description = "A entrada consiste em diversas casos de teste. A primeira linha de cada caso contém dois inteiros C (1 ≤ C ≤ 15) e E (1 ≤ E ≤ 225), que indicam a quantidade de cidades e estradas. As E linhas seguintes contém três inteiros C1, C2 e T, que identificam o tempo médio T de deslocamento entre as cidades C1, C2. Por fim, um inteiro D identifica a cidade em que Valentina se encontra no momento. Uma linha com 0 0 finaliza a entrada.",
                AuthorsComment = "Heleno Maurino",
                SiteOrigem = "www.urionlinejudge.com.br"
            });
            _exerciseList.Add(new Exercise()
            {
                Id = 2,
                Title = "Percurso em Árvore por Nível",
                DifficultyLevel = 2,
                NecessaryKnowledge = "Html;CSS;Lógica de Programação;Programação Dinâmica",
                Description = "A entrada consiste em diversas casos de teste. A primeira linha de cada caso contém dois inteiros C (1 ≤ C ≤ 15) e E (1 ≤ E ≤ 225), que indicam a quantidade de cidades e estradas. As E linhas seguintes contém três inteiros C1, C2 e T, que identificam o tempo médio T de deslocamento entre as cidades C1, C2. Por fim, um inteiro D identifica a cidade em que Valentina se encontra no momento. Uma linha com 0 0 finaliza a entrada.",
                AuthorsComment = "Bárbara Ribeiro",
                SiteOrigem = "www.urionlinejudge.com.br"
            });
            _exerciseList.Add(new Exercise()
            {
                Id = 3,
                Title = "Aproveite a Oferta",
                DifficultyLevel = 3,
                NecessaryKnowledge = "C++;Java;Lógica de Programação;Programação Dinâmica",
                Description = "A entrada consiste em diversas casos de teste. A primeira linha de cada caso contém dois inteiros C (1 ≤ C ≤ 15) e E (1 ≤ E ≤ 225), que indicam a quantidade de cidades e estradas. As E linhas seguintes contém três inteiros C1, C2 e T, que identificam o tempo médio T de deslocamento entre as cidades C1, C2. Por fim, um inteiro D identifica a cidade em que Valentina se encontra no momento. Uma linha com 0 0 finaliza a entrada.",
                AuthorsComment = "Carol Molina",
                SiteOrigem = "www.urionlinejudge.com.br"
            });
            _exerciseList.Add(new Exercise()
            {
                Id = 4,
                Title = "Diamantes e Areia",
                DifficultyLevel = 1,
                NecessaryKnowledge = "Lógica de Programação;Programação Dinâmica",
                Description = "A entrada consiste em diversas casos de teste. A primeira linha de cada caso contém dois inteiros C (1 ≤ C ≤ 15) e E (1 ≤ E ≤ 225), que indicam a quantidade de cidades e estradas. As E linhas seguintes contém três inteiros C1, C2 e T, que identificam o tempo médio T de deslocamento entre as cidades C1, C2. Por fim, um inteiro D identifica a cidade em que Valentina se encontra no momento. Uma linha com 0 0 finaliza a entrada.",
                AuthorsComment = "Thomas Richard",
                SiteOrigem = "www.urionlinejudge.com.br"
            });
            _exerciseList.Add(new Exercise()
            {
                Id = 5,
                Title = "Programação de Viagem",
                DifficultyLevel = 4,
                NecessaryKnowledge = "Grafos;Lógica de Programação;Programação Dinâmica",
                Description = "A entrada consiste em diversas casos de teste. A primeira linha de cada caso contém dois inteiros C (1 ≤ C ≤ 15) e E (1 ≤ E ≤ 225), que indicam a quantidade de cidades e estradas. As E linhas seguintes contém três inteiros C1, C2 e T, que identificam o tempo médio T de deslocamento entre as cidades C1, C2. Por fim, um inteiro D identifica a cidade em que Valentina se encontra no momento. Uma linha com 0 0 finaliza a entrada.",
                AuthorsComment = "William Douglas",
                SiteOrigem = "www.urionlinejudge.com.br"
            });
            _exerciseList.Add(new Exercise()
            {
                Id = 6,
                Title = "Desenhando Labirintos",
                DifficultyLevel = 5,
                NecessaryKnowledge = "C#;Ruby;Programação Orientada a Objetos;Lógica de Programação;Programação Dinâmica",
                Description = "A entrada consiste em diversas casos de teste. A primeira linha de cada caso contém dois inteiros C (1 ≤ C ≤ 15) e E (1 ≤ E ≤ 225), que indicam a quantidade de cidades e estradas. As E linhas seguintes contém três inteiros C1, C2 e T, que identificam o tempo médio T de deslocamento entre as cidades C1, C2. Por fim, um inteiro D identifica a cidade em que Valentina se encontra no momento. Uma linha com 0 0 finaliza a entrada.",
                AuthorsComment = "Heleno Maurino",
                SiteOrigem = "www.urionlinejudge.com.br"
            });
            _exerciseList.Add(new Exercise()
            {
                Id = 7,
                Title = "Percurso em Árvore por Nível",
                DifficultyLevel = 2,
                NecessaryKnowledge = "Html;CSS;Lógica de Programação;Programação Dinâmica",
                Description = "A entrada consiste em diversas casos de teste. A primeira linha de cada caso contém dois inteiros C (1 ≤ C ≤ 15) e E (1 ≤ E ≤ 225), que indicam a quantidade de cidades e estradas. As E linhas seguintes contém três inteiros C1, C2 e T, que identificam o tempo médio T de deslocamento entre as cidades C1, C2. Por fim, um inteiro D identifica a cidade em que Valentina se encontra no momento. Uma linha com 0 0 finaliza a entrada.",
                AuthorsComment = "Bárbara Ribeiro",
                SiteOrigem = "www.urionlinejudge.com.br"
            });
            _exerciseList.Add(new Exercise()
            {
                Id = 8,
                Title = "Aproveite a Oferta",
                DifficultyLevel = 3,
                NecessaryKnowledge = "C++;Java;Lógica de Programação;Programação Dinâmica",
                Description = "A entrada consiste em diversas casos de teste. A primeira linha de cada caso contém dois inteiros C (1 ≤ C ≤ 15) e E (1 ≤ E ≤ 225), que indicam a quantidade de cidades e estradas. As E linhas seguintes contém três inteiros C1, C2 e T, que identificam o tempo médio T de deslocamento entre as cidades C1, C2. Por fim, um inteiro D identifica a cidade em que Valentina se encontra no momento. Uma linha com 0 0 finaliza a entrada.",
                AuthorsComment = "Carol Molina",
                SiteOrigem = "www.urionlinejudge.com.br"
            });
            _exerciseList.Add(new Exercise()
            {
                Id = 9,
                Title = "Diamantes e Areia",
                DifficultyLevel = 1,
                NecessaryKnowledge = "Lógica de Programação;Programação Dinâmica",
                Description = "A entrada consiste em diversas casos de teste. A primeira linha de cada caso contém dois inteiros C (1 ≤ C ≤ 15) e E (1 ≤ E ≤ 225), que indicam a quantidade de cidades e estradas. As E linhas seguintes contém três inteiros C1, C2 e T, que identificam o tempo médio T de deslocamento entre as cidades C1, C2. Por fim, um inteiro D identifica a cidade em que Valentina se encontra no momento. Uma linha com 0 0 finaliza a entrada.",
                AuthorsComment = "Thomas Richard",
                SiteOrigem = "www.urionlinejudge.com.br"
            });
            _exerciseList.Add(new Exercise()
            {
                Id = 10,
                Title = "Desenhando Labirintos",
                DifficultyLevel = 5,
                NecessaryKnowledge = "C#;Ruby;Programação Orientada a Objetos;Lógica de Programação;Programação Dinâmica",
                Description = "A entrada consiste em diversas casos de teste. A primeira linha de cada caso contém dois inteiros C (1 ≤ C ≤ 15) e E (1 ≤ E ≤ 225), que indicam a quantidade de cidades e estradas. As E linhas seguintes contém três inteiros C1, C2 e T, que identificam o tempo médio T de deslocamento entre as cidades C1, C2. Por fim, um inteiro D identifica a cidade em que Valentina se encontra no momento. Uma linha com 0 0 finaliza a entrada.",
                AuthorsComment = "Heleno Maurino",
                SiteOrigem = "www.urionlinejudge.com.br"
            });
            _exerciseList.Add(new Exercise()
            {
                Id = 11,
                Title = "Percurso em Árvore por Nível",
                DifficultyLevel = 2,
                NecessaryKnowledge = "Html;CSS;Lógica de Programação;Programação Dinâmica",
                Description = "A entrada consiste em diversas casos de teste. A primeira linha de cada caso contém dois inteiros C (1 ≤ C ≤ 15) e E (1 ≤ E ≤ 225), que indicam a quantidade de cidades e estradas. As E linhas seguintes contém três inteiros C1, C2 e T, que identificam o tempo médio T de deslocamento entre as cidades C1, C2. Por fim, um inteiro D identifica a cidade em que Valentina se encontra no momento. Uma linha com 0 0 finaliza a entrada.",
                AuthorsComment = "Bárbara Ribeiro",
                SiteOrigem = "www.urionlinejudge.com.br"
            });
            _exerciseList.Add(new Exercise()
            {
                Id = 12,
                Title = "Aproveite a Oferta",
                DifficultyLevel = 3,
                NecessaryKnowledge = "C++;Java;Lógica de Programação;Programação Dinâmica",
                Description = "A entrada consiste em diversas casos de teste. A primeira linha de cada caso contém dois inteiros C (1 ≤ C ≤ 15) e E (1 ≤ E ≤ 225), que indicam a quantidade de cidades e estradas. As E linhas seguintes contém três inteiros C1, C2 e T, que identificam o tempo médio T de deslocamento entre as cidades C1, C2. Por fim, um inteiro D identifica a cidade em que Valentina se encontra no momento. Uma linha com 0 0 finaliza a entrada.",
                AuthorsComment = "Carol Molina",
                SiteOrigem = "www.urionlinejudge.com.br"
            });
            _exerciseList.Add(new Exercise()
            {
                Id = 13,
                Title = "Diamantes e Areia",
                DifficultyLevel = 1,
                NecessaryKnowledge = "Lógica de Programação;Programação Dinâmica",
                Description = "A entrada consiste em diversas casos de teste. A primeira linha de cada caso contém dois inteiros C (1 ≤ C ≤ 15) e E (1 ≤ E ≤ 225), que indicam a quantidade de cidades e estradas. As E linhas seguintes contém três inteiros C1, C2 e T, que identificam o tempo médio T de deslocamento entre as cidades C1, C2. Por fim, um inteiro D identifica a cidade em que Valentina se encontra no momento. Uma linha com 0 0 finaliza a entrada.",
                AuthorsComment = "Thomas Richard",
                SiteOrigem = "www.urionlinejudge.com.br"
            });
            _allExercises = _exerciseList;
        }
        #endregion


        #region -> Enuns <-

        #endregion
    }
}
