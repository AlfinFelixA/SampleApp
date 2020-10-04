using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace GroupingExample
{
    public class DataViewModel
    {
        public ObservableCollection<GroupedVeggieObject> GroupedVeggieObject { get; set; }

        public ICommand Show { get; set; }
        public DataViewModel()
        {
            Show = new Command(ShowList);
        }

        private void ShowList()
        {
            GroupedVeggieObject = new ObservableCollection<GroupedVeggieObject>();
            var veggieGroup = new GroupedVeggieObject() { LongName = "vegetables", ShortName = "v" };
            var fruitGroup = new GroupedVeggieObject() { LongName = "fruit", ShortName = "f" };
            veggieGroup.Add(new VegModel() { Name = "celery", IsReallyAVeggie = true, Comment = "try ants on a log" });
            veggieGroup.Add(new VegModel() { Name = "tomato", IsReallyAVeggie = false, Comment = "pairs well with basil" });
            veggieGroup.Add(new VegModel() { Name = "zucchini", IsReallyAVeggie = true, Comment = "zucchini bread > bannana bread" });
            veggieGroup.Add(new VegModel() { Name = "peas", IsReallyAVeggie = true, Comment = "like peas in a pod" });
            fruitGroup.Add(new VegModel() { Name = "banana", IsReallyAVeggie = false, Comment = "available in chip form factor" });
            fruitGroup.Add(new VegModel() { Name = "strawberry", IsReallyAVeggie = false, Comment = "spring plant" });
            fruitGroup.Add(new VegModel() { Name = "cherry", IsReallyAVeggie = false, Comment = "topper for icecream" });
            GroupedVeggieObject.Add(veggieGroup); GroupedVeggieObject.Add(fruitGroup);
            
        }
    }
}
