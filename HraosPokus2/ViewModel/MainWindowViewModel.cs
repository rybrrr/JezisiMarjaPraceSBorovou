using HraosPokus2.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraosPokus2.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public RelayCommand StartCommand => new RelayCommand(execute => NewGame());
        public RelayCommand FieldOpenCommand => new RelayCommand(execute => FieldOpened(execute as FieldViewModel));
        public RelayCommand FieldFlaggedCommand => new RelayCommand(execute => FieldFlagged(execute as FieldViewModel));

        #region Data Binding
        public ObservableCollection<FieldViewModel> Fields { get; set; }

        public int GridSize => (int)Math.Sqrt(Fields.Count);

        private int _score;
        public int Score
        {
            get => _score;
            set
            {
                if (_score != value)
                {
                    _score = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion


        #region Herní logika

        public void NewGame()
        {

        }

        public void FieldOpened(FieldViewModel field)
        {

        }

        public void FieldFlagged(FieldViewModel field)
        {

        }

        #endregion
    }
}
