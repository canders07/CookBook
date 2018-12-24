using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CookBook.Models;
using CookBook.DataSource;
using System.IO;

namespace CookBook.ViewModels
{
    class HomeFolders
    {
        private ObservableCollection<Folder> folders;
        public ObservableCollection<Folder> Folders
        {
            get { return folders; }
            set
            {
                folders = value;
            }
        }

        public HomeFolders()
        {
            
            Folders= new ObservableCollection<Folder>();
            FolderData _context = new FolderData();
            List<Folder> folders = _context.folders();
            foreach(Folder folder in folders)
            {
                
                Folders.Add(folder);
            }
        }
    }
}
