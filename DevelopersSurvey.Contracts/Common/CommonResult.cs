// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommonResult.cs" company="Peaceful Programmers">
//   Copyright by Peaceful Programmers 2017
// </copyright>
// <summary>
//   Defines the CommonResult type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Contracts.Common
{
    /// <summary>
    /// The common result base type
    /// </summary>
    public class CommonResult
    {
        /// <summary>
        /// Gets or sets a value indicating whether is success.
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResult"/> class.
        /// </summary>
        protected CommonResult()
        {
            IsSuccess = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResult"/> class.
        /// </summary>
        /// <param name="errorMessage">
        /// The error message.
        /// </param>
        protected CommonResult(string errorMessage)
        {
            IsSuccess = false;
            ErrorMessage = errorMessage;
        }

        /// <summary>
        /// The success.
        /// </summary>
        /// <returns>
        /// The <see cref="CommonResult"/>.
        /// </returns>
        public static CommonResult Success()
        {
            return new CommonResult();
        }

        /// <summary>
        /// The failure.
        /// </summary>
        /// <param name="errorMessage">
        /// The error message.
        /// </param>
        /// <returns>
        /// The <see cref="CommonResult"/>.
        /// </returns>
        public static CommonResult Failure(string errorMessage)
        {
            return new CommonResult(errorMessage);
        }
    }
}
