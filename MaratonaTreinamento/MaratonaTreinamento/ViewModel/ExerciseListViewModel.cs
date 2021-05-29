using System;
using System.Collections.Generic;
using MaratonaTreinamento.Model;

namespace MaratonaTreinamento.ViewModel
{
    public class ExerciseListViewModel : BaseViewModel
    {
        #region -> Propriedades <-
        private List<string> _difficultyLevel;
        private List<Exercise> _exerciseList;
        private string _titlePage;
        #endregion


        #region -> Construtor <-
        public ExerciseListViewModel()
        {
            _difficultyLevel = new List<string>();
            _exerciseList = new List<Exercise>();
            loadData();
        }
        #endregion


        #region -> Encapsulamentos <-
        public List<string> DifficultyLevel { get { return _difficultyLevel; } set { _difficultyLevel = value; OnPropertyChanged("DifficultyLevel"); } }
        public List<Exercise> ExerciseList { get { return _exerciseList; } set { _exerciseList = value; OnPropertyChanged("ExerciseList"); } }
        public string TitlePage { get { return _titlePage; } set { _titlePage = value; OnPropertyChanged("TitlePage"); } }
        #endregion


        #region -> Command's <-

        #endregion


        #region -> Metodos <-
        public void loadData()
        {
            _difficultyLevel.Add("Fácil");
            _difficultyLevel.Add("Médio");
            _difficultyLevel.Add("Difícil");
            _difficultyLevel.Add("Todos");

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

            _exerciseList.Add(new Exercise() {
                Id = 0,
                Title = "Programação de Viagem",
                DifficultyLevel = 4, NecessaryKnowledge = "Grafos;Lógica de Programação;Programação Dinâmica",
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
        }
        #endregion


        #region -> Enuns <-

        #endregion
    }
}
