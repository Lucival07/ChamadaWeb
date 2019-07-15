﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ChamadaWeb.Model
{
    class MyListPageViewModel
    {

        public ObservableCollection<MyListModel> FoodList { get; set; }

        public MyListPageViewModel()
        {


            FoodList = new ObservableCollection<MyListModel>();
            FoodList.Add(new MyListModel { Name = "Test1", Image = "https://media.istockphoto.com/photos/double-cheese-and-bacon-cheeseburger-picture-id511484502?k=6&m=511484502&s=612x612&w=0&h=2d8oTGH_E7KHkd4TIdftWIxjLsBP3CfdF44zy65FD0o=", Detail = "This is our burger", Ingredients = "This is our detail page details to be listed" });
            //you can add here multiple list items 
            //FoodList.Add(new MyListModel { Name = "Test2", Image = "https://media.istockphoto.com/photos/double-cheese-and-bacon-cheeseburger-picture-id511484502?k=6&m=511484502&s=612x612&w=0&h=2d8oTGH_E7KHkd4TIdftWIxjLsBP3CfdF44zy65FD0o=", Detail = "This is our burger",Ingredients="This is our detail page details to be listed" });

        }
    }
}
