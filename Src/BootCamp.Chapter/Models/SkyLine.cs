﻿using System;
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

        public static SkyLine CreateSkyLine(int[][] buildings)
        {
            return new SkyLine(buildings);
        }

        private int[] CalculateSkylineTop(int[][] buildings)
        {
            bool isTopView = true;
            int viewWidth = buildings.Length;

            int[] view = ConstructView(buildings, viewWidth, isTopView);

            return view;
        }

        private int[] CalculateSkylineSide(int[][] buildings)
        {
            bool isTopView = false;
            int viewWidth = buildings.Length;

            int[] view = ConstructView(buildings, viewWidth, isTopView);

            return view;
        }

        private static int[] ConstructView(int[][] buildings, int viewWidth, bool isTopView)
        {
            int[] view = new int[viewWidth];

            /*
             * This Code makes a list of the Rows or Columns depending on topview or sideview. 
             * Then pasts the highest number of the Row or collumn into the view.
            */
            for (int i = 0; i < viewWidth; i++)
            {
                int[] buildingArr = new int[viewWidth];
                for (int k = 0; k < viewWidth; k++)
                {
                    buildingArr[k] = isTopView ? buildings[k][i] : buildings[i][k]; 
                }
                view[i] = buildingArr.Max();
            }

            return view;
        }
    }
}
