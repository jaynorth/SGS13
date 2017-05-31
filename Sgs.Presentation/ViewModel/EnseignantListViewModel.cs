using Sgs.Persistance.EntityModel;
using Sgs.Presentation.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sgs.Presentation.ViewModel
{
    class EnseignantListViewModel : BaseViewModel
    {
        private ObservableCollection<tbEnseignants> _enseignants;

        private SGSEntities DBContext;
        public EnseignantListViewModel()
        {
            DBContext = App.GetDBContext();

            _enseignants = new ObservableCollection<tbEnseignants>(DBContext.tbEnseignants);
        }

        public ObservableCollection<tbEnseignants> Enseignants
        {
            get { return _enseignants; }
            set
            {
                _enseignants.Clear();
                _enseignants = value;
                FirePropertyChanged();
            }
        }


        private tbEnseignants _currentItem;

        public tbEnseignants CurrentItem
        {
            get
            {
                return _currentItem;
            }
            set
            {
                _currentItem = value;
                FirePropertyChanged();
            }
        }

        public ICommand AddNew { get { return new ExecutableCommand(_addNew); } }
        private void _addNew()
        {
            tbEnseignants newItem = new tbEnseignants("Brown", "Charlie");
            Enseignants.Add(newItem);
            DBContext.tbEnseignants.Add(newItem);
            CurrentItem = newItem;
        }

        public ICommand DeleteCurrent { get { return new ExecutableCommand(_deleteCurrent); } }
        private void _deleteCurrent()
        {
            if (CurrentItem == null) { return; }
            DBContext.tbEnseignants.Remove(CurrentItem);
            Enseignants.Remove(CurrentItem);
            FirePropertyChanged();
        }

        public ICommand SaveList { get { return new ExecutableCommand(_saveList); } }
        private void _saveList()
        {
            DBContext.SaveChanges();
        }
    }
}
