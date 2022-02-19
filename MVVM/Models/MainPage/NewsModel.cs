using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models.MainPage
{
    class NewsModel
    {
        public string Heading { get; set; }
        public string News { get; set; }

        public static implicit operator ObservableCollection<object>(NewsModel v)
        {
            throw new NotImplementedException();
        }
    }
}
