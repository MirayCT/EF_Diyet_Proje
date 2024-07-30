﻿using _04Project.ViewModel.Abstract;
using _06Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Project.ViewModel.Concrete
{
    public class FoodViewModel:IViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Calorie { get; set; }
        public int Carbs { get; set; }
        public int Fats { get; set; }
        public int Protein { get; set; }
        public byte[]? Picture { get; set; }
        public virtual List<UserFood> UserFoods { get; set; }

        public override string ToString()
        {
            return Name + " " + Description + " "+Calorie + "cal";
        }
    }
}