﻿using System.Reflection;

namespace FamilyManager
{
    /// <summary>
    /// The Core assembly helper methods.
    /// </summary>
    public static class CoreAssembly
    {

        #region public methods

        /// <summary>
        /// Gets the core assembly location.
        /// </summary>
        /// <returns></returns>
        public static string GetAssemblyLocation()
        {
            return Assembly.GetExecutingAssembly().Location; 
        }

        #endregion
    }
}
