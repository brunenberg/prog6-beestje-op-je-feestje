﻿using Models;

namespace BusinessLogic.Interfaces {
    public interface IPriceRules {

        public double CalculateAnimalsPrice(List<Animal> selectedAnimals);
        public (double, List<string>) CalculateDiscount(List<Animal> selectedAnimals, CustomerCard customerCard, DateTime bookingDate);
    }
}
