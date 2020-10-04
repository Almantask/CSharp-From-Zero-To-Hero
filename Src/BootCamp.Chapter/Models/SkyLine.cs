using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BootCamp.Chapter.Models
{
    public class SkyLine
    {
        public int[] TopView { get; }
        public int[] SideView { get; }

        public SkyLine(int[][] buildings)
        {
            TopView = CalculateSkylineTop(buildings);
            SideView = CalculateSkylineSide(buildings);
        }

        private int[] CalculateSkylineTop(int[][] buildings)
        {
            bool isTopView = true;
            int viewLength = buildings.Length;
            int[] view = ConstructView(buildings, viewLength, isTopView);
            return view;
        }

        private int[] CalculateSkylineSide(int[][] buildings)
        {
            bool isTopView = false;
            int viewLength = buildings.Length;

            int[] view = ConstructView(buildings, viewLength, isTopView);

            return view;
        }

        private static int[] ConstructView(int[][] buildings, int viewLength, bool isTopView)
        {
            int[] view = new int[viewLength];

            for (int i = 0; i < viewLength; i++)
            {
                int[] buildingArr = new int[viewLength];
                for (int k = 0; k < viewLength; k++)
                {
                    buildingArr[k] = isTopView ? buildings[k][i] : buildings[i][k];
                }
                view[i] = buildingArr.Max();
            }

            return view;
        }
    }
}
