﻿namespace CollectionsVsArrays
{
    public class Indexers
    {
        string[] car = new string[40];

        public string this[int carNum]
        {
            get
            {
                if (carNum >= 0 && carNum < car.Length)
                {
                    return "Car one is " + car[carNum] + " Is the best";
                }
                return "Out of index range...";
            }

            set
            {
                if (carNum >= 0 && carNum < car.Length)
                {
                    car[carNum] = value;
                }
            }
        }
    }
}