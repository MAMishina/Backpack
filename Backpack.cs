using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backpack
{
    class Backpack
    {
        private List<Item> bestItems = null;

        private double maxWeight;

        private double bestPrice;

        public Backpack(double _maxWeight)
        {
            maxWeight = _maxWeight;
        }

        /// <summary>
        /// вычисляет общий вес набора предметов
        /// </summary>
        /// <param name="items">список предметов</param>
        /// <returns></returns>
        private double CalculateWeigth(List<Item> items)
        {
            double sumWeight = 0;

            foreach (Item i in items)
            {
                sumWeight += i.weigth;
            }

            return sumWeight;
        }


        /// <summary>
        /// вычисляет общую стоимость набора предметов
        /// </summary>
        /// <param name="items">список предметов</param>
        /// <returns></returns>
        private double CalculatePrice(List<Item> items)
        {
            double sumPrice = 0;

            foreach (Item i in items)
            {
                sumPrice += i.price;
            }

            return sumPrice;
        }

        /// <summary>
        /// проверка, является ли данный набор лучшим решением задачи
        /// </summary>
        /// <param name="items">список предметов</param>
        private void CheckSet(List<Item> items)
        {
            if (bestItems == null)
            {
                if (CalculateWeigth(items) <= maxWeight)
                {
                    bestItems = items;
                    bestPrice = CalculatePrice(items);
                }
            }
            else
            {
                if (CalculateWeigth(items) <= maxWeight && CalculatePrice(items) > bestPrice)
                {
                    bestItems = items;
                    bestPrice = CalculatePrice(items);
                }
            }
        }

        /// <summary>
        /// создание всех наборов перестановок значений
        /// </summary>
        /// <param name="items">список предметов</param>
        public void MakeAllSets(List<Item> items)
        {
            if (items.Count > 0)
                CheckSet(items);

            for (int i = 0; i < items.Count; i++)
            {
                List<Item> newItems = new List<Item>(items);

                newItems.RemoveAt(i);

                MakeAllSets(newItems);
            }

        }

        
        /// <summary>
        /// возвращает решение задачи (набор предметов)
        /// </summary>
        /// <returns></returns>
        public List<Item> GetBestSet()
        {
            return bestItems;
        }
    }
}
