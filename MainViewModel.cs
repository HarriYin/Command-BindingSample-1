using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingSample
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {

            ShowCommand = new MyCommand(Show);
        }

        public MyCommand ShowCommand { get; set; }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                //name = value;
                //OnPropertyChanged();

                UpdateProper(ref name, value);
            }
        }


        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                //title = value;
                //OnPropertyChanged();

                UpdateProper(ref title, value);
            }
        }



        private void Show()
        {
            Name = "点击了按钮";
            Title = "我是标题";
            System.Windows.MessageBox.Show(Name);
        }


    }
}
