using KursISP21.Helpers;
using KursISP21.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursISP21.ViewModels
{
    public class AuthorViewModel:BaseViewModel
    {
        private KursovayaContext db = new KursovayaContext();
        private RelayCommand? addCommand;
        private RelayCommand? editCommand;
        private RelayCommand? deleteCommand;
        public ObservableCollection<Author> Authors { get; set; }

        public AuthorViewModel()
        {
            db.Database.EnsureCreated();
            db.Authors.Load();
            Authors = db.Authors.Local.ToObservableCollection();
        }
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand((o) =>
                  {

                  }));
            }
        }
        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ??
                  (editCommand = new RelayCommand((o) =>
                  {

                  }));
            }
        }
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ??
                  (deleteCommand = new RelayCommand((o) =>
                  {

                  }));
            }
        }
    }
}
