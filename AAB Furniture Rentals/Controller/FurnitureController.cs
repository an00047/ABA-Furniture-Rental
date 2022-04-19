﻿using System;
using System.Collections.Generic;
using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;

namespace AAB_Furniture_Rentals.Controller
{
    /// <summary>
    /// A static controller class that should be utilized for all employee related queries
    /// </summary>
    public static class FurnitureController
    {
        private static FurnitureDAL localFurnitureDAL;
        private static IsRentedDAL localIsRentedDAL;
        /// <summary>
        /// Initializes the <see cref="FurnitureController"/> class.
        /// </summary>
        static FurnitureController()
        {
            localFurnitureDAL = new FurnitureDAL();
            localIsRentedDAL = new IsRentedDAL();
        }

        /// <summary>
        /// requests all furniture form the associated DAL class
        /// </summary>
        /// <returns></returns>
        public static List<Furniture> GetAllFurnitures()
        {
            var test = localFurnitureDAL.GetAllFurniture();
            return localFurnitureDAL.GetAllFurniture();
        }

        /// <summary>
        /// creates a new Rental Transaction, returns the transaction ID
        /// </summary>
        /// <param name="newRentaltransaction"></param>
        /// <returns></returns>
        internal static int ProcessRentalTransaction(Rental newRentaltransaction)
        {
            if (newRentaltransaction == null )
            {
                throw new ArgumentException("The Transaction is null");
            }
            return localIsRentedDAL.InsertNewRentalTransaction(newRentaltransaction);
        }

        /// <summary>
        /// Gets the furniture by parameter.
        /// </summary>
        /// <param name="style">The style.</param>
        /// <param name="category">The category.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static List<Furniture> GetFurnitureByParameter(string style, string category, int? id)
        {
            if (style == null || category == null)
            {
                throw new ArgumentException("Style and category cannot be null");
            }
            if (id < 0)
            {
                throw new ArgumentException("ID cannot be negative");
            }
            return localFurnitureDAL.GetFurnitureByParameter(style, category, id);

        }
        /// <summary>
        /// gets the furniture item by id
        /// </summary>
        /// <param name="furnitureID"></param>
        /// <returns></returns>
        public static Furniture GetFurnitureByID(int furnitureID) {
            if (furnitureID < 0)
            {
                throw new ArgumentException("furnitureID cannot be negative");
            }
            return localFurnitureDAL.GetFurnitureByID(furnitureID);
        }
        /// <summary>
        /// Updates an existing furniture Item. (Multi-Use)
        /// </summary>
        /// <param name="updatedFurniture"></param>
        public static void UpdateFurnitureItem(Furniture updatedFurniture) {
            if (updatedFurniture == null)
            {
                throw new ArgumentException("furniture to update cannot be null");
            }
            localFurnitureDAL.UpdateFurnitureItem(updatedFurniture);
        }
        /// <summary>
        /// updates the Isrented Database. 
        /// </summary>
        /// <param name="isRentedList"></param>
        internal static void ProcessIsRentedList(List<IsRentedModel> isRentedList)
        {
            if (isRentedList == null)
            {
                throw new ArgumentException("furniture to update cannot be null");
            }
            localIsRentedDAL.InsertIsRentedTable(isRentedList);
        }
    }
}
