﻿namespace VirtueSky.Attributes
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Attribute used to show or hide the Field depending on certain conditions
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class ShowIfAttribute : PropertyAttribute
    {
        public readonly string conditionFieldName;
        public readonly object comparationValue;
        public readonly object[] comparationValueArray;


        /// <summary>
        /// Attribute used to show or hide the Field depending on certain conditions
        /// </summary>
        /// <param name="conditionFieldName">Name of the bool condition Field</param>
        public ShowIfAttribute(string conditionFieldName)
        {
            this.conditionFieldName = conditionFieldName;
        }

        /// <summary>
        /// Attribute used to show or hide the Field depending on certain conditions
        /// </summary>
        /// <param name="conditionFieldName">Name of the Field to compare (bool, enum, int or float)</param>
        /// <param name="comparationValue">Value to compare</param>
        public ShowIfAttribute(string conditionFieldName, object comparationValue = null)
        {
            this.conditionFieldName = conditionFieldName;
            this.comparationValue = comparationValue;
        }


        /// <summary>
        /// Attribute used to show or hide the Field depending on certain conditions
        /// </summary>
        /// <param name="conditionFieldName">Name of the Field to compare (bool, enum, int or float)</param>
        /// <param name="comparationValueArray">Array of values to compare (only for enums)</param>
        public ShowIfAttribute(string conditionFieldName, object[] comparationValueArray = null)
        {
            this.conditionFieldName = conditionFieldName;
            this.comparationValueArray = comparationValueArray;
        }
    }
}