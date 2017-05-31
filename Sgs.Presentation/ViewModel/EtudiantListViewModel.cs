using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Sgs.Business.Model;
using System.Collections.ObjectModel;
using Sgs.Persistance.EntityModel;
using Sgs.Presentation.Helpers;

namespace Sgs.Presentation.ViewModel
{

    public class EtudiantListViewModel : BaseViewModel
    {
        private ObservableCollection<tbEtudiants> _etudiants;
        private SGSEntities DBContext;
        public EtudiantListViewModel()
        {
            DBContext = App.GetDBContext();

            _etudiants = new ObservableCollection<tbEtudiants>(DBContext.tbEtudiants);

            //foreach (tbEtudiants etudiant in context.tbEtudiants.ToList<tbEtudiants>()) 
            //    _etudiants.Add(etudiant);
        }

        public ObservableCollection<tbEtudiants> Etudiants
        {
            get { return _etudiants; }
            set
            {
                _etudiants.Clear();
                _etudiants = value;
            }
        }

        private tbEtudiants _currentItem;

        public tbEtudiants CurrentItem
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
            tbEtudiants newItem = new tbEtudiants("Pascal", "Blaise");
            Etudiants.Add(newItem);
            DBContext.tbEtudiants.Add(newItem);
            CurrentItem = newItem;
        }

        public ICommand DeleteCurrent { get { return new ExecutableCommand(_deleteCurrent); } }
        private void _deleteCurrent()
        {
            if (CurrentItem == null) { return; }
            DBContext.tbEtudiants.Remove(CurrentItem);
            Etudiants.Remove(CurrentItem);
            FirePropertyChanged();
        }

        public ICommand SaveList { get { return new ExecutableCommand(_saveList); } }
        private void _saveList()
        {
            DBContext.SaveChanges();
        }
    }

}