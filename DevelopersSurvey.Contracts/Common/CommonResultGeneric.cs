// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommonResultGeneric.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the CommonResultGeneric type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Contracts.Common
{
    /// <summary>
    /// The generic CommonResult type
    /// </summary>
    /// <typeparam name="T">
    /// Passed type
    /// </typeparam>
    public class CommonResultGeneric<T> : CommonResult
    {
        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        public T Item { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResultGeneric{T}"/> class.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        public CommonResultGeneric(T item) : base()
        {
            Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResultGeneric{T}"/> class.
        /// </summary>
        /// <param name="errorMessage">
        /// The error message.
        /// </param>
        protected CommonResultGeneric(string errorMessage) : base(errorMessage)
        {
        }

        /// <summary>
        /// The success.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <typeparam name="T">
        /// Item Type
        /// </typeparam>
        /// <returns>
        /// The <see cref="CommonResultGeneric{T}"/>.
        /// </returns>
        public static CommonResultGeneric<T> Success<T>(T item)
        {
            return new CommonResultGeneric<T>(item);
        }

        /// <summary>
        /// The failure.
        /// </summary>
        /// <param name="errorMessage">
        /// The error message.
        /// </param>
        /// <typeparam name="T">
        /// Item Type
        /// </typeparam>
        /// <returns>
        /// The <see cref="CommonResultGeneric{T}"/>.
        /// </returns>
        public static CommonResultGeneric<T> Failure<T>(string errorMessage)
        {
            return new CommonResultGeneric<T>(errorMessage);
        }
    }
}