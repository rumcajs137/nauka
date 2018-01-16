using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DataGrid
{
    class GenderTemplateSelector : DataTemplateSelector
    {
        public DataTemplate MaleTemplate { get; set; }
        public DataTemplate FemaleTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            PersonData person = item as PersonData;
            if (person.GenderType == PersonData.Gender.Male)
                return MaleTemplate;
            else return FemaleTemplate;


        }

    }
}
